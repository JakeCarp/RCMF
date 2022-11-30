namespace Rcmf.Repositories;

public class NewsletterRepository : BaseRepository, IRepo<Newsletter, int>
{
  public NewsletterRepository(IDbConnection db) : base(db)
  {
  }

  public Newsletter Create(Newsletter newsLetterData)
  {
    var sql = @"INSERT INTO newsLetters
                (name,email,)
                VALUES
                (@Name,@Email);
                SELECT LAST_INSERT_ID()
                ;";

    int newsLetterId = _db.ExecuteScalar<int>(sql, newsLetterData);
    return GetById(newsLetterId);
  }

  public void Delete(int id)
  {
    var sql = @"DELETE FROM newsLetters WHERE id = @id;";

    var rows = _db.Execute(sql, new { id });
    if (rows != 1) { throw new Exception("Data is bad or Id is Bad"); }
    return;

  }

  public List<Newsletter> Get()
  {
    throw new NotImplementedException();
  }

  public Newsletter GetById(int id)
  {
    string sql = @"SELECT 
                *
                FROM newsLetters
                WHERE id = @id
                ;";
    return _db.Query<Newsletter>(sql, new { id }).FirstOrDefault();
  }

  public Newsletter Update(Newsletter data)
  {
    throw new NotImplementedException();
  }
}