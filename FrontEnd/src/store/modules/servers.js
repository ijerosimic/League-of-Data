const state = {
    servers: []
}

const mutations = {
    'INITIALIZE_SERVERS': (state, payload) => {
        state.servers = payload
    }
}

const actions = {
    fetchServers: ({
        commit
    }) => {
        fetch("https://localhost:44302/api/servers", {
                method: 'GET',
            })
            .then(res => res.json())
            .then(res => commit('INITIALIZE_SERVERS', res))
            .catch(error => console.log(error));
    }
}

const getters = {
    getServers: state => {
        return state.servers
    }
}

export default {
    state,
    mutations,
    actions,
    getters
}