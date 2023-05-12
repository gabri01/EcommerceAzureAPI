using Models.IdentityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Tabelle
{
    [Table("AZIENDA")]
    public class TAZIENDA
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

        [Column(TypeName = "bigint")]
        public long ProgerssivoFattura { get; set; }

        [Column(TypeName = "bigint")]
        public long IdUtente { get; set; }

        [ForeignKey("IdUtente"),
         InverseProperty("Azienda")]
        public virtual EcommerceAzureIdentityUser IdUtenteNavigation { get; set; }

        //[InverseProperty("IdAziendaNavigation")]
        //public virtual ICollection<TNEGOZIO> Negozio { get; set; }
    }
}
