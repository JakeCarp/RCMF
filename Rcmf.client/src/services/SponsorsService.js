import { AppState } from "../AppState.js";
import { Sponsor } from "../models/Sponsor.js";
import { mySQL } from "./AxiosService.js";

class SponsorsService {
  async getSponsors() {
    const res = await mySQL.get("api/sponsors");
    console.log(res.data);
    AppState.sponsors = res.data.map((s) => new Sponsor(s));
  }
  async getSponsorById(sponsorId){
    const res = await mySQL.get(`api/sponsors/${sponsorId}`)
    AppState.activeSponsor = new Sponsor(res.data)
  }

  async createSponsor(sponsorData) {
    const res = await mySQL.post("api/sponsors", sponsorData);
    let newSponsor = new Sponsor(res.data);
    AppState.sponsors.push(newSponsor);
  }

  async deleteSponsor(sponsorId) {
    await mySQL.delete(`api/sponsors/${sponsorId}`);
    AppState.sponsors.filter((x) => x.id != sponsorId);
  }

  async editSponsor(sponsorData) {
    const res = await mySQL.put(`api/sponsors`, sponsorData);
    let updatedSponsor = new Sponsor(res.data);
    let index = AppState.sponsors.findIndex((s) => {
      s.id == sponsorData.id;
    });
    AppState.sponsors.splice(index, 1);
    AppState.sponsors.push(updatedSponsor);
  }


}
export const sponsorsService = new SponsorsService();
