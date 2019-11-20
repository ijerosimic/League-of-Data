import Home from "./components/Home.vue"
import SummonerDashboard from "./components/SummonerDashboard.vue"
import SummonerDetails from "./components/SummonerDetails.vue"
import MatchDetails from "./components/MatchDetails.vue"

const routes = [{
        path: '/',
        component: Home,
        alias: '/index'
    }, {
        path: '/summoners/dashboard',
        component: SummonerDashboard
    },
    {
        path: '/summoners/:name',
        component: SummonerDetails
    },
    {
        path: '/matches/:id',
        component: MatchDetails
    }
]

export default routes