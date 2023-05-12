using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdineController : ControllerBase
    {
        IBusiness Business;
        public OrdineController(IBusiness Business)
        {
            this.Business = Business;
        }

        [HttpGet, Route("Ordini"),Authorize]
        public async Task<IActionResult> OrdiniAsync()
        {
            Claim IdClaim = User.Claims.FirstOrDefault(e => e.Type.Equals("Id", StringComparison.InvariantCultureIgnoreCase));

            return Ok(await Business.GetOrdiniUtenteAsync(Int64.Parse(IdClaim.Value)));
        }
    }
}
