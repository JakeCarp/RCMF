
namespace Rcmf.Models;

public class Sponsor
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public SponsorTier Tier { get; set; }

}
