using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

[ApiController]
[Route("api/[controller]")]
public class CreditScoreController : ControllerBase
{
    private static List<CreditScore> _creditScores = new List<CreditScore>();

    [HttpGet]
    public ActionResult<IEnumerable<CreditScore>> GetCreditScores()
    {
        return Ok(_creditScores);
    }

    [HttpPost]
    public ActionResult AddCreditScore(CreditScore creditScore)
    {
        creditScore.Date = DateTime.Now;
        _creditScores.Add(creditScore);
        return CreatedAtAction(nameof(GetCreditScores), new { id = creditScore.Id }, creditScore);
    }
}
