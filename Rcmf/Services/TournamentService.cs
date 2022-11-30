namespace Rcmf.Services;

public class TournamentService
{
  private readonly TournamentsRepository _tournamentRepo;

  public TournamentService(TournamentsRepository tournamentRepo)
  {
    _tournamentRepo = tournamentRepo;
  }
}