﻿// <auto-generated />
using System;
using HELMo_bilite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230507205302_TruckDatageneration")]
    partial class TruckDatageneration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DriverLicense", b =>
                {
                    b.Property<string>("DriversMatricule")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("LicensesId")
                        .HasColumnType("int");

                    b.HasKey("DriversMatricule", "LicensesId");

                    b.HasIndex("LicensesId");

                    b.ToTable("DriverLicense", (string)null);
                });

            modelBuilder.Entity("HELMo_bilite.Models.Address", b =>
                {
                    b.Property<string>("IdAddress")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAddress");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            IdAddress = "90",
                            Country = "Sri Lanka",
                            Locality = "Pagacborough",
                            LocalityCode = "97440-9992",
                            Number = "108",
                            Street = "Monserrat Crossroad"
                        },
                        new
                        {
                            IdAddress = "91",
                            Country = "Azerbaijan",
                            Locality = "Gusberg",
                            LocalityCode = "59648",
                            Number = "299",
                            Street = "Herzog Way"
                        },
                        new
                        {
                            IdAddress = "92",
                            Country = "Jordan",
                            Locality = "Frederikport",
                            LocalityCode = "08837",
                            Number = "46554",
                            Street = "Greenfelder Vista"
                        },
                        new
                        {
                            IdAddress = "93",
                            Country = "Virgin Islands, British",
                            Locality = "North Mayra",
                            LocalityCode = "51386-4584",
                            Number = "84451",
                            Street = "Fisher Villages"
                        },
                        new
                        {
                            IdAddress = "94",
                            Country = "Spain",
                            Locality = "Lake Minervahaven",
                            LocalityCode = "56592-6804",
                            Number = "77973",
                            Street = "Manuela Stravenue"
                        },
                        new
                        {
                            IdAddress = "95",
                            Country = "Lao People's Democratic Republic",
                            Locality = "Brennaside",
                            LocalityCode = "98042",
                            Number = "741",
                            Street = "Fadel Views"
                        },
                        new
                        {
                            IdAddress = "96",
                            Country = "Cayman Islands",
                            Locality = "East Emily",
                            LocalityCode = "32449-1042",
                            Number = "5037",
                            Street = "Zackary Cliff"
                        },
                        new
                        {
                            IdAddress = "97",
                            Country = "Benin",
                            Locality = "South Caesar",
                            LocalityCode = "28192-1236",
                            Number = "365",
                            Street = "Madonna Mission"
                        },
                        new
                        {
                            IdAddress = "98",
                            Country = "Iraq",
                            Locality = "West Ernesto",
                            LocalityCode = "94433",
                            Number = "880",
                            Street = "Murazik Trail"
                        },
                        new
                        {
                            IdAddress = "99",
                            Country = "China",
                            Locality = "West Eduardo",
                            LocalityCode = "78395",
                            Number = "6609",
                            Street = "Zelda Walk"
                        });
                });

            modelBuilder.Entity("HELMo_bilite.Models.Certification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Certifications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CESS"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bachelier"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Master"
                        });
                });

            modelBuilder.Entity("HELMo_bilite.Models.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Licenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "B"
                        },
                        new
                        {
                            Id = 2,
                            Name = "C"
                        },
                        new
                        {
                            Id = 3,
                            Name = "CE"
                        });
                });

            modelBuilder.Entity("HELMo_bilite.Models.User", b =>
                {
                    b.Property<string>("Matricule")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Matricule");

                    b.ToTable("User", (string)null);

                    b.HasDiscriminator<string>("Role").HasValue("User");
                });

            modelBuilder.Entity("HELMo_bilite.Models.Vehicule", b =>
                {
                    b.Property<string>("Plate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLicenses")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payload")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Plate");

                    b.HasIndex("IdLicenses");

                    b.ToTable("Trucks");

                    b.HasData(
                        new
                        {
                            Plate = "ZR3SYK40K2SK61953",
                            Brand = "Rolls Royce",
                            IdLicenses = 2,
                            Model = "Explorer",
                            Payload = 16000
                        },
                        new
                        {
                            Plate = "A2CPHJUFBBXV12437",
                            Brand = "Volvo",
                            IdLicenses = 2,
                            Model = "911",
                            Payload = 5000
                        },
                        new
                        {
                            Plate = "V1LY16VD4AQV46550",
                            Brand = "Tesla",
                            IdLicenses = 3,
                            Model = "Volt",
                            Payload = 22000
                        },
                        new
                        {
                            Plate = "SS1GIVD235F537437",
                            Brand = "Rolls Royce",
                            IdLicenses = 1,
                            Model = "Malibu",
                            Payload = 39000
                        },
                        new
                        {
                            Plate = "POK243CPHZC540896",
                            Brand = "Mini",
                            IdLicenses = 2,
                            Model = "Colorado",
                            Payload = 19000
                        },
                        new
                        {
                            Plate = "IDEO2MQ4VCVP28531",
                            Brand = "Hyundai",
                            IdLicenses = 2,
                            Model = "Grand Caravan",
                            Payload = 39000
                        },
                        new
                        {
                            Plate = "PGKAZFG8NETR69956",
                            Brand = "BMW",
                            IdLicenses = 2,
                            Model = "Wrangler",
                            Payload = 3000
                        },
                        new
                        {
                            Plate = "9ZVMEQLMYNIT84444",
                            Brand = "Aston Martin",
                            IdLicenses = 1,
                            Model = "Taurus",
                            Payload = 30000
                        },
                        new
                        {
                            Plate = "M54M4VFXXFLC69003",
                            Brand = "Tesla",
                            IdLicenses = 3,
                            Model = "Impala",
                            Payload = 30000
                        },
                        new
                        {
                            Plate = "78410WS0JNZU60252",
                            Brand = "Aston Martin",
                            IdLicenses = 3,
                            Model = "1",
                            Payload = 30000
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

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

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HELMo_bilite.Models.Admin", b =>
                {
                    b.HasBaseType("HELMo_bilite.Models.User");

                    b.HasDiscriminator().HasValue("Admin");

                    b.HasData(
                        new
                        {
                            Matricule = "-1",
                            Email = "admin@admin.com",
                            FirstName = "Admin",
                            Name = "Admin",
                            Password = "admin"
                        });
                });

            modelBuilder.Entity("HELMo_bilite.Models.Client", b =>
                {
                    b.HasBaseType("HELMo_bilite.Models.User");

                    b.Property<string>("CompanyAddressId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CompanyAddressId");

                    b.HasDiscriminator().HasValue("Client");

                    b.HasData(
                        new
                        {
                            Matricule = "100",
                            Email = "Thora.Kuvalis56@hotmail.com",
                            FirstName = "Terry",
                            Name = "McKenzie",
                            Password = "p8SHolxZeU",
                            CompanyAddressId = "90",
                            CompanyName = "Berge - Sporer",
                            Number = "483-506-7101"
                        },
                        new
                        {
                            Matricule = "101",
                            Email = "Wilburn_Bartoletti@yahoo.com",
                            FirstName = "Vern",
                            Name = "Hand",
                            Password = "Kkg_2eOKfS",
                            CompanyAddressId = "91",
                            CompanyName = "Towne - Hilll",
                            Number = "202-595-3449"
                        },
                        new
                        {
                            Matricule = "102",
                            Email = "Rosa.Carter@yahoo.com",
                            FirstName = "Gayle",
                            Name = "Boehm",
                            Password = "f59UIHJ7j4",
                            CompanyAddressId = "92",
                            CompanyName = "Vandervort - Johnston",
                            Number = "323-641-5750"
                        },
                        new
                        {
                            Matricule = "103",
                            Email = "Demarco_Parisian77@hotmail.com",
                            FirstName = "Armani",
                            Name = "Morissette",
                            Password = "oduD0m2H9B",
                            CompanyAddressId = "93",
                            CompanyName = "Sporer, Stroman and Kautzer",
                            Number = "870-216-2710"
                        },
                        new
                        {
                            Matricule = "104",
                            Email = "Annie.Quitzon@hotmail.com",
                            FirstName = "Constantin",
                            Name = "Lemke",
                            Password = "Uc9yFL9zBo",
                            CompanyAddressId = "94",
                            CompanyName = "Beahan - Mayert",
                            Number = "981-755-8271"
                        },
                        new
                        {
                            Matricule = "105",
                            Email = "Mitchell_Schaden38@gmail.com",
                            FirstName = "Demario",
                            Name = "Maggio",
                            Password = "Jggu5bibiQ",
                            CompanyAddressId = "95",
                            CompanyName = "Okuneva and Sons",
                            Number = "877-270-3613"
                        },
                        new
                        {
                            Matricule = "106",
                            Email = "Kory_Emard1@gmail.com",
                            FirstName = "Jessyca",
                            Name = "Jakubowski",
                            Password = "ksWRJVcUH3",
                            CompanyAddressId = "96",
                            CompanyName = "Terry, Bode and Kutch",
                            Number = "548-897-9723"
                        },
                        new
                        {
                            Matricule = "107",
                            Email = "Iliana_Pacocha@yahoo.com",
                            FirstName = "Aurelia",
                            Name = "McGlynn",
                            Password = "S8BCh5Yrar",
                            CompanyAddressId = "97",
                            CompanyName = "Hills - Bashirian",
                            Number = "883-677-3964"
                        },
                        new
                        {
                            Matricule = "108",
                            Email = "Ali_Feest@gmail.com",
                            FirstName = "Maryjane",
                            Name = "Sauer",
                            Password = "MsuwzmUrw7",
                            CompanyAddressId = "98",
                            CompanyName = "Bauch, Rau and Rath",
                            Number = "872-425-8960"
                        },
                        new
                        {
                            Matricule = "109",
                            Email = "Zachery_Hilll70@gmail.com",
                            FirstName = "Hudson",
                            Name = "Hamill",
                            Password = "X9A417cftS",
                            CompanyAddressId = "99",
                            CompanyName = "Greenfelder - Harris",
                            Number = "392-879-3862"
                        });
                });

            modelBuilder.Entity("HELMo_bilite.Models.Dispatcher", b =>
                {
                    b.HasBaseType("HELMo_bilite.Models.User");

                    b.Property<int>("IdCertification")
                        .HasColumnType("int");

                    b.HasIndex("IdCertification");

                    b.HasDiscriminator().HasValue("Dispatcher");

                    b.HasData(
                        new
                        {
                            Matricule = "80",
                            Email = "Sammie80@yahoo.com",
                            FirstName = "Joan",
                            Name = "Abbott",
                            Password = "wW8kvnUpFg",
                            IdCertification = 3
                        },
                        new
                        {
                            Matricule = "81",
                            Email = "Dustin.McClure3@yahoo.com",
                            FirstName = "Deion",
                            Name = "Wisozk",
                            Password = "i6LGjKxLQR",
                            IdCertification = 1
                        },
                        new
                        {
                            Matricule = "82",
                            Email = "Marcia28@hotmail.com",
                            FirstName = "Gerhard",
                            Name = "Hamill",
                            Password = "bdwhhgjSB8",
                            IdCertification = 2
                        },
                        new
                        {
                            Matricule = "83",
                            Email = "Leone_Rau73@gmail.com",
                            FirstName = "Jeremy",
                            Name = "Fisher",
                            Password = "YHdC_vGmZ1",
                            IdCertification = 1
                        },
                        new
                        {
                            Matricule = "84",
                            Email = "Twila.Monahan@gmail.com",
                            FirstName = "Keagan",
                            Name = "Collier",
                            Password = "aUGgqYHLHg",
                            IdCertification = 2
                        },
                        new
                        {
                            Matricule = "85",
                            Email = "Mossie_Zulauf@hotmail.com",
                            FirstName = "Bobby",
                            Name = "Schuppe",
                            Password = "ZYD3ZYR873",
                            IdCertification = 3
                        },
                        new
                        {
                            Matricule = "86",
                            Email = "Pansy13@yahoo.com",
                            FirstName = "Joanny",
                            Name = "Nienow",
                            Password = "yLTwq1D3aJ",
                            IdCertification = 3
                        },
                        new
                        {
                            Matricule = "87",
                            Email = "Juwan_Heller@gmail.com",
                            FirstName = "Rowan",
                            Name = "Durgan",
                            Password = "HBthoJ0ZRJ",
                            IdCertification = 2
                        },
                        new
                        {
                            Matricule = "88",
                            Email = "Murl46@hotmail.com",
                            FirstName = "Emile",
                            Name = "Stoltenberg",
                            Password = "P5GFW2kX0n",
                            IdCertification = 1
                        },
                        new
                        {
                            Matricule = "89",
                            Email = "Greg61@yahoo.com",
                            FirstName = "Maida",
                            Name = "Gottlieb",
                            Password = "YsFBriOOHY",
                            IdCertification = 1
                        });
                });

            modelBuilder.Entity("HELMo_bilite.Models.Driver", b =>
                {
                    b.HasBaseType("HELMo_bilite.Models.User");

                    b.HasDiscriminator().HasValue("Driver");

                    b.HasData(
                        new
                        {
                            Matricule = "61",
                            Email = "Jaida_Bosco@yahoo.com",
                            FirstName = "Effie",
                            Name = "Lind",
                            Password = "caaoXUumpg"
                        },
                        new
                        {
                            Matricule = "63",
                            Email = "Ilene_Erdman71@gmail.com",
                            FirstName = "Jamie",
                            Name = "Gutkowski",
                            Password = "_yG6LY4vhm"
                        },
                        new
                        {
                            Matricule = "65",
                            Email = "Geraldine_DuBuque@gmail.com",
                            FirstName = "Dewayne",
                            Name = "Leuschke",
                            Password = "RV1e_AkrIE"
                        },
                        new
                        {
                            Matricule = "67",
                            Email = "Taya.Mann76@hotmail.com",
                            FirstName = "Kenny",
                            Name = "Steuber",
                            Password = "Rocf4AhWI_"
                        },
                        new
                        {
                            Matricule = "69",
                            Email = "Ima.Turcotte28@yahoo.com",
                            FirstName = "David",
                            Name = "Gerhold",
                            Password = "k6Bq8S9Orv"
                        },
                        new
                        {
                            Matricule = "71",
                            Email = "Nicolette68@yahoo.com",
                            FirstName = "Saul",
                            Name = "Reichel",
                            Password = "mRAs_Rn2th"
                        },
                        new
                        {
                            Matricule = "73",
                            Email = "Zoie36@yahoo.com",
                            FirstName = "Stacy",
                            Name = "Hermiston",
                            Password = "Aax1q8oJvQ"
                        },
                        new
                        {
                            Matricule = "75",
                            Email = "Destinee_Dach@yahoo.com",
                            FirstName = "Margarette",
                            Name = "Ruecker",
                            Password = "XOzxFlYsaP"
                        },
                        new
                        {
                            Matricule = "77",
                            Email = "Levi.Hessel92@hotmail.com",
                            FirstName = "Brandy",
                            Name = "Powlowski",
                            Password = "OZfoNNlfUr"
                        },
                        new
                        {
                            Matricule = "79",
                            Email = "Tobin.Fritsch@hotmail.com",
                            FirstName = "Elian",
                            Name = "Kohler",
                            Password = "DDoLGY8Zw7"
                        });
                });

            modelBuilder.Entity("DriverLicense", b =>
                {
                    b.HasOne("HELMo_bilite.Models.Driver", null)
                        .WithMany()
                        .HasForeignKey("DriversMatricule")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HELMo_bilite.Models.License", null)
                        .WithMany()
                        .HasForeignKey("LicensesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HELMo_bilite.Models.Vehicule", b =>
                {
                    b.HasOne("HELMo_bilite.Models.License", "Licenses")
                        .WithMany()
                        .HasForeignKey("IdLicenses")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Licenses");
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

            modelBuilder.Entity("HELMo_bilite.Models.Client", b =>
                {
                    b.HasOne("HELMo_bilite.Models.Address", "CompanyAddress")
                        .WithMany()
                        .HasForeignKey("CompanyAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyAddress");
                });

            modelBuilder.Entity("HELMo_bilite.Models.Dispatcher", b =>
                {
                    b.HasOne("HELMo_bilite.Models.Certification", "Certification")
                        .WithMany()
                        .HasForeignKey("IdCertification")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Certification");
                });
#pragma warning restore 612, 618
        }
    }
}
