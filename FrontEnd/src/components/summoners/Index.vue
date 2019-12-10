<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12">
        <v-row>
          <v-col cols="12" lg="1" sm="2" offset-lg="3" offset-md="3">
            <v-select
              :items="servers"
              item-text="serverName"
              item-value="serverName"
              v-model="select"
              solo
            ></v-select>
          </v-col>
          <v-col cols="12" sm="4">
            <v-autocomplete
              label="Solo"
              placeholder="Search summoners"
              solo
              v-model="searchModel"
              :search-input.sync="search"
              :items="items"
              item-text="summonerName"
              item-value="id"
              hide-no-data
            >
              <v-icon slot="append" color="purple">mdi-magnify</v-icon>
            </v-autocomplete>
          </v-col>
        </v-row>
        <v-row>
          <v-card
            v-for="field in fields"
            :key="field.id"
            cols="12"
            lg="3"
            @click="getDetails(field.summonerName)"
          >
            <v-img :src="getSrc(field.profileIconID)"></v-img>
            <v-card-title>{{field.summonerName}}</v-card-title>
            <v-card-text>Server {{field.serverName}}</v-card-text>
            <v-card-text>Summoner level {{field.summonerLevel}}</v-card-text>
          </v-card>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
export default {
  data() {
    return {
      items: [],
      search: null,
      searchModel: null,
      select: { text: "EUW" }
    };
  },
  computed: {
    ...mapGetters({
      summoners: "getSummoners",
      servers: "getServers"
    }),
    fields() {
      if (this.searchModel == false) return [];
      return this.summoners.filter(s => s.id === this.searchModel);
    }
  },
  methods: {
    getSrc(val) {
      return require(`../../assets/images/profileIcons/${val}.png`);
    },
    getDetails(name) {
      this.$router.push(`/summoners/details/${name}`);
    }
  },
  watch: {
    search(val) {
      this.items = this.summoners.filter(
        s =>
          s.summonerName.toLowerCase().includes(val.toLowerCase()) &&
          s.serverName === this.select
      );
    }
  },
  created() {
    this.$store.dispatch("fetchSummoners");
    this.$store.dispatch("fetchServers");
  }
};
</script>

<style>
</style>
