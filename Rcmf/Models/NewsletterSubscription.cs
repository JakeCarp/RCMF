namespace Rcmf.Models;

public class NewsletterSubscription : IDbItem<int>
{
  public string Name { get; set; }
  public string  Email { get; set; }
  public int Id { get; set; }
  public DateTime CreatedAt { get ; set ; }
  public DateTime UpdatedAt { get ; set ; }
}