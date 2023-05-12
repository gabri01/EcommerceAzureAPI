using Common.Serilog;
using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.IdentityModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvaController : ControllerBase
    {
        IBusiness Business;
        public ProvaController(IBusiness Business)
        {
            this.Business = Business;
        }

        //[HttpGet, Route("Ordini")]
        //public async Task<IActionResult> GetOrdni()
        //{
        //    long IdUtente = 6;
        //    return Ok(await Business.GetOrdiniUtente(IdUtente));
        //}

        //[HttpGet, Route("Scalar")]
        //public async Task<IActionResult> GetScalar()
        //{
        //    return Ok(await Business.GetScalar());
        //}

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        if (true)
        //            throw new Exception();
        //    }
        //    catch (Exception Ex)
        //    {
        //        ManageSerilog.LogError("Mario", "API.Controllers", Ex.ToString());
        //        return Ok("Exc loggato!");
        //    }
        //}
    }
}
