using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class RecommendationController : ControllerBase
{
    private static List<Recommendation> _recommendations = new List<Recommendation>()
    {
        new Recommendation { Id = 1, Description = "Pay your bills on time to improve your credit score." },
        new Recommendation { Id = 2, Description = "Keep your credit card balances low to maintain a good credit utilization ratio." }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Recommendation>> GetRecommendations()
    {
        return Ok(_recommendations);
    }
}