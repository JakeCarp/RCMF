namespace Rcmf.Models;

public class Player : IDbItem<int>
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; } //optional
  public ShirtSize ShirtSize{ get; set; } //enum
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
