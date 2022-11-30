namespace Rcmf.Services;

public class PlayersService
{
  private readonly PlayersRepository _playersRepo;

  public PlayersService(PlayersRepository playersRepo)
  {
    _playersRepo = playersRepo;
  }
}