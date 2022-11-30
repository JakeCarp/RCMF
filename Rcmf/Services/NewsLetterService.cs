namespace Rcmf.Services;

public class NewsletterService
{
  private readonly NewsletterRepository _newsletterRepo;

  public NewsletterService(NewsletterRepository newsletterRepo)
  {
    _newsletterRepo = newsletterRepo;
  }
}