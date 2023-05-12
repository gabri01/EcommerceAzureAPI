using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Models.ControllerInput;
using Models.Remap;
using Models.StoredProceduresResult;
using Models.Tabelle;

namespace BusinessLogic
{
    public class BusinessClass : IBusiness 
    {
        IDAL Dal;

        public BusinessClass(IDAL Dal)
        {
            this.Dal = Dal;
        }

        public async Task<List<spGetOrdiniUtente>> GetOrdiniUtenteAsync(long IdUtente)
        {
            return await Dal.GetOrdiniUtenteAsync(IdUtente);
        }

        //public async Task<int> GetScalar()
        //{
        //    return await Dal.GetScalar();
        //}

        public bool VerificaFormatoEmail(string Email)
        {
            return new EmailAddressAttribute().IsValid(Email);
        }

        public bool VerificaFormatoPassword(string Password)
        {
            Regex NumeroCaratteri = new Regex(@".{8,}");
            Regex CarattereMaiuscolo = new Regex(@"[A-Z]+");
            Regex CarattereMinuscolo = new Regex(@"[a-z]+");
            Regex Numero = new Regex(@"[0-9]+");
            Regex Simbolo = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            return (NumeroCaratteri.IsMatch(Password) &&
                    CarattereMaiuscolo.IsMatch(Password) &&
                    CarattereMinuscolo.IsMatch(Password) &&
                    Numero.IsMatch(Password) &&
                    Simbolo.IsMatch(Password));
        }

        public async Task<spEsisteUtente> EsisteUtenteAsync(LoginUtente Utente)
        {
            return await Dal.EsisteUtenteAsync(Utente);
        }

        public string GenerateJWTToken(spEsisteUtente Utente)
        {
            string Key = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("JWTConfigurations")["Key"];
            var SymmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
            var Credentials = new SigningCredentials(SymmetricKey, SecurityAlgorithms.HmacSha256);

            Claim[] Claims = new[]
            {
                new Claim("Id", Utente.Id.ToString()),
                new Claim(ClaimTypes.Role, Utente.Ruolo)
            };

            var JwtToken = new JwtSecurityToken
            (
                issuer: new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("JWTConfigurations")["Issuer"],
                audience: new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("JWTConfigurations")["Audience"],
                claims: Claims,
                expires: DateTime.Now.AddMinutes(Int32.Parse(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("JWTConfigurations")["Duration"])),
                signingCredentials: Credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(JwtToken);
        }

        public async Task<List<Prodotto>> GetProdottiAsync(int From, int To)
        {
            return await Dal.GetProdottiAsync(From, To);
        }

        public async Task<long> InsertProdottoAsync(TPRODOTTO Prodotto)
        {
            return await Dal.InsertProdottoAsync(Prodotto);
        }

        public async Task<long> DeleteProductAsync(long Id)
        {
            return await Dal.DeleteProductAsync(Id);
        }

        public async Task<long> UpdateProductAsync(TPRODOTTO Prodotto)
        {
            return await Dal.UpdateProductAsync(Prodotto);
        }
    }
}
