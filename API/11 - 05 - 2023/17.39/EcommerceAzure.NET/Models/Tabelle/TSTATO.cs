using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Models.Tabelle
{
    [Table("STATO")]
    public class TSTATO
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [InverseProperty("IdStatoNavigation")]
        public virtual ICollection<TPROVINCIA> Provincia { get; set; }
    }
}
