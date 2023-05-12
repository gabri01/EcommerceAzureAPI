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
    [Table("CATEGORIA")]
    public class TCATEGORIA
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "tinyint")]
        public short Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[]? Icona { get; set; }

        [InverseProperty("IdCategoriaNavigation")]
        public ICollection<TPRODOTTO_CATEGORIA> Prodotto_CATEGORIA { get; set; }
    }
}
