namespace Rcmf.Repositories;

public class NewsletterRepository : BaseRepository, IRepo<NewsletterSubscription, int>
{
  public NewsletterRepository(IDbConnection db) : base(db)
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