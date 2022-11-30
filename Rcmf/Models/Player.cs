namespace Rcmf.Models;

public class Player
{
  public string Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; } //optional
  public ShirtSize ShirtSize{ get; set; } //enum
}
