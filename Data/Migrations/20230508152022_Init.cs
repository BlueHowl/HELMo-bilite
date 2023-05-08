using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    Plate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdLicenses = table.Column<int>(type: "int", nullable: false),
                    Payload = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.Plate);
                    table.ForeignKey(
                        name: "FK_Vehicules_Licenses_IdLicenses",
                        column: x => x.IdLicenses,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    IdAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocalityCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoadAddressId = table.Column<int>(type: "int", nullable: true),
                    UnloadingAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.IdAddress);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Matricule = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyAddressId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IdCertification = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Matricule);
                    table.ForeignKey(
                        name: "FK_User_Address_CompanyAddressId",
                        column: x => x.CompanyAddressId,
                        principalTable: "Address",
                        principalColumn: "IdAddress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Certifications_IdCertification",
                        column: x => x.IdCertification,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    IdDriver = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadAddressId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnloadingAddressId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnloadingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdVehicule = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_User_IdClient",
                        column: x => x.IdClient,
                        principalTable: "User",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_User_IdDriver",
                        column: x => x.IdDriver,
                        principalTable: "User",
                        principalColumn: "Matricule");
                    table.ForeignKey(
                        name: "FK_Deliveries_Vehicules_IdVehicule",
                        column: x => x.IdVehicule,
                        principalTable: "Vehicules",
                        principalColumn: "Plate");
                });

            migrationBuilder.CreateTable(
                name: "DriverLicense",
                columns: table => new
                {
                    DriversMatricule = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    LicensesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicense", x => new { x.DriversMatricule, x.LicensesId });
                    table.ForeignKey(
                        name: "FK_DriverLicense_Licenses_LicensesId",
                        column: x => x.LicensesId,
                        principalTable: "Licenses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverLicense_User_DriversMatricule",
                        column: x => x.DriversMatricule,
                        principalTable: "User",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "LoadAddressId", "Locality", "LocalityCode", "Number", "Street", "UnloadingAddressId" },
                values: new object[,]
                {
                    { "120", "New Caledonia", null, "South Norwood", "50643", "019", "Hirthe Dam", null },
                    { "121", "Cuba", null, "South Lourdes", "48631-6390", "055", "Cordell Route", null },
                    { "122", "Holy See (Vatican City State)", null, "Goyettechester", "50884-7560", "46844", "Hills Vista", null },
                    { "123", "Costa Rica", null, "Lake Curt", "13914-0532", "06253", "Schoen Courts", null },
                    { "124", "South Africa", null, "Wolffchester", "68774-9493", "7681", "Aryanna Station", null },
                    { "125", "Guadeloupe", null, "North Arlene", "02274-1960", "236", "Dora Bypass", null },
                    { "126", "Poland", null, "South Simland", "30405", "1194", "VonRueden Terrace", null },
                    { "127", "United States of America", null, "West Felicitaborough", "43981-1518", "74636", "Jasen Orchard", null },
                    { "128", "Lao People's Democratic Republic", null, "Nyahville", "75386", "882", "Sawayn Avenue", null },
                    { "129", "Bahamas", null, "McLaughlinland", "72920-6802", "710", "Hoeger Orchard", null },
                    { "150", "Somalia", null, "Grimesfurt", "63588", "888", "Pouros Lights", null },
                    { "151", "Ukraine", null, "South Katlynnstad", "58596-3496", "5860", "Dayna Lodge", null },
                    { "152", "Sierra Leone", null, "Pollichchester", "64693", "80675", "Mann Course", null },
                    { "153", "Bangladesh", null, "Port Kennethbury", "15641", "586", "Gusikowski Lane", null },
                    { "154", "Zambia", null, "Kubbury", "04322", "930", "Schumm Expressway", null },
                    { "155", "Swaziland", null, "West Grace", "44194", "48479", "Lynch Junctions", null },
                    { "156", "Tunisia", null, "Pfefferborough", "13288", "50391", "Madelynn Village", null },
                    { "157", "Liberia", null, "South Weldontown", "83548-8676", "7777", "O'Kon Prairie", null },
                    { "158", "Switzerland", null, "South Bell", "03607-8963", "616", "Tyrel Crest", null },
                    { "159", "New Caledonia", null, "New Jewell", "70412-3057", "8852", "Greenfelder Creek", null },
                    { "160", "Seychelles", null, "West Hillard", "31082-4144", "087", "Jones Lights", null },
                    { "161", "Burundi", null, "Satterfieldton", "94417-3302", "50752", "Rosetta Locks", null },
                    { "162", "Costa Rica", null, "Wehnerfort", "10048", "95451", "Lukas Meadow", null },
                    { "163", "Barbados", null, "North Ryleyshire", "57548-2361", "4099", "Ashleigh Fort", null },
                    { "164", "Guyana", null, "South Morris", "01103", "92125", "Smitham Shore", null },
                    { "165", "Senegal", null, "Claudiaberg", "64113", "578", "Adams Passage", null },
                    { "166", "Saint Pierre and Miquelon", null, "Port Lizeth", "71675-9432", "2225", "Lauryn Ridges", null },
                    { "167", "Singapore", null, "South Landenmouth", "50509-6780", "1577", "Lisette Prairie", null },
                    { "168", "Norway", null, "Waelchibury", "92190-5946", "976", "Shanahan Shore", null },
                    { "169", "Slovenia", null, "Port Elias", "10742-1183", "1597", "Reinhold Drive", null }
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CESS" },
                    { 2, "Bachelier" },
                    { 3, "Master" }
                });

            migrationBuilder.InsertData(
                table: "Licenses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "B" },
                    { 2, "C" },
                    { 3, "CE" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "-1", "admin@admin.com", "Admin", "Admin", "admin", "Admin" },
                    { "101", "Nikolas_Ritchie10@yahoo.com", "Rhianna", "Ratke", "nOqZSya48D", "Driver" },
                    { "103", "Eric49@hotmail.com", "Colten", "Hartmann", "JKZzdkKwPj", "Driver" },
                    { "105", "Lisette13@gmail.com", "Edison", "Powlowski", "I0A3fi4YlS", "Driver" },
                    { "107", "Garland_Monahan@gmail.com", "Toby", "White", "arNI3aBOWA", "Driver" },
                    { "109", "Araceli65@yahoo.com", "Edison", "Williamson", "z5vgotd9Vm", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "91", "Adrienne30@hotmail.com", "Ramiro", "Schoen", "me2TryzEqV", "Driver" },
                    { "93", "Iliana89@hotmail.com", "Beatrice", "Morissette", "qPcUyCVIUp", "Driver" },
                    { "95", "Jay52@yahoo.com", "Estel", "Schoen", "eSieoDbyYJ", "Driver" },
                    { "97", "Eli40@yahoo.com", "Lauryn", "Farrell", "9_oKwTl2pS", "Driver" },
                    { "99", "Cary_Tremblay@yahoo.com", "Clyde", "Reichert", "OEMNz90Zs_", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "130", "120", "Wiza - Olson", "Morton10@hotmail.com", "Shanelle", "Denesik", "293-451-9855", "TPaCtp0Nks", "Client" },
                    { "131", "121", "Daugherty Inc", "Minerva96@gmail.com", "Jamal", "Sawayn", "607-882-1441", "xh368Mc9Rq", "Client" },
                    { "132", "122", "Turner - Tremblay", "Jordyn_Hayes1@yahoo.com", "Loy", "Bednar", "561-860-0550", "zaPTc_13sx", "Client" },
                    { "133", "123", "Gleason Inc", "Lauriane42@hotmail.com", "Sammie", "Rice", "827-832-5697", "Bnm1GRu0If", "Client" },
                    { "134", "124", "Labadie - Kautzer", "Abner.OReilly25@gmail.com", "Camila", "Donnelly", "335-901-8029", "kQelN0smyd", "Client" },
                    { "135", "125", "Terry, Krajcik and Batz", "Kelsie_Vandervort88@gmail.com", "Loren", "Vandervort", "572-709-7154", "23Qb5YZVe3", "Client" },
                    { "136", "126", "Runte and Sons", "Arvid17@gmail.com", "Mariam", "Walsh", "320-360-6720", "YWB5cLxmvm", "Client" },
                    { "137", "127", "Turcotte, Kerluke and Wehner", "Flavio4@gmail.com", "Sigmund", "Boyle", "531-537-7937", "iKBUs8OyrD", "Client" },
                    { "138", "128", "Moen and Sons", "Marjorie.Emard50@gmail.com", "Garrett", "Feil", "310-526-9627", "IepnYqUmmB", "Client" },
                    { "139", "129", "Berge - Lynch", "Dakota.Grady@hotmail.com", "Max", "Hermann", "450-893-7979", "oX006t_3TQ", "Client" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "110", "Alda.Monahan@hotmail.com", "Clay", 1, "Welch", "F5q5JfrGAa", "Dispatcher" },
                    { "111", "Quincy.Lehner@gmail.com", "Monserrate", 1, "Grant", "NkFkAzzve_", "Dispatcher" },
                    { "112", "Caesar.Wilkinson59@yahoo.com", "Vivianne", 3, "Streich", "CWlW8p4fCn", "Dispatcher" },
                    { "113", "Victor33@hotmail.com", "Malvina", 1, "Dooley", "hPmdYpi5L3", "Dispatcher" },
                    { "114", "Izabella.OHara@gmail.com", "Bernice", 1, "Sipes", "l0FBcp_6X9", "Dispatcher" },
                    { "115", "Marty28@gmail.com", "Retta", 3, "Little", "_YCvpy7PSM", "Dispatcher" },
                    { "116", "Arnoldo34@hotmail.com", "Amely", 2, "Miller", "9sBBfDxBnv", "Dispatcher" },
                    { "117", "Hunter_Gutkowski@gmail.com", "Elva", 1, "McClure", "z5Z_Syzd08", "Dispatcher" },
                    { "118", "Okey_Kuhic76@hotmail.com", "Aidan", 1, "Kunde", "P4x1UtlwPh", "Dispatcher" },
                    { "119", "Garth93@hotmail.com", "Zackery", 1, "Nikolaus", "R5Lqp2VvTB", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "0I5GFLJ2F2IC38150", "Jaguar", 2, "Wrangler", 4000, null },
                    { "AAV1FJEK2PTF69226", "Maserati", 2, "Model T", 40000, null },
                    { "BMNPBI1H4GLX68436", "BMW", 3, "Focus", 29000, null },
                    { "CF9XYN1T6MDH62877", "Honda", 3, "F-150", 28000, null },
                    { "D72YS3W6WYOK30108", "Ford", 3, "A4", 34000, null },
                    { "FELSV94ODHEQ73728", "Nissan", 2, "Fiesta", 20000, null },
                    { "I6ILZWMMV6XZ56201", "Kia", 2, "Explorer", 19000, null },
                    { "PSI9DTWXKYXB27005", "Rolls Royce", 1, "ATS", 21000, null },
                    { "QL6JQHOL31XQ64464", "Toyota", 2, "Focus", 16000, null },
                    { "SAUQOW9IE0NL81126", "Jaguar", 1, "Camry", 2000, null }
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "Content", "IdClient", "IdDriver", "IdVehicule", "LoadAddressId", "LoadDate", "UnloadingAddressId", "UnloadingDate", "status" },
                values: new object[,]
                {
                    { 170, "Ipsum alias et cum corrupti vel omnis aut blanditiis neque.", "130", null, "D72YS3W6WYOK30108", "150", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "151", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 171, "Neque voluptatem deserunt enim corporis repudiandae.\nDoloribus ut et amet quae assumenda necessitatibus ut occaecati quasi.\nUt minima aperiam cupiditate sed itaque.\nIusto ullam ea quos quas sunt quis.", "131", null, "FELSV94ODHEQ73728", "152", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "153", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 172, "Sit voluptatem qui voluptates sit illo sunt tenetur. Mollitia ea quas incidunt voluptatibus rerum harum blanditiis. Deleniti expedita est animi officiis. Eum eos in.", "132", null, "CF9XYN1T6MDH62877", "154", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "155", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 173, "Beatae ratione et impedit quis repellat labore autem vero. Qui et dicta quia exercitationem incidunt consequatur veniam. Quas aspernatur ducimus libero commodi minima. Beatae ad voluptatem eaque non unde dolor. Blanditiis consectetur enim fugiat sit enim et.", "133", null, "AAV1FJEK2PTF69226", "156", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "157", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 174, "Quos ipsum omnis non iusto exercitationem sint. Tempore assumenda quia debitis corrupti facilis. Aut delectus molestiae consequatur aut non. Fugiat amet placeat eos in numquam officiis. Eos id voluptatum dolorem molestiae. Eum quae consequatur et mollitia eveniet.", "134", null, "BMNPBI1H4GLX68436", "158", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "159", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 175, "Consectetur neque dicta ut qui.\nLaboriosam perspiciatis quaerat quaerat ipsum laboriosam dolores fugiat odio.\nEa et iure architecto quos molestiae sapiente.", "135", null, "I6ILZWMMV6XZ56201", "160", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "161", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 176, "Recusandae ipsum a aut inventore deserunt esse odio velit aut.", "136", null, "SAUQOW9IE0NL81126", "162", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "163", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 177, "Sapiente ad magnam aperiam magnam natus aut.\nDolorem aperiam quod natus aut aut commodi dolores quasi.\nAd omnis ipsam.\nError aut quas voluptate est.", "137", null, "QL6JQHOL31XQ64464", "164", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "165", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 178, "Nisi et illo dolor ullam et rerum vel sed. Earum autem commodi autem. Totam dolor reprehenderit quia quia assumenda dignissimos et. Perspiciatis numquam tempore porro tempora eaque hic repellat perferendis. Placeat dolores sint deserunt deserunt sit quasi.", "138", null, "0I5GFLJ2F2IC38150", "166", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "167", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" },
                    { 179, "Ea temporibus est eaque explicabo.", "139", null, "PSI9DTWXKYXB27005", "168", new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "169", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_LoadAddressId",
                table: "Address",
                column: "LoadAddressId",
                unique: true,
                filter: "[LoadAddressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UnloadingAddressId",
                table: "Address",
                column: "UnloadingAddressId",
                unique: true,
                filter: "[UnloadingAddressId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdClient",
                table: "Deliveries",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdDriver",
                table: "Deliveries",
                column: "IdDriver");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdVehicule",
                table: "Deliveries",
                column: "IdVehicule");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicense_LicensesId",
                table: "DriverLicense",
                column: "LicensesId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdCertification",
                table: "User",
                column: "IdCertification");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicules_IdLicenses",
                table: "Vehicules",
                column: "IdLicenses");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Deliveries_LoadAddressId",
                table: "Address",
                column: "LoadAddressId",
                principalTable: "Deliveries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Deliveries_UnloadingAddressId",
                table: "Address",
                column: "UnloadingAddressId",
                principalTable: "Deliveries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Deliveries_LoadAddressId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Deliveries_UnloadingAddressId",
                table: "Address");

            migrationBuilder.DropTable(
                name: "DriverLicense");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Licenses");
        }
    }
}
