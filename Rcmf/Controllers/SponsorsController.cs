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


  [HttpPost]
  public ActionResult<List<string>> Create([FromBody] string value)
  {
    try
    {
      return Ok(value);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
