using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    IdAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocalityCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.IdAddress);
                });

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
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "90", "Bolivia", "Lemuelhaven", "94926-1835", "106", "Metz Vista" },
                    { "91", "Estonia", "East Felipahaven", "10447", "8581", "Ullrich Cape" },
                    { "92", "Fiji", "Schillerburgh", "94392-7837", "91704", "Imani Plains" },
                    { "93", "Algeria", "Nicolasbury", "31974", "47792", "Waelchi Island" },
                    { "94", "Guinea", "Brekkefurt", "74630", "786", "Alfonso Vista" },
                    { "95", "Barbados", "Reinachester", "22535-9340", "86530", "Wisozk Crossing" },
                    { "96", "New Caledonia", "West Anitaburgh", "28140-1322", "07344", "Dietrich Row" },
                    { "97", "Estonia", "New Destinee", "36102-8154", "502", "Berge Union" },
                    { "98", "Papua New Guinea", "New Francesco", "58452", "7502", "O'Kon Loop" },
                    { "99", "Luxembourg", "Roslynbury", "04218", "8690", "Funk Pass" }
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
                    { "61", "Arnaldo.Macejkovic16@hotmail.com", "Sherman", "Smitham", "WecrTy7Nlb", "Driver" },
                    { "63", "Myra59@yahoo.com", "Madyson", "Block", "305_KpAobN", "Driver" },
                    { "65", "Dominic.Rowe@hotmail.com", "Bobby", "Leannon", "mrzcQq8xLa", "Driver" },
                    { "67", "Chase_Zemlak@hotmail.com", "Benton", "Bahringer", "3ezVMlTSnd", "Driver" },
                    { "69", "Bernita_Balistreri28@hotmail.com", "Katelin", "Gibson", "JO4kOdHOv0", "Driver" },
                    { "71", "Estelle_Waters@hotmail.com", "Ewell", "Murray", "yWcaXule0c", "Driver" },
                    { "73", "Fanny_DAmore45@hotmail.com", "Ebba", "Upton", "kgZACBywmu", "Driver" },
                    { "75", "Dock.Bergnaum47@yahoo.com", "Bridie", "Cole", "zw62ycJNds", "Driver" },
                    { "77", "Rebecca.Abernathy6@yahoo.com", "Nikolas", "Crona", "tnD_ClFfUv", "Driver" },
                    { "79", "Litzy_Dooley@hotmail.com", "Jefferey", "Mosciski", "DWtev6DbA2", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "100", "90", "Howell - Dickens", "Selmer_Barrows@hotmail.com", "Clinton", "Hane", "339-591-5369", "FYqUlk5Smw", "Client" },
                    { "101", "91", "Pacocha and Sons", "Ken.Runolfsdottir82@gmail.com", "Perry", "Cremin", "334-984-2129", "8vjVvROWAX", "Client" },
                    { "102", "92", "Kulas LLC", "Linwood32@yahoo.com", "Richie", "Marquardt", "965-835-1432", "rDJEUk2LrJ", "Client" },
                    { "103", "93", "Ward - Orn", "Grover31@hotmail.com", "Gregoria", "Heaney", "353-329-8007", "9sFbATxkSM", "Client" },
                    { "104", "94", "Stracke, Jacobi and Huels", "Chyna89@hotmail.com", "Geovanny", "Johns", "758-810-5625", "ltbF1IZFL3", "Client" },
                    { "105", "95", "Connelly, Emard and Weber", "Pearl_Stamm@gmail.com", "Adelbert", "Rice", "962-695-2696", "CUwp9Hw_rC", "Client" },
                    { "106", "96", "Thiel, Prosacco and Murphy", "Wendell64@gmail.com", "Ona", "Welch", "759-308-0015", "AleBXUatam", "Client" },
                    { "107", "97", "O'Connell, Wehner and Crona", "Rylan51@hotmail.com", "Lauryn", "Nienow", "465-739-7978", "cBG42dadJg", "Client" },
                    { "108", "98", "Boehm Group", "Arnulfo89@yahoo.com", "Donavon", "Jaskolski", "474-667-6546", "xJk9AMBO3J", "Client" },
                    { "109", "99", "Kilback - Herman", "Dan_Gleichner@yahoo.com", "Amya", "DuBuque", "642-705-9397", "sQ36U4IXzp", "Client" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "80", "Clay.Schuppe11@yahoo.com", "Sandra", 2, "Gibson", "sR5BmXUOSW", "Dispatcher" },
                    { "81", "Gladys.Quigley98@gmail.com", "Micah", 3, "Lynch", "AzaDbcgwcM", "Dispatcher" },
                    { "82", "Citlalli3@hotmail.com", "Jackson", 1, "Crona", "J89t1snmQ1", "Dispatcher" },
                    { "83", "Elton48@hotmail.com", "Rosina", 2, "Doyle", "FY79GtoVm1", "Dispatcher" },
                    { "84", "Linnie.Oberbrunner@gmail.com", "Hiram", 3, "McCullough", "m1aWw3mcsZ", "Dispatcher" },
                    { "85", "Vincenza_Strosin91@yahoo.com", "Rafaela", 2, "Jaskolski", "J40xDPM7jr", "Dispatcher" },
                    { "86", "Vladimir.Wilkinson@hotmail.com", "Ruthie", 3, "Harris", "_vLvJY0BGE", "Dispatcher" },
                    { "87", "Heath_Crooks@hotmail.com", "Gardner", 3, "Lebsack", "BgLiZB3fTa", "Dispatcher" },
                    { "88", "Neal46@hotmail.com", "Eliezer", 1, "Thompson", "SvMn2U3wVm", "Dispatcher" },
                    { "89", "Jameson78@gmail.com", "Mariane", 1, "West", "DaSdQAXl37", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "2BS8X1TPIWGF97038", "Tesla", 1, "Roadster", 36000, null },
                    { "4CKDGG2E3DVB25896", "Mazda", 2, "Sentra", 24000, null },
                    { "9W8EGAOQBXIP38812", "Hyundai", 2, "911", 4000, null },
                    { "B5T4K984FGJK94366", "Nissan", 3, "Colorado", 17000, null },
                    { "D3T1OFWIDBN338430", "Aston Martin", 2, "Ranchero", 2000, null },
                    { "HZI1ET161FXW19857", "Porsche", 3, "Roadster", 4000, null },
                    { "L0TN99SN5NA488891", "Smart", 1, "Beetle", 34000, null },
                    { "PVFJ85JGSXUO57106", "Smart", 1, "Countach", 23000, null },
                    { "SSPT4GZY58O853562", "Maserati", 3, "Alpine", 2000, null },
                    { "V1L6S9EL57UH87439", "Polestar", 1, "Roadster", 26000, null }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverLicense");

            migrationBuilder.DropTable(
                name: "Vehicules");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Certifications");
        }
    }
}
