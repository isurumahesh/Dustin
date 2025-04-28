import axios from "axios";
import { appSettings } from "../appSettings";

const axiosInstance = axios.create({
  baseURL: appSettings.DustinApiUrl, // Replace with your API's base URL
});

// Interceptor to add Authorization header
axiosInstance.interceptors.request.use(
  (config) => {
    const token = localStorage.getItem("accessToken"); // Replace with your token storage logic
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

export default axiosInstance;