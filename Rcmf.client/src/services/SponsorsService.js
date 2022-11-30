import { AppState } from "../AppState.js";
import { mySQL } from "./AxiosService.js";

class SponsorsService {
  async getSponsors() {
    const res = await mySQL.get("api/sponsors");
    
    AppState.sponsors = res.data.map
  }
}
export const sponsorsService = new SponsorsService();
