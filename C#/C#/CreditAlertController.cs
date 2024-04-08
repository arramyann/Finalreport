using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class CreditAlertController : ControllerBase
{
    private static List<CreditAlert> _creditAlerts = new List<CreditAlert>();

    [HttpGet]
    public ActionResult<IEnumerable<CreditAlert>> GetCreditAlerts()
    {
        return Ok(_creditAlerts);
    }

    [HttpPost]
    public ActionResult AddCreditAlert(CreditAlert creditAlert)
    {
        creditAlert.Date = DateTime.Now;
        _creditAlerts.Add(creditAlert);
        return CreatedAtAction(nameof(GetCreditAlerts), new { id = creditAlert.Id }, creditAlert);
    }
}
