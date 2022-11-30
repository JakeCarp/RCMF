namespace Rcmf.Services;

public class SponsorsService
{
  private readonly SponsorsRepository _sponsorsRepo;

  public SponsorsService(SponsorsRepository sponsorsRepo)
  {
    _sponsorsRepo = sponsorsRepo;
  }
}