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
    public interface IDAL
    {
        public Task<List<spGetOrdiniUtente>> GetOrdiniUtenteAsync(long IdUtente);
        //public Task<int> GetScalar();
        public Task<spEsisteUtente> EsisteUtenteAsync(LoginUtente Utente);
        //public Task
    }
}
