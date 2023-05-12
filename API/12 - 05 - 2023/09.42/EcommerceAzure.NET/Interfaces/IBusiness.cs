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
    public interface IBusiness
    {
        public Task<List<spGetOrdiniUtente>> GetOrdiniUtenteAsync(long IdUtente);
        //public Task<int> GetScalar();
        public bool VerificaFormatoEmail(string Email);
        public bool VerificaFormatoPassword(string Password);
        public Task<spEsisteUtente> EsisteUtenteAsync(LoginUtente Utente);
        public string GenerateJWTToken(spEsisteUtente Utente);
        public Task<List<Prodotto>> GetProdottiAsync(int From, int To);
        public Task<long> InsertProdottoAsync(TPRODOTTO Prodotto);
        public Task<long> DeleteProductAsync(long Id);
    }
}
