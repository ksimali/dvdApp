﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dvdApp.Data;

#nullable disable

namespace dvdApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240925025001_SeedCategories")]
    partial class SeedCategories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("dvdApp.Models.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adolescent"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Biographie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cape et d'épée"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Catastrophe"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chronique"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Comédie de moeurs"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Comédie d'horreur"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Comédie dramatique"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Comédie fantaisiste"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Comédie musicale"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Comédie policière"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Comédie satirique"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Comédie sentimentale"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Comédie"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Criminel"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Danse"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Dessins animés"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Documentaire"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Drame de guerre"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Drame de moeurs"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Drame d'horreur"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Drame judiciaire"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Drame musical"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Drame poétique"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Drame policier"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Drame psychologique"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Drame sentimental"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Drame social"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Drame"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Espionnage"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Expérimental"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Fantastique"
                        },
                        new
                        {
                            Id = 34,
                            Name = "Film à sketches"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Film d'animation"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Film d'art martial"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Historique"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Horreur"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Humoristique"
                        },
                        new
                        {
                            Id = 40,
                            Name = "Marionnettes"
                        },
                        new
                        {
                            Id = 41,
                            Name = "Mélodrame"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Road movie"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Romantique"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Science-fiction"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Série policière"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Série TV"
                        },
                        new
                        {
                            Id = 48,
                            Name = "Spectacle d'humour"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Spectacle musical"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Suspense"
                        },
                        new
                        {
                            Id = 51,
                            Name = "Western"
                        });
                });

            modelBuilder.Entity("dvdApp.Models.Dvd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActeursPrincipaux")
                        .HasColumnType("longtext");

                    b.Property<int?>("AnneeSortie")
                        .HasColumnType("int");

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DerniereMiseAJour")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Duree")
                        .HasColumnType("int");

                    b.Property<string>("Emprunteur")
                        .HasColumnType("longtext");

                    b.Property<bool>("EstOriginal")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EstVersionEtendue")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("EstVisible")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Format")
                        .HasColumnType("longtext");

                    b.Property<string>("ImagePochette")
                        .HasColumnType("longtext");

                    b.Property<string>("Langue")
                        .HasColumnType("longtext");

                    b.Property<string>("MiseAJourEffectueePar")
                        .HasColumnType("longtext");

                    b.Property<int?>("NombreDisques")
                        .HasColumnType("int");

                    b.Property<string>("Producteur")
                        .HasColumnType("longtext");

                    b.Property<string>("Propriétaire")
                        .HasColumnType("longtext");

                    b.Property<string>("Realisateur")
                        .HasColumnType("longtext");

                    b.Property<string>("Resume")
                        .HasColumnType("longtext");

                    b.Property<string>("SousTitres")
                        .HasColumnType("longtext");

                    b.Property<string>("Supplements")
                        .HasColumnType("longtext");

                    b.Property<string>("TitreFrancais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TitreOriginal")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Dvds");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dvdApp.Models.Dvd", b =>
                {
                    b.HasOne("dvdApp.Models.Categorie", "Categorie")
                        .WithMany("Dvds")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("dvdApp.Models.Categorie", b =>
                {
                    b.Navigation("Dvds");
                });
#pragma warning restore 612, 618
        }
    }
}