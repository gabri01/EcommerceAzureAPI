using Models.CustomIdentityUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tabelle
{
    // Un negozio può avere più propietari.
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
        public virtual EcommerceAzureUser IdUtenteNavigation { get; set; }

        [ForeignKey("IdNegozio"),
         InverseProperty("Utente_NEGOZIO")]
        public virtual TNEGOZIO IdNegozioNavigation { get; set; }
    }
}
