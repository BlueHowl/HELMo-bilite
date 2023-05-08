using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class DeliveryIncomplet45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "UnloadingAddressId",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UnloadingDate",
                table: "Deliveries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UnloadingAddressId",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "90",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Anguilla", "Jamiehaven", "44136-5081", "8203", "Kyleigh Views" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "91",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Cayman Islands", "Lake Bailee", "34380-5585", "0448", "Rey Points" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "92",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Iceland", "Langmouth", "19051-4476", "894", "Rylan Keys" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "93",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mauritius", "Botsfordburgh", "62382-1118", "10847", "Eriberto Park" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "94",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Austria", "Port Jonbury", "09552", "935", "Torp Ville" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "95",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Aruba", "Crystelberg", "85477-8414", "51573", "Frami Centers" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "96",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bulgaria", "Faheyton", "32983", "189", "Mortimer Oval" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "97",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Canada", "Sipesmouth", "53131-3023", "0678", "Gerhold Tunnel" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "98",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Bosnia and Herzegovina", "Markville", "21278", "21203", "Meda Mall" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "99",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Hungary", "Anitaton", "08326", "4013", "Rodriguez Spurs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "100",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Bauch LLC", "Orin42@yahoo.com", "Rocky", "Ebert", "706-845-0400", "4Jeb2igbGV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "101",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Crist Group", "Mona.Cole62@gmail.com", "Crystel", "Kshlerin", "786-548-7926", "ZDHhvnzdgW" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "102",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Treutel, Turner and Lemke", "Rosa.Mante@yahoo.com", "Meagan", "Rippin", "563-216-1273", "EhHV2ELutf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "103",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "McCullough LLC", "Abigale41@hotmail.com", "Mandy", "Barrows", "929-871-8865", "Gko5Re8GzC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "104",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Crist, VonRueden and Robel", "Christine56@yahoo.com", "Dangelo", "Thiel", "687-830-7428", "c7uNnlpw3D" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "105",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Shields LLC", "Morris28@yahoo.com", "Eddie", "MacGyver", "357-218-9160", "oj60W9dQ3W" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "106",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Rolfson, Connelly and Moen", "Crystal_Larkin0@gmail.com", "Gabriel", "Jenkins", "253-250-5579", "LG9fHjbkl1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "107",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Morissette - Towne", "Chloe.Boyle@hotmail.com", "Santa", "Dooley", "390-648-8623", "_atRZLhSGt" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "108",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Barton Inc", "Stephon.Harris@hotmail.com", "Ethyl", "Rice", "270-782-7509", "1thWE2l0Qf" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "109",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Kertzmann - Funk", "Eveline.Walter34@yahoo.com", "Brant", "Gorczany", "433-782-5153", "EXgPstvOt7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "80",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Henderson77@hotmail.com", "Mohamed", 3, "Hudson", "ps9i6r4DZJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "81",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Wilfredo50@hotmail.com", "Sherman", 2, "Halvorson", "NvRzulhF9U" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "82",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Tillman_Renner@yahoo.com", "Faustino", "Streich", "909_JrkAFL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "83",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Phyllis18@hotmail.com", "Emmett", 2, "Kris", "plYQETfPKV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "84",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Brennan40@yahoo.com", "Laurianne", 3, "Marquardt", "OHzyP_kISU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Kathryne75@gmail.com", "Nathan", 1, "Goyette", "S2DpIYjx90" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "86",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Yolanda_Cassin@hotmail.com", "Loren", 1, "Greenholt", "ZOMijlRsii" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "87",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Wilfrid_Corkery23@hotmail.com", "Seamus", "Gusikowski", "uD4zt0QhVv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "88",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Claudia97@hotmail.com", "Rose", 3, "Schmidt", "mj08tGnliv" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "89",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Savanna.Conn@hotmail.com", "Nicolas", 1, "Bins", "D_0pDGfiim" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "61",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Shayna.Kerluke@gmail.com", "Gianni", "Mante", "1FgUC_q0cr" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "63",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hilma73@yahoo.com", "Rigoberto", "Jones", "LeTRGnTRht" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "65",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Napoleon_Baumbach7@yahoo.com", "Mazie", "Heidenreich", "V_30zeRUbb" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "67",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Oceane_Gulgowski56@hotmail.com", "Zack", "Pouros", "Aa0DkfhWu0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "69",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alejandra45@hotmail.com", "Lesly", "McClure", "uaN27sukeQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Osvaldo.Purdy3@yahoo.com", "Macy", "O'Keefe", "d9RGObgQQV" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Darion_Grant89@gmail.com", "Werner", "Parisian", "l_l3si_Cx3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Isaias_Langworth@hotmail.com", "Fidel", "Schumm", "oCdlHshj6A" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nichole_Hodkiewicz@gmail.com", "Giles", "Nader", "0uQNw4rdBq" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hanna.Walker@gmail.com", "Gerardo", "Maggio", "VtJW35w5lK" });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "67IGR099DVY556591", "Volvo", 2, "Sentra", 38000, null },
                    { "6Y1HUZPJA5SB80574", "Jaguar", 2, "Spyder", 10000, null }
                });

            migrationBuilder.InsertData(
                table: "Vehicules",
                columns: new[] { "Plate", "Brand", "IdLicenses", "Model", "Payload", "Picture" },
                values: new object[,]
                {
                    { "7FA7IOIT7IKU37067", "Volvo", 3, "Civic", 36000, null },
                    { "9T64915NZ3BU19883", "Fiat", 3, "Grand Caravan", 38000, null },
                    { "KXOMJ7A7UABW88687", "Porsche", 3, "Mustang", 20000, null },
                    { "OXXQDNRKXLFV36481", "Mini", 3, "2", 13000, null },
                    { "S7P3UHAFKSH298884", "Polestar", 1, "Corvette", 6000, null },
                    { "Y3XC4JLPH2K514062", "Jeep", 2, "Prius", 23000, null },
                    { "YCR739LKFRIW39986", "Fiat", 3, "Focus", 28000, null },
                    { "YUFDPAE3QEOM83916", "Nissan", 1, "PT Cruiser", 40000, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_UnloadingAddressId",
                table: "Address",
                column: "UnloadingAddressId",
                unique: true,
                filter: "[UnloadingAddressId] IS NOT NULL");

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
                name: "FK_Address_Deliveries_UnloadingAddressId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_UnloadingAddressId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "67IGR099DVY556591");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "6Y1HUZPJA5SB80574");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "7FA7IOIT7IKU37067");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "9T64915NZ3BU19883");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "KXOMJ7A7UABW88687");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "OXXQDNRKXLFV36481");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "S7P3UHAFKSH298884");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "Y3XC4JLPH2K514062");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "YCR739LKFRIW39986");

            migrationBuilder.DeleteData(
                table: "Vehicules",
                keyColumn: "Plate",
                keyValue: "YUFDPAE3QEOM83916");

            migrationBuilder.DropColumn(
                name: "UnloadingAddressId",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "UnloadingDate",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "UnloadingAddressId",
                table: "Address");

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
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Brando_Hirthe47@gmail.com", "Hilbert", 2, "Schamberger", "Hb335zmF__" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "85",
                columns: new[] { "Email", "FirstName", "IdCertification", "Name", "Password" },
                values: new object[] { "Verda49@gmail.com", "Adele", 3, "Ruecker", "OIczgkNQhA" });

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
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Zena_Ferry@gmail.com", "Shayna", "McCullough", "1iDGh94Kfr" });

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
        }
    }
}
