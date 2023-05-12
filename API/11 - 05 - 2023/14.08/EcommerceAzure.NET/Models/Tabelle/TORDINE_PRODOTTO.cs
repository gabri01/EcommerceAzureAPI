using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Tabelle
{
    [Table("ORDINE_PRODOTTO")]
    public class TORDINE_PRODOTTO
    {
        [Key,
         Column(TypeName = "bigint")]
        public long IdOrdine { get; set; }

        [Key,
         Column(TypeName = "bigint")]
        public long IdProdotto { get; set; }

        [Column(TypeName = "int")]
        public int Quantita;

        [Column(TypeName = "float")]
        public double PrezzoUnitario;

        [Column(TypeName = "bit")]
        public bool RichiestaFattura { get; set; }

        [ForeignKey("IdProdotto"),
         InverseProperty("Ordine_PRODOTTO")]
        public virtual TPRODOTTO IdProdottoNavigation { get; set; }

        [ForeignKey("IdOrdine"),
         InverseProperty("ORDINE_Prodotto")]
        public virtual TORDINE IdOrdineNavigation { get; set; }
    }
}
