using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "2BS8X1TPIWGF97038");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "4CKDGG2E3DVB25896");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9W8EGAOQBXIP38812");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "B5T4K984FGJK94366");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "D3T1OFWIDBN338430");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "HZI1ET161FXW19857");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "L0TN99SN5NA488891");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "PVFJ85JGSXUO57106");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "SSPT4GZY58O853562");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "V1L6S9EL57UH87439");

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdClient = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DispatcherMatricule = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    DriverMatricule = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_User_DispatcherMatricule",
                        column: x => x.DispatcherMatricule,
                        principalTable: "User",
                        principalColumn: "Matricule");
                    table.ForeignKey(
                        name: "FK_Deliveries_User_DriverMatricule",
                        column: x => x.DriverMatricule,
                        principalTable: "User",
                        principalColumn: "Matricule");
                    table.ForeignKey(
                        name: "FK_Deliveries_User_IdClient",
                        column: x => x.IdClient,
                        principalTable: "User",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Guernsey", "New Immanuelview", "41101-1158", "28925", "Nienow Terrace" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Iraq", "Uptonmouth", "90247", "994", "Selena Manor" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Luxembourg", "Maureenburgh", "54772-9611", "944", "Carlo Expressway" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Guatemala", "East Lisetteport", "52758-7732", "5570", "Wintheiser Orchard" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Turkmenistan", "East Muhammadstad", "38578", "946", "Barney Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Malta", "Lake Benjaminfort", "00838-1522", "38603", "Reilly Meadows" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Trinidad and Tobago", "Moniquebury", "14508-4080", "48659", "Frederic Glen" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "China", "Lake Tomasaton", "33979", "75457", "McClure Creek" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Switzerland", "Marquardtmouth", "31302", "770", "Roob Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Tajikistan", "Elianfort", "42604-0814", "49368", "Stark Forest" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kulas - Streich", "Matilda.Schoen3@hotmail.com", "Santina", "Bechtelar", "652-420-6021", "T4Htxnzgj7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Senger - Huel", "Jadon10@yahoo.com", "Lorena", "Mraz", "877-477-7166", "z4QsnarPIy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Feil, Predovic and Erdman", "Elissa21@yahoo.com", "Adriana", "Effertz", "813-312-0203", "glY6dBHarM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Swift, Wyman and Carroll", "Rhianna.Botsford@gmail.com", "Maeve", "Grady", "401-640-9701", "UaFF9idAic" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Ward, Daniel and Stark", "Arvilla.Koss69@hotmail.com", "Dayton", "Abbott", "552-234-4429", "rErNa3SS3G" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Larkin LLC", "Ralph.Ebert80@hotmail.com", "Frida", "Koss", "864-613-8430", "NxZGNF31m5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Becker, Schmeler and Zulauf", "Cicero.Zulauf75@yahoo.com", "Frida", "Rutherford", "720-667-0437", "vERuqu1dGT" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Roob - Fahey", "Eleazar.OConnell15@gmail.com", "Aurelio", "Cormier", "757-501-6931", "cmz4Jjdfdq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Pollich and Sons", "Calista77@yahoo.com", "Izabella", "Adams", "695-535-9367", "EUbvLOxw1A" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Steuber - Hauck", "Daniella6@gmail.com", "Douglas", "Kuphal", "378-471-2422", "qA2s6xj36Z" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Edison_Cole73@gmail.com", "Buford", 1, "Fadel", "s68o6YoU1W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Garth_Feeney49@yahoo.com", "Cleveland", 1, "Osinski", "wbiaiBLxaX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Abigale95@gmail.com", "Randy", 2, "Sanford", "tNYkdClucB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Juliana88@hotmail.com", "Cornelius", "Mann", "w6edsmb8Qo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Americo27@gmail.com", "Brando", 1, "Kuvalis", "MYJhSMRojd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Adalberto_Kemmer@hotmail.com", "Whitney", "Lang", "6UoGte8kKP" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Nicola_Stark37@yahoo.com", "Jakayla", 1, "Effertz", "D5hXfMP0un" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Conor_Christiansen74@gmail.com", "Clinton", 2, "Hodkiewicz", "eZ9GPKnTKn" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Brianne.Bartell12@yahoo.com", "Carroll", 3, "Koelpin", "XkIOmBZ36O" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Leopoldo51@yahoo.com", "Cristobal", 3, "Marks", "vKhi4KXpGk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ally.Gleason88@yahoo.com", "Jacquelyn", "Erdman", "rjfPIAJ7hv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Odie.Gaylord@hotmail.com", "Jaren", "Predovic", "3xOlX_YCTY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Curt.Hickle90@gmail.com", "Shanny", "Runolfsson", "TNMYjFQgXk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Clemmie_Ebert@gmail.com", "Ethelyn", "Hane", "5lgXZZsOIy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Modesto.Connelly@gmail.com", "Theresa", "Rogahn", "9gNVOLCmki" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kenton_Hansen64@yahoo.com", "Gregorio", "Nikolaus", "i9Z1X0E7JQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Barbara.Kulas17@gmail.com", "Emmalee", "Hayes", "62aN4r5qqM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Art14@hotmail.com", "Dallin", "Gleason", "X5M4u6KC93" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hipolito81@gmail.com", "Cleora", "Auer", "12Dal5XZAv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Earnestine.Brakus4@hotmail.com", "Lennie", "Collins", "HmcqDzjcOe" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "0G0VA08FL7YN53142", "Lamborghini", 3, "Grand Cherokee", 17000, null },
                    { "5RGQ818Z8PJI68875", "Mercedes Benz", 3, "Altima", 22000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "64PTNOXYHOV478797", "Porsche", 1, "Durango", 33000, null },
                    { "85QCVRNPROKM65452", "Bentley", 2, "Colorado", 24000, null },
                    { "C47EDOECQ2NK74107", "Honda", 1, "Grand Cherokee", 33000, null },
                    { "CHZIF6I26IO293610", "Smart", 2, "Impala", 6000, null },
                    { "EM4CTQUHIVH014878", "Mini", 1, "Element", 34000, null },
                    { "MR3NCMLXYLMS92580", "Porsche", 1, "LeBaron", 23000, null },
                    { "VMSY366853RF41669", "Volkswagen", 2, "Taurus", 4000, null },
                    { "YYQL5B636EBS40228", "Kia", 3, "Durango", 30000, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DispatcherMatricule",
                table: "Deliveries",
                column: "DispatcherMatricule");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DriverMatricule",
                table: "Deliveries",
                column: "DriverMatricule");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdClient",
                table: "Deliveries",
                column: "IdClient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "0G0VA08FL7YN53142");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "5RGQ818Z8PJI68875");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "64PTNOXYHOV478797");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "85QCVRNPROKM65452");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "C47EDOECQ2NK74107");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "CHZIF6I26IO293610");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "EM4CTQUHIVH014878");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "MR3NCMLXYLMS92580");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "VMSY366853RF41669");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "YYQL5B636EBS40228");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bolivia", "Lemuelhaven", "94926-1835", "106", "Metz Vista" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Estonia", "East Felipahaven", "10447", "8581", "Ullrich Cape" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Fiji", "Schillerburgh", "94392-7837", "91704", "Imani Plains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Algeria", "Nicolasbury", "31974", "47792", "Waelchi Island" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Guinea", "Brekkefurt", "74630", "786", "Alfonso Vista" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Barbados", "Reinachester", "22535-9340", "86530", "Wisozk Crossing" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "New Caledonia", "West Anitaburgh", "28140-1322", "07344", "Dietrich Row" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Estonia", "New Destinee", "36102-8154", "502", "Berge Union" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Papua New Guinea", "New Francesco", "58452", "7502", "O'Kon Loop" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Luxembourg", "Roslynbury", "04218", "8690", "Funk Pass" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Howell - Dickens", "Selmer_Barrows@hotmail.com", "Clinton", "Hane", "339-591-5369", "FYqUlk5Smw" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Pacocha and Sons", "Ken.Runolfsdottir82@gmail.com", "Perry", "Cremin", "334-984-2129", "8vjVvROWAX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kulas LLC", "Linwood32@yahoo.com", "Richie", "Marquardt", "965-835-1432", "rDJEUk2LrJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Ward - Orn", "Grover31@hotmail.com", "Gregoria", "Heaney", "353-329-8007", "9sFbATxkSM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Stracke, Jacobi and Huels", "Chyna89@hotmail.com", "Geovanny", "Johns", "758-810-5625", "ltbF1IZFL3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Connelly, Emard and Weber", "Pearl_Stamm@gmail.com", "Adelbert", "Rice", "962-695-2696", "CUwp9Hw_rC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Thiel, Prosacco and Murphy", "Wendell64@gmail.com", "Ona", "Welch", "759-308-0015", "AleBXUatam" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "O'Connell, Wehner and Crona", "Rylan51@hotmail.com", "Lauryn", "Nienow", "465-739-7978", "cBG42dadJg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Boehm Group", "Arnulfo89@yahoo.com", "Donavon", "Jaskolski", "474-667-6546", "xJk9AMBO3J" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kilback - Herman", "Dan_Gleichner@yahoo.com", "Amya", "DuBuque", "642-705-9397", "sQ36U4IXzp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Clay.Schuppe11@yahoo.com", "Sandra", 2, "Gibson", "sR5BmXUOSW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Gladys.Quigley98@gmail.com", "Micah", 3, "Lynch", "AzaDbcgwcM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Citlalli3@hotmail.com", "Jackson", 1, "Crona", "J89t1snmQ1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Elton48@hotmail.com", "Rosina", "Doyle", "FY79GtoVm1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Linnie.Oberbrunner@gmail.com", "Hiram", 3, "McCullough", "m1aWw3mcsZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vincenza_Strosin91@yahoo.com", "Rafaela", "Jaskolski", "J40xDPM7jr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Vladimir.Wilkinson@hotmail.com", "Ruthie", 3, "Harris", "_vLvJY0BGE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Heath_Crooks@hotmail.com", "Gardner", 3, "Lebsack", "BgLiZB3fTa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Neal46@hotmail.com", "Eliezer", 1, "Thompson", "SvMn2U3wVm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Jameson78@gmail.com", "Mariane", 1, "West", "DaSdQAXl37" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Arnaldo.Macejkovic16@hotmail.com", "Sherman", "Smitham", "WecrTy7Nlb" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Myra59@yahoo.com", "Madyson", "Block", "305_KpAobN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dominic.Rowe@hotmail.com", "Bobby", "Leannon", "mrzcQq8xLa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Chase_Zemlak@hotmail.com", "Benton", "Bahringer", "3ezVMlTSnd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bernita_Balistreri28@hotmail.com", "Katelin", "Gibson", "JO4kOdHOv0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Estelle_Waters@hotmail.com", "Ewell", "Murray", "yWcaXule0c" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Fanny_DAmore45@hotmail.com", "Ebba", "Upton", "kgZACBywmu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dock.Bergnaum47@yahoo.com", "Bridie", "Cole", "zw62ycJNds" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Rebecca.Abernathy6@yahoo.com", "Nikolas", "Crona", "tnD_ClFfUv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Litzy_Dooley@hotmail.com", "Jefferey", "Mosciski", "DWtev6DbA2" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "2BS8X1TPIWGF97038", "Tesla", 1, "Roadster", 36000, null },
                    { "4CKDGG2E3DVB25896", "Mazda", 2, "Sentra", 24000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "9W8EGAOQBXIP38812", "Hyundai", 2, "911", 4000, null },
                    { "B5T4K984FGJK94366", "Nissan", 3, "Colorado", 17000, null },
                    { "D3T1OFWIDBN338430", "Aston Martin", 2, "Ranchero", 2000, null },
                    { "HZI1ET161FXW19857", "Porsche", 3, "Roadster", 4000, null },
                    { "L0TN99SN5NA488891", "Smart", 1, "Beetle", 34000, null },
                    { "PVFJ85JGSXUO57106", "Smart", 1, "Countach", 23000, null },
                    { "SSPT4GZY58O853562", "Maserati", 3, "Alpine", 2000, null },
                    { "V1L6S9EL57UH87439", "Polestar", 1, "Roadster", 26000, null }
                });
        }
    }
}
