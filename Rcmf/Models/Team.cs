namespace Rcmf.Models;

public class Team
{

  public int Id { get; set; }
  public int Phone { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public string Picture { get; set; }
  public int SponsorId { get; set; }
  public int TournamentId { get; set; }

}
