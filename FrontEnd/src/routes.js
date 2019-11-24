import Home from "./components/Home.vue"
import SummonerDashboard from "./components/SummonerDashboard.vue"
import SummonerDetails from "./components/SummonerDetails.vue"
import MatchDetails from "./components/MatchDetails.vue"
import Test from "./components/Test.vue"

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
    },
    {
        path: '/test',
        component: Test
    }
]

export default routes