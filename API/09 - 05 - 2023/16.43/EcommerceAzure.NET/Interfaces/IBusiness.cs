using Models.ControllerInput;
using Models.StoredProceduresResult;
using Models.Tabelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBusiness
    {
        public Task<List<spGetOrdiniUtente>> GetOrdiniUtenteAsync(long IdUtente);

        public bool VerificaFormatoEmail(string Email);
        public bool VerificaFormatoPassword(string Password);
        public Task<spEsisteUtente> EsisteUtenteAsync(LoginUtente Utente);
        public string GenerateJWTToken(spEsisteUtente Utente);
    }
}
