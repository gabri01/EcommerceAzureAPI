using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Models.Tabelle;

namespace Models.IdentityModels
{
    public class EcommerceAzureIdentityUser : IdentityUser<Int64>
    {
        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Cognome { get; set; }

        [Column(TypeName = "char"),
         StringLength(16)]
        public string? CodFis { get; set; }

        [Column(TypeName = "char"),
         StringLength(11)]
        public string? PIva { get; set; }

        [InverseProperty("IdUtenteNavigation")]
        public virtual ICollection<TUTENTE_NEGOZIO> UTENTE_Negozio { get; set; }

        [InverseProperty("IdUtenteNavigation")]
        public virtual ICollection<TINDIRIZZO> Indirizzo { get; set; }

        [InverseProperty("IdUtenteNavigation")]
        public virtual ICollection<TAZIENDA> Azienda { get; set; }

        //[InverseProperty("Utente")]
        //public virtual ICollection<TORDINE> Ordine { get; set; }
    }

    public class EcommerceAzureRole : IdentityRole<Int64>
    {
    }
}
