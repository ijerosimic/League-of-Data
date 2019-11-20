<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12">
        <v-card class="mx-auto" outlined>
          <v-card-title class="justify-center">Match Details</v-card-title>
          <v-row>
            <v-col cols="6">
              <v-card v-for="(n,i) in 5" :key="i" class="pa-5 ma-2">
                <v-row>
                  <v-col cols="2">
                    <v-avatar size="auto" tile>
                      <img
                        src="https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Aatrox.png"
                        alt="John"
                      />
                    </v-avatar>
                  </v-col>
                  <v-col cols="1">
                    <v-avatar tile color="blue" v-for="n in 2" :key="n" class="mt-3" size="30">
                      <v-icon dark size="auto" align="center">mdi-alarm</v-icon>
                    </v-avatar>
                  </v-col>
                  <v-col cols="1">
                    <v-avatar tile color="blue" v-for="n in 2" :key="n" class="mt-3" size="30">
                      <v-icon dark size="auto">mdi-alarm</v-icon>
                    </v-avatar>
                  </v-col>
                  <v-col cols="8">
                    <v-row class="ma-1">
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                    </v-row>
                  </v-col>
                </v-row>
              </v-card>
            </v-col>
            <v-col cols="6">
              <v-card v-for="(n,i) in 5" :key="i" class="pa-5 ma-2">
                <v-row>
                  <v-col cols="2">
                    <v-avatar size="auto" tile>
                      <img
                        src="https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Aatrox.png"
                        alt="John"
                      />
                    </v-avatar>
                  </v-col>
                  <v-col cols="1">
                    <v-avatar tile color="blue" v-for="n in 2" :key="n" class="mt-3" size="30">
                      <v-icon dark size="auto" align="center">mdi-alarm</v-icon>
                    </v-avatar>
                  </v-col>
                  <v-col cols="1">
                    <v-avatar tile color="blue" v-for="n in 2" :key="n" class="mt-3" size="30">
                      <v-icon dark size="auto">mdi-alarm</v-icon>
                    </v-avatar>
                  </v-col>
                  <v-col cols="8">
                    <v-row class="ma-1">
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                      <v-col cols="2">
                        <v-card-text class="justify-center">Summoner</v-card-text>
                      </v-col>
                    </v-row>
                  </v-col>
                </v-row>
              </v-card>
            </v-col>
          </v-row>
        </v-card>
      </v-col>
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
