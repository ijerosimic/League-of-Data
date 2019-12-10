<template>
  <v-app>
    <app-navbar></app-navbar>
    <v-content>
      <v-container fluid>
        <router-view></router-view>
      </v-container>
    </v-content>
    <v-footer app></v-footer>
  </v-app>
</template> 

<script>
import TheNavbar from "./components/layout/TheNavbar";
export default {
  name: "App",
  components: {
    appNavbar: TheNavbar
  },
  data: () => ({})
};
</script>
