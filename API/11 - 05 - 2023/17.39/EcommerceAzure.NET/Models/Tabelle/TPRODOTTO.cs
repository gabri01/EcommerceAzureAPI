using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tabelle
{
    [Table("PRODOTTO")]
    public class TPRODOTTO
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "bigint")]
        public long Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [Column(TypeName = "int")]
        public int Quantita { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Prezzo { get; set; }

        [Column(TypeName = "int")]
        public int Cod { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[]? Img { get; set; }

        [Column(TypeName = "bigint")]
        public long IdNegozio { get; set; }

        [ForeignKey("IdNegozio"),
         InverseProperty("Prodotto")]
        public virtual TNEGOZIO IdNegozioNavigation { get; set; }

        [InverseProperty("IdProdottoNavigation")]
        public virtual ICollection<TPRODOTTO_CATEGORIA> PRODOTTO_Categoria { get; set; }

        //[InverseProperty("IdProdottoNavigation")]
        //public virtual ICollection<TORDINE_PRODOTTO> Ordine_PRODOTTO { get; set; }

        [InverseProperty("IdProdottoNavigation")]
        public virtual ICollection<TORDINE_PRODOTTO> Ordine_PRODOTTO { get; set; }
    }
}
