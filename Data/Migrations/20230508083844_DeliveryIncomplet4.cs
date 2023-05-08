using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "LoadAddressId",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadDate",
                table: "Deliveries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LoadAddressId",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Singapore", "Stammport", "95953", "7484", "Bailey Tunnel" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Sao Tome and Principe", "New Leoraborough", "36379-8289", "60637", "Mose Trail" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Israel", "Wisokyhaven", "91447", "2135", "Nola Turnpike" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Nauru", "Port Antonetta", "64104-3924", "410", "Cummings Crest" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Somalia", "Ervinport", "50040-1122", "07684", "Joy Light" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Martinique", "West Erichfurt", "20842-5987", "890", "Schaefer Port" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Lao People's Democratic Republic", "Hildegardborough", "72594-8053", "9224", "Heathcote Mountains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bouvet Island (Bouvetoya)", "West Rachelleburgh", "12832", "404", "Howell Glens" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cambodia", "North Dana", "96213-5143", "018", "Tyra Camp" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Gambia", "West Nathanial", "17685", "4605", "Kathryn Stream" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Keeling, Labadie and Casper", "Kellie_Ryan@gmail.com", "Catherine", "Kessler", "389-215-1209", "caseQBKfIY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Aufderhar - Jones", "Bernardo.Mertz43@hotmail.com", "Cortney", "Parisian", "843-396-6481", "zRCdd9IAiQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Anderson and Sons", "Aryanna19@yahoo.com", "Colleen", "Lehner", "775-815-9879", "JxsEoJ_oEt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hilpert, Lehner and Wintheiser", "Daron.Jacobi@yahoo.com", "Macy", "Padberg", "284-955-9957", "hORmgXwZNo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Windler, Brown and Emard", "Shyann.Gorczany29@gmail.com", "Estevan", "Brekke", "727-811-4458", "qx4YpF3IzL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Beer - Schimmel", "Makenna.Lemke@yahoo.com", "Mervin", "Metz", "268-467-8331", "0EGNEx7VlX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Barton Inc", "Jeramy.Boyer73@gmail.com", "Keira", "O'Connell", "831-496-1994", "9qgWu1FLWN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Blanda, Effertz and Olson", "Dortha6@gmail.com", "Murl", "Reynolds", "654-658-0013", "tPb0P0CG1R" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Abernathy Inc", "Jean59@hotmail.com", "Haylee", "Pfannerstill", "923-895-5014", "UHbKqQSOyx" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Mraz LLC", "Wellington.Larkin@gmail.com", "Myles", "Gaylord", "851-976-1549", "wlVBP47cdV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Avery40@yahoo.com", "Torey", 1, "Cummings", "4Ti7dTQt7Y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Candice86@gmail.com", "Herbert", 3, "Leannon", "Ds9yLUd3lN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cristina8@hotmail.com", "Antone", "Stroman", "1PlOGAppKD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Jena_Feeney@yahoo.com", "Estell", 1, "Harvey", "YRT0Ap29MN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Brando_Hirthe47@gmail.com", "Hilbert", "Schamberger", "Hb335zmF__" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Verda49@gmail.com", "Adele", "Ruecker", "OIczgkNQhA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Kaela.Welch79@gmail.com", "Greta", 3, "Boyle", "eisb_z3EQd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Zena_Ferry@gmail.com", "Shayna", 1, "McCullough", "1iDGh94Kfr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Allison.Marks@gmail.com", "Hilario", 2, "Abernathy", "7CkhSIJkCr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Euna55@gmail.com", "Gabriel", 3, "Rodriguez", "eReUmAbHV6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Bria.Weissnat@hotmail.com", "Hiram", "Mertz", "kJnipV1Kwi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Lonny_Bauch18@gmail.com", "Ruben", "Romaguera", "bVqHk3tSnS" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Shyann39@gmail.com", "Jarrell", "Lubowitz", "mQ8uKRm_ax" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Deshawn56@yahoo.com", "Kasey", "Schuppe", "v58D4UNbEB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Flo60@gmail.com", "Ima", "Willms", "5M54ROcF9b" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Gust.Hauck62@hotmail.com", "Novella", "Feest", "21WyeSpuiC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Elissa.Schultz29@yahoo.com", "Imogene", "Funk", "c7htrqW4dv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Lenna50@gmail.com", "Eloise", "O'Reilly", "fZZGGvsbLm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Sheldon78@gmail.com", "Jermaine", "Emard", "4JttMn14jC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Oda.Rohan79@yahoo.com", "Nils", "Emmerich", "GqOQzxAjbI" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "17TF4SCZQBXD10731", "Volkswagen", 1, "Explorer", 22000, null },
                    { "301CZU713VLD27705", "Volkswagen", 3, "Beetle", 35000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "5FMDGQBT5FT749392", "Nissan", 1, "Fiesta", 14000, null },
                    { "B1DEEPV45AVS13496", "Bentley", 1, "LeBaron", 1000, null },
                    { "BVU1IAF6MCW560878", "Fiat", 2, "1", 35000, null },
                    { "HT6X0X7ZFZDJ50869", "Polestar", 2, "Taurus", 15000, null },
                    { "NOL2TOZHW8DM34396", "BMW", 1, "CTS", 9000, null },
                    { "NYF1LBDPXTJ721904", "Smart", 3, "Element", 11000, null },
                    { "QQEZEYIGIZWV25882", "Smart", 3, "1", 26000, null },
                    { "SFYJHN13AOQC62152", "Bentley", 1, "Accord", 8000, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_LoadAddressId",
                table: "Address",
                column: "LoadAddressId",
                unique: true,
                filter: "[LoadAddressId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Deliveries_LoadAddressId",
                table: "Address",
                column: "LoadAddressId",
                principalTable: "Deliveries",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Deliveries_LoadAddressId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_LoadAddressId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "17TF4SCZQBXD10731");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "301CZU713VLD27705");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "5FMDGQBT5FT749392");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "B1DEEPV45AVS13496");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "BVU1IAF6MCW560878");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "HT6X0X7ZFZDJ50869");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "NOL2TOZHW8DM34396");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "NYF1LBDPXTJ721904");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "QQEZEYIGIZWV25882");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "SFYJHN13AOQC62152");

            migrationBuilder.DropColumn(
                name: "LoadAddressId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LoadDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "LoadAddressId",
                table: "Address");

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Micheal42@hotmail.com", "Isabella", "Langworth", "Ge2NQfbWHU" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Estefania.Treutel@gmail.com", "Name", "Zboncak", "tSliyvr5lB" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Reina50@hotmail.com", "Oliver", "Tillman", "9BFHDffU9t" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Josefa88@hotmail.com", "Abbigail", 1, "Kuhlman", "dDHIzpK9P7" });

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Theodora.Rosenbaum@hotmail.com", "Lambert", 3, "Boyer", "QWCs_4Uwxg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Cora_Treutel32@gmail.com", "Loyal", 2, "O'Kon", "AnnBguY4jf" });

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
        }
    }
}
