using Models.ControllerInput;
using Models.Remap;
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
        public Task<List<Prodotto>> GetProdottiAsync(int From, int To);
        public Task<long> InsertProdottoAsync(TPRODOTTO Prodotto);
        public Task<long> DeleteProductAsync(long Id);
    }
}
