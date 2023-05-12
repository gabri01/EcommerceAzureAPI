using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Tabelle
{
    [Table("NEGOZIO")]
    public class TNEGOZIO
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "bigint")]
        public long Id { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string Nome { get; set; }

        [Column(TypeName = "char"),
         StringLength(11)]
        public string PIva { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[]? Logo { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(200)]
        public string? Descrizione { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(50)]
        public string ContainerName { get; set; }

        [Column(TypeName = "bigint")]
        public long ProgerssivoFattura { get; set; }

        [Column(TypeName = "bigint")]
        public long IdAzienda { get; set; }

        [InverseProperty("IdNegozioNavigation")]
        public virtual ICollection<TUTENTE_NEGOZIO> Utente_NEGOZIO { get; set; }

        [InverseProperty("IdNegozioNavigation")]
        public virtual ICollection<TPRODOTTO> Prodotto { get; set; }

        [InverseProperty("IdNegozioNavigation")]
        public virtual ICollection<TFATTURA> Fattura { get; set; }

        //[InverseProperty("IdNegozioNavigation")]
        //public virtual ICollection<TORDINE> Ordine { get; set; }

        //[ForeignKey("IdAzienda"),
        // InverseProperty("Negozio")]
        public virtual TAZIENDA IdAziendaNavigation { get; set; }
    }
}
