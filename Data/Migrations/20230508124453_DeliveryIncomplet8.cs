using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69");

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

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "LoadAddressId", "Locality", "LocalityCode", "Number", "Street", "UnloadingAddressId" },
                values: new object[,]
                {
                    { "110", "Burundi", null, "Lake Maritza", "22540-7103", "969", "Lakin Well", null },
                    { "111", "Samoa", null, "North Diana", "64035", "8413", "Forrest Coves", null },
                    { "112", "Chile", null, "Robelside", "91692-0336", "3318", "Keshawn Summit", null },
                    { "113", "Senegal", null, "Waelchimouth", "71223", "80825", "Fisher Road", null },
                    { "114", "Haiti", null, "South Bertfort", "71965-0419", "8645", "Skiles Flats", null },
                    { "115", "Martinique", null, "Schusterland", "18082-3791", "0052", "Brionna Walk", null },
                    { "116", "United Kingdom", null, "Lednerfurt", "80830", "764", "Bode Spring", null },
                    { "117", "Haiti", null, "Smithberg", "81778", "8676", "Lucas Lakes", null },
                    { "118", "Chile", null, "Schmidtland", "41971", "4944", "Sawayn Causeway", null },
                    { "119", "Liechtenstein", null, "Adamstown", "04835-9496", "6931", "Kristopher Lane", null },
                    { "140", "Tanzania", null, "Bauchborough", "24442-6689", "9663", "Casandra Greens", null },
                    { "141", "United States of America", null, "Grayceburgh", "92498", "972", "Willms Hill", null },
                    { "142", "Gambia", null, "Kadinshire", "11693", "6467", "Derick Creek", null },
                    { "143", "Benin", null, "East Hermann", "13000-5378", "847", "Ruecker Cove", null },
                    { "144", "Zambia", null, "New Aubree", "61297", "8129", "Erick Fields", null },
                    { "145", "Barbados", null, "Russelland", "91260-4434", "43762", "Dallin Dale", null },
                    { "146", "Vanuatu", null, "Littlestad", "21532", "89870", "Hickle Brooks", null },
                    { "147", "Niue", null, "New Serena", "15055-0974", "17703", "Xavier Rest", null },
                    { "148", "Senegal", null, "South Quincy", "74262", "8378", "Jameson Greens", null },
                    { "149", "Tonga", null, "Satterfieldport", "29361", "893", "Smitham Lights", null },
                    { "150", "Swaziland", null, "Lake Roberto", "56382-5458", "83340", "Bauch Causeway", null },
                    { "151", "Namibia", null, "East Josh", "18272-3663", "13562", "Brennan Passage", null },
                    { "152", "Gabon", null, "Marciabury", "54940-7975", "936", "Oran Bypass", null },
                    { "153", "Venezuela", null, "Framiberg", "55807", "9135", "Mayert Gateway", null },
                    { "154", "United Kingdom", null, "Corwinbury", "42401", "9356", "Prosacco Stravenue", null },
                    { "155", "Timor-Leste", null, "Port Sydnieborough", "75096", "7968", "Daugherty Street", null },
                    { "156", "Turkey", null, "Robertberg", "09708-0755", "0903", "Bessie Flat", null },
                    { "157", "New Caledonia", null, "Jayneside", "04184", "3878", "Heathcote Trail", null },
                    { "158", "Timor-Leste", null, "Brownberg", "39199-3246", "43317", "Hardy Estate", null },
                    { "159", "Spain", null, "Lake Stella", "08299", "6762", "Harmon Mountain", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "100", "Deron_Denesik@hotmail.com", "Liam", 2, "Schultz", "f9n2k0Uhjy", "Dispatcher" },
                    { "101", "Armand82@hotmail.com", "Russ", 2, "O'Hara", "YtY_RelWbz", "Dispatcher" },
                    { "102", "Leone12@gmail.com", "Conrad", 2, "Fisher", "DR0e_yoF3I", "Dispatcher" },
                    { "103", "Rowena_Wisoky@gmail.com", "Rickie", 1, "Becker", "rdANfxMytx", "Dispatcher" },
                    { "104", "Ryann.Nader59@gmail.com", "Jovanny", 1, "Cassin", "Rlwk941nTn", "Dispatcher" },
                    { "105", "Zoey_Prosacco20@hotmail.com", "Stefan", 3, "Wiegand", "ifJYhT583a", "Dispatcher" },
                    { "106", "Jonas_Raynor8@hotmail.com", "Mireille", 2, "Larkin", "nAxlAEX2fv", "Dispatcher" },
                    { "107", "Dane35@yahoo.com", "Queen", 2, "Dare", "q6uEGggAVD", "Dispatcher" },
                    { "108", "Adolf.Runolfsdottir@yahoo.com", "Rowland", 2, "Grady", "H2dKZyY_m6", "Dispatcher" },
                    { "109", "Kenna.Predovic79@gmail.com", "Obie", 3, "Jast", "ndAhVHXr6Z", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "81", "Braeden.Tromp17@hotmail.com", "Dorothy", "Witting", "_ckPUqqxeC", "Driver" },
                    { "83", "Araceli.Weber65@yahoo.com", "Bettie", "Windler", "9n9tun0zgm", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "85", "Mitchel93@yahoo.com", "Jeremy", "Bogan", "B3cJorTTmC", "Driver" },
                    { "87", "Maritza_Rohan@yahoo.com", "Jody", "Trantow", "uFhUzy_Pni", "Driver" },
                    { "89", "Verner_Metz@gmail.com", "Deven", "McLaughlin", "Bvd7UMapAs", "Driver" },
                    { "91", "Rashawn.Rau82@hotmail.com", "Milford", "Treutel", "5j7njjCXWQ", "Driver" },
                    { "93", "Rashad_Denesik99@gmail.com", "Eulalia", "Schneider", "THxKY14x5X", "Driver" },
                    { "95", "Roel8@gmail.com", "Angelo", "Baumbach", "UPYcedRonl", "Driver" },
                    { "97", "Vita_Hackett90@gmail.com", "Claud", "Fisher", "TZhJYvJDi4", "Driver" },
                    { "99", "Hillary70@gmail.com", "Lincoln", "Douglas", "ogrMsE6bkw", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "0QCVS6SGQXPH59993", "Bugatti", 1, "Mustang", 14000, null },
                    { "4TI8S6HWL1IK43079", "Bugatti", 1, "Silverado", 16000, null },
                    { "6HDMWQ9VTRNI17254", "Volkswagen", 2, "Fortwo", 33000, null },
                    { "89MO0LNH93P178738", "Kia", 3, "Malibu", 18000, null },
                    { "B1TM5Q41LWWO51517", "Chevrolet", 2, "Impala", 15000, null },
                    { "DI2NEKZ2GMHD19035", "Maserati", 3, "Fortwo", 10000, null },
                    { "DWIS44PS3QK872829", "Nissan", 3, "Grand Caravan", 8000, null },
                    { "HDLHCGSOGWOZ84838", "BMW", 3, "ATS", 28000, null },
                    { "NT6JJ4O45PQQ99068", "Lamborghini", 2, "V90", 7000, null },
                    { "S5ZBFD9PYNHD83834", "Cadillac", 2, "El Camino", 38000, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "120", "110", "Gislason, Prohaska and Schoen", "Vladimir86@gmail.com", "Wade", "Batz", "571-917-3099", "W92zT0LHMm", "Client" },
                    { "121", "111", "Wuckert, Langosh and Franecki", "Samara71@yahoo.com", "Frederique", "Hickle", "519-331-5548", "Sw75ZNTchH", "Client" },
                    { "122", "112", "Kulas and Sons", "Arvid82@yahoo.com", "Flossie", "O'Reilly", "222-801-9696", "U8QlPp2RHs", "Client" },
                    { "123", "113", "O'Conner LLC", "Alexandria.Kemmer4@yahoo.com", "Eulah", "Hoppe", "326-297-9017", "2jViDRmGp8", "Client" },
                    { "124", "114", "Halvorson, Sporer and Ryan", "Cortney_Moen@yahoo.com", "Elenor", "Rodriguez", "398-618-6554", "ozgo4lgeZX", "Client" },
                    { "125", "115", "Adams Group", "Cordell_Predovic51@gmail.com", "Deshaun", "McLaughlin", "479-648-6729", "pj1Wb4JbdW", "Client" },
                    { "126", "116", "Abshire, Bednar and Mosciski", "Eugene_Zemlak14@yahoo.com", "Jalon", "Donnelly", "878-331-7651", "Aa7cEq0dVG", "Client" },
                    { "127", "117", "Maggio, Armstrong and Williamson", "Joyce_Lind38@hotmail.com", "Aylin", "Schoen", "794-516-7118", "NTwawNSDKK", "Client" },
                    { "128", "118", "Rowe - Predovic", "Queenie.Rice@yahoo.com", "Arden", "Corkery", "219-560-1097", "eEHUGkILYR", "Client" },
                    { "129", "119", "Bernier - Kuvalis", "Flossie80@yahoo.com", "Estel", "Mraz", "383-342-2036", "kpHu40vZhw", "Client" }
                });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "Content", "IdClient", "IdDriver", "IdVehicule", "LoadAddressId", "LoadDate", "UnloadingAddressId", "UnloadingDate", "status" },
                values: new object[] { 1, "livaison 0", "120", null, "DWIS44PS3QK872829", "140", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "141", new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "En cours" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "140");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "141");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "142");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "143");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "144");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "145");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "146");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "147");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "148");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "149");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "150");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "151");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "152");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "153");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "154");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "155");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "156");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "157");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "158");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "159");

            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "121");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "122");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "123");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "124");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "125");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "126");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "127");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "128");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "129");

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
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "99");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "0QCVS6SGQXPH59993");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "4TI8S6HWL1IK43079");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "6HDMWQ9VTRNI17254");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "89MO0LNH93P178738");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "B1TM5Q41LWWO51517");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "DI2NEKZ2GMHD19035");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "HDLHCGSOGWOZ84838");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "NT6JJ4O45PQQ99068");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "S5ZBFD9PYNHD83834");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "111");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "112");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "113");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "114");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "115");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "116");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "117");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "118");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "119");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "120");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "DWIS44PS3QK872829");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "110");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "IdAddress", "Country", "LoadAddressId", "Locality", "LocalityCode", "Number", "Street", "UnloadingAddressId" },
                values: new object[,]
                {
                    { "90", "Montenegro", null, "Emardport", "68095-0710", "559", "Lind Hill", null },
                    { "91", "Lesotho", null, "Cliffordbury", "48127-3662", "6959", "Lempi Viaduct", null },
                    { "92", "Kenya", null, "East Reilly", "11307-8235", "491", "Noble Highway", null },
                    { "93", "Gabon", null, "Moenville", "22315-9533", "1071", "Veum Plains", null },
                    { "94", "Ghana", null, "East Jarretfurt", "10871-7876", "23900", "Nienow Forges", null },
                    { "95", "Montenegro", null, "Manteview", "79700", "949", "MacGyver Ports", null },
                    { "96", "Pakistan", null, "Dorothychester", "32810", "7134", "Pollich Creek", null },
                    { "97", "Macedonia", null, "Port Edythville", "76899", "9508", "Carter Drives", null },
                    { "98", "Sierra Leone", null, "Lake Vernonbury", "50299-3832", "927", "Aufderhar Stravenue", null },
                    { "99", "Denmark", null, "Eulahbury", "20713", "53740", "Amie Causeway", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "IdCertification", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "80", "Kallie.Franecki@gmail.com", "Hortense", 1, "Leannon", "6D1XmtaZIe", "Dispatcher" },
                    { "81", "Magnolia_Welch@gmail.com", "Leonor", 2, "Goodwin", "zrqOumfURI", "Dispatcher" },
                    { "82", "Ken.Collier86@yahoo.com", "Guy", 3, "Mosciski", "ACmS0ifleu", "Dispatcher" },
                    { "83", "Lindsey_Crooks26@gmail.com", "Arlene", 3, "DuBuque", "qhUeFvWzn6", "Dispatcher" },
                    { "84", "Marlen.Fahey@yahoo.com", "Samara", 3, "Pacocha", "aMgU_6hSpX", "Dispatcher" },
                    { "85", "Lavern_Powlowski@hotmail.com", "Nedra", 1, "Kunde", "UULhrS23tA", "Dispatcher" },
                    { "86", "Mortimer_Dare@yahoo.com", "Marguerite", 1, "Schiller", "HqZby4FDat", "Dispatcher" },
                    { "87", "Maggie_Conroy@gmail.com", "Easter", 1, "Dare", "qFJy29a4pM", "Dispatcher" },
                    { "88", "Jerel_Beatty@hotmail.com", "Nakia", 2, "Sawayn", "zhWk2j52vl", "Dispatcher" },
                    { "89", "Leonor45@gmail.com", "Bert", 1, "Lockman", "lSWalt79co", "Dispatcher" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "Email", "FirstName", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { "61", "Magdalena18@hotmail.com", "Charley", "Smitham", "eyCvFaIQdq", "Driver" },
                    { "63", "Pedro24@hotmail.com", "Kennedy", "Windler", "rSuN_SZKN4", "Driver" },
                    { "65", "Terence.Lueilwitz10@hotmail.com", "Melody", "Mueller", "BKgrStdFAo", "Driver" },
                    { "67", "Colby30@hotmail.com", "Hadley", "Schinner", "hpj9rdIYr9", "Driver" },
                    { "69", "Kendrick.Effertz20@yahoo.com", "Ephraim", "Murray", "Jj48Mv2MwT", "Driver" },
                    { "71", "Hassan_Bruen@hotmail.com", "Luis", "Kovacek", "7qA4h50z1q", "Driver" },
                    { "73", "Mark35@gmail.com", "Oran", "Heller", "xZAe9dgH7H", "Driver" },
                    { "75", "Mabelle19@yahoo.com", "Emmett", "Block", "1MlJ9y3JqE", "Driver" },
                    { "77", "Victor.Prosacco63@hotmail.com", "Haylee", "Waters", "j5_qMLYNkm", "Driver" },
                    { "79", "Nicolette57@hotmail.com", "Coleman", "Stanton", "YUajNM6Nef", "Driver" }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "1MJZM5Y3E0IJ49587", "Polestar", 2, "Altima", 12000, null },
                    { "6FN7TDCBHHK571798", "Hyundai", 3, "Impala", 19000, null },
                    { "93VAT6KSO1OZ91304", "Dodge", 2, "Impala", 9000, null },
                    { "9KM26M3XHCKL38702", "Polestar", 3, "Expedition", 39000, null },
                    { "EAYHX72Z7JA374208", "Volvo", 3, "2", 21000, null },
                    { "EXJD2ZQT8XO917918", "Kia", 1, "Fortwo", 13000, null },
                    { "FABYLPDTQLF191872", "Hyundai", 3, "Camaro", 25000, null },
                    { "FWEMA5HONRPV84305", "Hyundai", 1, "Mercielago", 22000, null },
                    { "IKHNBXDNS2SA60703", "Kia", 3, "Aventador", 24000, null },
                    { "P67ELXFIGJD492478", "Mini", 1, "Element", 4000, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Matricule", "CompanyAddressId", "CompanyName", "Email", "FirstName", "Name", "Number", "Password", "Role" },
                values: new object[,]
                {
                    { "100", "90", "Mertz, Wilderman and Aufderhar", "Matt_Mante19@hotmail.com", "Nikolas", "Keeling", "858-479-0214", "SUyoOcZkXA", "Client" },
                    { "101", "91", "Labadie - Murphy", "Lemuel54@hotmail.com", "Jacquelyn", "Legros", "971-918-5501", "yF52cVX005", "Client" },
                    { "102", "92", "Cummerata and Sons", "Victoria5@hotmail.com", "German", "Block", "241-362-5096", "MBSLEmLoup", "Client" },
                    { "103", "93", "McLaughlin - O'Connell", "Mavis_Spinka12@hotmail.com", "Darian", "Carroll", "429-789-9146", "RIiGdU_l75", "Client" },
                    { "104", "94", "Crooks and Sons", "Carter.Borer@yahoo.com", "Alfonzo", "Hammes", "812-859-8208", "S6RXgL7puh", "Client" },
                    { "105", "95", "Lang and Sons", "Zack_Swaniawski@yahoo.com", "Milford", "Crona", "228-463-0101", "yKjSKbkU2L", "Client" },
                    { "106", "96", "Kiehn, Osinski and Cummerata", "Garnet31@gmail.com", "Otto", "Bednar", "607-299-7413", "0YrTyiuUq8", "Client" },
                    { "107", "97", "Jacobi, Williamson and Torphy", "Jesus.Hansen13@gmail.com", "Shanny", "Parisian", "861-474-4360", "7J4DctO0L9", "Client" },
                    { "108", "98", "Trantow, Heidenreich and Kiehn", "Garett_Rowe@yahoo.com", "Marion", "Cormier", "274-355-7659", "tBvK_My3lV", "Client" },
                    { "109", "99", "West, Shanahan and Oberbrunner", "Blair.Fahey@hotmail.com", "Paris", "Ortiz", "352-618-5459", "rXHpCWng7L", "Client" }
                });
        }
    }
}
