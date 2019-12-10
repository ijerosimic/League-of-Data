<template>
  <v-row class="text-center">
    <v-avatar size="auto" tile>
      <v-img :src="getChampIcon('Akali')" height="25" width="25" />
    </v-avatar>
    <p style="float:right; ma-0 pa-0">{{teamHeader('blue', item)}} {{item}}</p>
    <!-- slot??? umjesto p gore -->
  </v-row>
</template>

<script>
export default {
  props: {
    team: String,
    src: String
  },
  data() {
    return {};
  }
};
</script>

<style>
</style>
