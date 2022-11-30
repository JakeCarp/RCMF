namespace Rcmf.Repositories;

public class DonorsRepository : BaseRepository, IRepo<Donor, int>
{
  public DonorsRepository(IDbConnection db) : base(db)
  {
  }

  public Donor Create(Donor data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<Donor> Get()
  {
    throw new NotImplementedException();
  }

  public Donor GetById(int id)
  {
    throw new NotImplementedException();
  }

  public Donor Update(Donor data)
  {
    throw new NotImplementedException();
  }
}