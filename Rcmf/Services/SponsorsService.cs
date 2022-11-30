namespace Rcmf.Services;

public class SponsorsService
{
  private readonly SponsorsRepository _sponsorsRepo;

  public SponsorsService(SponsorsRepository sponsorsRepo)
  {
    _sponsorsRepo = sponsorsRepo;
  }

  internal List<Sponsor> GetAllSponsors(string adminId)
  {
    return _sponsorsRepo.Get();
  }
}