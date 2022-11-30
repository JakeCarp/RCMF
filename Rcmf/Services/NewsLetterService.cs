namespace Rcmf.Services;

public class NewsletterService
{
  private readonly NewsLetterRepository _newsletterRepo;

  public NewsletterService(NewsLetterRepository newsletterRepo)
  {
    _newsletterRepo = newsletterRepo;
  }
}