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
                    { "1f0a4268-5dcd-4d46-aa88-0d1784b8fa17", "1f0a4268-5dcd-4d46-aa88-0d1784b8fa17", "Logist", "LOGIST" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "User", "USER" },
                    { "0935268b-06a2-449c-8e4a-a9324c47f4b7", "0935268b-06a2-449c-8e4a-a9324c47f4b7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a5942cf-ec42-40e8-b2ea-decda57825e1", 0, "acfb5d19-a2a9-4ae7-b882-4bb28de1a84c", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEG4FK13VJsFG71oPwyvZ2CzsB+CqwVgLvIpOdI6TIUYFogLUohx+m8Ceyr5o71sAig==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(2074), new TimeSpan(0, 0, 0, 0, 0)), "506de7bd-9d12-4c1f-b840-a8f2fb949ed1", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "980dc472-9edd-4ec0-a9ec-fbf33bffa8d5", 0, "03ab3d15-e008-4a1c-aa06-a78caf6f21f5", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEFT3u+VAn4OYKRYcaE3YACBK6b721O2aEz+azaK2bQX0k6e43QOwSVxH5+c3kyopUA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), "8b0d8da5-b914-4ed5-b517-76cb51fce50e", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "7c8da2cc-96e2-446d-9547-6315ea35ac28", 0, "50eedf75-6d3d-4f19-a341-34afb049b34d", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEMh2vqZLWDHryZveg+kZ6KAo3JHlWp7iYwyPvLr/eP5lD4ipF3ByGScR/VcBHFlHFg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(2023), new TimeSpan(0, 0, 0, 0, 0)), "9e16374a-ab96-4ce7-a21f-7f106ef49cf5", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "4177e658-5333-43cd-ac51-1260c26a64fe", 0, "c00a3fe4-8d1e-466d-8c4a-66de55eb9321", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEAyo5LWCZ7MuYkpcs4tfCGCZZQbpMmhdrKpmtSiZJKnhcqnHYSMRtSpTveHKXUFeZA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(1997), new TimeSpan(0, 0, 0, 0, 0)), "09ffeda2-9631-4e7e-8ecd-5800b0d8e0d2", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "0445929e-685a-45af-93f2-2784891fe9c7", 0, "6c700de1-c9e5-4cc8-8c9c-4a4deadd97f3", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEA40Hq8i2MZtKVsRIpx1AhH54gd61+us8+fjrvA7yTzsjjK0X1l+wlOBv+BGv3BvUQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(1967), new TimeSpan(0, 0, 0, 0, 0)), "a020f6af-440f-4b26-9ae4-f3567ce89c61", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362", 0, "4ed2d9d8-2f26-4b61-a5f0-47ba1b4a78e3", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEJ/QbtNcY52m+04PplyiBLCuVnI+uEIWL0liyeEWhdVNG9x8vSm9+4pkh0bhu9XONg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(1939), new TimeSpan(0, 0, 0, 0, 0)), "cb88bbc9-e006-4d34-b1ad-460f78605fd0", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "ea711007-e129-4f5f-a3e3-769b4ea06a00", 0, "6d29fd2c-b76f-47ca-a69b-9a1297e2fe98", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEMD3c9OtaWmk9eX9GlZ8eB9DVlTyUOsVvKV8WAxWWmyTbm1Qr5OuTOrZ8Gegy0XbHg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 459, DateTimeKind.Unspecified).AddTicks(1818), new TimeSpan(0, 0, 0, 0, 0)), "c287935d-0948-46bf-a0a7-6558060f337f", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "97980051-7ac5-4fec-87fa-97b477272484", 0, "962d1e2e-63e9-4db7-a74c-1f24f3b931cb", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEPkLW6J1XKNOZQvsFOpzfUYvK7cgrNHhhM8clt3befFOkqt3Nkem6BWk/UhFgMbvyw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 15, 12, 37, 23, 458, DateTimeKind.Unspecified).AddTicks(9138), new TimeSpan(0, 0, 0, 0, 0)), "fcfcf4d1-a7e2-4a02-b8d9-6dd921d91476", "Chorrny", false, "chorrny228@gmail.com" }
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
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, 26.257569, 0, " Рівненська область", "Шпанів", null },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, 28.649229999999999, 0, "Житомирська область", "Житомир", null },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, 30.1144958, 0, "Київська область", "Біла церква", null },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, 31.561633, 0, "Чернігівська область", "Горбово", null },
                    { 1, "місто Остріг, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог", null },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, 32.158811, 0, "Кіровоградська  область", "Бобринець", null },
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
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, 25.386282000000001, 0, "Волинська область", "Луцьк", null },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, 32.030366999999998, 0, "Миколаївська область", "Миколаїв", null },
                    { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "SENDER" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "RECIPIENT" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "0a5942cf-ec42-40e8-b2ea-decda57825e1" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "980dc472-9edd-4ec0-a9ec-fbf33bffa8d5" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "0445929e-685a-45af-93f2-2784891fe9c7" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "7c8da2cc-96e2-446d-9547-6315ea35ac28" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "ea711007-e129-4f5f-a3e3-769b4ea06a00" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "97980051-7ac5-4fec-87fa-97b477272484" },
                    { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "4177e658-5333-43cd-ac51-1260c26a64fe" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 3, "Чорний", new DateTimeOffset(new DateTime(2016, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 593.0873f, "K 468 Y", "IR0RBG0CGY9G41JLBIDF", "7PJ0EPLKCXJKO2PLYQHU", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "RXQVOSPCVC0YPT70C" },
                    { 9, 4, "Жовтий", new DateTimeOffset(new DateTime(2016, 5, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 647.64215f, "V 323 F", "VW43IZ726RG70HTWTNKC", "8K49VKTBOSUXGZQHFSA4", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "3Z8CZHTACM8WZBSU8" },
                    { 8, 2, "Синій", new DateTimeOffset(new DateTime(2016, 1, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), true, 472.74176f, "K 702 X", "F73UMUQI7HQS2I3S5Y3W", "7W747FPGPY9UWYEKSYVX", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "O7MEJWT4M1ARPJZZM" },
                    { 7, 4, "Чорний", new DateTimeOffset(new DateTime(2016, 5, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 558.55096f, "W 466 I", "KLRRLQGAFE82L9PZ44YQ", "YCYCVPZGVRHSVHF24DMQ", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "KVURWTIRV9WOC7MFW" },
                    { 6, 3, "Зелений", new DateTimeOffset(new DateTime(2016, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 935.2106f, "E 630 Z", "7WCKNARBVSWU6HST5X7A", "WCE9CVACGGHC9FP62ONR", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "ASZNW58HQIZA2UH37" },
                    { 5, 3, "Сірий", new DateTimeOffset(new DateTime(2016, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), true, 950.19006f, "K 382 I", "7P1WIANGJXQVHFM8528P", "GPLEV7E79YXIZ5UZXDRC", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "UEW2E8A2N05LWI3N0" },
                    { 1, 4, "Жовтий", new DateTimeOffset(new DateTime(2016, 5, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 795.84216f, "V 814 E", "OT4QN9NLV8NYMO033001", "OQN2YPZUF7FO7ZE7IAEW", "0a5942cf-ec42-40e8-b2ea-decda57825e1", "HTRKW4U6YWTRIY52S" },
                    { 2, 2, "Чорний", new DateTimeOffset(new DateTime(2016, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 481.70877f, "E 714 U", "ZQM9SLTM3DT8UADSU099", "JUGHG1GIFMVPT0RUAU1K", "97980051-7ac5-4fec-87fa-97b477272484", "PEPPBRE6FRVF94A5T" },
                    { 3, 4, "Синій", new DateTimeOffset(new DateTime(2016, 5, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 650.487f, "E 521 M", "3FTIJI0ZO4942SRQO497", "3TDRMK41AFT39WL9H8UN", "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362", "7B008C1ZH6W9EA11W" },
                    { 4, 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 2, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), true, 418.05743f, "R 344 H", "5V57I8F9LSBM2RMCSZAY", "N6ZHA7FCVAF3X1U424JR", "97980051-7ac5-4fec-87fa-97b477272484", "BH2OZA9MKZEBMYWNW" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Savings Account Tasty Plastic Bacon Wooden zero administration tan logistical invoice Courts Bermuda Granite Kids & Shoes.", new DateTimeOffset(new DateTime(2022, 6, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 500.17395f, false, "97980051-7ac5-4fec-87fa-97b477272484", 2, null, new DateTimeOffset(new DateTime(2022, 1, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "flexibility Generic Granite Computer infomediaries Associate efficient Rustic Rubber Ball Clothing disintermediate Rubber Handmade payment protocol olive Tasty Fresh Car.", new DateTimeOffset(new DateTime(2022, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 180.31082f, false, "97980051-7ac5-4fec-87fa-97b477272484", 12, null, new DateTimeOffset(new DateTime(2022, 2, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "invoice RSS productize Roads back-end Unbranded Wooden Salad Mandatory SMS Brand withdrawal.", new DateTimeOffset(new DateTime(2022, 5, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 18.720966f, false, "97980051-7ac5-4fec-87fa-97b477272484", 14, null, new DateTimeOffset(new DateTime(2022, 5, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Profound synthesize RSS Port South Africa Awesome Concrete Towels Money Market Account Cambridgeshire Alabama partnerships violet Branding tan functionalities Awesome Frozen Tuna Gorgeous Nepalese Rupee Markets Industrial & Outdoors Investment Account Tasty Rubber Shirt Oregon e-services Avon Valleys Fields web-enabled Proactive.", new DateTimeOffset(new DateTime(2022, 8, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 775.0064f, false, "97980051-7ac5-4fec-87fa-97b477272484", 19, null, new DateTimeOffset(new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Parkway Face to face Borders connect blue Extensions Gorgeous schemas mission-critical platforms Specialist Refined Granite Table application Cape Personal Loan Account Tasty.", new DateTimeOffset(new DateTime(2022, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 787.09515f, false, "ea711007-e129-4f5f-a3e3-769b4ea06a00", 6, null, new DateTimeOffset(new DateTime(2022, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Bosnia and Herzegovina models Lights optical Sweden Personal Loan Account Home & Tools networks Unbranded Steel Chair Practical Granite Computer Sleek Wooden Hat Fiji Dollar Grocery & Electronics hack Small Frozen Sausages Dynamic Associate Generic Granite Salad PNG installation.", new DateTimeOffset(new DateTime(2022, 10, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 507.2459f, false, "ea711007-e129-4f5f-a3e3-769b4ea06a00", 7, null, new DateTimeOffset(new DateTime(2022, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Avenue interactive Knoll Architect compressing navigate Germany Mandatory incentivize Accountability index Incredible Cotton Pizza Unbranded Fresh Bike revolutionize Personal Loan Account Unbranded.", new DateTimeOffset(new DateTime(2022, 8, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 669.97394f, false, "ea711007-e129-4f5f-a3e3-769b4ea06a00", 9, null, new DateTimeOffset(new DateTime(2022, 5, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Vista next generation Auto Loan Account Licensed Cotton Cheese Borders Tasty Frozen Mouse Forest Generic Rubber Salad Assurance Savings Account.", new DateTimeOffset(new DateTime(2022, 8, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 300.46283f, false, "ea711007-e129-4f5f-a3e3-769b4ea06a00", 10, null, new DateTimeOffset(new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Oklahoma communities Usability AI Fantastic synthesize portal Trinidad and Tobago Intelligent Innovative Money Market Account Future Handcrafted Frozen Chicken Forward bypassing Swedish Krona Checking Account mobile program auxiliary India.", new DateTimeOffset(new DateTime(2022, 8, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 140.1205f, false, "4177e658-5333-43cd-ac51-1260c26a64fe", 1, null, new DateTimeOffset(new DateTime(2022, 2, 7, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "maximize scalable Awesome Wooden Chicken methodologies Rustic Cotton Salad Developer primary conglomeration interface Alaska California syndicate niches copying SDD cross-platform Checking Account Ridge.", new DateTimeOffset(new DateTime(2022, 10, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 917.5849f, false, "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362", 11, null, new DateTimeOffset(new DateTime(2022, 5, 7, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "TCP Tasty Steel Keyboard secured line New Jersey Triple-buffered Incredible Plastic Keyboard Dam Data auxiliary panel Intelligent Plastic Computer Soft Berkshire Seamless Singapore Dollar Future-proofed Avon Ergonomic Steel Soap Games hub optimize relationships.", new DateTimeOffset(new DateTime(2022, 6, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 544.8283f, false, "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362", 20, null, new DateTimeOffset(new DateTime(2022, 5, 7, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "calculate Diverse Diverse supply-chains Station maroon Mobility Island withdrawal budgetary management Loaf View Credit Card Account Executive Assistant Electronics, Outdoors & Home demand-driven transition Switzerland backing up toolset web-enabled Metal Arkansas.", new DateTimeOffset(new DateTime(2022, 6, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 258.2349f, false, "0445929e-685a-45af-93f2-2784891fe9c7", 5, null, new DateTimeOffset(new DateTime(2022, 2, 7, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Metal hard drive Frozen white Infrastructure bifurcated connect enhance infomediaries clicks-and-mortar Savings Account Course navigate Tasty Frozen Computer Fundamental Electronics cross-platform implement Supervisor.", new DateTimeOffset(new DateTime(2022, 8, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 191.82733f, false, "980dc472-9edd-4ec0-a9ec-fbf33bffa8d5", 15, null, new DateTimeOffset(new DateTime(2022, 5, 7, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Tenge deposit real-time alliance Money Market Account Markets Utah South Dakota user-centric Intuitive Shoes & Outdoors Belize revolutionary overriding EXE Inlet Borders Unbranded Monaco Handmade dynamic Common Handmade Cotton Pizza.", new DateTimeOffset(new DateTime(2022, 8, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 103.27014f, false, "980dc472-9edd-4ec0-a9ec-fbf33bffa8d5", 4, null, new DateTimeOffset(new DateTime(2022, 5, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "disintermediate primary innovate Generic Knoll copying multi-byte Jersey hacking Handmade Cotton Towels Street optical Hungary Spur convergence Path Corporate Principal Solomon Islands Dollar Frozen hard drive leading edge synergy Rustic transmitting Avon Buckinghamshire Rand instruction set.", new DateTimeOffset(new DateTime(2022, 9, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 202.54924f, false, "7c8da2cc-96e2-446d-9547-6315ea35ac28", 18, null, new DateTimeOffset(new DateTime(2022, 4, 7, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Flat hierarchy indexing Incredible Plastic Computer back up Manors Optional pixel context-sensitive reboot Clothing, Jewelery & Tools bandwidth reboot mobile Louisiana parse Unbranded Concrete Towels Strategist generate International Industrial Practical Cotton Keyboard Operative violet protocol Practical sky blue lavender Unbranded Granite.", new DateTimeOffset(new DateTime(2022, 10, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 601.0029f, false, "7c8da2cc-96e2-446d-9547-6315ea35ac28", 17, null, new DateTimeOffset(new DateTime(2022, 3, 7, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "synergistic Liaison e-enable e-enable Rubber process improvement Movies, Music & Industrial Berkshire Awesome Frozen Mouse invoice Operations Frozen Streamlined SMS pixel Upgradable.", new DateTimeOffset(new DateTime(2022, 9, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 35.695515f, false, "0445929e-685a-45af-93f2-2784891fe9c7", 8, null, new DateTimeOffset(new DateTime(2022, 4, 7, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "compressing installation relationships model Licensed Wooden Gloves Dynamic Codes specifically reserved for testing purposes transmitting Botswana PNG platforms Drive Practical Integration sensor programming firmware open-source.", new DateTimeOffset(new DateTime(2022, 5, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 246.50653f, false, "4177e658-5333-43cd-ac51-1260c26a64fe", 13, null, new DateTimeOffset(new DateTime(2022, 1, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "payment Architect knowledge user mobile mission-critical input compress systemic throughput Granite.", new DateTimeOffset(new DateTime(2022, 5, 7, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 255.86082f, false, "0445929e-685a-45af-93f2-2784891fe9c7", 16, null, new DateTimeOffset(new DateTime(2022, 3, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "microchip Web copy olive redundant Pre-emptive Idaho indexing product Alley JBOD Ergonomic Granite Pants Kansas Automotive & Beauty Toys & Tools Indian Rupee neural hardware adapter reboot Sleek Metal Tuna Oval Books driver hacking users Dynamic convergence Norwegian Krone.", new DateTimeOffset(new DateTime(2022, 9, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 969.0529f, false, "7c8da2cc-96e2-446d-9547-6315ea35ac28", 3, null, new DateTimeOffset(new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0935268b-06a2-449c-8e4a-a9324c47f4b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f0a4268-5dcd-4d46-aa88-0d1784b8fa17");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "0445929e-685a-45af-93f2-2784891fe9c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "0a5942cf-ec42-40e8-b2ea-decda57825e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "4177e658-5333-43cd-ac51-1260c26a64fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "7c8da2cc-96e2-446d-9547-6315ea35ac28" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "97980051-7ac5-4fec-87fa-97b477272484" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "980dc472-9edd-4ec0-a9ec-fbf33bffa8d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06", "ea711007-e129-4f5f-a3e3-769b4ea06a00" });

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
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 1);

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
                keyValue: "ebaf7f30-11ff-4f50-b6e5-bfa278f48b06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0445929e-685a-45af-93f2-2784891fe9c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a5942cf-ec42-40e8-b2ea-decda57825e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4177e658-5333-43cd-ac51-1260c26a64fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b06fdc7-5a2c-4a6c-a81a-ca62d0241362");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c8da2cc-96e2-446d-9547-6315ea35ac28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97980051-7ac5-4fec-87fa-97b477272484");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "980dc472-9edd-4ec0-a9ec-fbf33bffa8d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea711007-e129-4f5f-a3e3-769b4ea06a00");

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

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
