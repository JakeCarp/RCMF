namespace Rcmf.Repositories;

public class TournamentsRepository : BaseRepository, IRepo<Tournament, int>
{
  public TournamentsRepository(IDbConnection db) : base(db)
  {
  }

  public Tournament Create(Tournament data)
  {
    var sql = @"
    INSERT INTO
    tournaments (date, location, netIncome)
    VALUES (@Date, @Location, @NetIncome);
    SELECT LAST_INSERT_ID()
    ;";

    int tourneyId = _db.ExecuteScalar<int>(sql, data);
    return GetById(tourneyId);
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
    var sql = @"
    SELECT *
    FROM tournaments
    WHERE id = @id
    ;";
    return _db.Query<Tournament>(sql, new { id }).FirstOrDefault();
  }

  public Tournament Update(Tournament data)
  {
    throw new NotImplementedException();
  }
}