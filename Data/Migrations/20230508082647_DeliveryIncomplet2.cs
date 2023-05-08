using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_User_DispatcherMatricule",
                table: "Deliveries");

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

            migrationBuilder.RenameColumn(
                name: "DispatcherMatricule",
                table: "Deliveries",
                newName: "IdDispatcher");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_DispatcherMatricule",
                table: "Deliveries",
                newName: "IX_Deliveries_IdDispatcher");

            migrationBuilder.AddColumn<string>(
                name: "IdDriver",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Uruguay", "Halliebury", "80371-8608", "7618", "Malinda Hill" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Kenya", "East Elmiraport", "74973", "4017", "Casper Greens" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "India", "New Hans", "56250", "31735", "Nick Brook" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Slovakia (Slovak Republic)", "Wintheiserburgh", "10462", "76296", "Pfeffer Islands" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Virgin Islands, U.S.", "West Murielburgh", "31113-6775", "918", "Tyshawn Fords" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Germany", "Noeliastad", "52172", "0048", "Grant Mews" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Djibouti", "North Montanaton", "38229", "57271", "Ward Extensions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Uganda", "South Roderickshire", "03273-6647", "8520", "Madalyn Stravenue" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mozambique", "Dasiaborough", "88233-0661", "7740", "Dietrich Land" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bahamas", "North Luz", "10174", "33817", "Pablo Valleys" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Farrell and Sons", "Wendy.Legros@hotmail.com", "Rachelle", "Connelly", "255-417-4712", "9mwIwKXn6U" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Zieme - Kuvalis", "Winifred81@yahoo.com", "Immanuel", "Koch", "877-329-4677", "ohnnOJ0wAb" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Collier - Schuster", "Crawford.Lubowitz33@hotmail.com", "Kathryn", "Weber", "736-489-7242", "FASh9lOR4y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Nikolaus LLC", "Kayli.Wolff@gmail.com", "Yasmeen", "Flatley", "813-909-7547", "XPmywJoUdc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Davis Inc", "Edythe41@gmail.com", "Linnie", "Leannon", "693-244-7874", "2hIqa3zJWB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Boyle, Padberg and Hessel", "Everett_Kub76@yahoo.com", "Arthur", "Auer", "621-338-9814", "3mFRSLJAg_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Olson - Gislason", "Maggie23@gmail.com", "Suzanne", "Crooks", "324-429-9083", "ATgwrk2DZM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Turcotte, Kuphal and Heathcote", "Pinkie_Glover@hotmail.com", "Aaron", "Nader", "446-861-7263", "oUwdpLm5yM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Schimmel - Jacobson", "Trystan20@gmail.com", "Easton", "Wisoky", "963-966-0767", "xAgqBJsVjj" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Brakus Inc", "Jayde_Paucek@yahoo.com", "Ronaldo", "McGlynn", "452-347-0194", "wrHpDLFY9l" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Willy.Marvin@hotmail.com", "Lottie", "Boyer", "0clJ5El73h" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Jakob_Macejkovic63@yahoo.com", "Ephraim", 3, "Schneider", "0c80uHTpLf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Marisa_Sawayn@yahoo.com", "Sincere", 3, "Greenfelder", "RAXKv4Pm_i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Devante_Gorczany74@gmail.com", "Vance", 1, "Cummings", "FUZP9xGAut" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kiarra_Berge@yahoo.com", "Jayce", "Morissette", "KFSsGxrFO8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Luciano_Effertz39@gmail.com", "Abigale", "Mitchell", "KLqrr0B4ik" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Scarlett.Glover54@hotmail.com", "Josie", "Denesik", "SIbVNAP7ph" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Victoria44@yahoo.com", "Dortha", 1, "Harber", "v6W5jp8hLF" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Evelyn_Zulauf@gmail.com", "Asia", "Waters", "ijmSUw9z16" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Jordyn82@hotmail.com", "Marian", 2, "Mills", "JDRM4_USNp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jillian_Adams@hotmail.com", "Brenna", "Murphy", "n0KeaZ9mUS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Amelia28@yahoo.com", "Kirk", "Okuneva", "1gryL1J04V" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Reynold.Kassulke31@yahoo.com", "Blake", "Hintz", "CPndvUpfJK" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Garett_Cremin@gmail.com", "Rylee", "Schaden", "zHu6eaqLxy" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dillan43@hotmail.com", "Morris", "Zboncak", "AxouTcnvKU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dina_Bashirian@gmail.com", "Virginie", "Shanahan", "BDA8uyLPnk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hayley.Yost@gmail.com", "Yvette", "Harber", "LKAWkGoC7x" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Issac.Littel@hotmail.com", "Madelyn", "Koch", "SJ6nzn0DOJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Brielle.Davis@hotmail.com", "Cielo", "Ullrich", "NaRqozKys9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Skye.Hodkiewicz@hotmail.com", "Cierra", "Adams", "YSLB4dgcbJ" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "5301RC1BEREE22892", "Cadillac", 3, "Altima", 13000, null },
                    { "83C9UUGFJSYB17683", "Chrysler", 3, "Impala", 37000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "8BRQ3YH7ROF188977", "Honda", 3, "Focus", 36000, null },
                    { "9T2TMF4KCVL034339", "Smart", 1, "LeBaron", 22000, null },
                    { "ATTWH7Z1XSPE40343", "Dodge", 3, "CTS", 18000, null },
                    { "BW6TNQVC09YG93085", "BMW", 3, "CX-9", 26000, null },
                    { "CJYEJXE13LN668309", "Fiat", 2, "CTS", 31000, null },
                    { "ULNKBB3RQ4MA49427", "Smart", 2, "XC90", 11000, null },
                    { "URFXJQ1TUXPZ60739", "Cadillac", 2, "Countach", 14000, null },
                    { "ZOH1ZRBLOGKO20807", "Bugatti", 3, "CX-9", 3000, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_User_IdDispatcher",
                table: "Deliveries",
                column: "IdDispatcher",
                principalTable: "User",
                principalColumn: "Matricule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_User_IdDispatcher",
                table: "Deliveries");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "5301RC1BEREE22892");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "83C9UUGFJSYB17683");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "8BRQ3YH7ROF188977");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9T2TMF4KCVL034339");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "ATTWH7Z1XSPE40343");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "BW6TNQVC09YG93085");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "CJYEJXE13LN668309");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "ULNKBB3RQ4MA49427");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "URFXJQ1TUXPZ60739");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "ZOH1ZRBLOGKO20807");

            migrationBuilder.DropColumn(
                name: "IdDriver",
                table: "Deliveries");

            migrationBuilder.RenameColumn(
                name: "IdDispatcher",
                table: "Deliveries",
                newName: "DispatcherMatricule");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_IdDispatcher",
                table: "Deliveries",
                newName: "IX_Deliveries_DispatcherMatricule");

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Edison_Cole73@gmail.com", "Buford", "Fadel", "s68o6YoU1W" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Juliana88@hotmail.com", "Cornelius", 2, "Mann", "w6edsmb8Qo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Americo27@gmail.com", "Brando", "Kuvalis", "MYJhSMRojd" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nicola_Stark37@yahoo.com", "Jakayla", "Effertz", "D5hXfMP0un" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Brianne.Bartell12@yahoo.com", "Carroll", "Koelpin", "XkIOmBZ36O" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_User_DispatcherMatricule",
                table: "Deliveries",
                column: "DispatcherMatricule",
                principalTable: "User",
                principalColumn: "Matricule");
        }
    }
}
