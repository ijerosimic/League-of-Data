<template>
  <v-container fluid>
    <v-row>
      <v-col cols="12">
        <v-card class="text-center" outlined>
          <v-card-title class="justify-center">Match Details</v-card-title>
          <v-card-text>
            <v-simple-table>
              <tr>
                <td>
                  <v-icon slot="prepend">mdi-map-outline</v-icon>
                  {{mapName}}
                </td>
                <td>
                  <v-icon slot="prepend">mdi-flash</v-icon>
                  {{gameMode}}
                </td>
                <td>
                  <v-icon slot="prepend">mdi-calendar-clock</v-icon>
                  {{matchCreatedOn}}
                </td>
                <td>
                  <v-icon slot="prepend">mdi-timer-sand</v-icon>
                  {{matchDuration}}
                </td>
              </tr>
            </v-simple-table>
          </v-card-text>
          <v-row class="text-center">
            <v-col cols-6>
              <v-row>
                <app-objectives
                  cols="2"
                  v-for="(item, index) in this.objectives"
                  :key="index"
                  size="auto"
                ></app-objectives>
              </v-row>
            </v-col>
            <v-col cols-6>
              <v-row>
                <app-objectives
                  cols="2"
                  v-for="(item, index) in this.objectives"
                  :key="index"
                  size="auto"
                ></app-objectives>
              </v-row>
            </v-col>
          </v-row>
          <v-row>
            <v-col cols="6">
              <app-summoners
                v-for="summoner in blueTeam()"
                :key="summoner.summonerID"
                :summoner="summoner"
              ></app-summoners>
            </v-col>
            <v-col cols="6">
              <app-summoners
                v-for="summoner in redTeam()"
                :key="summoner.summonerID"
                :summoner="summoner"
              ></app-summoners>
            </v-col>
          </v-row>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import summoners from "./MatchSummoners.vue";
import objectives from "./MatchDetailsObjectives.vue";
export default {
  components: {
    appSummoners: summoners,
    appObjectives: objectives
  },
  data() {
    return {
      objectives: ["Dragon", "Elder", "Baron", "Gold", "Kills", "Turrets"]
    };
  },
  computed: {
    ...mapGetters({
      match: "getMatchDetails"
    }),
    matchCreatedOn() {
      if (this.match.matchCreation) {
        const dateTime = this.match.matchCreation.split("T");
        const date = dateTime[0];
        const time = dateTime[1].split(".")[0];
        return `${date}, ${time}`;
      }
    },
    matchDuration() {
      if (this.match.matchDuration) {
        const duration = this.match.matchDuration.toString();
        const mins = duration.substr(0, 2);
        const seconds = duration.substr(2, 2);
        return `${mins}:${seconds}`;
      }
    },
    mapName() {
      return this.match.mapName;
    },
    gameMode() {
      return this.match.gameMode;
    }
  },
  methods: {
    blueTeam() {
      if (this.match.summonerDetails)
        return this.match.summonerDetails.filter(x => x.team === "Blue");
    },
    redTeam() {
      if (this.match.summonerDetails)
        return this.match.summonerDetails.filter(x => x.team === "Red");
    },
    getChampIcon(val) {
      return require(`../../assets/images/champions/icons/${val}.png`);
    },
    getItemIcon(val) {
      return require(`../../assets/images/items/${val}.png`);
    },
    getRuneIcon(val) {
      return require(`../../assets/images/runes/${val}/${val}.png`);
    },
    teamHeader(side, objective) {
      return Object.keys(this.match)
        .sort((a, b) => a.localeCompare(b))
        .filter(
          x =>
            x.toUpperCase().includes(side.toUpperCase()) &&
            x.toUpperCase().includes(objective.toUpperCase())
        )
        .reduce((o, k) => {
          return this.match[k];
        }, {});
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
