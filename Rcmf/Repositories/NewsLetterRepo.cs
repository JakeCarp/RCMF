namespace Rcmf.Repositories;

public class NewsLetterRepository : BaseRepository, IRepo<NewsletterSubscription, int>
{
  public NewsLetterRepository(IDbConnection db) : base(db)
  {
  }

  public NewsletterSubscription Create(NewsletterSubscription data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<NewsletterSubscription> Get()
  {
    throw new NotImplementedException();
  }

  public NewsletterSubscription GetById(int id)
  {
    throw new NotImplementedException();
  }

  public NewsletterSubscription Update(NewsletterSubscription data)
  {
    throw new NotImplementedException();
  }
}