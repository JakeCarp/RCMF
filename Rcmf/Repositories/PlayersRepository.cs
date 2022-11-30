namespace Rcmf.Repositories;

public class PlayersRepository : BaseRepository, IRepo<Player, int>
{
  public PlayersRepository(IDbConnection db) : base(db)
  {
  }

  public Player Create(Player data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<Player> Get()
  {
    throw new NotImplementedException();
  }

  public Player GetById(int id)
  {
    throw new NotImplementedException();
  }

  public Player Update(Player data)
  {
    throw new NotImplementedException();
  }
}