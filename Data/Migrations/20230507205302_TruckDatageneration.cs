using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class TruckDatageneration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Licenses_LicensesId",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trucks_LicensesId",
                table: "Trucks");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "99");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "89");

            migrationBuilder.DropColumn(
                name: "LicensesId",
                table: "Trucks");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "90", "Sri Lanka", "Pagacborough", "97440-9992", "108", "Monserrat Crossroad" },
                    { "91", "Azerbaijan", "Gusberg", "59648", "299", "Herzog Way" },
                    { "92", "Jordan", "Frederikport", "08837", "46554", "Greenfelder Vista" },
                    { "93", "Virgin Islands, British", "North Mayra", "51386-4584", "84451", "Fisher Villages" },
                    { "94", "Spain", "Lake Minervahaven", "56592-6804", "77973", "Manuela Stravenue" },
                    { "95", "Lao People's Democratic Republic", "Brennaside", "98042", "741", "Fadel Views" },
                    { "96", "Cayman Islands", "East Emily", "32449-1042", "5037", "Zackary Cliff" },
                    { "97", "Benin", "South Caesar", "28192-1236", "365", "Madonna Mission" },
                    { "98", "Iraq", "West Ernesto", "94433", "880", "Murazik Trail" },
                    { "99", "China", "West Eduardo", "78395", "6609", "Zelda Walk" }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "78410WS0JNZU60252", "Aston Martin", 3, "1", 30000, null },
                    { "9ZVMEQLMYNIT84444", "Aston Martin", 1, "Taurus", 30000, null },
                    { "A2CPHJUFBBXV12437", "Volvo", 2, "911", 5000, null },
                    { "IDEO2MQ4VCVP28531", "Hyundai", 2, "Grand Caravan", 39000, null },
                    { "M54M4VFXXFLC69003", "Tesla", 3, "Impala", 30000, null },
                    { "PGKAZFG8NETR69956", "BMW", 2, "Wrangler", 3000, null },
                    { "POK243CPHZC540896", "Mini", 2, "Colorado", 19000, null },
                    { "SS1GIVD235F537437", "Rolls Royce", 1, "Malibu", 39000, null },
                    { "V1LY16VD4AQV46550", "Tesla", 3, "Volt", 22000, null },
                    { "ZR3SYK40K2SK61953", "Rolls Royce", 2, "Explorer", 16000, null }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jaida_Bosco@yahoo.com", "Effie", "Lind", "caaoXUumpg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ilene_Erdman71@gmail.com", "Jamie", "Gutkowski", "_yG6LY4vhm" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Geraldine_DuBuque@gmail.com", "Dewayne", "Leuschke", "RV1e_AkrIE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Taya.Mann76@hotmail.com", "Kenny", "Steuber", "Rocf4AhWI_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ima.Turcotte28@yahoo.com", "David", "Gerhold", "k6Bq8S9Orv" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "80", "Sammie80@yahoo.com", "Joan", 3, "Abbott", "wW8kvnUpFg", "Dispatcher" },
                    { "81", "Dustin.McClure3@yahoo.com", "Deion", 1, "Wisozk", "i6LGjKxLQR", "Dispatcher" },
                    { "82", "Marcia28@hotmail.com", "Gerhard", 2, "Hamill", "bdwhhgjSB8", "Dispatcher" },
                    { "83", "Leone_Rau73@gmail.com", "Jeremy", 1, "Fisher", "YHdC_vGmZ1", "Dispatcher" },
                    { "84", "Twila.Monahan@gmail.com", "Keagan", 2, "Collier", "aUGgqYHLHg", "Dispatcher" },
                    { "85", "Mossie_Zulauf@hotmail.com", "Bobby", 3, "Schuppe", "ZYD3ZYR873", "Dispatcher" },
                    { "86", "Pansy13@yahoo.com", "Joanny", 3, "Nienow", "yLTwq1D3aJ", "Dispatcher" },
                    { "87", "Juwan_Heller@gmail.com", "Rowan", 2, "Durgan", "HBthoJ0ZRJ", "Dispatcher" },
                    { "88", "Murl46@hotmail.com", "Emile", 1, "Stoltenberg", "P5GFW2kX0n", "Dispatcher" },
                    { "89", "Greg61@yahoo.com", "Maida", 1, "Gottlieb", "YsFBriOOHY", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "71", "Nicolette68@yahoo.com", "Saul", "Reichel", "mRAs_Rn2th", "Driver" },
                    { "73", "Zoie36@yahoo.com", "Stacy", "Hermiston", "Aax1q8oJvQ", "Driver" },
                    { "75", "Destinee_Dach@yahoo.com", "Margarette", "Ruecker", "XOzxFlYsaP", "Driver" },
                    { "77", "Levi.Hessel92@hotmail.com", "Brandy", "Powlowski", "OZfoNNlfUr", "Driver" },
                    { "79", "Tobin.Fritsch@hotmail.com", "Elian", "Kohler", "DDoLGY8Zw7", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "100", "90", "Berge - Sporer", "Thora.Kuvalis56@hotmail.com", "Terry", "McKenzie", "483-506-7101", "p8SHolxZeU", "Client" },
                    { "101", "91", "Towne - Hilll", "Wilburn_Bartoletti@yahoo.com", "Vern", "Hand", "202-595-3449", "Kkg_2eOKfS", "Client" },
                    { "102", "92", "Vandervort - Johnston", "Rosa.Carter@yahoo.com", "Gayle", "Boehm", "323-641-5750", "f59UIHJ7j4", "Client" },
                    { "103", "93", "Sporer, Stroman and Kautzer", "Demarco_Parisian77@hotmail.com", "Armani", "Morissette", "870-216-2710", "oduD0m2H9B", "Client" },
                    { "104", "94", "Beahan - Mayert", "Annie.Quitzon@hotmail.com", "Constantin", "Lemke", "981-755-8271", "Uc9yFL9zBo", "Client" },
                    { "105", "95", "Okuneva and Sons", "Mitchell_Schaden38@gmail.com", "Demario", "Maggio", "877-270-3613", "Jggu5bibiQ", "Client" },
                    { "106", "96", "Terry, Bode and Kutch", "Kory_Emard1@gmail.com", "Jessyca", "Jakubowski", "548-897-9723", "ksWRJVcUH3", "Client" },
                    { "107", "97", "Hills - Bashirian", "Iliana_Pacocha@yahoo.com", "Aurelia", "McGlynn", "883-677-3964", "S8BCh5Yrar", "Client" },
                    { "108", "98", "Bauch, Rau and Rath", "Ali_Feest@gmail.com", "Maryjane", "Sauer", "872-425-8960", "MsuwzmUrw7", "Client" },
                    { "109", "99", "Greenfelder - Harris", "Zachery_Hilll70@gmail.com", "Hudson", "Hamill", "392-879-3862", "X9A417cftS", "Client" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_IdLicenses",
                table: "Trucks",
                column: "IdLicenses");

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Licenses_IdLicenses",
                table: "Trucks",
                column: "IdLicenses",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Licenses_IdLicenses",
                table: "Trucks");

            migrationBuilder.DropIndex(
                name: "IX_Trucks_IdLicenses",
                table: "Trucks");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "78410WS0JNZU60252");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "9ZVMEQLMYNIT84444");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "A2CPHJUFBBXV12437");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "IDEO2MQ4VCVP28531");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "M54M4VFXXFLC69003");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "PGKAZFG8NETR69956");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "POK243CPHZC540896");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "SS1GIVD235F537437");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "V1LY16VD4AQV46550");

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Plate",
                keyValue: "ZR3SYK40K2SK61953");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99");

            migrationBuilder.AddColumn<int>(
                name: "LicensesId",
                table: "Trucks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[,]
                {
                    { "80", "Timor-Leste", "New Hazelmouth", "30183", "102", "Mafalda Wells" },
                    { "81", "Mauritius", "North Aliya", "82500-4341", "0120", "Gene Estates" },
                    { "82", "Seychelles", "South Yasminemouth", "44562-5814", "340", "Johnson Turnpike" },
                    { "83", "Latvia", "Lake Edenburgh", "23000-7070", "7839", "Edward Fields" },
                    { "84", "Falkland Islands (Malvinas)", "East Mozellehaven", "88296-0601", "365", "King Fords" },
                    { "85", "Kuwait", "New Martinechester", "76422", "6390", "Murphy Meadows" },
                    { "86", "Brazil", "East Nia", "76457", "2292", "Anibal Forges" },
                    { "87", "Turks and Caicos Islands", "East Weldonburgh", "38007", "92715", "Jamil Run" },
                    { "88", "Lithuania", "Rodrigueztown", "13739-5139", "1265", "Bauch Villages" },
                    { "89", "Myanmar", "South Darrenshire", "05402", "54891", "Aliya Mill" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nannie2@gmail.com", "Idella", "Skiles", "c0q0X0opUo" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Trystan21@gmail.com", "Muriel", "Ruecker", "IyDX8AhS2V" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cyril28@gmail.com", "Giuseppe", "Miller", "P7pQq10qon" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Cielo.Effertz51@hotmail.com", "Betsy", "Nienow", "qkLKrKDy2A" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Buck_Parisian@yahoo.com", "Ladarius", "Monahan", "wBalHUk8V_" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "70", "Braulio_Simonis@yahoo.com", "Jonatan", 1, "Orn", "Sn4RbNkrgB", "Dispatcher" },
                    { "71", "Marian84@yahoo.com", "Jermain", 2, "Emard", "FbYKyz18VZ", "Dispatcher" },
                    { "72", "Brandy_Hermann76@gmail.com", "Anastacio", 3, "Mosciski", "_mTN520f_d", "Dispatcher" },
                    { "73", "Kole32@yahoo.com", "Lela", 1, "Murazik", "FvdcjJSf2b", "Dispatcher" },
                    { "74", "Randy_Harber@hotmail.com", "Ervin", 1, "Wolff", "O_1KwpvdkE", "Dispatcher" },
                    { "75", "Ramon_Cole@yahoo.com", "Helmer", 2, "Ward", "p9F3IiKszX", "Dispatcher" },
                    { "76", "Maximillian87@yahoo.com", "Eugenia", 1, "Beatty", "ITZ8gyVEc4", "Dispatcher" },
                    { "77", "Bradly3@yahoo.com", "Sanford", 2, "Corwin", "kVykP0QfkL", "Dispatcher" },
                    { "78", "Sally80@gmail.com", "Pink", 3, "Hilpert", "ocsqV3BB9l", "Dispatcher" },
                    { "79", "Nadia25@yahoo.com", "Jamison", 3, "Hegmann", "pc2vRqbZPr", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "51", "Werner76@gmail.com", "Francis", "Satterfield", "1eCP5ZlVSt", "Driver" },
                    { "53", "Kenyatta44@gmail.com", "Rory", "Kautzer", "Q4Av61bfds", "Driver" },
                    { "55", "Destiney_Hand@hotmail.com", "Ashlee", "Collins", "yTdrEiEly_", "Driver" },
                    { "57", "Cooper34@yahoo.com", "Noel", "Haley", "uKAPQsppV0", "Driver" },
                    { "59", "Jaqueline_Stanton@yahoo.com", "Dayna", "Boyle", "RU80DFRML2", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "90", "80", "Greenfelder - Schmeler", "Neil81@gmail.com", "Letitia", "Kirlin", "900-364-2937", "qV28VHvV3j", "Client" },
                    { "91", "81", "Koss - Hintz", "Wendy.Stamm@gmail.com", "Christy", "Schinner", "322-261-3587", "6QTBKSw_9j", "Client" },
                    { "92", "82", "Stark, Luettgen and Johnson", "Julia.Olson@gmail.com", "Chet", "O'Hara", "851-357-3239", "sRECeZkDFK", "Client" },
                    { "93", "83", "Rice, Howe and Oberbrunner", "Arianna.Heller45@yahoo.com", "Rosalind", "Lubowitz", "852-680-6976", "PUwPlXTyyV", "Client" },
                    { "94", "84", "Anderson - Hyatt", "Gus.Herman25@yahoo.com", "Maye", "Blick", "323-249-6000", "Ydksm7GiwY", "Client" },
                    { "95", "85", "Bayer - Bosco", "Bessie.Skiles6@yahoo.com", "Marc", "Tremblay", "991-261-0246", "ZpEBuZvlbw", "Client" },
                    { "96", "86", "Heathcote - Hansen", "Ethan.Skiles32@yahoo.com", "Diego", "Bashirian", "564-248-1772", "LIx80YLshA", "Client" },
                    { "97", "87", "Kilback and Sons", "Leonel_Marvin82@yahoo.com", "Salma", "Schultz", "470-610-1655", "wAFY8yPhBZ", "Client" },
                    { "98", "88", "Bosco Group", "Deron.Ullrich@hotmail.com", "Gianni", "Predovic", "947-987-8661", "wpYya_FxTD", "Client" },
                    { "99", "89", "Harvey LLC", "Harrison.Shields97@gmail.com", "Effie", "Crona", "548-418-6282", "Ko1y6GYksW", "Client" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_LicensesId",
                table: "Trucks",
                column: "LicensesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Licenses_LicensesId",
                table: "Trucks",
                column: "LicensesId",
                principalTable: "Licenses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
