<template>
  <v-card class="pa-5 ma-2">
    <v-row align="center">
      <v-col cols="2">
        <v-avatar size="auto" tile>
          <v-img :src="getChampIcon(summoner.championName)" height="75" width="75" />
        </v-avatar>
      </v-col>
      <v-col cols="1" class="pa-0">
        <v-img :src="getRuneIcon('ArcaneComet')" height="25" width="25" class="mb-1" />
        <v-img :src="getRuneIcon('ArcaneComet')" height="25" width="25" class="mt-2" />
      </v-col>
      <v-col cols="6" class="pa-1 mt-4">
        <v-row class="text-center">
          <v-col cols="4">
            <p class="caption">Summoner</p>
            <p class="caption">{{summoner.summonerName}}</p>
          </v-col>
          <v-col cols="2">
            <p class="caption">KDA</p>
            <p class="caption">{{summoner.kills}}/{{summoner.deaths}}/{{summoner.assists}}</p>
          </v-col>
          <v-col cols="5">
            <p class="caption">Damage done</p>
            <p class="caption">{{summoner.damageDone * 1000}}</p>
          </v-col>
          <v-col cols="1">
            <p class="caption">CS</p>
            <p class="caption">{{summoner.creepScore}}</p>
          </v-col>
        </v-row>
      </v-col>
      <v-col cols="2" class="ml-4">
        <table>
          <tr>
            <td>
              <img :src="getItemIcon(1001)" height="30" width="auto" />
            </td>
            <td>
              <img :src="getItemIcon(1037)" height="30" width="auto" />
            </td>
            <td>
              <img :src="getItemIcon(1018)" height="30" width="auto" />
            </td>
          </tr>
          <tr>
            <td>
              <img :src="getItemIcon(1042)" height="30" width="auto" />
            </td>
            <td>
              <img :src="getItemIcon(1400)" height="30" width="auto" />
            </td>
            <td>
              <img :src="getItemIcon(1038)" height="30" width="auto" />
            </td>
          </tr>
        </table>
      </v-col>
    </v-row>
  </v-card>
</template>

<script>
export default {
  props: {
    summoner: Object
  },
  data() {
    return {};
  },
  methods: {
    getChampIcon(val) {
      console.log(this.summoner);
      return require(`../../assets/images/champions/icons/${val}.png`);
    },
    getItemIcon(val) {
      return require(`../../assets/images/items/${val}.png`);
    },
    getRuneIcon(val) {
      return require(`../../assets/images/runes/${val}/${val}.png`);
    }
  }
};
</script>

<style>
</style>
