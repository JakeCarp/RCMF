import { AppState } from "../AppState.js";
import { Donor } from "../models/Donor.js";
import { mySQL } from "./AxiosService.js";

class DonationsService {

  async createDonor(donorData) {
    const res = await mySQL.post("donors", donorData);
    let newDonor = new Donor(res.data);
    AppState.donors.push(newDonor);
  }

}
export const donationsService = new DonationsService();
