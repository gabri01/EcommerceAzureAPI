using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tabelle
{
    [Table("SPEDIZIONE")]
    public class TSPEDIZIONE
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "tinyint")]
        public short Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Tipologia { get; set; }

        [Column(TypeName = "float")]
        public double Costo { get; set; }

        [InverseProperty("IdSpedizioneNavigation")]
        public virtual ICollection<TORDINE> Ordine { get; set; }
    }
}
