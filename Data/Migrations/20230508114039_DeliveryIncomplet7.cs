using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_User_IdDispatcher",
                table: "Deliveries");

            migrationBuilder.DropIndex(
                name: "IX_Deliveries_IdDispatcher",
                table: "Deliveries");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "6A9LH2QG4UQF26306");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "AU778B6PJHNZ88743");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "D58D2GU3EBUW83916");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "E6XJ0U58QCVV69017");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "G8X2IUPB1KPV11836");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "HAD4QHODK4RJ80527");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "NPPMV3YSCITE36620");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "ODZMJINVI0C078483");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "VE4BS6JS6VB756830");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "X2UZT04BSUSZ92665");

            migrationBuilder.DropColumn(
                name: "IdDispatcher",
                table: "Deliveries");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Montenegro", "Emardport", "68095-0710", "559", "Lind Hill" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Lesotho", "Cliffordbury", "48127-3662", "6959", "Lempi Viaduct" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Kenya", "East Reilly", "11307-8235", "491", "Noble Highway" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Gabon", "Moenville", "22315-9533", "1071", "Veum Plains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Ghana", "East Jarretfurt", "10871-7876", "23900", "Nienow Forges" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Montenegro", "Manteview", "79700", "949", "MacGyver Ports" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Pakistan", "Dorothychester", "32810", "7134", "Pollich Creek" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Macedonia", "Port Edythville", "76899", "9508", "Carter Drives" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Sierra Leone", "Lake Vernonbury", "50299-3832", "927", "Aufderhar Stravenue" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Denmark", "Eulahbury", "20713", "53740", "Amie Causeway" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Mertz, Wilderman and Aufderhar", "Matt_Mante19@hotmail.com", "Nikolas", "Keeling", "858-479-0214", "SUyoOcZkXA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Labadie - Murphy", "Lemuel54@hotmail.com", "Jacquelyn", "Legros", "971-918-5501", "yF52cVX005" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cummerata and Sons", "Victoria5@hotmail.com", "German", "Block", "241-362-5096", "MBSLEmLoup" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "McLaughlin - O'Connell", "Mavis_Spinka12@hotmail.com", "Darian", "Carroll", "429-789-9146", "RIiGdU_l75" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Crooks and Sons", "Carter.Borer@yahoo.com", "Alfonzo", "Hammes", "812-859-8208", "S6RXgL7puh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lang and Sons", "Zack_Swaniawski@yahoo.com", "Milford", "Crona", "228-463-0101", "yKjSKbkU2L" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kiehn, Osinski and Cummerata", "Garnet31@gmail.com", "Otto", "Bednar", "607-299-7413", "0YrTyiuUq8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Jacobi, Williamson and Torphy", "Jesus.Hansen13@gmail.com", "Shanny", "Parisian", "861-474-4360", "7J4DctO0L9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Trantow, Heidenreich and Kiehn", "Garett_Rowe@yahoo.com", "Marion", "Cormier", "274-355-7659", "tBvK_My3lV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "West, Shanahan and Oberbrunner", "Blair.Fahey@hotmail.com", "Paris", "Ortiz", "352-618-5459", "rXHpCWng7L" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kallie.Franecki@gmail.com", "Hortense", "Leannon", "6D1XmtaZIe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Magnolia_Welch@gmail.com", "Leonor", "Goodwin", "zrqOumfURI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Ken.Collier86@yahoo.com", "Guy", 3, "Mosciski", "ACmS0ifleu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Lindsey_Crooks26@gmail.com", "Arlene", "DuBuque", "qhUeFvWzn6" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Marlen.Fahey@yahoo.com", "Samara", "Pacocha", "aMgU_6hSpX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Lavern_Powlowski@hotmail.com", "Nedra", 1, "Kunde", "UULhrS23tA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Mortimer_Dare@yahoo.com", "Marguerite", "Schiller", "HqZby4FDat" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Maggie_Conroy@gmail.com", "Easter", "Dare", "qFJy29a4pM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jerel_Beatty@hotmail.com", "Nakia", "Sawayn", "zhWk2j52vl" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Leonor45@gmail.com", "Bert", "Lockman", "lSWalt79co" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Magdalena18@hotmail.com", "Charley", "Smitham", "eyCvFaIQdq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Pedro24@hotmail.com", "Kennedy", "Windler", "rSuN_SZKN4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Terence.Lueilwitz10@hotmail.com", "Melody", "Mueller", "BKgrStdFAo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Colby30@hotmail.com", "Hadley", "Schinner", "hpj9rdIYr9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kendrick.Effertz20@yahoo.com", "Ephraim", "Murray", "Jj48Mv2MwT" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hassan_Bruen@hotmail.com", "Luis", "Kovacek", "7qA4h50z1q" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Mark35@gmail.com", "Oran", "Heller", "xZAe9dgH7H" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Mabelle19@yahoo.com", "Emmett", "Block", "1MlJ9y3JqE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Victor.Prosacco63@hotmail.com", "Haylee", "Waters", "j5_qMLYNkm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nicolette57@hotmail.com", "Coleman", "Stanton", "YUajNM6Nef" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "1MJZM5Y3E0IJ49587", "Polestar", 2, "Altima", 12000, null },
                    { "6FN7TDCBHHK571798", "Hyundai", 3, "Impala", 19000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "93VAT6KSO1OZ91304", "Dodge", 2, "Impala", 9000, null },
                    { "9KM26M3XHCKL38702", "Polestar", 3, "Expedition", 39000, null },
                    { "EAYHX72Z7JA374208", "Volvo", 3, "2", 21000, null },
                    { "EXJD2ZQT8XO917918", "Kia", 1, "Fortwo", 13000, null },
                    { "FABYLPDTQLF191872", "Hyundai", 3, "Camaro", 25000, null },
                    { "FWEMA5HONRPV84305", "Hyundai", 1, "Mercielago", 22000, null },
                    { "IKHNBXDNS2SA60703", "Kia", 3, "Aventador", 24000, null },
                    { "P67ELXFIGJD492478", "Mini", 1, "Element", 4000, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "1MJZM5Y3E0IJ49587");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "6FN7TDCBHHK571798");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "93VAT6KSO1OZ91304");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9KM26M3XHCKL38702");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "EAYHX72Z7JA374208");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "EXJD2ZQT8XO917918");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "FABYLPDTQLF191872");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "FWEMA5HONRPV84305");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "IKHNBXDNS2SA60703");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "P67ELXFIGJD492478");

            migrationBuilder.AddColumn<string>(
                name: "IdDispatcher",
                table: "Deliveries",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Australia", "Siennafort", "17340", "9540", "Tyra Cape" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Virgin Islands, British", "Stantonport", "12894-8358", "8447", "Clemmie Loaf" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Dominican Republic", "Ashahaven", "99743-6360", "84627", "Kovacek Club" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Ukraine", "Langborough", "25046", "6997", "McCullough Grove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Palestinian Territory", "East Marciamouth", "82891-6062", "53459", "Laurie Corners" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Republic of Korea", "Corneliusview", "19953", "7445", "Conroy Overpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Nauru", "Wadeshire", "97389", "20767", "Gutmann Extensions" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Andorra", "Aglaeside", "12966", "383", "Kessler Plain" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Saint Helena", "Mantebury", "88531-6222", "23051", "Hegmann Grove" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cocos (Keeling) Islands", "Nehamouth", "67253-1020", "68161", "Thiel Extension" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bahringer, Lakin and Rau", "Rosario.Tromp@hotmail.com", "Gene", "Larkin", "888-805-2530", "qSeVkKO1nn" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Padberg, Kshlerin and Blick", "Ford67@hotmail.com", "Lavada", "Heathcote", "257-287-4774", "pDFn0gPuOX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Douglas, Dickens and Runolfsson", "Sam.Hagenes67@gmail.com", "Clay", "Bruen", "420-901-7710", "0Em9ziD0lX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Baumbach and Sons", "Dillon99@yahoo.com", "Geraldine", "Stark", "228-399-6120", "WcR4uPWQz1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cummings - Stamm", "Yvette.Gutkowski47@gmail.com", "Wilhelm", "Homenick", "743-476-9548", "Vr3pWROTrm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Halvorson, Koelpin and Altenwerth", "Harold_Zieme@hotmail.com", "Dion", "Goyette", "572-251-4812", "AHuOoUmyoY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kuhn - Mohr", "Felipe62@yahoo.com", "Consuelo", "Zieme", "634-767-0995", "UiUOW9_B5i" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Wiza - Fisher", "Josiah_Bergnaum@gmail.com", "Tom", "Ankunding", "733-449-5227", "DAiWHKXT31" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Zemlak, Lemke and Powlowski", "Berta.Barton85@yahoo.com", "Lavinia", "Stanton", "294-518-4196", "UFCl4asu19" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bradtke Inc", "Electa7@gmail.com", "Ellsworth", "Hilpert", "504-953-3710", "LRKPRoeZUM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Leda_Langosh73@yahoo.com", "Ebba", "Wunsch", "KbdvQU8pxw" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Benjamin86@hotmail.com", "Cesar", "Homenick", "QEH1L3IKlN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Faye_Kihn46@hotmail.com", "Dameon", 2, "Streich", "9b0FfN5vDE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Paxton12@gmail.com", "Daisy", "Keebler", "cikM7WJmop" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Lorenza.Schaden@yahoo.com", "Audrey", "Grady", "GCagCPqt0R" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Niko_Turcotte@gmail.com", "Gregoria", 3, "DuBuque", "96uAFQY1ag" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ward_Wunsch@hotmail.com", "Genesis", "Goldner", "qmMu34etHC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Eulalia44@yahoo.com", "Hazle", "Powlowski", "qTSGulnZwh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Juliana.Robel@hotmail.com", "Jaylin", "Kuphal", "D1JapCrAmZ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Elmo.Stiedemann29@gmail.com", "Caleigh", "Haag", "uW6EBuwEBk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Edwardo_Boyle@gmail.com", "Marvin", "Maggio", "f9Z9OxUIZl" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Edyth_Mills40@gmail.com", "Daniella", "Legros", "3nxsZVqpBq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Eusebio.Dibbert73@gmail.com", "Boris", "Nikolaus", "OybgjNnunD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jeffery28@yahoo.com", "Marlee", "Olson", "EULzaTI6DN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Deon.Pfeffer45@hotmail.com", "Alexandria", "Lowe", "0qEpDRrMQp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Earline_Aufderhar@yahoo.com", "Tessie", "Kerluke", "erkA9TFY1n" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Juwan.Hackett94@gmail.com", "Jada", "Collier", "aT5n0CRbLo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vergie_MacGyver10@gmail.com", "Sherwood", "Friesen", "j1VKkZI5ox" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Augustus43@yahoo.com", "Blair", "Ebert", "0Qa1i4ycAi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Rhea_Breitenberg@yahoo.com", "Tony", "Franecki", "E3mVXzlaVQ" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "6A9LH2QG4UQF26306", "Ford", 3, "Spyder", 22000, null },
                    { "AU778B6PJHNZ88743", "Mercedes Benz", 1, "Roadster", 5000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "D58D2GU3EBUW83916", "Aston Martin", 1, "1", 4000, null },
                    { "E6XJ0U58QCVV69017", "Maserati", 3, "LeBaron", 33000, null },
                    { "G8X2IUPB1KPV11836", "Toyota", 1, "Land Cruiser", 19000, null },
                    { "HAD4QHODK4RJ80527", "Fiat", 1, "Spyder", 15000, null },
                    { "NPPMV3YSCITE36620", "Tesla", 1, "Fortwo", 15000, null },
                    { "ODZMJINVI0C078483", "Dodge", 3, "Aventador", 22000, null },
                    { "VE4BS6JS6VB756830", "Ferrari", 2, "Accord", 15000, null },
                    { "X2UZT04BSUSZ92665", "Mini", 2, "Silverado", 29000, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_IdDispatcher",
                table: "Deliveries",
                column: "IdDispatcher");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_User_IdDispatcher",
                table: "Deliveries",
                column: "IdDispatcher",
                principalTable: "User",
                principalColumn: "Matricule");
        }
    }
}
