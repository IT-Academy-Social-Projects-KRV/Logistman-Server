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
                    { "7979dc73-10ea-4de9-ac5b-4ba4b127c37b", "7979dc73-10ea-4de9-ac5b-4ba4b127c37b", "Logist", "LOGIST" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "7139c955-57ae-4546-85d9-7541330c93d4", "User", "USER" },
                    { "9da2a5aa-4cef-4223-be7c-c66e05ba11a2", "9da2a5aa-4cef-4223-be7c-c66e05ba11a2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmEmailToken", "ConfirmEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "35414efd-16a4-449e-b2a8-9770bf43b698", 0, "757f4c5c-7ddc-4d25-b075-8a4c91641e3f", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEEj6B6X5gouykM9Uo4xlqvmrlfZOAhBv3jYFzEbPOwEokcugVFyM1TAXrAUzOAPijg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8317), new TimeSpan(0, 0, 0, 0, 0)), "bdca2d0b-181c-4fa0-b66f-f6950b6d8ae5", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c", 0, "a328a278-c4e4-42f1-ba3c-89d19f737f94", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEFJj5VUdlMKRJv4TU3ItC0ybHlz+7XzygWZDHTSVt2ianUUS6IWMtIlj24KWEqIkrA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8302), new TimeSpan(0, 0, 0, 0, 0)), "b1f06859-fa2b-44d5-a66b-f0dfbc88610d", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "7896e42d-9afd-4525-90fd-53acafa00775", 0, "5c108036-b374-46bc-879e-bf28f3b2eda7", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEDVyZMok9cwM2AX81Ar8lAKbZpG0Ar0Vn+2xT47Ocyo6pih/D2lwjjtiwNpsRzkSiw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8291), new TimeSpan(0, 0, 0, 0, 0)), "177b0b9f-631a-454e-9548-ec12e55f1d1a", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "96878efe-2c05-4810-857a-5959ac7adc38", 0, "a5f3ecf0-48e2-4ce2-8755-e7b560e819c4", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEKixe5TTaGMbmT4GhOsiRJfry9YKMMNy+9v/0xYuoediRKt1fo+oOLTrk130f1OrDg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8279), new TimeSpan(0, 0, 0, 0, 0)), "30f89562-9292-4c16-a139-e0b05886469c", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "5a8f1618-d068-4d18-959b-ddaa1d93764c", 0, "b7936243-0c30-4e23-b316-c2a4ce5f664b", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEHBhUtFq7lMeEEdPKg63oicow0dZ+JEAHiBWYDVetiZrD2XSJj/gbdkkTfW9uqBtkw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8261), new TimeSpan(0, 0, 0, 0, 0)), "23dea56c-7e29-4c40-a2a2-ec2d9dbccfe9", "Kernychna", false, "mapourse@gmail.com" },
                    { "72a85512-0abf-44dc-ada6-9ad6e015787e", 0, "274c3b4f-f543-4116-b69f-05efd2459da9", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEHDrxLPYkp6eSOvloAgzRCsiKBWZHoj2bEGpkha0zXYjYHK5sb+5egqB/mFQ0Dwexw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8248), new TimeSpan(0, 0, 0, 0, 0)), "61de1f84-e68f-4591-8d35-daedf84c7e55", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d", 0, "6dc31a8e-7a02-4a1d-bb33-46a4fa70dc98", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEEcQhfKzZfuEwUMDT0uvJAt06o7cXakPDVwQVQc9AbAoz50vt5C/uLspmtLr0C/Yxw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 0, 0, 0, 0)), "fda6ad79-893e-4a78-8731-e6837e9d2943", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "04e37cf3-407b-4f11-8856-33864cae582d", 0, "4e468c37-d381-4d6c-a780-09e41d008ca4", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEAgo4M3cy2NyK6x+KM6Jrxh7NLlT6rgiv94nNB5/1ijsulKy2e5atnr1NB04U9j9eA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 6, 16, 38, 18, 447, DateTimeKind.Unspecified).AddTicks(6649), new TimeSpan(0, 0, 0, 0, 0)), "3d55dcf4-151d-4738-9e6a-24d8b332f5b5", "Chorrny", false, "chorrny228@gmail.com" }
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
                values: new object[] { 1, "місто Острог, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог", null });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[] { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів", null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7979dc73-10ea-4de9-ac5b-4ba4b127c37b", "72a85512-0abf-44dc-ada6-9ad6e015787e" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "96878efe-2c05-4810-857a-5959ac7adc38" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "5a8f1618-d068-4d18-959b-ddaa1d93764c" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "7896e42d-9afd-4525-90fd-53acafa00775" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "04e37cf3-407b-4f11-8856-33864cae582d" },
                    { "7139c955-57ae-4546-85d9-7541330c93d4", "35414efd-16a4-449e-b2a8-9770bf43b698" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 4, "White", new DateTimeOffset(new DateTime(2016, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 547.0345f, "Ford,F350 Super Duty Super Cab, Pickup", "N7FIZKPZQSKMHZN2MS77", "AH6XNMTVAR2AKJYR6MNQ", "35414efd-16a4-449e-b2a8-9770bf43b698", "OLGQN4L8PXAK751IU" },
                    { 7, 4, "Red", new DateTimeOffset(new DateTime(2016, 7, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 606.1953f, "Nissan,Titan King Cab, Pickup", "PWZ351X1KSFJPIUKULCY", "HLNOQFJ5JXKZ0QX5L3SS", "35414efd-16a4-449e-b2a8-9770bf43b698", "MZM4NBX9FE1D439AC" },
                    { 5, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 978.31647f, "Jeep,Wrangler, SUV", "WLA9LIC19YG0XWW7AX9G", "6PGTAGOSLAAGPECC1SLJ", "35414efd-16a4-449e-b2a8-9770bf43b698", "BLDI3WWJ5EAOV64HZ" },
                    { 1, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 681.4366f, "Ford,F350 Super Duty Crew Cab, Pickup", "ACNMRYCQNM1TY5GABM82", "3BNFTLGAH7N5ZXHCOAO2", "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c", "19S1RJ24YCVQ8YO7T" },
                    { 10, 3, "Green", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 852.68f, "Jeep,Wrangler Unlimited, SUV", "8TIJD4PB89MJPCC7D5G9", "NUWWV0R9VM3TK5GZA3T8", "96878efe-2c05-4810-857a-5959ac7adc38", "P4GZVK82OGSWJEXMN" },
                    { 2, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 970.34515f, "Ford,F250 Super Duty Super Cab, Pickup", "FYVU0N4M1X6LBADNRTW8", "C8AA8OJNGHIKEJLBX7QV", "04e37cf3-407b-4f11-8856-33864cae582d", "XEP4XNBK1CLTW7NKL" },
                    { 4, 2, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 916.468f, "Ford,F350 Super Duty Crew Cab, Pickup", "YN9SGWWI7MX320XD0KHV", "D5UIC4BRGA0NTGHLCRM0", "04e37cf3-407b-4f11-8856-33864cae582d", "9YB162A9LKUJ0TTQG" },
                    { 9, 2, "White", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 834.0456f, "Nissan,Titan King Cab, Pickup", "ZQA1X1VV04HYZTKHXYP9", "2150ZCSQORAYFMPV6OP2", "5a8f1618-d068-4d18-959b-ddaa1d93764c", "PSSM7CG0XE2JLXLA2" },
                    { 3, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 545.48376f, "Jeep,Wrangler Unlimited, SUV", "JEL7RP2QK209TAWL4RVC", "WG6YKNDNCMFRHDEZ3X5Y", "5a8f1618-d068-4d18-959b-ddaa1d93764c", "G9LJ2WRYGK84828NM" },
                    { 6, 2, "White", new DateTimeOffset(new DateTime(2016, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 608.53046f, "Ford,F350 Super Duty Super Cab, Pickup", "YOZBIJJ6ICPHYDUFSDSV", "25W51I58JSFQESCXD7KD", "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d", "N1L6XT916S1NDTSU9" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 27, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Stiedemann and SonsAwesome Street Awesome aggregate Rhode Island mindshare transmitting Books & Movies Checking Account green deposit Belarussian Ruble background payment vortals Quality Frozen syndicate deliverables Beauty, Health & Home firewall online calculating Gorgeous Plastic Soap Beauty, Games & Industrial definition.", new DateTimeOffset(new DateTime(2022, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 557.63684f, false, "5a8f1618-d068-4d18-959b-ddaa1d93764c", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 29, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Rolfson IncIB Auto Loan Account Electronics & Garden Consultant Avon standardization Frozen regional Creative European Unit of Account 17(E.U.A.-17) product utilisation overriding open architecture Valleys white throughput Congo Colorado Tajikistan Metal e-tailers Product Springs PCI digital User-centric Texas Canyon.", new DateTimeOffset(new DateTime(2022, 7, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 581.84503f, false, "04e37cf3-407b-4f11-8856-33864cae582d", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Powlowski - BlockAvon Generic Soft Computer Washington Rustic synthesizing Gorgeous Steel Keyboard Home Loan Account asynchronous embrace Licensed customized Metal middleware Intranet Licensed plug-and-play multi-byte THX synthesize Personal Loan Account policy deposit Kids Practical Frozen Pants ubiquitous.", new DateTimeOffset(new DateTime(2022, 7, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 371.23605f, false, "04e37cf3-407b-4f11-8856-33864cae582d", 12, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Considine, Flatley and Littlescale Oklahoma interface Regional morph transmit wireless GB Sleek Cotton Shoes Handcrafted Wooden Hat matrix synthesizing mint green optical revolutionary complexity Factors Personal Loan Account Cocos (Keeling) Islands Montana Baby, Sports & Health open system Auto Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 81.458534f, false, "04e37cf3-407b-4f11-8856-33864cae582d", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Pacocha, Hoeger and Connconnect Associate alarm China Awesome Concrete Bike Cameroon Liaison hacking Granite Investor deposit California repurpose Product.", new DateTimeOffset(new DateTime(2022, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 886.9942f, false, "04e37cf3-407b-4f11-8856-33864cae582d", 19, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Altenwerth and Sonsoverriding Accountability Kwacha Tenge generating bottom-line Tennessee Metrics Handcrafted Soft Gloves Credit Card Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 93.85981f, false, "35414efd-16a4-449e-b2a8-9770bf43b698", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Dooley - HermistonTasty Frozen Sausages back-end virtual Glens Markets Licensed Cotton Fish Michigan JBOD scalable Credit Card Account auxiliary application synergy navigating Lebanese Pound payment Seychelles Rupee invoice Wooden Fork Danish Krone Rue Investment Account Avon frame.", new DateTimeOffset(new DateTime(2022, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 418.5481f, false, "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d", 6, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Parker, Koepp and LubowitzBrazilian Real deposit synthesizing Accountability tan redefine Locks Automotive deliverables Incredible Generic Cotton Pants Unions Barbados Frozen back-end Trinidad and Tobago Personal Loan Account world-class viral Bedfordshire Village sexy groupware SDD.", new DateTimeOffset(new DateTime(2022, 7, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 261.3997f, false, "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hagenes LLCCorporate withdrawal Gorgeous Investor Computers & Baby capacity solid state New Zealand regional real-time Forint Division Beauty, Clothing & Outdoors optical.", new DateTimeOffset(new DateTime(2022, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 715.99677f, false, "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c", 20, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 21, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Blick - KeeblerPrincipal Accounts circuit Graphical User Interface open-source connect Director Canyon Switchable payment Investment Account Unbranded Extensions.", new DateTimeOffset(new DateTime(2022, 7, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 547.27167f, false, "5a8f1618-d068-4d18-959b-ddaa1d93764c", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Ebert IncADP array deposit Fresh productize RAM payment Product Engineer RSS Small Concrete Shoes Credit Card Account Usability AI holistic utilize Cotton Applications bypassing Run.", new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 495.10312f, false, "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c", 15, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Will GroupTasty Granite Shoes Associate syndicate Cambridgeshire Track Intelligent Soft Cheese bricks-and-clicks protocol Strategist Sleek Granite Bike override green Wooden Awesome Managed Gorgeous Granite Shoes Plastic distributed.", new DateTimeOffset(new DateTime(2022, 7, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 418.11533f, false, "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 21, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Green - CassinGeneric Cotton Branch Auto Loan Account human-resource Borders Gorgeous Frozen Pizza Lithuanian Litas copy yellow Berkshire withdrawal iterate.", new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 710.1935f, false, "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d", 10, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 29, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Torp - SatterfieldTugrik e-enable Executive supply-chains Fresh purple North Dakota backing up invoice Ergonomic Wooden Towels methodology methodologies Handcrafted Soft Soap deposit Iowa Greens Dynamic Savings Account Strategist Cotton.", new DateTimeOffset(new DateTime(2022, 7, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 983.3381f, false, "7896e42d-9afd-4525-90fd-53acafa00775", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Friesen IncGorgeous Auto Loan Account invoice Buckinghamshire Technician Directives Faroe Islands action-items matrix Licensed reboot Extended Movies & Electronics Cotton efficient port Gorgeous Granite Gloves bluetooth one-to-one facilitate Borders haptic open-source eyeballs Gorgeous Wooden Mouse Shoes & Games compressing New Mexico 24/365 Fields.", new DateTimeOffset(new DateTime(2022, 7, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 232.47063f, false, "7896e42d-9afd-4525-90fd-53acafa00775", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "D'Amore - KesslerSwitchable transparent multi-byte recontextualize Sleek Rubber Hat overriding Frozen Tools & Baby firewall Lithuania transmitting.", new DateTimeOffset(new DateTime(2022, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 525.07806f, false, "7896e42d-9afd-4525-90fd-53acafa00775", 3, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Sauer - HettingerPersevering SCSI Garden communities platforms engineer Canada hybrid Movies, Electronics & Garden Borders Lead calculate deposit Representative Shoes, Baby & Computers mint green back-end Intranet Portugal Configurable.", new DateTimeOffset(new DateTime(2022, 7, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 468.3591f, false, "96878efe-2c05-4810-857a-5959ac7adc38", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 26, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Turcotte - Handuser-centric Intelligent Soft Chair Decentralized Kids, Outdoors & Shoes withdrawal Guadeloupe Japan reboot convergence Licensed Steel Fish web services Stravenue Ports payment dedicated monitor optical mindshare Liechtenstein optical Customizable Bermuda Practical Tennessee National.", new DateTimeOffset(new DateTime(2022, 7, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 3.8011658f, false, "5a8f1618-d068-4d18-959b-ddaa1d93764c", 16, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kuvalis LLCSleek Delaware parse Locks Auto Loan Account Integration Profit-focused Ergonomic Refined Plastic Table Shores Rubber Plastic Identity Practical microchip Berkshire yellow Buckinghamshire microchip generate Credit Card Account Liaison panel Generic Manager Intelligent Cotton Pants blockchains Industrial & Computers.", new DateTimeOffset(new DateTime(2022, 7, 9, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 366.45535f, false, "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Raynor and SonsPlastic Handcrafted Rubber Pants Moroccan Dirham Sleek Rubber Bike Orchestrator 24/7 GB Practical Supervisor Groves Sports, Movies & Games protocol Electronics SMTP Maine bluetooth invoice reboot payment Response magnetic leading-edge Personal Loan Account Research Legacy UIC-Franc Netherlands best-of-breed Passage.", new DateTimeOffset(new DateTime(2022, 7, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 944.4043f, false, "96878efe-2c05-4810-857a-5959ac7adc38", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9da2a5aa-4cef-4223-be7c-c66e05ba11a2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "04e37cf3-407b-4f11-8856-33864cae582d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "35414efd-16a4-449e-b2a8-9770bf43b698" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "5a8f1618-d068-4d18-959b-ddaa1d93764c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7979dc73-10ea-4de9-ac5b-4ba4b127c37b", "72a85512-0abf-44dc-ada6-9ad6e015787e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "7896e42d-9afd-4525-90fd-53acafa00775" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7139c955-57ae-4546-85d9-7541330c93d4", "96878efe-2c05-4810-857a-5959ac7adc38" });

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
                keyValue: "7139c955-57ae-4546-85d9-7541330c93d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7979dc73-10ea-4de9-ac5b-4ba4b127c37b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04e37cf3-407b-4f11-8856-33864cae582d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2ce64f-34ca-4d7c-a10f-5e670b4c837c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35414efd-16a4-449e-b2a8-9770bf43b698");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f492e6b-6ca4-4e6a-9f4d-d5cfea92684d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a8f1618-d068-4d18-959b-ddaa1d93764c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a85512-0abf-44dc-ada6-9ad6e015787e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7896e42d-9afd-4525-90fd-53acafa00775");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96878efe-2c05-4810-857a-5959ac7adc38");

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
