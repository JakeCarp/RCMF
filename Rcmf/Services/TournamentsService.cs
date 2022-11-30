namespace Rcmf.Services;

public class TournamentsService
{
  private readonly TournamentsRepository _tournamentRepo;

  public TournamentsService(TournamentsRepository tournamentRepo)
  {
    _tournamentRepo = tournamentRepo;
  }
}