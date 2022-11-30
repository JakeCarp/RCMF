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
    var admin = _accountsService.GetAdminById(adminId);
    if (admin == null)
    {
      throw new Exception("Bad Admin Id");
    }
    return _sponsorsRepo.Get();
  }
}