import { AppState } from "../AppState.js";
import { Grant } from "../models/Grant.js";
import { mySQL } from "./AxiosService.js";

class GrantsService {
  async createGrant(grantData) {
    const res = await mySQL.post("grants", grantData);
    let newGrant = new Grant(res.data);

    AppState.grants.push(newGrant);
  }

 
}
export const grantsService = new GrantsService();
