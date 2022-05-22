using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "103c5f41-8d61-4fe3-b97e-9e683c666ea3", "103c5f41-8d61-4fe3-b97e-9e683c666ea3", "Logist", "LOGIST" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "User", "USER" },
                    { "0af11548-2ad9-452b-82d3-008f6ec7bbbc", "0af11548-2ad9-452b-82d3-008f6ec7bbbc", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50662ecc-f177-41fb-95b7-5ba272c2a4ce", 0, "531076e1-c2dc-4b87-bd9f-f744c6543d07", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAECXwn6gQIXfDihQR4kgSFH7tiGbTQI6Ie0wd1KI4T0kJtCz3uNstghOyotJx/j4iRg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 0, 0, 0, 0)), "866d6435-e8dc-465c-aab2-d98562eed5e6", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "944e6c2f-7692-4c93-9a9c-81c30905a158", 0, "80d0e30a-7c89-468c-ba1e-d6a65d34c9f9", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAELJahAF+HA3XGUVks0e1fOkLrn6+Oc5sYP4GLSNZlv5S9v45Pm2AjbORaq+Hs4s7bw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5722), new TimeSpan(0, 0, 0, 0, 0)), "32904fce-068d-4e1e-be0a-b8dd581a3efc", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "875c647c-6b1a-468c-97c5-294de8507eb3", 0, "aa28b311-d2e0-4a40-bce0-7c677898ac49", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAECtncuy6W+xCqBdl6E3jBbssjTjTbFyBO6ia72+vUZp/l/vztez37dyrlpcDFh8rEQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5712), new TimeSpan(0, 0, 0, 0, 0)), "d12ee6b3-2fe7-48b7-9304-9f1cabdf8a1b", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "762dd1e0-f2bb-4baa-8f2c-82d6d480df29", 0, "af517b83-d897-44e0-8ed0-1456f71d142d", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEGfZdYx9MfOJbdY3G0J7+hBfdvRDlbVSh795FbygHhs+u2or02H3s7YOLC/0r/9P1Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 0, 0, 0, 0)), "ed22e9f8-4710-43fd-b1c8-966ce6e19782", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "8c17e1ba-57da-4b33-9559-badad2641fc3", 0, "32f29126-6f0e-4cd9-8847-9797ddfaad29", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEI1F66xS4lGwk1VhvFO6IvCSLCKO4JyhROVI7jgVITqf3LjU6qxl1zXW8959MPtjJw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5690), new TimeSpan(0, 0, 0, 0, 0)), "b1d03fa9-2e05-46e5-b5e8-cde3a31cdd10", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", 0, "1d3bef42-6fc1-4f81-8468-3c49a1010067", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAECeci6a6UsJGxnKhbiuNDb4XBQhpbDdjhPdaELzMmWM+LXIaIFeM2LJ3EFcT8faxjQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5680), new TimeSpan(0, 0, 0, 0, 0)), "2d86e35f-e432-4975-bce1-b3339b6b9dc7", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "8b605fbc-b858-4225-8458-aa9715844640", 0, "e168cea8-5413-4199-899d-0cbe6652471a", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4NqdZjvoGntsU42/512QSu58SWo1bgc0GmK3cLgeuVC1nHetdz6/6Lz+bt+0Ageg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(5627), new TimeSpan(0, 0, 0, 0, 0)), "cd880d2c-e349-4444-bfd0-73523394cdb0", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "e7a5c59a-b887-4043-bd3d-71b57733b5aa", 0, "f296b83c-7dbd-4dc9-902c-cb4c0db2fc4c", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEChq9vg2lx2bK57HBw5o3JxDORmpuFEaYXWKY7VYrNRl+YObdZApdJ5DcQP8S3BRQg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 15, 42, 47, 566, DateTimeKind.Unspecified).AddTicks(4435), new TimeSpan(0, 0, 0, 0, 0)), "4d6a94ef-6d6a-4954-9a9f-02fcc5e20fb8", "Chorrny", false, "chorrny228@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "CarCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" },
                    { 3, "C" },
                    { 4, "D" }
                });

            migrationBuilder.InsertData(
                table: "GoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "FOOD" },
                    { 2, "DRINKS" },
                    { 3, "CLOTHING" },
                    { 4, "FOOTWEAR" },
                    { 5, "HYGIENE PRODUCTS" },
                    { 7, "MEDICINES" },
                    { 6, "CAMOUFLAGE" }
                });

            migrationBuilder.InsertData(
                table: "OfferRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "RECIPIENT" },
                    { 1, "SENDER" }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, 26.257569, 0, " Рівненська область", "Шпанів", null },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, 28.649229999999999, 0, "Житомирська область", "Житомир", null },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, 30.1144958, 0, "Київська область", "Біла церква", null },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, 31.561633, 0, "Чернігівська область", "Горбово", null },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, 32.158811, 0, "Кіровоградська  область", "Бобринець", null },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, 32.030366999999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, 32.007182749999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, 28.494243999999998, 0, "Вінницька область", "Вінниця", null },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, 26.702999999999999, 0, "Хмельницька  область", "Маків", null },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, 22.317772999999999, 0, "Закарпатская область", "Ужгород", null },
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, 35.018729, 0, "Дніпропетровська область", "Дніпро", null },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, 36.980499999999999, 0, "Донецька область", "Новодонецьк", null },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, 35.513638, 0, "Харківська область", "Ульянівка", null },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, 35.660035000000001, 0, "Харківська область", "Дніпро", null },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, 36.801640999999996, 0, "Донецька область", "Макаровка", null },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, 37.3148804, 0, "Донецька область", "Нікольське", null },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, 35.021573400000001, 0, "Дніпропетровська область", "Дніпро", null },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, 25.386282000000001, 0, "Волинська область", "Луцьк", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 1, "місто Остріг, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог", null });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "50662ecc-f177-41fb-95b7-5ba272c2a4ce" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "944e6c2f-7692-4c93-9a9c-81c30905a158" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8c17e1ba-57da-4b33-9559-badad2641fc3" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "875c647c-6b1a-468c-97c5-294de8507eb3" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8b605fbc-b858-4225-8458-aa9715844640" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "e7a5c59a-b887-4043-bd3d-71b57733b5aa" },
                    { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "762dd1e0-f2bb-4baa-8f2c-82d6d480df29" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 464.95175f, "X 217 H", "P32QKBZNSEC1HZR7OH9Q", "NGH7TU0P3BDROPPM0JS1", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "KCNUTDKQNUNDN8MUW" },
                    { 9, 3, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 832.46014f, "V 896 Z", "PRPV9A7IYGIC9GPN1PG4", "ZUGDIAYVLT6T87P4C11N", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "SZEQ2ADC3JCR0VACC" },
                    { 8, 2, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 643.97003f, "R 393 B", "JSNOQ288Y4BO0GW054WV", "4GGWLQX0E25LXALNPXMY", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "47FW2WBYX5RGW2CQ2" },
                    { 7, 2, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 650.53705f, "E 903 J", "IEYKBVRLU12LAVJDGL3K", "LXBLCCSHWIZISN7TB8D5", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "8B4GCMC0NU2CRL2D7" },
                    { 6, 3, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 664.8034f, "O 841 Z", "BY3O0DRAMSJ2RYB55VHG", "RABLRN9A4QF0OSE0AEAM", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "O0P7ASO06U3C71NIW" },
                    { 5, 4, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 499.50977f, "Z 785 K", "VKFARIW2HPW3YPPE1LOY", "5KJNAK76HNQL4U1P0AB1", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "IRPYE2A06ZBS9A1R0" },
                    { 1, 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 824.4033f, "S 731 D", "4STOEF723EE7XBONP8OC", "O2DCWYTFPKEAF5GAHK1K", "50662ecc-f177-41fb-95b7-5ba272c2a4ce", "728D5F4WOH1CG1FHS" },
                    { 2, 2, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 738.7338f, "J 573 Z", "4SRUE6474NMVB3ITDASV", "X82PFV0SLXWOO24LDKQQ", "e7a5c59a-b887-4043-bd3d-71b57733b5aa", "WPT63D9M9IKN1VP2F" },
                    { 3, 3, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 676.8f, "Q 262 T", "Y68ZXGSK2BOCCV9RMJYO", "E3108VA56K8MQYUZVEB6", "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", "ICDJD76SJSNHCV58Q" },
                    { 4, 3, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 589.31256f, "J 548 B", "1LE09V87S8FLPMOI3ZE0", "GZ8MZUNN80TK09CXZ6WW", "e7a5c59a-b887-4043-bd3d-71b57733b5aa", "V9W9GL2K2OZHL2DR0" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "next-generation Shores redundant multi-byte Lead overriding silver budgetary management Lithuanian Litas bus Electronics composite reboot Awesome Fresh Computer Auto Loan Account Cambridgeshire Brazilian Real Checking Account Cliff Tools, Movies & Home pixel array Kids, Music & Outdoors Proactive knowledge user Sleek Soft Car Unbranded Concrete Shirt matrix Checking Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 61.76999f, false, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", 2, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Rubber Plastic Small Steel Shoes object-oriented Money Market Account Intelligent Granite Shirt indexing partnerships upward-trending Netherlands Antilles wireless American Samoa supply-chains Prairie local RAM back up Kids & Tools Supervisor vortals.", new DateTimeOffset(new DateTime(2022, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 58.465134f, false, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Radial Avon interfaces index interactive analyzing Taiwan Licensed Handcrafted Soft Chair multi-state viral Solomon Islands Dollar Representative Portugal monitor Garden Gorgeous Soft Soap plum Team-oriented.", new DateTimeOffset(new DateTime(2022, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 395.20547f, false, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Ohio deposit Manat Fantastic 24/7 synthesizing hybrid Corners blue Burundi Franc e-business Tools & Home Executive Product payment Greenland strategize.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 981.36743f, false, "e7a5c59a-b887-4043-bd3d-71b57733b5aa", 19, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "back up Trail Security alliance mobile port scale payment International Credit Card Account Enhanced Texas Wooden Granite Wooden Sports & Electronics TCP Licensed.", new DateTimeOffset(new DateTime(2022, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 795.2876f, false, "8b605fbc-b858-4225-8458-aa9715844640", 6, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Money Market Account Representative Dynamic copy Wooden Montana input parsing programming invoice violet Refined Metal Table Unbranded Wooden Gloves definition Inlet Russian Federation Awesome Concrete Sausages demand-driven Aruban Guilder dot-com.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 323.01862f, false, "8b605fbc-b858-4225-8458-aa9715844640", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "AI Unbranded Small Granite Sausages optical open-source front-end Isle Avon Savings Account compelling Dynamic Generic Plastic Fish customized Spur Sports, Home & Sports mobile Buckinghamshire orange Handmade Turkmenistan exploit invoice Knoll Cotton Global.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 395.407f, false, "8b605fbc-b858-4225-8458-aa9715844640", 9, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "24 hour Integrated panel Norway Wooden platforms Auto Loan Account Operations capacitor SMTP Ergonomic Cotton Salad West Virginia online Administrator matrix withdrawal calculating instruction set payment Wooden global Euro next generation Haven neural transmitting hacking Money Market Account.", new DateTimeOffset(new DateTime(2022, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 847.3365f, false, "8b605fbc-b858-4225-8458-aa9715844640", 10, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "collaborative compress Spur hard drive Tunnel copying multi-byte Soft Hill Shores Libyan Arab Jamahiriya Human payment engineer Home & Jewelery bypassing process improvement calculate Electronics & Shoes Moroccan Dirham Small Rubber Pants Data Heights Papua New Guinea revolutionize Kids, Automotive & Tools Global Intranet.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 18.269161f, false, "762dd1e0-f2bb-4baa-8f2c-82d6d480df29", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Mews Versatile Diverse black Awesome Fresh Cheese Concrete neural-net Small payment Marketing quantify deposit Technician FTP Sleek invoice real-time Handmade Concrete Computer.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 609.37854f, false, "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Architect adapter Israel 24/7 Legacy Usability payment radical revolutionize Architect Awesome Concrete Ball Research Home Circles data-warehouse Alley Security hierarchy payment.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 77.20522f, false, "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f", 20, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "circuit Ergonomic Rubber Cheese Ranch Forward Division Checking Account eyeballs TCP mindshare salmon Forge concept Movies & Books IB Rubber hierarchy Borders Credit Card Account Handcrafted Metal Fish Credit Card Account Consultant Outdoors input.", new DateTimeOffset(new DateTime(2022, 7, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 628.3656f, false, "8c17e1ba-57da-4b33-9559-badad2641fc3", 5, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Center Generic Cotton Mouse National Cotton Malaysian Ringgit programming South Dakota New York Stand-alone parsing Nebraska Secured ROI cross-platform withdrawal Central Branding Bermudian Dollar (customarily known as Bermuda Dollar) Music.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 930.12854f, false, "944e6c2f-7692-4c93-9a9c-81c30905a158", 15, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Ranch Falls withdrawal Factors RAM bus Fords PCI Connecticut Assistant Stream JBOD San Marino Checking Account Bedfordshire Baby & Clothing Multi-lateral withdrawal Nevada Colorado Personal Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 425.77927f, false, "944e6c2f-7692-4c93-9a9c-81c30905a158", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Tasty Technician Progressive Borders Representative out-of-the-box deposit Oklahoma Direct deposit maroon EXE open-source actuating adapter.", new DateTimeOffset(new DateTime(2022, 7, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 864.35956f, false, "875c647c-6b1a-468c-97c5-294de8507eb3", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Mobility Synergistic Open-source engineer programming Islands Ireland Global Arkansas Steel Developer Bedfordshire Future RAM Cotton heuristic initiatives Euro Albania mission-critical Tactics Money Market Account back up Bahraini Dinar Internal.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 297.76202f, false, "875c647c-6b1a-468c-97c5-294de8507eb3", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Plastic teal Plastic Avon overriding programming 6th generation communities Soft needs-based feed International Granite Rustic Wooden Sausages San Marino well-modulated.", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 310.41092f, false, "8c17e1ba-57da-4b33-9559-badad2641fc3", 8, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "demand-driven red Cambridgeshire human-resource Small Soft Ball Solutions Hill systems connect Optimization programming Bedfordshire USB Personal Loan Account multimedia Curve Specialist deposit asynchronous parse.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 568.51733f, false, "762dd1e0-f2bb-4baa-8f2c-82d6d480df29", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "calculating Isle Kids Mill Iraq Auto Loan Account payment feed national productize Direct Plains Handcrafted Fresh Gloves proactive Managed content Unbranded Plastic Table Auto Loan Account strategic Handcrafted Cotton Ball Berkshire Operations pink Supervisor Investor Outdoors, Toys & Clothing capacity Bedfordshire maroon Object-based.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 810.4967f, false, "8c17e1ba-57da-4b33-9559-badad2641fc3", 16, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "azure Garden fuchsia ability hard drive protocol primary Executive website Applications programming Music & Garden Specialist Bedfordshire Corporate hacking Checking Account violet SSL Savings Account deposit Optional Visionary Antigua and Barbuda Avon Incredible Plastic Chair.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 16.921375f, false, "875c647c-6b1a-468c-97c5-294de8507eb3", 3, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0af11548-2ad9-452b-82d3-008f6ec7bbbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "103c5f41-8d61-4fe3-b97e-9e683c666ea3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "50662ecc-f177-41fb-95b7-5ba272c2a4ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "762dd1e0-f2bb-4baa-8f2c-82d6d480df29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "875c647c-6b1a-468c-97c5-294de8507eb3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8b605fbc-b858-4225-8458-aa9715844640" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "8c17e1ba-57da-4b33-9559-badad2641fc3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "944e6c2f-7692-4c93-9a9c-81c30905a158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381", "e7a5c59a-b887-4043-bd3d-71b57733b5aa" });

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecb9730e-36fb-4ca9-8ef8-e8bb5d5f0381");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50662ecc-f177-41fb-95b7-5ba272c2a4ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "762dd1e0-f2bb-4baa-8f2c-82d6d480df29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "875c647c-6b1a-468c-97c5-294de8507eb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b605fbc-b858-4225-8458-aa9715844640");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c17e1ba-57da-4b33-9559-badad2641fc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "944e6c2f-7692-4c93-9a9c-81c30905a158");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4ffba1f-2bad-451a-9ad3-a8e35f1b989f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7a5c59a-b887-4043-bd3d-71b57733b5aa");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OfferRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OfferRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
