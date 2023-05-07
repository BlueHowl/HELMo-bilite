using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HELMo_bilite.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Addresses_CompanyAddressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "IdAddress");

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "60",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "China", "South Oceanehaven", "71414-2106", "31801", "Ratke Points" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "61",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Faroe Islands", "Elvabury", "93343-9945", "1077", "Ralph Brooks" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "62",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Albania", "Cindyside", "32601", "4421", "Harvey Underpass" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "63",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Saint Pierre and Miquelon", "Walkerfurt", "46645", "029", "Kling Divide" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "64",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Mozambique", "Hughborough", "73932", "180", "Runolfsson Road" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "65",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Turkey", "Jaceborough", "62353", "29520", "Geovanny Plains" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "66",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Andorra", "North Rigoberto", "81207", "08814", "Leone Prairie" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "67",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Uruguay", "Framiville", "83956-4151", "91280", "Lakin Crossroad" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "68",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Nicaragua", "Laurianebury", "09757-4744", "3839", "Corkery Meadows" });

            migrationBuilder.UpdateData(
                table: "Address",
                keyColumn: "IdAddress",
                keyValue: "69",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Comoros", "New Ulises", "31357-7242", "5382", "Desiree Underpass" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Leuschke - Leffler", "Heber_Rodriguez@hotmail.com", "Melvin", "Rath", "280-623-5988", "EM0U6J7Bry" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Treutel, Torphy and Parisian", "Fermin.Becker35@hotmail.com", "Hester", "Mitchell", "723-283-2272", "Ei2CJxhhOQ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hilpert LLC", "Hudson35@hotmail.com", "Eliseo", "Labadie", "893-890-0860", "9W0b6xwdcE" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lockman, Crist and Turner", "Sage.Shanahan@gmail.com", "Doyle", "Jakubowski", "430-582-0595", "4q77YdrCqU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Schuppe, Waters and Friesen", "Marge74@yahoo.com", "Amanda", "Hodkiewicz", "810-202-6198", "tdcHHBS0QU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Price, Stark and Volkman", "Orie.Walter62@gmail.com", "Clifton", "Deckow", "383-974-2568", "ScyOwgukB5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Russel - Dach", "Ahmad.Strosin38@gmail.com", "Francesco", "Goyette", "227-445-8065", "1JUknVV6h8" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Von and Sons", "Oral_Hoppe33@gmail.com", "Odie", "Willms", "552-787-6932", "b0aLzke8aJ" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cummerata Group", "Carey_Reichert@gmail.com", "Modesta", "Christiansen", "892-526-6511", "ersIwdvCtp" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Lind Group", "Holly_Dicki0@gmail.com", "Zoey", "Ortiz", "934-698-2229", "35ImMmQSag" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "50",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Eloisa72@hotmail.com", "Ava", "Lowe", "dpxdjnK3GA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hazle.Swaniawski44@gmail.com", "Lilla", "Bednar", "U0kuysYVht" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "52",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Clarissa80@hotmail.com", "Nat", "Rosenbaum", "f_6OfP7WG4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Gerhard_Osinski@hotmail.com", "Alexane", "Metz", "TCkeEvk4L9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "54",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Nannie.Schuppe29@gmail.com", "Cesar", "Tillman", "yOZ9qMn1I4" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Orion_Hettinger@yahoo.com", "Max", "Beier", "6Id6PI1bkC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jovan_Koepp48@yahoo.com", "Alvena", "Hoppe", "pLgu8DUc6n" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Leanne_Metz90@hotmail.com", "Judd", "Keebler", "2h6UIn54EU" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "58",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Corrine.OConnell@gmail.com", "Ressie", "Armstrong", "ckkm8GTpxh" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Murphy7@gmail.com", "Trevion", "Sporer", "WhA2yPC3KY" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "40",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Ellis_Kozey@gmail.com", "Verna", "Upton", "Ru4latlJFc" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "41",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Muhammad_Fadel92@yahoo.com", "Arch", "Baumbach", "Ao5ZlGGlAL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "42",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vivian_Bode2@gmail.com", "Colin", "Frami", "dEO4JdOkXd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "43",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Jay.Schuppe66@gmail.com", "Levi", "Macejkovic", "XrCDN06FB7" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "44",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Marianne.Kiehn45@gmail.com", "Coby", "Fay", "A1CvioS5rO" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "45",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Julian.Hodkiewicz@yahoo.com", "Dejuan", "Glover", "sKjv9BeiBs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "46",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Aubree86@yahoo.com", "Eloy", "Jakubowski", "zdsPDRyz5t" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "47",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alyce48@gmail.com", "Mireya", "Baumbach", "1oncDBbfOd" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "48",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Rolando_Jacobson58@yahoo.com", "Raoul", "Bogisich", "u7j2AHvkhD" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Arden.Connelly@gmail.com", "Ignatius", "Leannon", "bAkSPXdDis" });

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId",
                principalTable: "Address",
                principalColumn: "IdAddress",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_CompanyAddressId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "IdAddress");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "60",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Suriname", "South Ernestina", "28387-6071", "42849", "Berge Shores" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "61",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "American Samoa", "Catharinemouth", "89588", "7877", "Emiliano Cove" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "62",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Myanmar", "South Tinaville", "96975", "315", "Gottlieb Corners" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "63",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Equatorial Guinea", "East Eldonshire", "52809-3498", "8999", "Richmond Haven" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "64",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Malawi", "South Susanna", "87414", "234", "Timmy Viaduct" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "65",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Qatar", "Bernhardland", "64338", "554", "Buckridge Dam" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "66",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Kenya", "Mattiemouth", "18117", "9444", "Madisyn Ridges" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "67",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Suriname", "O'Haramouth", "09276", "02406", "Kemmer Cliffs" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "68",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Denmark", "Bernieceland", "99682", "216", "Bernhard Mountain" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "IdAddress",
                keyValue: "69",
                columns: new[] { "Country", "Locality", "LocalityCode", "Number", "Street" },
                values: new object[] { "Seychelles", "New Gonzalo", "50883", "7027", "Mayer Wall" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "70",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Larkin and Sons", "Mike.Thompson39@gmail.com", "Darrin", "Emard", "539-863-4533", "Xgw7zR1yxC" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "71",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Leannon Group", "Linnie3@hotmail.com", "Dovie", "Boyle", "741-716-4122", "yE6Ckxo0EI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "72",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Cronin, Mayert and Ullrich", "Shawna.Breitenberg24@yahoo.com", "Michelle", "Mayer", "621-567-3328", "abKt5Dl1Qe" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "73",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Moore Inc", "Marietta.Muller@yahoo.com", "Roosevelt", "Mitchell", "400-883-1300", "T_oyCv8C6y" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "74",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Quigley, O'Keefe and Rath", "Reina75@hotmail.com", "Gianni", "Effertz", "781-208-4655", "___4f5iAgk" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "75",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Waters - Sipes", "Olin.Yundt90@hotmail.com", "Margarette", "Crist", "303-424-0192", "BR6dkuxfvP" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "76",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Fritsch and Sons", "Emmet.Kulas@gmail.com", "Lizeth", "Ullrich", "870-448-2595", "EMDwIttWd1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "77",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hilpert LLC", "Adell_Becker@gmail.com", "Tito", "Krajcik", "994-333-0350", "NXUbh8v6B_" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "78",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Mills - Leannon", "Antone_Lemke24@gmail.com", "Giuseppe", "Wuckert", "403-976-9428", "UqeXtidOZG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "79",
                columns: new[] { "CompanyName", "Email", "FirstName", "Name", "Number", "Password" },
                values: new object[] { "Hills, Morissette and McKenzie", "Frankie_Lind28@yahoo.com", "Stephan", "Purdy", "267-694-5476", "P5er5vGDpg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "50",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Alene70@gmail.com", "Ronaldo", "Bergnaum", "MkGwzQmnxg" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "51",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Abbie.Durgan@yahoo.com", "Clifton", "Schmeler", "NPSn7Mf8x9" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "52",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Elyse_Kohler@hotmail.com", "Lionel", "Bins", "Z1yPMOCJog" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "53",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Mafalda_Bergstrom13@gmail.com", "Dominique", "Marks", "Jm2IcbiGR1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "54",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Garett.Schuppe@yahoo.com", "Tierra", "Bauch", "TSEukDRJre" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "55",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Brionna.Sauer39@gmail.com", "Emory", "Hirthe", "tpMcyrJZD3" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "56",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Vince_Senger9@hotmail.com", "Tod", "Heathcote", "2G_be6cBNs" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "57",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Gia_Lynch28@hotmail.com", "Giovani", "Wilkinson", "zcVZ77TycI" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "58",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Randy58@yahoo.com", "Gudrun", "Muller", "vToaTB9C_5" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "59",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Sylvan26@gmail.com", "Dennis", "Kirlin", "bFW9tWuMMG" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "40",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Taylor.Shanahan99@gmail.com", "Camden", "Ryan", "pJl4rbrfNA" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "41",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Andre.Kessler36@hotmail.com", "Anjali", "Mohr", "GG5jdeVZtM" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "42",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kassandra_Dicki82@yahoo.com", "Gianni", "Predovic", "VWtt3ZOjYu" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "43",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Hobart.Mayer@yahoo.com", "Jeanette", "Olson", "TZ6VsNmKzL" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "44",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Joel.Goodwin55@yahoo.com", "Jannie", "Reilly", "UlxyLXZJQj" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "45",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Trey_Roob@hotmail.com", "Lori", "Baumbach", "rVOGUDsLol" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "46",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Van96@hotmail.com", "Joey", "Leuschke", "zRYzU5UqJ1" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "47",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Anibal74@yahoo.com", "Creola", "Streich", "qJhKuWBpiX" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "48",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Liana11@gmail.com", "Rachael", "Veum", "YTdZ5wlFUP" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Matricule",
                keyValue: "49",
                columns: new[] { "Email", "FirstName", "Name", "Password" },
                values: new object[] { "Kattie_Spencer@gmail.com", "Kevon", "Kuvalis", "xn1TMgdsFB" });

            migrationBuilder.AddForeignKey(
                name: "FK_User_Addresses_CompanyAddressId",
                table: "User",
                column: "CompanyAddressId",
                principalTable: "Addresses",
                principalColumn: "IdAddress",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
