import { AppState } from "../AppState.js";
import { Sponsor } from "../models/Sponsor.js";
import { mySQL } from "./AxiosService.js";

class SponsorsService {


  async createSponsor(sponsorData) {
    const res = await mySQL.post("sponsors", sponsorData);
    let newSponsor = new Sponsor(res.data);
    AppState.sponsors.push(newSponsor);
  }

}
export const sponsorsService = new SponsorsService();
