using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_User_DriverMatricule",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_DriverMatricule",
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
                name: "DriverMatricule",
                table: "Deliveries");

            migrationBuilder.AlterColumn<string>(
                name: "IdDriver",
                table: "Deliveries",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Pakistan", "Rosemarieberg", "45844", "7008", "Emmerich Forges" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Spain", "New Wallace", "04066", "82419", "Gutkowski Underpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Italy", "Rempelhaven", "09567", "736", "Hettinger Mountains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "South Georgia and the South Sandwich Islands", "North Dashawnstad", "84507-7353", "72212", "Klein Estates" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Fiji", "South Avis", "00604-3394", "18333", "Gerlach Prairie" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cote d'Ivoire", "Legrosfort", "24833-3343", "822", "Gaylord Skyway" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Barbados", "Quentinview", "35171-7018", "10638", "Nels Ford" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Tonga", "Marksville", "68614", "63693", "Armstrong Plains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Nigeria", "South Marcella", "77399-6534", "130", "O'Reilly Lane" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Macedonia", "Christiansenville", "95035", "53750", "Julia Knolls" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Zieme, Erdman and Emard", "Kelvin43@gmail.com", "Tyler", "Keebler", "393-924-9629", "ulplrdpiW8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Feeney, Schultz and Boyer", "Einar20@yahoo.com", "Chaya", "Robel", "682-430-4361", "qLWR6kAQji" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "O'Conner Group", "Lon28@gmail.com", "Roberta", "Johnston", "695-232-8171", "RRbV2WjSdo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hansen, Vandervort and Emard", "Hayden.Pagac67@hotmail.com", "Jayne", "McLaughlin", "913-712-2374", "_ni_5XP5d4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Windler Inc", "Cielo.Fritsch89@gmail.com", "Claudie", "Beahan", "689-270-2891", "jgtT7vk1CU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hartmann - Kuphal", "Sophie_Nicolas11@gmail.com", "Madelynn", "Considine", "631-412-3588", "GLfHV1dqLe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Tremblay, Lind and Boyle", "Lilly.Lesch52@yahoo.com", "Iva", "Brakus", "209-955-0881", "ZHMTMFusfT" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Veum - Bradtke", "Eli82@gmail.com", "Josefina", "Kemmer", "648-912-3214", "rA75DiB6mg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Ebert LLC", "Alysa_Ortiz@yahoo.com", "Elmore", "Macejkovic", "212-437-0916", "YUQ9NbrH1v" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Macejkovic and Sons", "Cristobal_Turner1@gmail.com", "Quentin", "Kutch", "445-805-5210", "3jjB_RTTWl" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Gunnar_Friesen@yahoo.com", "Leonor", 3, "Casper", "KaL6QYzukb" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Sheridan.Nienow40@yahoo.com", "Kathlyn", 1, "Gaylord", "vhFM3c7DiB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Micheal42@hotmail.com", "Isabella", 2, "Langworth", "Ge2NQfbWHU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Adolph.Parisian63@yahoo.com", "Noel", 3, "Hammes", "xllwxPrGHH" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Estefania.Treutel@gmail.com", "Name", 2, "Zboncak", "tSliyvr5lB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Reina50@hotmail.com", "Oliver", 3, "Tillman", "9BFHDffU9t" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Josefa88@hotmail.com", "Abbigail", "Kuhlman", "dDHIzpK9P7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Makayla_Anderson32@hotmail.com", "Tess", 2, "Johnston", "MAdFrL526f" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Theodora.Rosenbaum@hotmail.com", "Lambert", "Boyer", "QWCs_4Uwxg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cora_Treutel32@gmail.com", "Loyal", "O'Kon", "AnnBguY4jf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Trey_Sporer1@yahoo.com", "Jerrold", "Turcotte", "yd16W97zna" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ford39@yahoo.com", "Ada", "Gaylord", "ZSF79Ral6D" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Laverne.Kilback@gmail.com", "Junius", "West", "qvcCy303Z5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Asha_Feest@gmail.com", "Tiffany", "Keeling", "CcOi3Z2xY6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Dudley.Aufderhar85@hotmail.com", "Meaghan", "Schowalter", "VE8ZxOHiPa" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Skylar69@yahoo.com", "Laila", "Emmerich", "EGMhHG1WiR" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "May.Fritsch@yahoo.com", "Myrtice", "Towne", "Zwaqv5PIr8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Romaine12@hotmail.com", "Murray", "Rau", "bF6Rjo8mpt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alverta.Zboncak@gmail.com", "Ariane", "Mueller", "0LnA9tdewI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Quinton19@hotmail.com", "Misty", "Mayert", "s1mHHx9_Bk" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "48EMBP6IBELT14254", "Volvo", 2, "Explorer", 29000, null },
                    { "8ESCJNQ9NXMF24693", "BMW", 2, "Spyder", 39000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "9DQKXZ1KCPRL54722", "Porsche", 3, "Charger", 16000, null },
                    { "CE06LUUNBONO18001", "Fiat", 2, "LeBaron", 21000, null },
                    { "I5R8DYVPIRJL76072", "Mazda", 2, "Countach", 35000, null },
                    { "IZ4YBHJZU3AK60870", "Aston Martin", 2, "1", 27000, null },
                    { "JCM2KETIT0K829426", "Chrysler", 3, "911", 26000, null },
                    { "NSHV2LTGC3E126640", "Bugatti", 1, "Charger", 11000, null },
                    { "P7YV36FP67CH69024", "Ford", 3, "Accord", 11000, null },
                    { "SJMOKL4NCWV362089", "Nissan", 3, "XC90", 36000, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdDriver",
                table: "Deliveries",
                column: "IdDriver");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_User_IdDriver",
                table: "Deliveries",
                column: "IdDriver",
                principalTable: "User",
                principalColumn: "Matricule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_User_IdDriver",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_IdDriver",
                table: "Deliveries");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "48EMBP6IBELT14254");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "8ESCJNQ9NXMF24693");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9DQKXZ1KCPRL54722");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "CE06LUUNBONO18001");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "I5R8DYVPIRJL76072");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "IZ4YBHJZU3AK60870");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "JCM2KETIT0K829426");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "NSHV2LTGC3E126640");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "P7YV36FP67CH69024");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "SJMOKL4NCWV362089");

            migrationBuilder.AlterColumn<string>(
                name: "IdDriver",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverMatricule",
                table: "Deliveries",
                type: "nvarchar(10)",
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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Willy.Marvin@hotmail.com", "Lottie", 1, "Boyer", "0clJ5El73h" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Kiarra_Berge@yahoo.com", "Jayce", 1, "Morissette", "KFSsGxrFO8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Luciano_Effertz39@gmail.com", "Abigale", 2, "Mitchell", "KLqrr0B4ik" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jordyn82@hotmail.com", "Marian", "Mills", "JDRM4_USNp" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DriverMatricule",
                table: "Deliveries",
                column: "DriverMatricule");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_User_DriverMatricule",
                table: "Deliveries",
                column: "DriverMatricule",
                principalTable: "User",
                principalColumn: "Matricule");
        }
    }
}
