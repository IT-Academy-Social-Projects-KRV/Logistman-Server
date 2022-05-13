using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FirstSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Points",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Points",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3870b76e-d01d-49a2-97b6-618862ed378b", 0, "89c1759d-9c7d-41b5-9ac1-821b89880b94", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antinina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAECFmmiANc6Uq9/mrqLT3VLf6AuTX4+i1c3s8YkYhNZ9rY2wVoopI9lEB5TYeRUUQ2w==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6984), new TimeSpan(0, 0, 0, 0, 0)), "2dcfe1f7-f023-4c6f-ac1c-62833098faac", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23", 0, "08add9fd-39c4-490e-ba45-5b3c76e1d58d", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEKLFvZBI/GS+FW/9Vf/u4jv+BA2AK3dAViZWvvfRQ3aV1GVgvx4NuONH2RHB8/gVMA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6976), new TimeSpan(0, 0, 0, 0, 0)), "13500339-f6c5-474c-b44f-962c80f2a032", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "f5e5ba53-e2fc-4d07-be91-8f488219da70", 0, "73cd61eb-da6f-430a-a6e0-e1740cc1e4da", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEAq6h0Hs6mS38fv9lAYflErjWg141AvEUB0uXMV/u+2DpYQdZF/CsunaCnnK24qjJg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 0, 0, 0, 0)), "b84011d8-d911-44f2-8ef9-687a6901e307", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "c586b47a-e79f-425c-a148-fdf6808b2d3b", 0, "c5725f53-bc8d-413d-8c6b-359f21342919", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEGFsvD1PrzCsHyyH1ye2oRcwzg9eVBhkTkH3b3ub+vbt1wV7RaSeL7FoPgWb82sGAg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6955), new TimeSpan(0, 0, 0, 0, 0)), "f94c1321-ea3f-4642-8036-246a0b4a9fc3", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "2dacf970-cca4-4fbf-8685-a3c75238c32a", 0, "d08cddbe-0748-4e04-8298-5ff34d62db76", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAELtZ0XrQEcC0Kge7EXaCwLCE2eAF34TJp3BGr4AHr3PgI3j1deZJglKrg4GyRPrReg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6945), new TimeSpan(0, 0, 0, 0, 0)), "fb079b4b-ed50-46de-8d71-ce93859eb475", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "24ae36dc-45b7-4efb-9c7e-2641a813703e", 0, "060c2ea9-cdb1-49d3-959e-fa181c686774", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEHeBTh0KLPYLNcmC1wFF0KO96450F/jB1Tf5ZTPsp5rTPskoOh1kLZfHwPm507ugqw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6909), new TimeSpan(0, 0, 0, 0, 0)), "8d6f1ad5-bfc7-4f44-a7fc-d06f34b08bc3", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", 0, "fd70673b-312b-4b2a-89f4-bb4d5e8aef04", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEJL0UkBzj8XwyJ9Nw/1w2ahhhnjwktk8gr4zUThTYmL5HHL2ETrG3hYubbPJeMy5Vw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(3592), new TimeSpan(0, 0, 0, 0, 0)), "ccdb0902-7d1d-4af9-9d09-0f3434150025", "Chorrny", false, "chorrny228@gmail.com" },
                    { "297cac55-efe3-4924-a55f-0b1c16196292", 0, "924b0c2a-d1b3-42df-875a-7881849c59bf", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEOMyehOTDfjP25Ef6Lj8wvmzMHgWPqHxHOYnNK6BigLkzoTJqdOpt5UkzLVIHpU1kg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 9, 27, 46, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 0, 0, 0, 0)), "df259045-efc5-4682-954b-03421ec92f0b", "Eremenko", false, "sergeyeremenko@gmail.com" }
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
                    { 7, "MEDICINES" },
                    { 1, "FOOD" },
                    { 2, "DRINKS" },
                    { 3, "CLOTHING" },
                    { 4, "FOOTWEAR" },
                    { 5, "HYGIENE PRODUCTS" },
                    { 6, "CAMOUFLAGE" }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement" },
                values: new object[,]
                {
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, 28.649229999999999, 0, "Житомирська область", "Житомир" },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, 30.1144958, 0, "Київська область", "Біла церква" },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, 31.561633, 0, "Чернігівська область", "Горбово" },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, 32.158811, 0, "Кіровоградська  область", "Бобринець" },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, 32.030366999999998, 0, "Миколаївська область", "Миколаїв" },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, 32.007182749999998, 0, "Миколаївська область", "Миколаїв" },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, 26.702999999999999, 0, "Хмельницька  область", "Маків" },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, 22.317772999999999, 0, "Закарпатская область", "Ужгород" },
                    { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів" },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, 36.980499999999999, 0, "Донецька область", "Новодонецьк" },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, 35.513638, 0, "Харківська область", "Ульянівка" },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, 35.660035000000001, 0, "Харківська область", "Дніпро" },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, 36.801640999999996, 0, "Донецька область", "Макаровка" },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, 37.3148804, 0, "Донецька область", "Нікольське" },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, 35.021573400000001, 0, "Дніпропетровська область", "Дніпро" },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, 25.386282000000001, 0, "Волинська область", "Луцьк" },
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, 26.257569, 0, " Рівненська область", "Шпанів" },
                    { 1, "місто Остріг, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог" },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, 28.494243999999998, 0, "Вінницька область", "Вінниця" },
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, 35.018729, 0, "Дніпропетровська область", "Дніпро" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SENDER" },
                    { 2, "RECIPIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "297cac55-efe3-4924-a55f-0b1c16196292" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "2dacf970-cca4-4fbf-8685-a3c75238c32a" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "3870b76e-d01d-49a2-97b6-618862ed378b" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "c586b47a-e79f-425c-a148-fdf6808b2d3b" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "24ae36dc-45b7-4efb-9c7e-2641a813703e" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "ed986759-5ed1-404b-80d1-aa4d7fa16a1b" },
                    { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "f5e5ba53-e2fc-4d07-be91-8f488219da70" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 2, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 827.7566f, "G 273 N", "8ERJZYUTCJ1Z5MT3B60A", "QXG4V1UNJV3O3TVHM6MJ", "297cac55-efe3-4924-a55f-0b1c16196292", "MLDQ92JTV48WRAYNN" },
                    { 9, 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 639.16455f, "K 186 K", "0XF2E92Q2350B5GHV9FY", "YAHQQH1SHVLWLKLHJ0F3", "297cac55-efe3-4924-a55f-0b1c16196292", "AB3WEQLHKUZ5FPFOC" },
                    { 8, 2, "Білий", new DateTimeOffset(new DateTime(2016, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 812.6773f, "S 281 S", "L0MYFD77IZMUDPL6Y7DS", "GPARVFY3SFLMWYM7XVHA", "297cac55-efe3-4924-a55f-0b1c16196292", "OYLEY3UCHNCF8WPV2" },
                    { 7, 4, "Білий", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 669.0207f, "O 458 G", "6EQ896YRVPI8M274QICG", "ZY2XSQR31N0W804SRJBU", "297cac55-efe3-4924-a55f-0b1c16196292", "4O87JTWOVJ7Y88CSF" },
                    { 6, 2, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 434.1489f, "D 247 S", "B19HF46Y8C4VEH6U5M5R", "ZVVDEMH4DU4XGN8WN6VA", "297cac55-efe3-4924-a55f-0b1c16196292", "M8B7HRL0E4ZEQF6V3" },
                    { 5, 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 917.9577f, "M 820 Q", "KMAXLDON641H2YWV36M7", "6IR15QTXJ0EQGTGHRW8D", "297cac55-efe3-4924-a55f-0b1c16196292", "MDJYWOAE8FVLF2V9S" },
                    { 1, 3, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 879.86194f, "I 641 B", "UJIPU4P418CK1YSCLE8J", "LVX8RR8A8WT4XGE51BH8", "297cac55-efe3-4924-a55f-0b1c16196292", "ABVEE2SKHZ31GYM9Y" },
                    { 2, 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 529.5811f, "X 223 K", "7MLJMA9XZRPLMDDD5HNF", "U1WZGJRDEDDZ5WORSJ5A", "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", "3ARC0WKPQX8PK5QL3" },
                    { 3, 2, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 459.2684f, "N 658 J", "QFPPMKMCD7RYL83JVTPN", "GQFCI07F1RCKHX0XA7Y4", "2dacf970-cca4-4fbf-8685-a3c75238c32a", "UIS65DZKN2TZWZZD6" },
                    { 4, 3, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 403.9624f, "H 645 W", "7HO868NUKJVVXJBUTGH4", "9QI00XX1CRWA9MLPH5SB", "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", "9F132UUQJQSHLGZN7" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 341.95535f, false, "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", 2, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 652.4579f, false, "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", 12, null, new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 787.49286f, false, "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", 14, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 8, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 498.71878f, false, "ed986759-5ed1-404b-80d1-aa4d7fa16a1b", 19, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 207.33945f, false, "24ae36dc-45b7-4efb-9c7e-2641a813703e", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 419.93698f, false, "24ae36dc-45b7-4efb-9c7e-2641a813703e", 7, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 739.81213f, false, "24ae36dc-45b7-4efb-9c7e-2641a813703e", 9, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 297.48154f, false, "24ae36dc-45b7-4efb-9c7e-2641a813703e", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 954.1763f, false, "f5e5ba53-e2fc-4d07-be91-8f488219da70", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 9, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 251.33359f, false, "2dacf970-cca4-4fbf-8685-a3c75238c32a", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 455.82202f, false, "2dacf970-cca4-4fbf-8685-a3c75238c32a", 20, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 309.12473f, false, "c586b47a-e79f-425c-a148-fdf6808b2d3b", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 632.0474f, false, "3870b76e-d01d-49a2-97b6-618862ed378b", 15, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 920.66144f, false, "3870b76e-d01d-49a2-97b6-618862ed378b", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 247.17726f, false, "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 148.89653f, false, "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 646.76105f, false, "c586b47a-e79f-425c-a148-fdf6808b2d3b", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 93.54962f, false, "f5e5ba53-e2fc-4d07-be91-8f488219da70", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, null, new DateTimeOffset(new DateTime(2022, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 482.11383f, false, "c586b47a-e79f-425c-a148-fdf6808b2d3b", 16, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, null, new DateTimeOffset(new DateTime(2022, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 586.28033f, false, "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23", 3, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "24ae36dc-45b7-4efb-9c7e-2641a813703e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "297cac55-efe3-4924-a55f-0b1c16196292" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "2dacf970-cca4-4fbf-8685-a3c75238c32a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "3870b76e-d01d-49a2-97b6-618862ed378b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "c586b47a-e79f-425c-a148-fdf6808b2d3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "ed986759-5ed1-404b-80d1-aa4d7fa16a1b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c13328f8-cdcc-4b78-894d-f01d49a3d3a3", "f5e5ba53-e2fc-4d07-be91-8f488219da70" });

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
                keyValue: 5);

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
                keyValue: "c13328f8-cdcc-4b78-894d-f01d49a3d3a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24ae36dc-45b7-4efb-9c7e-2641a813703e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "297cac55-efe3-4924-a55f-0b1c16196292");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dacf970-cca4-4fbf-8685-a3c75238c32a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3870b76e-d01d-49a2-97b6-618862ed378b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c586b47a-e79f-425c-a148-fdf6808b2d3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd6ceeaf-fe6e-4bd1-9a1c-62fb18bbaa23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed986759-5ed1-404b-80d1-aa4d7fa16a1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5e5ba53-e2fc-4d07-be91-8f488219da70");

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

            migrationBuilder.AlterColumn<float>(
                name: "Longitude",
                table: "Points",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "Latitude",
                table: "Points",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
