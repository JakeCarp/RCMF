namespace Rcmf.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsLetterController : ControllerBase
{
  private readonly NewsletterService _newsLetterService;
  private readonly Auth0Provider _auth0Provider;

  public NewsLetterController(NewsletterService newsLetterService, Auth0Provider auth0Provider)
  {
    _newsLetterService = newsLetterService;
    _auth0Provider = auth0Provider;
  }

  [Authorize]
   [HttpPost]
   public ActionResult<Newsletter> CreateNewsletter([FromBody] Newsletter newsletterData)
   {
     try
     {
  
       Newsletter newsletter = _newsLetterService.CreateNewsletter(newsletterData);
       return Ok(newsletter);
     }
     catch (Exception e)
     {
       return BadRequest(e.Message);
     }
   }
 
 

}
