using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tabelle
{
    [Table("FATTURA")]
    public class TFATTURA
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "bigint")]
        public long Id { get; set; }

        [Column(TypeName = "varbinary")]
        public byte[] Fattura { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Emissione { get; set; }

        [Column(TypeName = "char"),
         StringLength(1)]
        public string Inviata { get; set; }

        [Column(TypeName = "bigint")]
        public long IdOrdine { get; set; }

        //[Column(TypeName = "bigint")]
        //public long IdNegozio { get; set; }

        [ForeignKey("IdOrdine"),
         InverseProperty("Fattura")]
        public virtual TORDINE IdOrdineNavigation { get; set; }

        [ForeignKey("IdNegozio"),
         InverseProperty("Fattura")]
        public virtual TNEGOZIO IdNegozioNavigation { get; set; }
    }
}