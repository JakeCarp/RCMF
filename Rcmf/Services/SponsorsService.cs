namespace Rcmf.Services;

public class SponsorsService
{
  private readonly SponsorsRepository _sponsorsRepo;
  private readonly AccountService _accountsService;

  public SponsorsService(SponsorsRepository sponsorsRepo, AccountService accountsService)
  {
    _sponsorsRepo = sponsorsRepo;
    _accountsService = accountsService;
  }

  internal List<Sponsor> GetAllSponsors(string adminId)
  {

    return _sponsorsRepo.Get();
  }
}