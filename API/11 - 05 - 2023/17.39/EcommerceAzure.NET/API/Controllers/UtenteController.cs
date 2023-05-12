using Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.ControllerInput;
using Models.StoredProceduresResult;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtenteController : ControllerBase
    {
        IBusiness Business;

        public UtenteController(IBusiness Business)
        {
            this.Business = Business;
        }

        [HttpPost, Route("Login")]
        public async Task<IActionResult> LoginAsync(LoginUtente Utente)
        {
            if (!Business.VerificaFormatoEmail(Utente.Email))
                return BadRequest("Email non valida!");

            if (!Business.VerificaFormatoPassword(Utente.Password))
                return BadRequest("Password non valida!");

            spEsisteUtente DatiUtente = await Business.EsisteUtenteAsync(Utente);
            if (DatiUtente is not null)
                return Ok(Business.GenerateJWTToken(DatiUtente));

            return Ok("Credenziali non valide!");
        }
    }
}
