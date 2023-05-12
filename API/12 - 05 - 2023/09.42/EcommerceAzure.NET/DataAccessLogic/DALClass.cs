using DBContext;
using Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models.ControllerInput;
using Models.Remap;
using Models.StoredProceduresResult;
using Models.Tabelle;

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

        public async Task<List<Prodotto>> GetProdottiAsync(int From, int To)
        {
            //TODO: spostare sul controller e in appsettings.
            //int To = 5;

            SqlParameter[] SqlPrms = new[]
            {
                new SqlParameter
                {
                    ParameterName = "From",
                    Value = From,
                    SqlDbType = System.Data.SqlDbType.Int
                },
                new SqlParameter
                {
                    ParameterName = "To",
                    Value = To,
                    SqlDbType = System.Data.SqlDbType.Int
                }
            };

            List<spGetProdotti> spProdotti = await Context.spGetProdotti.FromSqlRaw("EXECUTE spGetProdotti @From, @To", SqlPrms).ToListAsync();
            List<Prodotto> Prodotti = new List<Prodotto>();
            foreach(spGetProdotti P in spProdotti)
            {
                SqlParameter SqlPrm = new SqlParameter
                {
                    ParameterName = "IdProdotto",
                    Value = P.Id,
                    SqlDbType = System.Data.SqlDbType.BigInt
                };

                Prodotti.Add(new Prodotto()
                {
                    Id = P.Id,
                    Cod = P.Cod,
                    Nome = P.Nome,
                    Prezzo = P.Prezzo,
                    Quantita = P.Quantita,
                    Img = P.Img,
                    Categorie = await Context.spGetCategorieProdotto.FromSqlRaw("EXECUTE spGetCategorieProdotto {0}", SqlPrm).ToListAsync()
                });
            }

            return Prodotti;
        }

        public async Task<long> InsertProdottoAsync(TPRODOTTO Prodotto)
        {
            SqlParameter[] SqlPrm = new[]
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    SqlDbType = System.Data.SqlDbType.BigInt,
                    Direction = System.Data.ParameterDirection.Output
                },
                new SqlParameter
                {
                    ParameterName = "Nome",
                    Value = Prodotto.Nome,
                    SqlDbType = System.Data.SqlDbType.NVarChar
                },
                new SqlParameter
                {
                    ParameterName = "Quantita",
                    Value = Prodotto.Quantita,
                    SqlDbType = System.Data.SqlDbType.Int
                },
                new SqlParameter
                {
                    ParameterName = "Prezzo",
                    Value = Prodotto.Prezzo,
                    SqlDbType = System.Data.SqlDbType.Float
                },
                new SqlParameter
                {
                    ParameterName = "Cod",
                    Value = Prodotto.Cod,
                    SqlDbType = System.Data.SqlDbType.Int
                },
                new SqlParameter
                {
                    ParameterName = "Img",
                    Value = Prodotto.Img,
                    SqlDbType = System.Data.SqlDbType.VarBinary
                },
                new SqlParameter
                {
                    ParameterName = "IdNegozio",
                    Value = Prodotto.IdNegozioNavigation,
                    SqlDbType = System.Data.SqlDbType.BigInt
                },
            };

            await Context.spInsertProduct.FromSqlRaw("EXECUTE spInsertProduct @Id, @Nome, @Quantita, @Prezzo, @Cod, @Img, @IdNegozio", SqlPrm).ToListAsync();

            return Prodotto.Id;
        }

        public async Task<long> DeleteProductAsync(long Id)
        {
            SqlParameter[] sqlPrm = new[]
            {
                new SqlParameter
                {
                    ParameterName = "Id",
                    SqlDbType = System.Data.SqlDbType.BigInt,
                    Direction = System.Data.ParameterDirection.Output
                }
            };

            await Context.spDeleteProduct.FromSqlRaw("EXECUTE spDeleteProduct @Id", sqlPrm).ToListAsync();

            return Id;
        }
    }
}
