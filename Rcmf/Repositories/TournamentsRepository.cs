namespace Rcmf.Repositories;

public class TournamentsRepository : BaseRepository, IRepo<Tournament, int>
{
  public TournamentsRepository(IDbConnection db) : base(db)
  {
  }

  public Tournament Create(Tournament data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<Tournament> Get()
  {
    throw new NotImplementedException();
  }

  public Tournament GetById(int id)
  {
    throw new NotImplementedException();
  }

  public Tournament Update(Tournament data)
  {
    throw new NotImplementedException();
  }
}