const state = {
    chosenMatch: {}
}

const mutations = {
    'INITIALIZE_CHOSEN_MATCH': (state, payload) => {
        state.chosenMatch = payload
    }
}

const actions = {
    fetchMatchById: ({
        commit
    }, id) => {
        fetch(`https://localhost:44302/api/matches/${id}`, {
                method: 'GET',
            })
            .then(res => res.json())
            .then(res => commit('INITIALIZE_CHOSEN_MATCH', res))
            .catch(error => console.log(error));
    }
}

const getters = {
    getMatchDetails: state => {
        return state.chosenMatch
    }
}

export default {
    state,
    mutations,
    actions,
    getters
}