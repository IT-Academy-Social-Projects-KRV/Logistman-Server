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
                    { "1eff73a9-1f26-4d95-8423-bea9b6df98b0", "1eff73a9-1f26-4d95-8423-bea9b6df98b0", "Logist", "LOGIST" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "8952a7a4-6184-4e76-bd8a-a3db4193f549", "User", "USER" },
                    { "a34e7390-4b8c-4373-b4f7-27e86e3a6287", "a34e7390-4b8c-4373-b4f7-27e86e3a6287", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "43b3c7ef-239e-4e6d-bd47-6d67140670f3", 0, "ff14fde7-57de-407b-9f65-3e5a57f215a6", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEFUJximgv2QUrBe67KCBk1xiGgW5y/w2MN5Ai2MRXm5H98Ba6dyK0Sf9J72wT+h5lA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 0, 0, 0, 0)), "24db0150-c46c-47ea-b2ff-d988de357200", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15", 0, "a5f61391-062b-4b1c-862c-e20f24286121", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEF0N4SgMxxyBjey+kFoYa4ZUI4OwpiS5wExCkmJeTW0xKwR0igfhVsQnP5xFUkpWnw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 0, 0, 0, 0)), "836de5c3-8b0e-4539-82a8-5552563a7cfd", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "8173152c-0703-42a0-9d0f-026a450d34d5", 0, "25d353b0-94d5-4583-962f-eda6ccef9786", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAELhyRO8myp7ZQTQFGJWfGG8MC/9yv1bXYkvDoDwIiAjyxZegE/D8wzpcqZf3H/dg+A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2850), new TimeSpan(0, 0, 0, 0, 0)), "bff66501-73f6-4247-b6b4-0153b3ea2fdc", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff", 0, "08fb8037-fefc-4539-b12d-baf742dda06b", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEJcEHJelMi/PoI8TJqOZT0VA/msKlX9pisVz7Yms91Uo3SLUAxV0ewefb4Vl19PGkw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2840), new TimeSpan(0, 0, 0, 0, 0)), "dd43bc02-556d-4d8a-8ab2-4921ccb13a1c", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "62fa8f4c-89d7-4ed8-8945-db05b7108165", 0, "6ca313da-f276-4285-bdb6-4d69bfdafa35", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4AN/kd+ic2LyCxdeO9ShjhaC6jt+rMGruLufq/NjfWrEuo+cJPMoPJFLRvJlR5Qg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 0, 0, 0, 0)), "a85901ff-ab1d-491c-88f4-f499c203e980", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "c658d69f-e107-4954-b69f-a3968427a951", 0, "24ff6293-bdbb-4eee-9a00-11be67406d1c", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEB7HuW/MQ56WA74l3UNd0pb+hwXUR3gCJwW30SHyvuLXrGNlNSqdq5cJbvcNRKyC7w==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2822), new TimeSpan(0, 0, 0, 0, 0)), "8c111b0f-a79b-48c2-97e2-68218fc65be1", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "24eb4191-eb07-4f44-8bcf-8662ddd45c1c", 0, "526206ab-2805-4516-b7fc-62faea49a3ba", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEKOV0uxvXtLWxmCkTz8nVV1D6ixBJ94hobraqHbVpjfZPebCM11g+qlp4RDfrhTX9Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(2785), new TimeSpan(0, 0, 0, 0, 0)), "cebf3fbf-f749-4a30-baef-3918631f3205", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "0320f7fb-9ba9-4bf2-b501-cbab3c281113", 0, "c78750c7-2376-4d0b-807d-d3495b3a3b3b", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAECo4qHsOSKfUfpywUV4VpnXOmOdB5uESqAti1ECMfhFhtfDwmjmyvIdxnDkGEOFY/A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 30, 8, 24, 41, 578, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 0, 0, 0, 0)), "04ef5862-758a-4aca-9271-93e780638418", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { "1eff73a9-1f26-4d95-8423-bea9b6df98b0", "c658d69f-e107-4954-b69f-a3968427a951" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "62fa8f4c-89d7-4ed8-8945-db05b7108165" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "8173152c-0703-42a0-9d0f-026a450d34d5" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "24eb4191-eb07-4f44-8bcf-8662ddd45c1c" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "0320f7fb-9ba9-4bf2-b501-cbab3c281113" },
                    { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "43b3c7ef-239e-4e6d-bd47-6d67140670f3" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 979.94293f, "Ford,F350 Super Duty Super Cab, Pickup", "AZ0CU8QBEJZEK4GWY5XI", "ITOWONDTV3Y7YIX83ZY3", "43b3c7ef-239e-4e6d-bd47-6d67140670f3", "X382Y3SWXN4ZYHB4O" },
                    { 7, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 681.96454f, "Jeep,Wrangler, SUV", "LXU5QCPQGA5I0US0DA9V", "KDO19X9795A456L2OYQA", "43b3c7ef-239e-4e6d-bd47-6d67140670f3", "884BSCORCM7HI89TV" },
                    { 5, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 974.9352f, "Ford,F350 Super Duty Crew Cab, Pickup", "XZNDGUUZ57L2FP44RDJ7", "CHD5DFSZWXYAUQBOR28D", "43b3c7ef-239e-4e6d-bd47-6d67140670f3", "OYD2X0YMV5QDZFLH0" },
                    { 1, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 439.8654f, "Ford,F250 Super Duty Super Cab, Pickup", "PFD9GP2C7GKWP3V9PHJK", "Y1C2MM0W0FPZMDSATLE4", "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15", "HHDDK5IEL9408O2AM" },
                    { 10, 4, "Black", new DateTimeOffset(new DateTime(2016, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 814.2673f, "Nissan,TITAN XD Crew Cab, Pickup", "OFMI3927ZUDFU8USKOU6", "K79M5HH8R6C6BB90OWRB", "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff", "3N8HNWGWVTV38G6ZC" },
                    { 2, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 965.6982f, "Ford,F350 Super Duty Crew Cab, Pickup", "SQL9CAKG32FI5KVP92UD", "MUGUM447JYKEWHORS37V", "0320f7fb-9ba9-4bf2-b501-cbab3c281113", "H6OH347LDRVTQY9QM" },
                    { 4, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 656.7233f, "Porsche,911, Convertible, Coupe", "PU9UL1KI9KRW9DWMOO5H", "HYRJ72R06CK4ISI2MJHJ", "0320f7fb-9ba9-4bf2-b501-cbab3c281113", "8NEGP7SUU6Y4DQ2QM" },
                    { 9, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 751.4808f, "Ford,F350 Super Duty Super Cab, Pickup", "BLRG267SY7UK3VKOLPA0", "Y6A3ZKGXZAR71ZMIGMVW", "62fa8f4c-89d7-4ed8-8945-db05b7108165", "YGAFVLQF3HLWH4AOG" },
                    { 3, 3, "Green", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 468.03946f, "Porsche,Cayenne, SUV", "5H0MNV3X5UYFND964000", "XKTJ2RQH2GZPK1BOOVG8", "62fa8f4c-89d7-4ed8-8945-db05b7108165", "7WWD2L0KI76CZKOHJ" },
                    { 6, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 711.78265f, "Jeep,Wrangler, SUV", "89B7PEFCO569HSESBIR0", "A1SKHRW2927B3RGP1V8M", "24eb4191-eb07-4f44-8bcf-8662ddd45c1c", "70J4HM6PPIATT6HRP" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 30, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Welch, Cummerata and Runolfssoncopying Security withdrawal Extensions calculate cross-platform bluetooth Division Port Personal Loan Account Berkshire navigating Rand bypass hack Interactions New York.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 690.824f, false, "62fa8f4c-89d7-4ed8-8945-db05b7108165", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 30, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Wisozk - Cormierwithdrawal Directives Trace Multi-lateral strategic Berkshire Ergonomic Wooden Bike Saudi Riyal Fresh Clothing & Tools Shoes grid-enabled reciprocal e-services Open-source invoice Planner Dynamic Response parsing Compatible connecting Ford Internal portal.", new DateTimeOffset(new DateTime(2022, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 112.224785f, false, "0320f7fb-9ba9-4bf2-b501-cbab3c281113", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Willms, Greenfelder and DaughertyResearch cyan multi-byte Netherlands Antillian Guilder Health & Music Virginia Branding RSS Investment Account Dynamic West Virginia parsing calculating leverage Producer models deploy.", new DateTimeOffset(new DateTime(2022, 7, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 659.24475f, false, "0320f7fb-9ba9-4bf2-b501-cbab3c281113", 12, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Jast, Kiehn and Kunzeorchid Industrial, Tools & Tools Pa'anga Liberian Dollar cross-media Utah Designer Movies Sleek Wooden Chicken Movies, Toys & Automotive Home Loan Account Branding Steel Accounts Garden plug-and-play invoice De-engineered transform bandwidth functionalities Cotton Rwanda Franc Gabon Specialist transparent hack Sleek.", new DateTimeOffset(new DateTime(2022, 7, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 690.0195f, false, "0320f7fb-9ba9-4bf2-b501-cbab3c281113", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 26, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Oberbrunner - Mohrstrategize purple back up extensible Berkshire Incredible back-end embrace Sports Producer cross-platform Granite Unbranded Wooden Bike Gorgeous Solutions navigating Gorgeous Cotton Chicken tan transmit EXE Cambridgeshire Handcrafted Applications Stream Savings Account Centers Generic Drive maroon orchestrate.", new DateTimeOffset(new DateTime(2022, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 143.70862f, false, "0320f7fb-9ba9-4bf2-b501-cbab3c281113", 19, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Stamm, Larson and BernierPitcairn Islands Markets repurpose Senior Delaware e-markets Rest compelling Home Loan Account payment interactive Reunion Fords Borders matrix overriding motivating Crossroad Licensed Frozen Chips Forint Program Checking Account intranet AI Concrete copying.", new DateTimeOffset(new DateTime(2022, 7, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 429.60556f, false, "43b3c7ef-239e-4e6d-bd47-6d67140670f3", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Abshire, Hand and RunteCredit Card Account Metrics out-of-the-box Malaysian Ringgit copying convergence Mexican Peso Fantastic Cotton Salad User-centric Sleek Concrete Gloves Fantastic Granite Towels Team-oriented microchip copying Handmade Rubber Pizza Awesome Wooden Salad coherent Alaska.", new DateTimeOffset(new DateTime(2022, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 562.2368f, false, "24eb4191-eb07-4f44-8bcf-8662ddd45c1c", 6, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 29, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bruen - KuphalMetrics Decentralized compelling Extensions withdrawal Italy generate SMS digital 3rd generation back up online online Ports Small Representative Vision-oriented Senior website Kansas Hills aggregate Germany.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 986.077f, false, "24eb4191-eb07-4f44-8bcf-8662ddd45c1c", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kutch - WestPine Gorgeous Soft Shoes modular bypassing e-markets backing up Refined Steel Chair framework Rue channels redefine optimize Human yellow matrix Manor Louisiana repurpose Handmade Plastic Chair Chief discrete Sudanese Pound Plains plum Reunion fuchsia IB Concrete Palladium Response.", new DateTimeOffset(new DateTime(2022, 7, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 286.24158f, false, "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15", 20, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 30, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Walker - FramiOrganized Agent lavender partnerships Direct communities Personal Loan Account Fully-configurable Seychelles Nauru port Plains Sleek Cotton Towels firewall Route withdrawal Street solutions indexing.", new DateTimeOffset(new DateTime(2022, 7, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 104.32187f, false, "62fa8f4c-89d7-4ed8-8945-db05b7108165", 5, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Fahey, Strosin and Cristcopying Directives empowering gold Intuitive killer Burgs Strategist China Cambridgeshire Sri Lanka Rupee quantify Berkshire calculate Handcrafted Granite Bacon generate Frozen systems Buckinghamshire.", new DateTimeOffset(new DateTime(2022, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 871.1951f, false, "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15", 15, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ullrich - Crooks6th generation Granite calculate New Leu programming Cotton Concrete 24/7 Health & Movies strategic invoice Forward portals Small Cotton Hat Auto Loan Account.", new DateTimeOffset(new DateTime(2022, 7, 8, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 639.32733f, false, "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15", 4, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hermiston, Grant and RodriguezEl Salvador Colon Customizable monitor withdrawal Syrian Pound best-of-breed Fresh Officer visualize Keys.", new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 518.77606f, false, "24eb4191-eb07-4f44-8bcf-8662ddd45c1c", 10, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Monahan - Okunevahacking Handcrafted navigate target Incredible Rubber Sausages Plains neural Berkshire Investment Account Switchable e-tailers.", new DateTimeOffset(new DateTime(2022, 7, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 339.8364f, false, "8173152c-0703-42a0-9d0f-026a450d34d5", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Mills and SonsSquare monetize bricks-and-clicks portal matrix SMTP Incredible Kuwaiti Dinar Sleek Frozen Canada Nebraska.", new DateTimeOffset(new DateTime(2022, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 924.5663f, false, "8173152c-0703-42a0-9d0f-026a450d34d5", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 30, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hodkiewicz Incgenerating Finland panel orchid Gorgeous ADP back-end International Outdoors Alabama Berkshire.", new DateTimeOffset(new DateTime(2022, 7, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 856.7374f, false, "8173152c-0703-42a0-9d0f-026a450d34d5", 3, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Zulauf, Olson and FunkSmall Plastic Tuna Facilitator cross-media Implementation Bedfordshire Bedfordshire Automated transmit strategy Drives hacking transmit connecting Optional Montana transmitting Gorgeous Plastic Computer calculating Product channels invoice withdrawal Zambian Kwacha Intelligent seize Cambridgeshire purple GB Health, Tools & Kids.", new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 981.6455f, false, "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Wintheiser, Emard and Beahanportal deliver cross-platform multi-byte North Carolina Virginia Arizona Personal Loan Account Planner SMS invoice Kids Bridge port CSS Loaf markets Handmade.", new DateTimeOffset(new DateTime(2022, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 439.11536f, false, "62fa8f4c-89d7-4ed8-8945-db05b7108165", 16, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Boyer and Sonssalmon Lead e-tailers Texas PCI Madagascar models Home Loan Account Point European Monetary Unit (E.M.U.-6).", new DateTimeOffset(new DateTime(2022, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 842.3762f, false, "24eb4191-eb07-4f44-8bcf-8662ddd45c1c", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bosco, Funk and FeestVatu Buckinghamshire index hard drive 6th generation 1080p Assurance relationships feed connecting Avon enable Engineer South Carolina Shoes pixel.", new DateTimeOffset(new DateTime(2022, 7, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 441.846f, false, "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a34e7390-4b8c-4373-b4f7-27e86e3a6287");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "0320f7fb-9ba9-4bf2-b501-cbab3c281113" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "24eb4191-eb07-4f44-8bcf-8662ddd45c1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "43b3c7ef-239e-4e6d-bd47-6d67140670f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "62fa8f4c-89d7-4ed8-8945-db05b7108165" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "8173152c-0703-42a0-9d0f-026a450d34d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8952a7a4-6184-4e76-bd8a-a3db4193f549", "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1eff73a9-1f26-4d95-8423-bea9b6df98b0", "c658d69f-e107-4954-b69f-a3968427a951" });

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
                keyValue: "1eff73a9-1f26-4d95-8423-bea9b6df98b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8952a7a4-6184-4e76-bd8a-a3db4193f549");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0320f7fb-9ba9-4bf2-b501-cbab3c281113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19a8a5e4-f3d0-4d4c-ab83-87d511ed3b15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24eb4191-eb07-4f44-8bcf-8662ddd45c1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43b3c7ef-239e-4e6d-bd47-6d67140670f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62fa8f4c-89d7-4ed8-8945-db05b7108165");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8173152c-0703-42a0-9d0f-026a450d34d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95fe7c1f-81fb-4e77-a7f6-c49c8e6acdff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c658d69f-e107-4954-b69f-a3968427a951");

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
