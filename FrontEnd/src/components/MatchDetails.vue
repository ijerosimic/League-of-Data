<template>
  <v-container fluid>
    <v-row>
      <v-btn text icon color="pink" @click="heyoo">
        <v-icon>mdi-heart</v-icon>
      </v-btn>
    </v-row>
  </v-container>
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
    heyoo() {
      console.log(this.match);
    }
  },
  watch: {},
  created() {
    this.$store.dispatch("fetchMatchById", this.$route.params.id);
  }
};
</script>

<style>
</style>
