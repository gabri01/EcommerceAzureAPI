using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Models.Tabelle
{
    [Table("PRODOTTO_CATEGORIA")]
    public class TPRODOTTO_CATEGORIA
    {
        [Key,
         Column(TypeName = "bigint")]
        public long IdProdotto { get; set; }

        [Key,
         Column(TypeName = "tinyint")]
        public short IdCategoria { get; set; }


        [ForeignKey("IdProdotto"),
         InverseProperty("PRODOTTO_Categoria")]
        public virtual TPRODOTTO IdProdottoNavigation { get; set; }

        [ForeignKey("IdCategoria"),
         InverseProperty("Prodotto_CATEGORIA")]
        public virtual TCATEGORIA IdCategoriaNavigation { get; set; }
    }
}
