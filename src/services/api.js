import axios from "axios";
const backendURL = import.meta.env.VITE_BACKEND_URL;

const api = axios.create( {
    baseURL: backendURL,
});

api.interceptors.request.use((config) => {
    const token = window.localStorage.getItem("AUTH_TOKEN");
    const isAuthenticated = Boolean(token);

    if(isAuthenticated) {
        config.headers["Authorization"] = `Bearer ${Token}`;
    }

    return config;
});

export default api;