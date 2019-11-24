<template>
  <v-row>
    <v-col cols="12" sm="6" offset-sm="3">
      <v-card>
        <v-container fluid>
          <v-row>
            <v-col v-for="n in 4" :key="n" cols="6">
              <v-img :src="getItemIcon(1001)" height="25" width="25" class="grey lighten-2"></v-img>
            </v-col>
          </v-row>
          <v-row>
            <v-col v-for="n in 2" :key="n" cols="1">
              <v-img :src="getItemIcon(1001)" height="25" width="auto" class="grey lighten-2"></v-img>
            </v-col>
          </v-row>
        </v-container>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
export default {
  data() {
    return {};
  },
  computed: {
    ...mapGetters({
      match: "getMatchDetails"
    })
  },
  methods: {
    blueTeam() {
      console.log(this.match.summonerDetails);
      if (this.match.summonerDetails)
        return this.match.summonerDetails.filter(x => x.team === "Blue");
    },
    redTeam() {
      if (this.match.summonerDetails)
        return this.match.summonerDetails.filter(x => x.team === "Red");
    },
    getChampIcon(val) {
      return require(`../assets/images/champions/icons/${val}.png`);
    },
    getItemIcon(val) {
      return require(`../assets/images/items/${val}.png`);
    }
  },
  watch: {},
  created() {
    this.$store.dispatch("fetchMatchById", this.$route.params.id);
  }
};
</script>
