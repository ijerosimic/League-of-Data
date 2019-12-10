import AppHome from "./components/home/AppHome.vue"
import Summoners from "./components/summoners/Index.vue"
import SummonerDetails from "./components/summoners/SummonerDetails.vue"
import MatchDetails from "./components/matches/MatchDetails.vue"
import Test from "./components/Test.vue"

const routes = [{
        path: '/',
        component: AppHome,
        alias: '/index'
    }, {
        path: '/summoners',
        component: Summoners
    },
    {
        path: '/summoners/details/:name',
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