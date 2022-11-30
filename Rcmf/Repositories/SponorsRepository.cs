namespace Rcmf.Repositories;

public class SponsorsRepository : BaseRepository, IRepo<Sponsor, int>
{
  public SponsorsRepository(IDbConnection db) : base(db)
  {
  }

  public Sponsor Create(Sponsor data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<Sponsor> Get()
  {
    throw new NotImplementedException();
  }

  public Sponsor GetById(int id)
  {
    throw new NotImplementedException();
  }

  public Sponsor Update(Sponsor data)
  {
    throw new NotImplementedException();
  }
}