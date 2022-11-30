namespace Rcmf.Repositories;

public class DonorsRepository : BaseRepository, IRepo<Donor, int>
{
  public DonorsRepository(IDbConnection db) : base(db)
  {
  }

  public Donor Create(Donor data)
  {
    var sql = @"INSERT INTO donors (name, email, amount)
            VALUES (@Name, @Email, @Amount);
            SELECT LAST_INSERT_ID()
            ;";

    int donorId = _db.ExecuteScalar<int>(sql, data);
    return GetById(donorId);
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
    string sql = @"SELECT 
                *
                FROM donors
                WHERE id = @id
                     ;";
    return _db.Query<Donor>(sql, new { id }).FirstOrDefault();
  }

  public Donor Update(Donor data)
  {
    throw new NotImplementedException();
  }
}