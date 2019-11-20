const state = {
    summoners: [],
    chosenSummoner: {},
    summonerMatches: []
}

const mutations = {
    'INITIALIZE_SUMMONERS': (state, payload) => {
        state.summoners = payload
    },
    'INITIALIZE_CHOSEN_SUMMONER': (state, payload) => {
        state.chosenSummoner = payload
    },
    'INITIALIZE_SUMMONER_MATCHES': (state, payload) => {
        state.summonerMatches = payload
    }
}

const actions = {
    fetchSummoners: ({
        commit
    }) => {
        fetch("https://localhost:44302/api/summoners", {
                method: 'GET',
            })
            .then(res => res.json())
            .then(res => commit('INITIALIZE_SUMMONERS', res))
            .catch(error => console.log(error));
    },
    fetchSummonerByName: ({
        commit
    }, name) => {
        fetch(`https://localhost:44302/api/summoners/${name}`, {
                method: 'GET',
            })
            .then(res => res.json())
            .then(res => commit('INITIALIZE_CHOSEN_SUMMONER', res))
            .catch(error => console.log(error));
    },
    fetchLastNSummonerMatches: ({
        commit
    }, data) => {
        fetch(`https://localhost:44302/api/summoners/${data.name}/matches/${data.lastNMatches}`, {
                method: 'GET',
            })
            .then(res => res.json())
            .then(res => commit('INITIALIZE_SUMMONER_MATCHES', res))
            .catch(error => console.log(error));
    }
}

const getters = {
    getSummoners: state => {
        return state.summoners
    },
    getSummonerDetails: state => {
        return state.chosenSummoner
    },
    getSummonerMatches: state => {
        return state.summonerMatches
    }
    // getSummonerNames: state => {
    //     return state.summoners
    //         .map(s => ({
    //             value: s.id,
    //             text: s.summonerName
    //         }))
    //}
}

export default {
    state,
    mutations,
    actions,
    getters
}