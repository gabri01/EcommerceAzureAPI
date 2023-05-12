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
    [Table("COMUNE")]
    public class TCOMUNE
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [Column(TypeName = "int")]
        public int IdProvincia { get; set; }

        [ForeignKey("IdProvincia"),
         InverseProperty("Comune")]
        public virtual TPROVINCIA IdProvinciaNavigation { get; set; }

        [InverseProperty("IdComuneNavigation")]
        public virtual  ICollection<TINDIRIZZO> Indirizzo { get; set; }
    }
}
