using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Models.IdentityModels;

namespace Models.Tabelle
{
    [Table("ORDINE")]
    public class TORDINE
    {
        [Key,
         DatabaseGenerated(DatabaseGeneratedOption.Identity),
         Column(TypeName = "bigint")]
        public long Id { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Creato { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Aggiornato { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Spedito { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Consegnato { get; set; }

        [Column(TypeName = "nvarchar"),
         StringLength(100)]
        // Note inserite dall'utente. Es.: "Lasciare il pacco in giardino.".
        public string Note { get; set; }

        [Column(TypeName = "float")]
        public double Costo { get; set; }

        [Column(TypeName = "tinyint")]
        public short IdIndirizzo { get; set; }

        [Column(TypeName = "tinyint")]
        public short IdSpedizione { get; set; }

        [Column(TypeName = "tinyint")]
        public short IdCondizione { get; set; }

        [Column(TypeName = "bigint")]
        public long IdNegozio { get; set; }

        [Column(TypeName = "bigint")]
        public long IdUtente { get; set; }

        [InverseProperty("IdOrdineNavigation")]
        public virtual ICollection<TORDINE_PRODOTTO> ORDINE_Prodotto { get; set; }

        [ForeignKey("IdIndirizzo"),
         InverseProperty("Ordine")]
        public virtual TINDIRIZZO IdIndirizzoNavigation { get; set; }

        [ForeignKey("IdSpedizione"),
         InverseProperty("Ordine")]
        public virtual TSPEDIZIONE IdSpedizioneNavigation { get; set; }

        [ForeignKey("IdCondizione"),
         InverseProperty("Ordine")]
        public virtual TCONDIZIONE IdCondizioneNavigation { get; set; }

        [InverseProperty("IdOrdineNavigation")]
        public virtual ICollection<TFATTURA> Fattura { get; set; }

        //[ForeignKey("IdNegozio"),
        // InverseProperty("Ordine")]
        public virtual TNEGOZIO IdNegozioNavigation { get; set; }

        //[ForeignKey("IdUtente"),
        // InverseProperty("Ordine")]
        public virtual EcommerceAzureIdentityUser IdUtenteNavigation { get; set;}
    }
}
