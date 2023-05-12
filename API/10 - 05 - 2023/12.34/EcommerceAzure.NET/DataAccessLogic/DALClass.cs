using DBContext;
using Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models.ControllerInput;
using Models.StoredProceduresResult;

namespace DataAccessLogic
{
    public class DALClass : IDAL
    {
        EcommerceAzureContext Context;
        public DALClass(EcommerceAzureContext Context)
        {
            this.Context = Context;
        }

        public async Task<List<spGetOrdiniUtente>> GetOrdiniUtenteAsync(long IdUtente)
        {
            SqlParameter IdUtentePrm = new SqlParameter
            {
                ParameterName = "Id",
                Value = IdUtente,
                SqlDbType = System.Data.SqlDbType.BigInt
            };
            List<spGetOrdiniUtente> Ordini = await Context.spGetOrdiniUtente.FromSqlRaw("EXECUTE spGetOrdiniUtente {0}", IdUtentePrm).ToListAsync();

            return Ordini;
        }

        //public async Task<int> GetScalar()
        //{
        //    SqlParameter ReturnValue = new SqlParameter
        //    {
        //        ParameterName = "ReturnValue",
        //        Direction = System.Data.ParameterDirection.Output,
        //        SqlDbType = System.Data.SqlDbType.Int
        //    };

        //    SqlParameter[] SqlPrm = new[]
        //    {
        //        ReturnValue
        //    };

        //    var Result = await Context.Database.ExecuteSqlRawAsync("EXEC @ReturnValue =  spProva", SqlPrm);

        //    return (int)ReturnValue.Value;
        //}

        public async Task<spEsisteUtente> EsisteUtenteAsync(LoginUtente Utente)
        {
            SqlParameter[] SqlPrm = new[]
            {
                new SqlParameter
                {
                    ParameterName = "Email",
                    Value = Utente.Email,
                    SqlDbType = System.Data.SqlDbType.NVarChar
                },
                new SqlParameter
                {
                    ParameterName = "Password",
                    Value = Utente.Password,
                    SqlDbType = System.Data.SqlDbType.NVarChar
                }
            };

            List<spEsisteUtente> UtenteList = await Context.spEsisteUtente.FromSqlRaw("EXECUTE spEsisteUtente @Email, @Password", SqlPrm).ToListAsync();

            return UtenteList.FirstOrDefault();
        }
    }
}
