namespace Rcmf.Repositories;

public class NewsletterRepository : BaseRepository, IRepo<Newsletter, int>
{
  public NewsletterRepository(IDbConnection db) : base(db)
  {
  }

  public Newsletter Create(Newsletter data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<Newsletter> Get()
  {
    throw new NotImplementedException();
  }

  public Newsletter GetById(int id)
  {
    throw new NotImplementedException();
  }

  public Newsletter Update(Newsletter data)
  {
    throw new NotImplementedException();
  }
}