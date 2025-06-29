import axios from "axios";

const API_URL = process.env.NEXT_PUBLIC_API_BASE_URL;
console.log(process.env.NEXT_PUBLIC_API_BASE_URL);
const axiosInstance = axios.create({
  baseURL: API_URL,
  headers: {
    "Content-Type": "application/json",
  },
});

export default axiosInstance;

// axiosInstance.interceptors.request.use(
//   (config) => {
//     // هدر احراز هویت یا تغییرات دیگر
//     const token = "your-auth-token";
//     if (token) {
//       config.headers.Authorization = `Bearer ${token}`;
//     }
//     return config;
//   },
//   (error) => {
//     return Promise.reject(error);
//   }
// );
