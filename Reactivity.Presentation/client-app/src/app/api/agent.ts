import { IActivity } from "./../models/activity";
import axios, { AxiosResponse } from "axios";

axios.defaults.baseURL = "http://localhost:12233/api";

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
  get: (url: string) => axios.get(url).then(responseBody),
  post: (url: string, body: {}) => axios.post(url, body).then(responseBody),
  put: (url: string, body: {}) => axios.put(url, body).then(responseBody),
  delete: (url: string) => axios.delete(url).then(responseBody),
};

const Activities = {
  list: (): Promise<IActivity[]> => requests.get("/activity"),
  details: (id: string) => requests.get(`/activity/${id}`),
  create: (activity: IActivity) => requests.post("/activity", activity),
  update: (activity: IActivity) => requests.put(`/activity`, activity),
  delete: (id: string) => requests.delete(`/activity/${id}`),
};

export default {
  Activities,
};
