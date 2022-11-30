namespace Rcmf.Controllers;

[ApiController]
[Route("[controller]")]
public class SponsorsController : ControllerBase
{

  private readonly Auth0Provider _auth0Provider;
  private readonly SponsorsService _sponsorsService;


  [HttpGet]
  public async Task<ActionResult<List<Sponsor>>> GetAllSponsors()
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);

      List<Sponsor> sponsors = _sponsorsService.GetAllSponsors(userInfo?.Id);
      return Ok(sponsors);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [Authorize]
  [HttpPost]
  public async Task<ActionResult<Sponsor>> CreateSponsor([FromBody] Sponsor sponsorData)
  {
    try
    {
      var userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      Sponsor sponsor = _sponsorsService.CreateSponsor(sponsorData);
      return Ok(sponsor);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpDelete("{sponsorId}")]
  [Authorize]
  public async Task<ActionResult<string>> DeleteSponsor(int sponsorId)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      _sponsorsService.DeleteSponsor(sponsorId, userInfo.Id);
      return Ok("Sponsor deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

   [HttpPut("{sponsorId}")]
      [Authorize]
      public async Task<ActionResult<Sponsor>> EditSponsor([FromBody] Sponsor sponsorData, int sponsorId)
      {
        try
        {
          Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
          Sponsor sponsor = _sponsorsService.UpdateSponsor(sponsorData, userInfo.Id);
          return Ok(sponsor);
        }
        catch (Exception e)
        {
          return BadRequest(e.Message);
        }
      }
  


}
