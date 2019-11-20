<template>
  <v-container fluid>
    <v-row>
      <v-col cols="2" lg-4 md-5 sm-5>
        <v-card class="mx-auto">
          <v-img :src="getProfileIcon(summoner.profileIconID)"></v-img>
          <v-card-title>{{summoner.summonerName}}</v-card-title>
          <v-card-text class="text--primary">
            <p v-for="(summ, prop, i) in fields" :key="i" :hidden="summ === null">{{prop}}: {{summ}}</p>
          </v-card-text>
          <v-card-actions>
            <v-btn color="orange" text>Share</v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
      <v-col cols="10">
        <v-row>
          <v-col cols="12">
            <v-row>
              <v-col cols="4">
                <v-alert class="font-italic font-weight-light headline" dark>Last 5 matches</v-alert>
              </v-col>
            </v-row>
            <v-row>
              <v-col cols="2" v-for="m in matches" :key="m.matchID">
                <v-card :color="m.color" height="250" @click="getMatchDetails(m.matchID)">
                  <v-img
                    class="white--text"
                    :src="require(`@/assets/images/champions/266/match.png`)"
                    height="100%"
                  >
                    <v-card-title :style="cardText">{{m.victory ? "Victory": "Defeat"}}</v-card-title>
                    <v-card-text :style="cardText">{{m.championPlayed}}</v-card-text>
                    <v-card-text :style="cardText">{{m.gameMode}}</v-card-text>
                    <v-card-text :style="cardText">{{m.map}}</v-card-text>
                  </v-img>
                </v-card>
              </v-col>
              <v-col cols="2">
                <v-icon x-large>mdi-eye-plus-outline</v-icon>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
        <v-row>
          <v-col cols="12">
            <v-row>
              <v-col cols="4">
                <v-alert class="font-italic font-weight-light headline" dark>Most played champs</v-alert>
              </v-col>
            </v-row>
            <v-row>
              <v-col cols="2" v-for="c in champs" :key="c">
                <v-hover v-slot:default="{hover}">
                  <v-card color="transparent" @click="champDetails(1)" :elevation="hover ? 12 : 0">
                    <v-layout column align-center pa-2>
                      <v-avatar size="100">
                        <img :src="c" alt="John" />
                      </v-avatar>
                    </v-layout>
                    <v-card-text class="text-center subtitle-1">
                      <p mb-0>Champ name</p>
                      <p>4W - 1L</p>
                      <p>75% WR</p>
                    </v-card-text>
                  </v-card>
                </v-hover>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import { match } from "minimatch";
export default {
  data() {
    return {
      cardText: {
        color: "white"
      },
      champs: [
        "https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Aatrox.png",
        "https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Ahri.png",
        "https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Morgana.png",
        "https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Ashe.png",
        "https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/TwistedFate.png"
      ]
    };
  },
  computed: {
    ...mapGetters({
      summoner: "getSummonerDetails",
      summonerMatches: "getSummonerMatches"
    }),
    fields() {
      return {
        Server: this.summoner.serverName,
        "Summoner level": this.summoner.summonerLevel,
        "Champion mastery score": this.summoner.summonerChampionMasteryScore,
        "Ranked league": `${this.summoner.rankedLeagueTier} ${this.summoner
          .rankedLeagueDivision || ""}`,
        "League points": this.summoner.leaguePoints,
        "Number of wins": this.summoner.numberOfWins
      };
    },
    matches() {
      let matchArr = [];
      console.log(this.summonerMatches);
      this.summonerMatches.map(x =>
        matchArr.push({
          matchID: x.matchID,
          championPlayed: x.championPlayed,
          victory: x.hasWon,
          lane: x.laneName,
          map: x.mapName,
          role: x.rolName,
          duration: x.matchDuration,
          date: x.matchCreation,
          gameMode: x.gameMode,
          gameType: x.gameType,
          color: x.hasWon ? "#4caf50" : "#B71C1C"
        })
      );
      return matchArr;
    }
  },
  methods: {
    getProfileIcon(val) {
      if (val) return require(`../assets/images/profileIcons/${val}.png`);
    },
    getChampAvatar() {
      return "https://ddragon.leagueoflegends.com/cdn/9.22.1/img/champion/Aatrox.png";
    },
    champDetails(id) {
      console.log("clicked");
    },
    getMatchDetails(matchID) {
      this.$router.push(`/matches/${matchID}`);
    }
  },
  watch: {},
  created() {
    this.$store.dispatch("fetchSummonerByName", this.$route.params.name);
    this.$store.dispatch("fetchLastNSummonerMatches", {
      name: this.$route.params.name,
      lastNMatches: 5
    });
  }
};
</script>

<style>
</style>
