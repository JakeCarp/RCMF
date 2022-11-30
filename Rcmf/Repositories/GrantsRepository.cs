namespace Rcmf.Repositories;

public class GrantsRepository : BaseRepository, IRepo<GrantApplication, int>
{
  public GrantsRepository(IDbConnection db) : base(db)
  {
  }

  public GrantApplication Create(GrantApplication data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<GrantApplication> Get()
  {
    throw new NotImplementedException();
  }

  public GrantApplication GetById(int id)
  {
    throw new NotImplementedException();
  }

  public GrantApplication Update(GrantApplication data)
  {
    throw new NotImplementedException();
  }
}