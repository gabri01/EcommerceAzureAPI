using Models.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Tabelle
{
    [Table("UTENTE_NEGOZIO")]
    public class TUTENTE_NEGOZIO
    {
        [Key,
         Column(TypeName = "bigint")]
        public long IdUtente { get; set; }

        [Key,
         Column(TypeName = "bigint")]
        public long IdNegozio { get; set; }

        [ForeignKey("IdUtente"),
         InverseProperty("UTENTE_Negozio")]
        public virtual EcommerceAzureIdentityUser IdUtenteNavigation { get; set; }

        [ForeignKey("IdNegozio"),
         InverseProperty("Utente_NEGOZIO")]
        public virtual TNEGOZIO IdNegozioNavigation { get; set; }
    }
}
