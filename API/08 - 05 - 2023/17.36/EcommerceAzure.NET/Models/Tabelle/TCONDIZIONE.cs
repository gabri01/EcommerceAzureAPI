using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tabelle
{
    [Table("CONDIZIONE")]
    public class TCONDIZIONE
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "tinyint")]
        public short Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(30)]
        public string Condizione { get; set; }

        [InverseProperty("IdCondizioneNavigation")]
        public virtual ICollection<TORDINE> Ordine { get; set; }
    }
}
