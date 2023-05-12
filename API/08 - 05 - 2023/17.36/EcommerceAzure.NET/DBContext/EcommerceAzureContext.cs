using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.CustomIdentityUser;
using Models.Tabelle;
using Models.StoredProceduresResult;

namespace DBContext
{
    public class EcommerceAzureContext : IdentityDbContext<EcommerceAzureUser, EcommerceAzureRole, Int64>
    {
        private readonly string ConnString;

        public EcommerceAzureContext(string ConnString)
        {
            this.ConnString = ConnString;
        }

        public EcommerceAzureContext(DbContextOptions<EcommerceAzureContext> Options) : base(Options)
        {
        }

        // TABELLE DATABASE
        DbSet<TNEGOZIO> NEGOZIO { get; set; }
        DbSet<TPRODOTTO> PRODOTTO { get; set; }
        DbSet<TPRODOTTO_CATEGORIA> PRODOTTO_CATEGORIA { get; set; }
        DbSet<TCATEGORIA> CATEGORIA { get; set; }
        DbSet<TORDINE_PRODOTTO> ORDINE_PRODOTTO { get; set; }
        DbSet<TORDINE> ORDINE { get; set; }
        DbSet<TFATTURA> FATTURA { get; set; }
        DbSet<TSPEDIZIONE> SPEDIZIONE { get; set; }
        DbSet<TCONDIZIONE> CONDIZIONE { get; set; }
        DbSet<TUTENTE_NEGOZIO> UTENTE_NEGOZIO { get; set; }
        DbSet<TSTATO> STATO { get; set; }
        DbSet<TPROVINCIA> PROVINCIA { get; set; }
        DbSet<TCOMUNE> COMUNE { get; set; }
        DbSet<TINDIRIZZO> INDIRIZZO { get; set; }
        DbSet<TAZIENDA> AZIENDA { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);
            ModelBuilder.Entity<TUTENTE_NEGOZIO>()
                    .HasKey(K => new { K.IdUtente, K.IdNegozio });

            ModelBuilder.Entity<TPRODOTTO_CATEGORIA>()
                    .HasKey(K => new { K.IdProdotto, K.IdCategoria });

            ModelBuilder.Entity<TORDINE_PRODOTTO>()
                    .HasKey(K => new { K.IdOrdine, K.IdProdotto });

            ModelBuilder.Entity<TNEGOZIO>()
                    .HasOne(R => R.IdAziendaNavigation)
                    .WithMany()
                    .HasForeignKey(K => K.IdAzienda)
                    .OnDelete(DeleteBehavior.Restrict);

            ModelBuilder.Entity<TORDINE>()
                    .HasOne(R => R.IdNegozioNavigation)
                    .WithMany()
                    .HasForeignKey(K => K.IdNegozio)
                    .OnDelete(DeleteBehavior.Restrict);

            ModelBuilder.Entity<TORDINE>()
                .HasOne(R => R.IdUtenteNavigation)
                .WithMany()
                .HasForeignKey(K => K.IdUtente)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            if (!OptionsBuilder.IsConfigured)
            {
                OptionsBuilder.UseSqlServer(ConnString);
            }
        }
    }
}
