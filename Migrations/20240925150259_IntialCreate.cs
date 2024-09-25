using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dvdApp.Migrations
{
    /// <inheritdoc />
    public partial class IntialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dvds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TitreOriginal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TitreFrancais = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnneeSortie = table.Column<int>(type: "int", nullable: true),
                    CategorieId = table.Column<int>(type: "int", nullable: false),
                    DerniereMiseAJour = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MiseAJourEffectueePar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Supplements = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duree = table.Column<int>(type: "int", nullable: true),
                    EstOriginal = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Format = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagePochette = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Langue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreDisques = table.Column<int>(type: "int", nullable: true),
                    Producteur = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Realisateur = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ActeursPrincipaux = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resume = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SousTitres = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Proprietaire = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Emprunteur = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstVersionEtendue = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EstVisible = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dvds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dvds_Categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adolescent" },
                    { 3, "Biographie" },
                    { 4, "Cape et d'épée" },
                    { 5, "Catastrophe" },
                    { 6, "Chronique" },
                    { 7, "Comédie de moeurs" },
                    { 8, "Comédie d'horreur" },
                    { 9, "Comédie dramatique" },
                    { 10, "Comédie fantaisiste" },
                    { 11, "Comédie musicale" },
                    { 12, "Comédie policière" },
                    { 13, "Comédie satirique" },
                    { 14, "Comédie sentimentale" },
                    { 15, "Comédie" },
                    { 16, "Criminel" },
                    { 17, "Danse" },
                    { 18, "Dessins animés" },
                    { 19, "Documentaire" },
                    { 20, "Drame de guerre" },
                    { 21, "Drame de moeurs" },
                    { 22, "Drame d'horreur" },
                    { 23, "Drame judiciaire" },
                    { 24, "Drame musical" },
                    { 25, "Drame poétique" },
                    { 26, "Drame policier" },
                    { 27, "Drame psychologique" },
                    { 28, "Drame sentimental" },
                    { 29, "Drame social" },
                    { 30, "Drame" },
                    { 31, "Espionnage" },
                    { 32, "Expérimental" },
                    { 33, "Fantastique" },
                    { 34, "Film à sketches" },
                    { 35, "Film d'animation" },
                    { 36, "Film d'art martial" },
                    { 37, "Historique" },
                    { 38, "Horreur" },
                    { 39, "Humoristique" },
                    { 40, "Marionnettes" },
                    { 41, "Mélodrame" },
                    { 42, "Musical" },
                    { 43, "Road movie" },
                    { 44, "Romantique" },
                    { 45, "Science-fiction" },
                    { 46, "Série policière" },
                    { 47, "Série TV" },
                    { 48, "Spectacle d'humour" },
                    { 49, "Spectacle musical" },
                    { 50, "Suspense" },
                    { 51, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Dvds",
                columns: new[] { "Id", "ActeursPrincipaux", "AnneeSortie", "CategorieId", "DerniereMiseAJour", "Duree", "Emprunteur", "EstOriginal", "EstVersionEtendue", "EstVisible", "Format", "ImagePochette", "Langue", "MiseAJourEffectueePar", "NombreDisques", "Producteur", "Proprietaire", "Realisateur", "Resume", "SousTitres", "Supplements", "TitreFrancais", "TitreOriginal" },
                values: new object[,]
                {
                    { 1, "Keanu Reeves, Laurence Fishburne", 1999, 4, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9160), 136, "Driss", true, false, true, "Blu-ray", "/img/icon1.jpg", "Anglais", "Cassim", 1, "Joel Silver", "Cassim", "Lana Wachowski, Lilly Wachowski", "Un pirate informatique découvre une réalité alternative.", "Français, English", null, "La Matrice", "The Matrix" },
                    { 2, "Marlon Brando, Al Pacino", 1972, 3, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9170), 175, "Driss", true, false, true, "DVD", "/img/icon2.jpg", "Anglais", "Cassim", 2, "Albert S. Ruddy", "Cassim", "Francis Ford Coppola", "L'histoire de la famille Corleone.", "Français, English", null, "Le Parrain", "The Godfather" },
                    { 3, "Leonardo DiCaprio, Joseph Gordon-Levitt", 2010, 4, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9180), 148, "Driss", true, false, true, "Blu-ray", "/img/icon3.jpg", "Anglais", "Cassim", 1, "Emma Thomas", "Cassim", "Christopher Nolan", "Un voleur s'infiltre dans les rêves.", "Français, English", null, "Inception", "Inception" },
                    { 4, "John Travolta, Samuel L. Jackson", 1994, 2, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9190), 154, "Driss", true, false, true, "DVD", "/img/icon1.jpg", "Anglais", "Cassim", 1, "Lawrence Bender", "Cassim", "Quentin Tarantino", "Des histoires entrecroisées dans le monde du crime.", "Français, English", null, "Pulp Fiction", "Pulp Fiction" },
                    { 5, "Leonardo DiCaprio, Kate Winslet", 1997, 7, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9200), 195, "Driss", true, false, true, "DVD", "/img/icon2.jpg", "Anglais", "Cassim", 2, "James Cameron", "Cassim", "James Cameron", "Une romance tragique à bord du Titanic.", "Français, English", null, "Titanic", "Titanic" },
                    { 6, "Mark Hamill, Harrison Ford", 1977, 9, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9210), 121, "Cassim", true, false, true, "Blu-ray", "/img/icon3.jpg", "Anglais", "Cassim", 1, "Gary Kurtz", "Rachid", "George Lucas", "L'épopée galactique commence avec Luke Skywalker.", "Français, English", null, "Star Wars : Un nouvel espoir", "Star Wars: A New Hope" },
                    { 7, "Liam Neeson, Ben Kingsley", 1993, 8, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9220), 195, "Cassim", true, false, true, "DVD", "/img/icon1.jpg", "Anglais", "Cassim", 2, "Steven Spielberg", "Rachid", "Steven Spielberg", "L'histoire vraie d'un industriel qui sauva des centaines de Juifs pendant la Seconde Guerre mondiale.", "Français, English", null, "La Liste de Schindler", "Schindler's List" },
                    { 8, "Christian Bale, Heath Ledger", 2008, 1, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9230), 152, "Cassim", true, false, true, "Blu-ray", "/img/icon2.jpg", "Anglais", "Cassim", 1, "Christopher Nolan", "Rachid", "Christopher Nolan", "Batman affronte le Joker dans un combat épique pour Gotham City.", "Français, English", null, "Le Chevalier Noir", "The Dark Knight" },
                    { 9, "Russell Crowe, Joaquin Phoenix", 2000, 1, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9240), 155, "Cassim", true, false, true, "Blu-ray", "/img/icon3.jpg", "Anglais", "Cassim", 1, "Douglas Wick", "Rachid", "Ridley Scott", "Un général romain trahi revient comme gladiateur pour se venger.", "Français, English", null, "Gladiator", "Gladiator" },
                    { 10, "Sigourney Weaver, Tom Skerritt", 1979, 5, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9250), 117, "Cassim", true, false, true, "DVD", "/img/icon1.jpg", "Anglais", "Cassim", 1, "Walter Hill", "Rachid", "Ridley Scott", "Un équipage spatial affronte une créature extraterrestre mortelle.", "Français, English", null, "Alien", "Alien" },
                    { 11, "Tom Hanks, Robin Wright", 1994, 3, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9260), 142, "Cassim", true, false, true, "DVD", "/img/icon2.jpg", "Anglais", "Cassim", 1, "Wendy Finerman", "Rachid", "Robert Zemeckis", "La vie extraordinaire de Forrest Gump, un homme avec un faible QI.", "Français, English", null, "Forrest Gump", "Forrest Gump" },
                    { 12, "Jodie Foster, Anthony Hopkins", 1991, 5, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9270), 118, "Rachid", true, false, true, "DVD", "/img/icon3.jpg", "Anglais", "Cassim", 1, "Kenneth Utt", "Driss", "Jonathan Demme", "Une jeune agent du FBI cherche l'aide d'un tueur en série emprisonné.", "Français, English", null, "Le Silence des agneaux", "The Silence of the Lambs" },
                    { 13, "Tim Robbins, Morgan Freeman", 1994, 3, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9280), 142, "Rachid", true, false, true, "Blu-ray", "/img/icon1.jpg", "Anglais", "Cassim", 1, "Niki Marvin", "Driss", "Frank Darabont", "L'histoire d'un homme emprisonné qui se lie d'amitié avec un autre détenu.", "Français, English", null, "Les Évadés", "The Shawshank Redemption" },
                    { 14, "Matthew Broderick, James Earl Jones", 1994, 2, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9280), 88, "Rachid", true, false, true, "DVD", "/img/icon2.jpg", "Anglais", "Cassim", 1, "Don Hahn", "Driss", "Roger Allers, Rob Minkoff", "L'histoire d'un lionceau qui devient roi après la mort de son père.", "Français, English", null, "Le Roi Lion", "The Lion King" },
                    { 15, "Sam Neill, Laura Dern", 1993, 1, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9290), 127, "Rachid", true, false, true, "DVD", "/img/icon3.jpg", "Anglais", "Cassim", 1, "Gerald R. Molen", "Driss", "Steven Spielberg", "Des scientifiques essaient de créer un parc avec des dinosaures vivants.", "Français, English", null, "Jurassic Park", "Jurassic Park" },
                    { 16, "Ryan Gosling, Emma Stone", 2016, 7, new DateTime(2024, 9, 25, 11, 2, 57, 774, DateTimeKind.Local).AddTicks(9300), 128, "Rachid", true, false, true, "Blu-ray", "/img/icon1.jpg", "Anglais", "Cassim", 1, "Fred Berger", "Driss", "Damien Chazelle", "Un musicien et une actrice poursuivent leurs rêves.", "Français, English", null, "La La Land", "La La Land" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dvds_CategorieId",
                table: "Dvds",
                column: "CategorieId");
        }

        /// <inheritdoc />
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
                name: "Dvds");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
