export class Donor {
  constructor(data) {
    this.donorId = data.id;
    this.donorName = data.donorName;
    this.donorEmail = data.donorEmail;
    this.amount = data.amount;
  }
}
