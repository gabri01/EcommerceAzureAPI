using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.CustomIdentityUser;

namespace Models.Tabelle
{
    [Table("INDIRIZZO")]
    public class TINDIRIZZO
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "tinyint")]
        public short Id { get; set; }

        public string Nome { get; set; }

        [Column(TypeName = "bigint")]
        public long IdUtente { get; set; }

        [Column(TypeName = "int")]
        public int IdComune { get; set; }

        [ForeignKey("IdComune"),
         InverseProperty("Indirizzo")]
        public virtual TCOMUNE IdComuneNavigation { get; set; }

        [ForeignKey("IdUtente"),
         InverseProperty("Indirizzo")]
        public virtual EcommerceAzureUser IdUtenteNavigation { get; set; }

        [InverseProperty("IdIndirizzoNavigation")]
        public virtual ICollection<TORDINE> Ordine { get; set; }
    }
}
