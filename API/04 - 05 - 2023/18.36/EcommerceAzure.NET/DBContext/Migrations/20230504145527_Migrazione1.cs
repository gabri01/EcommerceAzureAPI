using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class Migrazione1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodFis = table.Column<string>(type: "char(16)", maxLength: 16, nullable: true),
                    PIva = table.Column<string>(type: "char(11)", maxLength: 11, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CONDIZIONE",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Condizione = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONDIZIONE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NEGOZIO",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIva = table.Column<string>(type: "char(11)", maxLength: 11, nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContainerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProgerssivoFattura = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NEGOZIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SPEDIZIONE",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipologia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SPEDIZIONE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "STATO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODOTTO",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantita = table.Column<int>(type: "int", nullable: false),
                    Prezzo = table.Column<double>(type: "float", nullable: false),
                    Cod = table.Column<int>(type: "int", nullable: false),
                    Img = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IdNegozio = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODOTTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODOTTO_NEGOZIO_IdNegozio",
                        column: x => x.IdNegozio,
                        principalTable: "NEGOZIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UTENTE_NEGOZIO",
                columns: table => new
                {
                    IdUtente = table.Column<long>(type: "bigint", nullable: false),
                    IdNegozio = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UTENTE_NEGOZIO", x => new { x.IdUtente, x.IdNegozio });
                    table.ForeignKey(
                        name: "FK_UTENTE_NEGOZIO_AspNetUsers_IdUtente",
                        column: x => x.IdUtente,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UTENTE_NEGOZIO_NEGOZIO_IdNegozio",
                        column: x => x.IdNegozio,
                        principalTable: "NEGOZIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PROVINCIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdStato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROVINCIA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROVINCIA_STATO_IdStato",
                        column: x => x.IdStato,
                        principalTable: "STATO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODOTTO_CATEGORIA",
                columns: table => new
                {
                    IdProdotto = table.Column<long>(type: "bigint", nullable: false),
                    IdCategoria = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODOTTO_CATEGORIA", x => new { x.IdProdotto, x.IdCategoria });
                    table.ForeignKey(
                        name: "FK_PRODOTTO_CATEGORIA_CATEGORIA_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "CATEGORIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODOTTO_CATEGORIA_PRODOTTO_IdProdotto",
                        column: x => x.IdProdotto,
                        principalTable: "PRODOTTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "COMUNE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdProvincia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMUNE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMUNE_PROVINCIA_IdProvincia",
                        column: x => x.IdProvincia,
                        principalTable: "PROVINCIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "INDIRIZZO",
                columns: table => new
                {
                    Id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUtente = table.Column<long>(type: "bigint", nullable: false),
                    IdComune = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INDIRIZZO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INDIRIZZO_AspNetUsers_IdUtente",
                        column: x => x.IdUtente,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INDIRIZZO_COMUNE_IdComune",
                        column: x => x.IdComune,
                        principalTable: "COMUNE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDINE",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Creato = table.Column<DateTime>(type: "datetime", nullable: false),
                    Aggiornato = table.Column<DateTime>(type: "datetime", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Costo = table.Column<double>(type: "float", nullable: false),
                    IdIndirizzo = table.Column<byte>(type: "tinyint", nullable: false),
                    IdSpedizione = table.Column<byte>(type: "tinyint", nullable: false),
                    IdCondizione = table.Column<byte>(type: "tinyint", nullable: false),
                    IdNegozio = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDINE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORDINE_CONDIZIONE_IdCondizione",
                        column: x => x.IdCondizione,
                        principalTable: "CONDIZIONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDINE_INDIRIZZO_IdIndirizzo",
                        column: x => x.IdIndirizzo,
                        principalTable: "INDIRIZZO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDINE_SPEDIZIONE_IdSpedizione",
                        column: x => x.IdSpedizione,
                        principalTable: "SPEDIZIONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FATTURA",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fattura = table.Column<byte[]>(type: "varbinary", nullable: false),
                    Emissione = table.Column<DateTime>(type: "datetime", nullable: false),
                    Inviata = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false),
                    IdOrdine = table.Column<long>(type: "bigint", nullable: false),
                    IdNegozio = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FATTURA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FATTURA_NEGOZIO_IdNegozio",
                        column: x => x.IdNegozio,
                        principalTable: "NEGOZIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FATTURA_ORDINE_IdOrdine",
                        column: x => x.IdOrdine,
                        principalTable: "ORDINE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORDINE_PRODOTTO",
                columns: table => new
                {
                    IdOrdine = table.Column<long>(type: "bigint", nullable: false),
                    IdProdotto = table.Column<long>(type: "bigint", nullable: false),
                    RichiestaFattura = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDINE_PRODOTTO", x => new { x.IdOrdine, x.IdProdotto });
                    table.ForeignKey(
                        name: "FK_ORDINE_PRODOTTO_ORDINE_IdOrdine",
                        column: x => x.IdOrdine,
                        principalTable: "ORDINE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORDINE_PRODOTTO_PRODOTTO_IdProdotto",
                        column: x => x.IdProdotto,
                        principalTable: "PRODOTTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_COMUNE_IdProvincia",
                table: "COMUNE",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_FATTURA_IdNegozio",
                table: "FATTURA",
                column: "IdNegozio");

            migrationBuilder.CreateIndex(
                name: "IX_FATTURA_IdOrdine",
                table: "FATTURA",
                column: "IdOrdine");

            migrationBuilder.CreateIndex(
                name: "IX_INDIRIZZO_IdComune",
                table: "INDIRIZZO",
                column: "IdComune");

            migrationBuilder.CreateIndex(
                name: "IX_INDIRIZZO_IdUtente",
                table: "INDIRIZZO",
                column: "IdUtente");

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_IdCondizione",
                table: "ORDINE",
                column: "IdCondizione");

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_IdIndirizzo",
                table: "ORDINE",
                column: "IdIndirizzo");

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_IdSpedizione",
                table: "ORDINE",
                column: "IdSpedizione");

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_PRODOTTO_IdProdotto",
                table: "ORDINE_PRODOTTO",
                column: "IdProdotto");

            migrationBuilder.CreateIndex(
                name: "IX_PRODOTTO_IdNegozio",
                table: "PRODOTTO",
                column: "IdNegozio");

            migrationBuilder.CreateIndex(
                name: "IX_PRODOTTO_CATEGORIA_IdCategoria",
                table: "PRODOTTO_CATEGORIA",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_PROVINCIA_IdStato",
                table: "PROVINCIA",
                column: "IdStato");

            migrationBuilder.CreateIndex(
                name: "IX_UTENTE_NEGOZIO_IdNegozio",
                table: "UTENTE_NEGOZIO",
                column: "IdNegozio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FATTURA");

            migrationBuilder.DropTable(
                name: "ORDINE_PRODOTTO");

            migrationBuilder.DropTable(
                name: "PRODOTTO_CATEGORIA");

            migrationBuilder.DropTable(
                name: "UTENTE_NEGOZIO");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ORDINE");

            migrationBuilder.DropTable(
                name: "CATEGORIA");

            migrationBuilder.DropTable(
                name: "PRODOTTO");

            migrationBuilder.DropTable(
                name: "CONDIZIONE");

            migrationBuilder.DropTable(
                name: "INDIRIZZO");

            migrationBuilder.DropTable(
                name: "SPEDIZIONE");

            migrationBuilder.DropTable(
                name: "NEGOZIO");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "COMUNE");

            migrationBuilder.DropTable(
                name: "PROVINCIA");

            migrationBuilder.DropTable(
                name: "STATO");
        }
    }
}
