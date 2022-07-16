using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

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
                    { "c8d72d4d-28c5-40b6-894f-c1145d11b4d1", "c8d72d4d-28c5-40b6-894f-c1145d11b4d1", "Logist", "LOGIST" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "43226e79-2853-4c05-9226-24b92317ba56", "User", "USER" },
                    { "50ea0ff5-a886-41b1-9eae-f2f6e7e0cfd4", "50ea0ff5-a886-41b1-9eae-f2f6e7e0cfd4", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c", 0, "b170a5ae-eb5f-4beb-879a-7077b8c6c235", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEL1bmkr746miUa+iZvjhXNr1S1Afoxw/uQddkCicJcKETeGwFQTyLyASmGX/sQF03Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(4134), new TimeSpan(0, 0, 0, 0, 0)), "4da8b775-9583-4e8d-9e5a-8b5a74b3f6e8", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "a655875e-8339-4fb9-a16c-e4c5cb5f698c", 0, "ea1f3c8b-6a2a-4637-977d-33ddb75d348a", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEGJ3rfdUD3sWQjCXLWCrmmzLj8+rGPA5Sn0Yithsj/y0l44egAoWaHgnaxWAYopUew==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 0, 0, 0, 0)), "396a0bba-9b09-4ff0-b6df-4e3a24a81d58", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "5ac09661-54b2-4744-b5b4-7028537c6870", 0, "0dcaaa0c-32ad-4e3e-b5f9-b19a755ea37e", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAELx+EGCtWn3yAPvwbJ+7TJngWGTDwHcVZ51uYTr3sKKZrmFgrBJ/QaNcJj5HbAKmXA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(4039), new TimeSpan(0, 0, 0, 0, 0)), "a24b6aae-e100-4b36-9b18-b2aa3924aeb3", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "bde63227-61e9-49c3-a187-a051e1e6f842", 0, "39067d72-c2d7-4963-9b1e-4462ca045283", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEJKtcOrgqLsFg1D5QWMzHchWfA6nvuj59Sp7Z00O48xugmt1FRbONTwTIZGezSab8w==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(3791), new TimeSpan(0, 0, 0, 0, 0)), "939d0644-9994-4a32-ab13-4799f9a6a90b", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", 0, "7b56a20d-0765-4404-bbe8-4d9bbe94de90", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEIBcGGfrIycuJJz+XZ1+oMwDtTnOwUz26suGbuvfcEiE5elz/LCELsaGxTS6DyCgIw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(3763), new TimeSpan(0, 0, 0, 0, 0)), "8dcc180c-0d65-41d9-86f2-dff68792e499", "Kernychna", false, "mapourse@gmail.com" },
                    { "053b7b95-6a0b-4e0f-9780-b6e49112010c", 0, "0a0a5de5-cf89-4fe5-bc1e-9dc72b94281a", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEPrv6QxjRN3esrRWZERqpU40StOR298DhfWixlGPVCxPq1DQRsJm3NNdOygpZEKGdQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(3709), new TimeSpan(0, 0, 0, 0, 0)), "129d7029-513d-441c-9c1e-a496814869ca", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "80d235b3-93a4-48b6-8502-7ca76c243e5f", 0, "50b00e9b-7c84-4669-9b03-ac0fcb7de358", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEKOjR1vdy5j9ATWsniLXnl/hYcZ5W8ZS278CxTJHzK3HE4g5GaLGRykVCmo9EBj8vA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 0, 0, 0, 0)), "e315a1ca-3a22-4523-a5f0-2c3a9e30dcdd", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", 0, "ecbe0fa0-1943-4d44-8658-d6778fa81d61", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEEVnV04JiUsmBToPxIsHR42gMXADYqZ3OHzCBOYhwabfiQ2jMA4grD85SuMbdHenlQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 18, 38, 42, 188, DateTimeKind.Unspecified).AddTicks(78), new TimeSpan(0, 0, 0, 0, 0)), "e821988f-f581-4473-a828-3347aa9c456b", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { 6, "CAMOUFLAGE" },
                    { 1, "FOOD" },
                    { 2, "DRINKS" },
                    { 3, "CLOTHING" },
                    { 4, "FOOTWEAR" },
                    { 5, "HYGIENE PRODUCTS" },
                    { 7, "MEDICINES" }
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
                columns: new[] { "Id", "Address", "Country", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 24, "вулиця Шевченка, 10", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.9116167 47.1991193)"), 24, 0, "67301", "Одеська область", "Березівка", null },
                    { 25, "Трасса Е 95", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.317371 47.0234622)"), 25, 0, "67211", "Одеська область", "Знам'янка", null },
                    { 26, "48Q2+JJ Дубинове", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), 26, 0, "66220", "Одеська область", "Дубинове", null },
                    { 2, "вулиця Соборна, 5", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2614291 50.6175848)"), 2, 0, "33000", "Рівненська область", "Рівне", null },
                    { 28, "вул. Станціонна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.4974225 47.5464278)"), 28, 0, "55642", "Миколаївська область", "Новополтавка", null },
                    { 23, "Криве Озеро", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3443027 47.9484405)"), 23, 0, "55100", "Миколаївська область", "Криве Озеро", null },
                    { 27, "вулиця Медична, 19", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3832712 47.8876902)"), 27, 0, "50005", "Дніпропетровська область", "Кривий Ріг", null },
                    { 22, "Центральна 119", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1641172 48.1413224)"), 22, 0, "66221", "Одеська область", "Вільшанка", null },
                    { 21, "вул Соборна 44б", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.4570465 48.3880023)"), 21, 0, "26500", "Кіровоградська область", "Голованівськ", null },
                    { 20, "вулиця Бориса Тена, 2", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.6727154 50.2541948)"), 20, 0, "10001", "Житомирська область", "Житомир", null },
                    { 3, "Вишнівецька вулиця, 30", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.3839251 50.724626)"), 3, 0, "43000", "Волинська область", "Луцьк", null },
                    { 4, "вулиця Юрія Савченко, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0256349 48.4674516)"), 4, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 5, "вулиця Пушкіна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3386598 47.1917281)"), 5, 0, "87000", "Донецька область", "Нікольське", null },
                    { 6, "вулиця Садова, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0033648 46.9690278)"), 6, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 7, "вулиця Павлова, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2345305 48.5175858)"), 7, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 8, "вулиця Чкалова, 20", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2277797 48.5183484)"), 8, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 9, "Посадочна вулиця, 5", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2269653 48.5181244)"), 9, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 1, "вулиця Східна, 32", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5283633 50.3288577)"), 1, 0, "35800", "Рівненська область", "Острог", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 10, "вулиця Юрія Савченка, 3", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0247707 48.4658504)"), 10, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 12, "вулиця Шишкіна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3178905 48.6102995)"), 12, 0, "88000", "Закарпатська область", "Ужгород", null },
                    { 13, "вулиця Козацька, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.9919167 49.4178562)"), 13, 0, "29000", "Хмельницька  область", "Хмельницький", null },
                    { 14, "вулиця Братиславська, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3286723 47.8847308)"), 14, 0, "50000", "Дніпропетровська область", "Кривий Ріг", null },
                    { 16, "вулиця Привільна, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0222338 46.9858772)"), 16, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 17, "вулиця Привільна, 10", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0210963 46.9880672)"), 17, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 18, "вулиця В'ячеслава Чорновола, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.36196 50.755603)"), 18, 0, "43000", "Волинська область", "Луцьк", null },
                    { 19, "вулиця Острозька, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.8544323 50.3006939)"), 19, 0, "30000", "Хмельницька область", "Славута", null },
                    { 11, "просп. Вячеслава Черновола, 11", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.0253381 49.8468734)"), 11, 0, "79000", "Львівська область", "Львів", null },
                    { 15, "вулиця Слов'янська, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0147107 47.031949)"), 15, 0, "54000", "Миколаївська область", "Миколаїв", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c8d72d4d-28c5-40b6-894f-c1145d11b4d1", "053b7b95-6a0b-4e0f-9780-b6e49112010c" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "bde63227-61e9-49c3-a187-a051e1e6f842" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "a655875e-8339-4fb9-a16c-e4c5cb5f698c" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "30a7b34f-16e3-4997-b5c2-3d6c41beffeb" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "5ac09661-54b2-4744-b5b4-7028537c6870" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "80d235b3-93a4-48b6-8502-7ca76c243e5f" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3" },
                    { "43226e79-2853-4c05-9226-24b92317ba56", "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 4, "Green", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 745f, "Porsche,Cayenne, SUV", "BH2333XI", "RSE9TJJ2W8PNJWGY7O8R", "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c", "207I6Y8VC1U3KZ6LT" },
                    { 7, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 534f, "Porsche,911, Convertible, Coupe", "BC7739AA", "J89I2B0NKYHWYCW3XY8E", "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c", "CSKVMSWZAEWRTQ5P3" },
                    { 5, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 791f, "Nissan,TITAN XD Crew Cab, Pickup", "BH1232AA", "5XOLN66SXQE9QNCBN70V", "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c", "TVC460WW41ACE6496" },
                    { 1, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 650f, "Ford,F350 Super Duty Super Cab, Pickup", "AA4567XI", "C5WGVOSGQMV4B4V3VKNX", "a655875e-8339-4fb9-a16c-e4c5cb5f698c", "QK2WBVWUVNS30XLHT" },
                    { 10, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 588f, "Jeep,Wrangler Unlimited, SUV", "AC1273IX", "X8RH9SJIVQ2D9IAVI8YA", "bde63227-61e9-49c3-a187-a051e1e6f842", "7OTSKY20CC1QQJNU6" },
                    { 9, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 418f, "Ford,F350 Super Duty Crew Cab, Pickup", "AA8992BH", "563ATOQW64MC3PD2ADLU", "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", "NSFBGSLVZEN9XT47C" },
                    { 2, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 934f, "Jeep,Wrangler, SUV", "BC2234OP", "64663IN1TJF2LFCEZDWJ", "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", "7C83YIERWF1NKFVP7" },
                    { 4, 4, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 543f, "Nissan,Titan Crew Cab, Pickup", "AC6344AC", "T7G3H1R7S45ZHB0HNBKJ", "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", "K4SUUQB5VB457THRF" },
                    { 6, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 414f, "Porsche,Cayenne, SUV", "AA5421BH", "LPVH64FS8H23V3S9JZ6V", "80d235b3-93a4-48b6-8502-7ca76c243e5f", "DYE857D0GQAB85GN0" },
                    { 3, 4, "Green", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 439f, "Jeep,Wrangler, SUV", "BH4456AI", "4C1FI82TELU7GXUY0K4N", "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", "00XUXI95J93N2Z7OF" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "NotificationId", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kunze, Kassulke and Klein24/7 communities SSL online Michigan deposit payment Intelligent Auto Loan Account Refined Wooden Shirt SQL Wyoming De-engineered application back up Port Unions Park deposit solid state Generic Frozen Table Gorgeous Cotton Salad Metal incubate solid state transform CFA Franc BEAC Shoes & Jewelery.", 1, 640.8006f, false, null, "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bashirian, Larkin and MorarMartinique executive leverage Licensed olive Garden Cotton Awesome Concrete Fish optimize Ridge Sleek North Dakota Phased Colorado District input JSON Home Loan Account Awesome Concrete Car complexity redundant full-range withdrawal.", 4, 803.66077f, false, null, "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "McGlynn, Hintz and Gutmannbluetooth Functionality Dynamic Plaza Prairie backing up web services generate Ethiopian Birr Intelligent Concrete Table initiatives Agent Gorgeous Rubber Pants plum incubate XSS recontextualize Handcrafted IB 1080p Awesome Rubber Sausages Underpass Director blue withdrawal Self-enabling zero administration Incredible Steel Computer Bedfordshire.", 3, 661.09515f, false, null, "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 25, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Lesch, Prosacco and ThielSmall bluetooth Markets local Fields Equatorial Guinea Handcrafted Metal Hat invoice Refined Fresh Table Throughway.", 1, 503.67044f, false, null, "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", 14, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schulist, Goyette and OberbrunnerCambridgeshire Handmade Plastic Ball parse matrix Rupiah Paradigm Sudanese Pound Massachusetts array repurpose.", 6, 660.53f, false, null, "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3", 19, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 30, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Reichert, Renner and SchmelerVermont Dynamic vertical parse payment Metical end-to-end Facilitator Berkshire foreground.", 7, 888.3357f, false, null, "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bergstrom, Crona and SporerGorgeous Concrete Pants Soft Producer quantifying Metal IB Malawi visionary digital Intelligent Plastic Chips paradigm.", 1, 145.35307f, false, null, "80d235b3-93a4-48b6-8502-7ca76c243e5f", 6, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kuhic - NikolausHandmade Rubber Car Unbranded Fresh Keyboard United Kingdom hacking alarm channels expedite Principal Future Fantastic Metal Chips Buckinghamshire Pine Fantastic Concrete Pizza engage parallelism Gorgeous Plastic Bike Isle JBOD mission-critical CFA Franc BEAC Fresh North Carolina reboot.", 1, 698.3953f, false, null, "80d235b3-93a4-48b6-8502-7ca76c243e5f", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hansen, Larkin and ConroyBorders Investment Account neural Mobility framework pixel Engineer Rustic withdrawal China Codes specifically reserved for testing purposes SCSI Well cutting-edge Borders navigate Creative Ergonomic Soft Soap Overpass Future red pink Refined Infrastructure Industrial, Industrial & Games Nicaragua transmit.", 2, 795.5996f, false, null, "80d235b3-93a4-48b6-8502-7ca76c243e5f", 9, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 3, 120f, false, null, "a655875e-8339-4fb9-a16c-e4c5cb5f698c", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 6, 120f, false, null, "a655875e-8339-4fb9-a16c-e4c5cb5f698c", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schowalter - GradyErgonomic Granite Salad port Central Orchestrator open-source Intelligent Organized Marshall Islands 24/365 Iowa invoice solution Awesome Cotton Computer Uganda Cayman Islands Dollar.", 6, 289.17752f, false, null, "a655875e-8339-4fb9-a16c-e4c5cb5f698c", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 26, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "King - MarksHandcrafted Communications override ROI Refined Wooden Car Washington Refined next generation Wyoming Rubber West Virginia Fresh port Licensed SDD.", 1, 691.0092f, false, null, "a655875e-8339-4fb9-a16c-e4c5cb5f698c", 15, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 22, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "O'Keefe - DaughertyMovies & Shoes Engineer Spur calculating tertiary Tokelau Investor redundant Technician Michigan Jewelery, Music & Jewelery Analyst Stravenue East Caribbean Dollar.", 7, 625.4794f, false, null, "80d235b3-93a4-48b6-8502-7ca76c243e5f", 10, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Mosciski - KuvalisEngineer Direct Unbranded Soft Salad monitor Awesome Belize Dollar Configuration JBOD indigo pixel Djibouti.", 7, 800.535f, false, null, "5ac09661-54b2-4744-b5b4-7028537c6870", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hahn - Kiehnpayment Refined metrics empower Specialist Computers & Games transmitter Berkshire input Sports, Computers & Outdoors blue Credit Card Account Centers.", 2, 229.03317f, false, null, "5ac09661-54b2-4744-b5b4-7028537c6870", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 24, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Simonis GroupGB payment Rubber Hollow Dominica Dynamic Tennessee EXE functionalities panel networks Implementation archive teal backing up transmitter feed deposit scale Intelligent.", 3, 852.85443f, false, null, "5ac09661-54b2-4744-b5b4-7028537c6870", 3, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 7, 120f, false, null, "bde63227-61e9-49c3-a187-a051e1e6f842", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 4, 120f, false, null, "bde63227-61e9-49c3-a187-a051e1e6f842", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 3, 120f, false, null, "80d235b3-93a4-48b6-8502-7ca76c243e5f", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Klocko IncCredit Card Account aggregate Route program Wooden invoice markets interface copying Georgia Small Steel Pizza withdrawal monetize Small vortals Fantastic Steel Shirt hierarchy silver Director Personal Loan Account User-friendly.", 3, 207.36784f, false, null, "bde63227-61e9-49c3-a187-a051e1e6f842", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 2, 120f, false, null, "80d235b3-93a4-48b6-8502-7ca76c243e5f", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 3, 120f, false, null, "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 2, 120f, false, null, "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "NotificationId", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Wisoky and Sonssystems system Buckinghamshire Investor Nicaragua COM Granite Tasty Cambridgeshire Curve black Program expedite vertical content-based payment Montana User-centric Programmable synergies deploy contextually-based yellow.", 5, 771.8099f, false, null, "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", 16, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Waters - SchillerAccountability stable THX Borders Serbian Dinar bluetooth Peru circuit Health, Home & Sports California Cambridgeshire Plastic Fresh Handcrafted Mongolia synergies facilitate backing up Berkshire.", 1, 931.70874f, false, null, "30a7b34f-16e3-4997-b5c2-3d6c41beffeb", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 25, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hyatt LLCGreen Handcrafted Ergonomic turquoise Advanced portals Democratic People's Republic of Korea Bosnia and Herzegovina Human Licensed Wooden Tuna haptic high-level Global hack synthesizing Jordan Landing Aruban Guilder.", 7, 573.42346f, false, null, "a655875e-8339-4fb9-a16c-e4c5cb5f698c", 4, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 29, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Leannon and Sonspayment Practical scalable Sudanese Pound metrics solutions Global hard drive Bermudian Dollar (customarily known as Bermuda Dollar) Macedonia wireless solution-oriented USB GB Fork Handcrafted Soft Bike Malaysian Ringgit Hryvnia Checking Account.", 5, 663.1829f, false, null, "bde63227-61e9-49c3-a187-a051e1e6f842", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.36545 50.45624, 28.68603 50.26679, 27.62649 50.58838, 26.2517 50.62034)"), new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "30a7b34f-16e3-4997-b5c2-3d6c41beffeb" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (25.35595 50.7553, 24.76512 50.50216, 24.63097 50.28358, 24.00991 49.77351, 23.85867 49.26081, 22.3112 48.60822)"), new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "bde63227-61e9-49c3-a187-a051e1e6f842" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.2557039 48.7424709, 30.3017199 48.1390924, 30.3174055 47.0235592, 30.6598914 46.4932837)"), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "a655875e-8339-4fb9-a16c-e4c5cb5f698c" });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 33, "проспект Перемоги, ст. метро Житомирська", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.36545 50.45624)"), null, 1, "02000", "Київcька область", "Київ", 2 },
                    { 34, "вулиця Київська, 77", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.68603 50.26679)"), null, 2, "10001", "Житомирська область", "Житомир", 2 },
                    { 35, "вулиця Житомирська, 41-А", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (27.62649 50.58838)"), null, 3, "11702", "Житомирська область", "Новоград-Волинський", 2 },
                    { 36, "майдан Незалежності, 2", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2517 50.62034)"), null, 4, "33000", "Рівненська область", "Рівне", 2 },
                    { 37, "вулиця Сухомлинського, 1", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.35595 50.7553)"), null, 1, "43000", "Волинська область", "Луцьк", 3 },
                    { 38, "вулиця Луцька, 27", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.76512 50.50216)"), null, 2, "45700", "Волинська область", "Горохів", 3 },
                    { 39, "вулиця Витківська", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.63097 50.28358)"), null, 3, "80200", "Львівська область", "Радехів", 3 },
                    { 40, "вулиця Стрийська, 30 ТРЦ King Cross Leopolis", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.00991 49.77351)"), null, 4, "81130", "Львівська область", "Сокільники", 3 },
                    { 41, "вулиця Дубравського, 6", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (23.85867 49.26081)"), null, 5, "82400", "Львівська область", "Стрий", 3 },
                    { 42, "вулиця Верещагіна, 16", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3112 48.60822)"), null, 6, "88000", "Закарпатська область", "Ужгород", 3 },
                    { 29, "вулиця Волкова, 2", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.2557039 48.7424709)"), null, 1, "20300", "Черкаська область", "Умань", 1 },
                    { 30, "48Q2+JJ", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), null, 2, "20300", "Одеська область", "Дубинове", 1 },
                    { 31, "28F8+9X", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3174055 47.0235592)"), null, 3, "20300", "Одеська область", "Знам'янка", 1 },
                    { 32, "вулиця Мічуріна, 41", "Україна", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.6598914 46.4932837)"), null, 4, "65000", "Одеська область", "Одеса", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50ea0ff5-a886-41b1-9eae-f2f6e7e0cfd4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8d72d4d-28c5-40b6-894f-c1145d11b4d1", "053b7b95-6a0b-4e0f-9780-b6e49112010c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "30a7b34f-16e3-4997-b5c2-3d6c41beffeb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "5ac09661-54b2-4744-b5b4-7028537c6870" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "80d235b3-93a4-48b6-8502-7ca76c243e5f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "a655875e-8339-4fb9-a16c-e4c5cb5f698c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "bde63227-61e9-49c3-a187-a051e1e6f842" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43226e79-2853-4c05-9226-24b92317ba56", "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3" });

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "Offers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Offers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43226e79-2853-4c05-9226-24b92317ba56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8d72d4d-28c5-40b6-894f-c1145d11b4d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "053b7b95-6a0b-4e0f-9780-b6e49112010c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ac09661-54b2-4744-b5b4-7028537c6870");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73b3a6bf-e85f-4941-b872-bfc4ae1d5d6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80d235b3-93a4-48b6-8502-7ca76c243e5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e75eaf8b-6ef9-4ea3-a07a-9cdc60a7e9f3");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a7b34f-16e3-4997-b5c2-3d6c41beffeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a655875e-8339-4fb9-a16c-e4c5cb5f698c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bde63227-61e9-49c3-a187-a051e1e6f842");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
