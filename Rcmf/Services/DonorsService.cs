namespace Rcmf.Services;

public class DonorsService
{
  private readonly DonorsRepository _donorsRepo;

  public DonorsService(DonorsRepository donorsRepo)
  {
    _donorsRepo = donorsRepo;
  }

  internal Donor CreateDonor(Donor donorData)
  {
    return _donorsRepo.Create(donorData);
  }
}