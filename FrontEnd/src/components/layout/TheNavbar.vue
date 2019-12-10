<template>
  <nav>
    <v-app-bar app flat>
      <v-app-bar-nav-icon @click="mini = !mini"></v-app-bar-nav-icon>
      <v-toolbar-title class="purple--text">
        <span class="font-weight-light">_TITLE_</span>
      </v-toolbar-title>
    </v-app-bar>
    <v-navigation-drawer app v-model="drawer" :mini-variant.sync="mini" permanent>
      <v-list-item>
        <v-list-item-title>Navigation</v-list-item-title>
      </v-list-item>
      <v-list-item>
        <router-link to="/">Home</router-link>
      </v-list-item>
      <v-list-item>
        <router-link to="/summoners">Dashboard</router-link>
      </v-list-item>
    </v-navigation-drawer>
  </nav>
</template>
//Cookieji
<script>
export default {
  data: () => ({
    drawer: true,
    mini: false,
    noSummoner: true,
    canClose: true
  })
};
</script>

<style>
</style>