import Vue from 'vue'
import Vuex from 'vuex'

import summoners from './modules/summoners'
import servers from './modules/servers'
import matches from './modules/matches'

Vue.use(Vuex)

export const store = new Vuex.Store({
    modules: {
        summoners,
        servers,
        matches
    }
})