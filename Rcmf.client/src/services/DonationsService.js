import { AppState } from "../AppState.js";
import { Donor } from "../models/Donor.js";
import { mySQL } from "./AxiosService.js";

class DonationsService {
  async getDonors() {
    const res = await mySQL.get("donors");
    AppState.donors = res.data.map(new Donor(res.data));
  }
  async getDonorById(donorId) {
    const res = await mySQL.get(`donors/${donorId}`);
    AppState.activeDonor = new Donor(res.data);
  }

  async createDonor(donorData) {
    const res = await mySQL.post("donors", donorData);
    let newDonor = new Donor(res.data);
    AppState.donors.push(newDonor);
  }

  async deleteDonor(donorId) {
    await mySQL.delete(`donors/${donorId}`);
    AppState.donors.filter((d) => d.id != donorId);
  }
  getDonationTotal() {
    let donors = AppState.donors;
    let total = AppState.donationTotal;
    donors.forEach((d) => {
      total += d.amount;
    });
  }
}
export const donationsService = new DonationsService();
