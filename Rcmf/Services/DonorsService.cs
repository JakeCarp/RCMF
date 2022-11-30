namespace Rcmf.Services;

public class DonorsService
{
  private readonly DonorsRepository _donorsRepo;

  public DonorsService(DonorsRepository donorsRepo)
  {
    _donorsRepo = donorsRepo;
  }
}