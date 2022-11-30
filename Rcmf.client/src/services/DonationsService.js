import { mySQL } from "./AxiosService.js"

class DonationsService{
async getDonors(donorData){
  const res = await mySQL.get('api/donors',donorData)
}
}
export const donationsService = new DonationsService()