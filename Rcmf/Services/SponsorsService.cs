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

  internal void DeleteSponsor(int sponsorId, string userId)
  {
    Sponsor sponsor = _sponsorsRepo.GetById(sponsorId);
    Account account = _accountsService.GetAdminById(userId);
    if(account == null)
    {
      throw new Exception("Unauthorized to Delete");
    }
    _sponsorsRepo.Delete(sponsorId);
  }

  internal Sponsor GetSponsorById(int sponsorId)
  {
    var sponsor = _sponsorsRepo.GetById(sponsorId);
    if (sponsor == null)
    {
      throw new Exception("Bad Sponsor Id");
    }
    return sponsor;
  }

  internal Sponsor UpdateSponsor(Sponsor sponsor, string accountId)
  {
    Sponsor original = GetSponsorById(sponsor.Id);

    original.Name = sponsor.Name ?? original.Name;
    original.Email = sponsor.Email ?? original.Email;
    original.Tier = sponsor.Tier;

    Sponsor updated = _sponsorsRepo.Update(original);
    return updated;

  }

  internal Sponsor CreateSponsor(Sponsor sponsorData)
  {
    return _sponsorsRepo.Create(sponsorData);
  }


}