using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Tabelle;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdottoController : ControllerBase
    {
        IBusiness business;

        public ProdottoController(IBusiness business)
        {
            this.business = business;
        }

        [HttpPost, Route("Prodotti"), Authorize]
        public async Task<IActionResult> Prodotto(TPRODOTTO prodotto)
        {
            return Ok(await business.InsertProdottoAsync(prodotto));
        }

        [HttpDelete]
        [Route("Prodotti")]
        [Authorize]
        public async Task<IActionResult> Prodotto(long Id)
        {
            return Ok(await business.DeleteProductAsync(Id));
        }

        [HttpPut]
        [Route("Prodotti")]
        [Authorize]
        public async Task<IActionResult> Prodotto(TPRODOTTO Prodotto)
        {
            return Ok(await business.UpdateProductAsync(Prodotto));
        }
    }
}
