﻿// <auto-generated />
using System;
using DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBContext.Migrations
{
    [DbContext(typeof(EcommerceAzureContext))]
    [Migration("20230505162616_Migrazione6")]
    partial class Migrazione6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Models.CustomIdentityUser.EcommerceAzureRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Models.CustomIdentityUser.EcommerceAzureUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CodFis")
                        .HasMaxLength(16)
                        .HasColumnType("char(16)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PIva")
                        .HasMaxLength(11)
                        .HasColumnType("char(11)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Models.Tabelle.TAZIENDA", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Descrizione")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("IdUtente")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PIva")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)");

                    b.Property<int>("ProgerssivoFattura")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUtente");

                    b.ToTable("AZIENDA");
                });

            modelBuilder.Entity("Models.Tabelle.TCATEGORIA", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"), 1L, 1);

                    b.Property<byte[]>("Icona")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("CATEGORIA");
                });

            modelBuilder.Entity("Models.Tabelle.TCOMUNE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdProvincia");

                    b.ToTable("COMUNE");
                });

            modelBuilder.Entity("Models.Tabelle.TCONDIZIONE", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"), 1L, 1);

                    b.Property<string>("Condizione")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("CONDIZIONE");
                });

            modelBuilder.Entity("Models.Tabelle.TFATTURA", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("Emissione")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("Fattura")
                        .IsRequired()
                        .HasColumnType("varbinary");

                    b.Property<long>("IdNegozio")
                        .HasColumnType("bigint");

                    b.Property<long>("IdOrdine")
                        .HasColumnType("bigint");

                    b.Property<string>("Inviata")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.HasIndex("IdNegozio");

                    b.HasIndex("IdOrdine");

                    b.ToTable("FATTURA");
                });

            modelBuilder.Entity("Models.Tabelle.TINDIRIZZO", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"), 1L, 1);

                    b.Property<int>("IdComune")
                        .HasColumnType("int");

                    b.Property<long>("IdUtente")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdComune");

                    b.HasIndex("IdUtente");

                    b.ToTable("INDIRIZZO");
                });

            modelBuilder.Entity("Models.Tabelle.TNEGOZIO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("ContainerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Descrizione")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("IdAzienda")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PIva")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("char(11)");

                    b.Property<int>("ProgerssivoFattura")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAzienda");

                    b.ToTable("NEGOZIO");
                });

            modelBuilder.Entity("Models.Tabelle.TORDINE", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("Aggiornato")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Consegnato")
                        .HasColumnType("datetime");

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<DateTime>("Creato")
                        .HasColumnType("datetime");

                    b.Property<byte>("IdCondizione")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IdIndirizzo")
                        .HasColumnType("tinyint");

                    b.Property<long>("IdNegozio")
                        .HasColumnType("bigint");

                    b.Property<byte>("IdSpedizione")
                        .HasColumnType("tinyint");

                    b.Property<long>("IdUtente")
                        .HasColumnType("bigint");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("Spedito")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("IdCondizione");

                    b.HasIndex("IdIndirizzo");

                    b.HasIndex("IdNegozio");

                    b.HasIndex("IdSpedizione");

                    b.HasIndex("IdUtente");

                    b.ToTable("ORDINE");
                });

            modelBuilder.Entity("Models.Tabelle.TORDINE_PRODOTTO", b =>
                {
                    b.Property<long>("IdOrdine")
                        .HasColumnType("bigint");

                    b.Property<long>("IdProdotto")
                        .HasColumnType("bigint");

                    b.Property<bool>("RichiestaFattura")
                        .HasColumnType("bit");

                    b.HasKey("IdOrdine", "IdProdotto");

                    b.HasIndex("IdProdotto");

                    b.ToTable("ORDINE_PRODOTTO");
                });

            modelBuilder.Entity("Models.Tabelle.TPRODOTTO", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("Cod")
                        .HasColumnType("int");

                    b.Property<long>("IdNegozio")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Prezzo")
                        .HasColumnType("float");

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdNegozio");

                    b.ToTable("PRODOTTO");
                });

            modelBuilder.Entity("Models.Tabelle.TPRODOTTO_CATEGORIA", b =>
                {
                    b.Property<long>("IdProdotto")
                        .HasColumnType("bigint");

                    b.Property<byte>("IdCategoria")
                        .HasColumnType("tinyint");

                    b.HasKey("IdProdotto", "IdCategoria");

                    b.HasIndex("IdCategoria");

                    b.ToTable("PRODOTTO_CATEGORIA");
                });

            modelBuilder.Entity("Models.Tabelle.TPROVINCIA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdStato")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdStato");

                    b.ToTable("PROVINCIA");
                });

            modelBuilder.Entity("Models.Tabelle.TSPEDIZIONE", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"), 1L, 1);

                    b.Property<double>("Costo")
                        .HasColumnType("float");

                    b.Property<string>("Tipologia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SPEDIZIONE");
                });

            modelBuilder.Entity("Models.Tabelle.TSTATO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("STATO");
                });

            modelBuilder.Entity("Models.Tabelle.TUTENTE_NEGOZIO", b =>
                {
                    b.Property<long>("IdUtente")
                        .HasColumnType("bigint");

                    b.Property<long>("IdNegozio")
                        .HasColumnType("bigint");

                    b.HasKey("IdUtente", "IdNegozio");

                    b.HasIndex("IdNegozio");

                    b.ToTable("UTENTE_NEGOZIO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Tabelle.TAZIENDA", b =>
                {
                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", "IdUtenteNavigation")
                        .WithMany("Azienda")
                        .HasForeignKey("IdUtente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUtenteNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TCOMUNE", b =>
                {
                    b.HasOne("Models.Tabelle.TPROVINCIA", "IdProvinciaNavigation")
                        .WithMany("Comune")
                        .HasForeignKey("IdProvincia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdProvinciaNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TFATTURA", b =>
                {
                    b.HasOne("Models.Tabelle.TNEGOZIO", "IdNegozioNavigation")
                        .WithMany("Fattura")
                        .HasForeignKey("IdNegozio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tabelle.TORDINE", "IdOrdineNavigation")
                        .WithMany("Fattura")
                        .HasForeignKey("IdOrdine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdNegozioNavigation");

                    b.Navigation("IdOrdineNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TINDIRIZZO", b =>
                {
                    b.HasOne("Models.Tabelle.TCOMUNE", "IdComuneNavigation")
                        .WithMany("Indirizzo")
                        .HasForeignKey("IdComune")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", "IdUtenteNavigation")
                        .WithMany("Indirizzo")
                        .HasForeignKey("IdUtente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdComuneNavigation");

                    b.Navigation("IdUtenteNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TNEGOZIO", b =>
                {
                    b.HasOne("Models.Tabelle.TAZIENDA", "IdAziendaNavigation")
                        .WithMany()
                        .HasForeignKey("IdAzienda")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdAziendaNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TORDINE", b =>
                {
                    b.HasOne("Models.Tabelle.TCONDIZIONE", "IdCondizioneNavigation")
                        .WithMany("Ordine")
                        .HasForeignKey("IdCondizione")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tabelle.TINDIRIZZO", "IdIndirizzoNavigation")
                        .WithMany("Ordine")
                        .HasForeignKey("IdIndirizzo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tabelle.TNEGOZIO", "IdNegozioNavigation")
                        .WithMany()
                        .HasForeignKey("IdNegozio")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Tabelle.TSPEDIZIONE", "IdSpedizioneNavigation")
                        .WithMany("Ordine")
                        .HasForeignKey("IdSpedizione")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", "IdUtenteNavigation")
                        .WithMany()
                        .HasForeignKey("IdUtente")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdCondizioneNavigation");

                    b.Navigation("IdIndirizzoNavigation");

                    b.Navigation("IdNegozioNavigation");

                    b.Navigation("IdSpedizioneNavigation");

                    b.Navigation("IdUtenteNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TORDINE_PRODOTTO", b =>
                {
                    b.HasOne("Models.Tabelle.TORDINE", "IdOrdineNavigation")
                        .WithMany("ORDINE_Prodotto")
                        .HasForeignKey("IdOrdine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tabelle.TPRODOTTO", "IdProdottoNavigation")
                        .WithMany("Ordine_PRODOTTO")
                        .HasForeignKey("IdProdotto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdOrdineNavigation");

                    b.Navigation("IdProdottoNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TPRODOTTO", b =>
                {
                    b.HasOne("Models.Tabelle.TNEGOZIO", "IdNegozioNavigation")
                        .WithMany("Prodotto")
                        .HasForeignKey("IdNegozio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdNegozioNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TPRODOTTO_CATEGORIA", b =>
                {
                    b.HasOne("Models.Tabelle.TCATEGORIA", "IdCategoriaNavigation")
                        .WithMany("Prodotto_CATEGORIA")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Tabelle.TPRODOTTO", "IdProdottoNavigation")
                        .WithMany("PRODOTTO_Categoria")
                        .HasForeignKey("IdProdotto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdProdottoNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TPROVINCIA", b =>
                {
                    b.HasOne("Models.Tabelle.TSTATO", "IdStatoNavigation")
                        .WithMany("Provincia")
                        .HasForeignKey("IdStato")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdStatoNavigation");
                });

            modelBuilder.Entity("Models.Tabelle.TUTENTE_NEGOZIO", b =>
                {
                    b.HasOne("Models.Tabelle.TNEGOZIO", "IdNegozioNavigation")
                        .WithMany("Utente_NEGOZIO")
                        .HasForeignKey("IdNegozio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.CustomIdentityUser.EcommerceAzureUser", "IdUtenteNavigation")
                        .WithMany("UTENTE_Negozio")
                        .HasForeignKey("IdUtente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdNegozioNavigation");

                    b.Navigation("IdUtenteNavigation");
                });

            modelBuilder.Entity("Models.CustomIdentityUser.EcommerceAzureUser", b =>
                {
                    b.Navigation("Azienda");

                    b.Navigation("Indirizzo");

                    b.Navigation("UTENTE_Negozio");
                });

            modelBuilder.Entity("Models.Tabelle.TCATEGORIA", b =>
                {
                    b.Navigation("Prodotto_CATEGORIA");
                });

            modelBuilder.Entity("Models.Tabelle.TCOMUNE", b =>
                {
                    b.Navigation("Indirizzo");
                });

            modelBuilder.Entity("Models.Tabelle.TCONDIZIONE", b =>
                {
                    b.Navigation("Ordine");
                });

            modelBuilder.Entity("Models.Tabelle.TINDIRIZZO", b =>
                {
                    b.Navigation("Ordine");
                });

            modelBuilder.Entity("Models.Tabelle.TNEGOZIO", b =>
                {
                    b.Navigation("Fattura");

                    b.Navigation("Prodotto");

                    b.Navigation("Utente_NEGOZIO");
                });

            modelBuilder.Entity("Models.Tabelle.TORDINE", b =>
                {
                    b.Navigation("Fattura");

                    b.Navigation("ORDINE_Prodotto");
                });

            modelBuilder.Entity("Models.Tabelle.TPRODOTTO", b =>
                {
                    b.Navigation("Ordine_PRODOTTO");

                    b.Navigation("PRODOTTO_Categoria");
                });

            modelBuilder.Entity("Models.Tabelle.TPROVINCIA", b =>
                {
                    b.Navigation("Comune");
                });

            modelBuilder.Entity("Models.Tabelle.TSPEDIZIONE", b =>
                {
                    b.Navigation("Ordine");
                });

            modelBuilder.Entity("Models.Tabelle.TSTATO", b =>
                {
                    b.Navigation("Provincia");
                });
#pragma warning restore 612, 618
        }
    }
}
