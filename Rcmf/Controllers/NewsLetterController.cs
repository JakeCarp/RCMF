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
  public ActionResult<NewsLetter> CreateNewsletter([FromBody] NewsLetter newsLetterData)
  {
    try
    {

      NewsLetter newsLetter = _newsLetterService.CreateNewsletter(newsLetterData);
      return Ok(newsLetter);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



}
