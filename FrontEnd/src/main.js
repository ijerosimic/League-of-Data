import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import routes from './routes'
import store from './store/store'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify'
import vuetify from './plugins/vuetify';

Vue.config.productionTip = false

Vue.use(VueRouter)
Vue.use(Vuetify)

const router = new VueRouter({
  routes,
  mode: 'history'
})

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')