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
    [Table("PROVINCIA")]
    public class TPROVINCIA
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [Column(TypeName = "int")]
        public int IdStato { get; set; }

        [ForeignKey("IdStato"),
         InverseProperty("Provincia")]
        public virtual TSTATO IdStatoNavigation { get; set; }

        [InverseProperty("IdProvinciaNavigation")]
        public virtual ICollection<TCOMUNE> Comune { get; set; }
    }
}
