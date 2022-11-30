namespace Rcmf.Controllers;

[ApiController]
[Route("[controller]")]
public class DonorsController : ControllerBase


{
  private readonly DonorsService _donorsService;

  public DonorsController(DonorsService donorsService)
  {
    _donorsService = donorsService;
  }

  [HttpGet]
  public ActionResult<List<string>> Get()
  {
    try
    {
      return Ok(new List<string>() { "Value 1", "Value 2" });
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpPost]
  public ActionResult<Donor> CreateDonor([FromBody] Donor DonorData)
  {
    try
    {

      Donor Donor = _donorsService.CreateDonor(DonorData);
      return Ok(Donor);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



}
