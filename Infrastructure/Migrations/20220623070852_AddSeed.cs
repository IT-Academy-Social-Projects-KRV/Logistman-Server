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
                    { "b85f2115-c1dc-42c5-b8b1-b60feab436d6", "b85f2115-c1dc-42c5-b8b1-b60feab436d6", "Logist", "LOGIST" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "86a53a4c-ae53-42a2-b443-0f635d756307", "User", "USER" },
                    { "7fa3f495-c9d2-41e4-9c62-12334c49a290", "7fa3f495-c9d2-41e4-9c62-12334c49a290", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "524bcb8e-5cc6-438d-8234-8b09f73f20ce", 0, "bd6f8be2-0abd-49d5-9bab-751f8fdc505d", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAECpqSL+iFOyOZkYoP9/lrMqOtbVnJfF1uvj661wyDNkpgCvafidZztkqtvMrPnOfoA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1439), new TimeSpan(0, 0, 0, 0, 0)), "453b1d9d-886c-4a83-921b-4bbbb4cab588", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "5bf11eca-e271-45ee-b681-769483e68f6d", 0, "1dbe805b-d869-4c44-8586-e56b2e994e20", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEFVBSUxF3LHesLvQFo1qPOYHcAZN7JVFFvFZSbczaJSCMPHbnYnR3pEo4XVU+L/KNA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 0, 0, 0, 0)), "5a0b8812-7700-48b1-a3ab-fd2b293654e7", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "82a24a83-5e9c-485c-896d-16e733e58cf4", 0, "4b6e162b-9173-4df7-bcd5-84704131b525", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEIlPWUCJC44GYv2EpmStvHaGArG2UIClYEZw+xNrokPBDB/VL/Y1Ff4o//B3qmXFaA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1401), new TimeSpan(0, 0, 0, 0, 0)), "baad7a61-bff3-4f8b-88a4-cb860f609bd4", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "823e22b0-f278-4dd7-bbcb-7bf682d85eac", 0, "d4f227b9-68d0-4665-93f8-69d9df730284", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEFkW8iAfxZYpZB3XF9r3fFHnPHZtl2XSHg1we0Z7dWs4kwx63cntzDi3x5bvgKhNvQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1380), new TimeSpan(0, 0, 0, 0, 0)), "4f58501d-bd52-4983-9a0e-e3e9644eb665", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", 0, "83dd52c1-aa2d-42f6-a9ba-117aaff72107", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEBt75b2hKhRSKdOOCbblJ6hbl3ifB6/+WN3Q99Xn5+KaMcjN03CGslvXOiXE6jzpew==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1363), new TimeSpan(0, 0, 0, 0, 0)), "d2132bfe-84f5-4b63-8036-4379a34d3a34", "Kernychna", false, "mapourse@gmail.com" },
                    { "92fa9d91-856c-4412-a966-0f71c2f42188", 0, "6b30879b-d49a-4f46-8a1e-c5200d6c9b76", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEIu7pBL81HOxElcQr0sVeKwvtzs7iGUH6c6lFDbcxlu9eHk4i03p6CRPEAy+JrDo2Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1344), new TimeSpan(0, 0, 0, 0, 0)), "d0b867f1-dce2-4939-8c71-3390f988766f", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "73a46980-91f6-44c9-9df0-617a09546e35", 0, "3c22ab0d-1591-4217-9cfc-f070572d15bd", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEDSaRxcvxpjBq6OOwxSPBcKYOH0Y5sizgF6736n45RoYY0M4UU4hAfGs0eMdgY86jA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 682, DateTimeKind.Unspecified).AddTicks(1261), new TimeSpan(0, 0, 0, 0, 0)), "e6c319bd-8cd2-4ee4-8434-19e1958a3b60", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "7fb791f6-c093-458a-9c02-d19fbc924f36", 0, "dfb4a48b-3014-405b-abdd-974fa536c5ce", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEAMEUJc3zE74GWpRbUKkbydU5XgoR3V4mpcveyTOjpFsGzVkmJ4KcV+/78HtOMkmEg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 23, 7, 8, 51, 681, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 0, 0, 0, 0)), "e8044d27-d1ed-45e1-821e-76762e715898", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 24, "вулиця Шевченка, 10", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.9116167 47.1991193)"), 0, "67301", "Одеська область", "Березівка", null },
                    { 25, "Трасса Е 95", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.317371 47.0234622)"), 0, "67211", "Одеська область", "Знам'янка", null },
                    { 26, "48Q2+JJ Дубинове", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), 0, "66220", "Одеська область", "Дубинове", null },
                    { 2, "вулиця Соборна, 5", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2614291 50.6175848)"), 0, "33000", "Рівненська область", "Рівне", null },
                    { 28, "вул. Станціонна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.4974225 47.5464278)"), 0, "55642", "Миколаївська область", "Новополтавка", null },
                    { 23, "Криве Озеро", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3443027 47.9484405)"), 0, "55100", "Миколаївська область", "Криве Озеро", null },
                    { 27, "вулиця Медична, 19", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3832712 47.8876902)"), 0, "50005", "Дніпропетровська область", "Кривий Ріг", null },
                    { 22, "Центральна 119", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1641172 48.1413224)"), 0, "66221", "Одеська область", "Вільшанка", null },
                    { 21, "вул Соборна 44б", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.4570465 48.3880023)"), 0, "26500", "Кіровоградська область", "Голованівськ", null },
                    { 20, "вулиця Бориса Тена, 2", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.6727154 50.2541948)"), 0, "10001", "Житомирська область", "Житомир", null },
                    { 3, "Вишнівецька вулиця, 30", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.3839251 50.724626)"), 0, "43000", "Волинська область", "Луцьк", null },
                    { 4, "вулиця Юрія Савченко, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0256349 48.4674516)"), 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 5, "вулиця Пушкіна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3386598 47.1917281)"), 0, "87000", "Донецька область", "Нікольське", null },
                    { 6, "вулиця Садова, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0033648 46.9690278)"), 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 7, "вулиця Павлова, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2345305 48.5175858)"), 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 8, "вулиця Чкалова, 20", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2277797 48.5183484)"), 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 9, "Посадочна вулиця, 5", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2269653 48.5181244)"), 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 1, "вулиця Східна, 32", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5283633 50.3288577)"), 0, "35800", "Рівненська область", "Острог", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 10, "вулиця Юрія Савченка, 3", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0247707 48.4658504)"), 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 12, "вулиця Шишкіна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3178905 48.6102995)"), 0, "88000", "Закарпатська область", "Ужгород", null },
                    { 13, "вулиця Козацька, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.9919167 49.4178562)"), 0, "29000", "Хмельницька  область", "Хмельницький", null },
                    { 14, "вулиця Братиславська, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3286723 47.8847308)"), 0, "50000", "Дніпропетровська область", "Кривий Ріг", null },
                    { 16, "вулиця Привільна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0222338 46.9858772)"), 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 17, "вулиця Привільна, 10", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0210963 46.9880672)"), 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 18, "вулиця В'ячеслава Чорновола, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.36196 50.755603)"), 0, "43000", "Волинська область", "Луцьк", null },
                    { 19, "вулиця Острозька, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.8544323 50.3006939)"), 0, "30000", "Хмельницька область", "Славута", null },
                    { 11, "просп. Вячеслава Черновола, 11", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.0253381 49.8468734)"), 0, "79000", "Львівська область", "Львів", null },
                    { 15, "вулиця Слов'янська, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0147107 47.031949)"), 0, "54000", "Миколаївська область", "Миколаїв", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b85f2115-c1dc-42c5-b8b1-b60feab436d6", "92fa9d91-856c-4412-a966-0f71c2f42188" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "823e22b0-f278-4dd7-bbcb-7bf682d85eac" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "5bf11eca-e271-45ee-b681-769483e68f6d" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "82a24a83-5e9c-485c-896d-16e733e58cf4" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "73a46980-91f6-44c9-9df0-617a09546e35" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "7fb791f6-c093-458a-9c02-d19fbc924f36" },
                    { "86a53a4c-ae53-42a2-b443-0f635d756307", "524bcb8e-5cc6-438d-8234-8b09f73f20ce" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 610f, "Ford,F350 Super Duty Super Cab, Pickup", "BH2333XI", "D1G7RGWNGV9SFQQ1L66B", "524bcb8e-5cc6-438d-8234-8b09f73f20ce", "90PIKUV2WAHRD8W0L" },
                    { 7, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 485f, "Porsche,Cayenne, SUV", "BC7739AA", "PHZFTIMTKJOONM4HM3CQ", "524bcb8e-5cc6-438d-8234-8b09f73f20ce", "R9D7CGI72FNY4JNQ1" },
                    { 5, 2, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 427f, "Jeep,Wrangler, SUV", "BH1232AA", "ZIMRGI67GGV7L3R8Q833", "524bcb8e-5cc6-438d-8234-8b09f73f20ce", "FUQJ0JJTK15YXW9NR" },
                    { 1, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 604f, "Ford,F350 Super Duty Crew Cab, Pickup", "AA4567XI", "FQ7BB4HFY5PEU6J2Z8WT", "5bf11eca-e271-45ee-b681-769483e68f6d", "62MNNGCQHB3PKD6E9" },
                    { 10, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 822f, "Nissan,Titan King Cab, Pickup", "AC1273IX", "15MHGFIC2JS8KGU1FFJV", "823e22b0-f278-4dd7-bbcb-7bf682d85eac", "MD11VXF45LSCX40V1" },
                    { 9, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 635f, "Nissan,Titan King Cab, Pickup", "AA8992BH", "JE5OSXOGA9B5WRGI8W2R", "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", "YANDH5LK7PSUPLKTS" },
                    { 2, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 527f, "Nissan,Titan Crew Cab, Pickup", "BC2234OP", "CN82E0HGMRIZEJ4OOH13", "7fb791f6-c093-458a-9c02-d19fbc924f36", "EB4M5VKYA64HUFDL8" },
                    { 4, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 959f, "Jeep,Wrangler Unlimited, SUV", "AC6344AC", "LZ555GNGK9F629V94CEH", "7fb791f6-c093-458a-9c02-d19fbc924f36", "WEWF7JCJS0BCQUQKJ" },
                    { 6, 4, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 795f, "Ford,F350 Super Duty Crew Cab, Pickup", "AA5421BH", "JG54RZBTMCOZI3R1XHMN", "73a46980-91f6-44c9-9df0-617a09546e35", "T1M5VY2H2WP4VEKE9" },
                    { 3, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 806f, "Porsche,911, Convertible, Coupe", "BH4456AI", "JLQ6U2PL5L4BO9XXSULV", "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", "BUWPPA38L8XSUPEFB" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 28, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Braun, Kshlerin and Murraygreen connecting Automotive & Movies Unbranded Soft Keyboard Plastic ubiquitous Steel Assistant hacking Expanded yellow Ergonomic Granite Computer Future Balanced mobile Ergonomic Managed array Viaduct ADP bluetooth Personal Loan Account.", 6, 725.6767f, false, "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", 5, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Abshire, Nitzsche and Schillercapacitor HDD Camp Rubber invoice multi-tasking hard drive Montenegro Hawaii Global JSON Inverse Handcrafted Cambodia Grass-roots Division mobile Granite Shoes Falkland Islands Pound concept Handmade Granite Soap Response Jewelery port Internal.", 6, 691.33075f, false, "7fb791f6-c093-458a-9c02-d19fbc924f36", 2, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Corkery GroupPlain bypass Accountability deposit SMS transmitter withdrawal implement SDD Alaska New Mexico Freeway data-warehouse invoice concept Buckinghamshire enhance maximize invoice Engineer upward-trending Assistant methodologies.", 1, 721.2651f, false, "7fb791f6-c093-458a-9c02-d19fbc924f36", 12, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kautzer and SonsAssistant orange Kentucky Jewelery & Computers olive cross-media Auto Loan Account Quality-focused synergy New Jersey Refined Granite Table Virginia.", 3, 437.4236f, false, "7fb791f6-c093-458a-9c02-d19fbc924f36", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Thiel and Sonsprocess improvement collaborative Alabama initiative Metal Orchestrator Program Serbia compress Executive.", 3, 680.6398f, false, "7fb791f6-c093-458a-9c02-d19fbc924f36", 19, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 21, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Willms, Ebert and ZiemeSupervisor parsing user-facing Drive Awesome Rubber Salad Idaho local Awesome Wooden Soap Street Developer Orchestrator Cambridgeshire markets payment Monitored real-time copying Internal Managed Interactions Tasty Steel Pizza Canada.", 3, 768.4622f, false, "524bcb8e-5cc6-438d-8234-8b09f73f20ce", 11, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Macejkovic, Hahn and WaelchiHDD Solutions Tunisia Sleek Cotton Chicken Forward Corner Buckinghamshire function copy Lodge Junction synthesizing solutions bandwidth invoice artificial intelligence.", 7, 856.01117f, false, "73a46980-91f6-44c9-9df0-617a09546e35", 6, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Champlin, Fay and Erdmantransitional Gibraltar Pound synthesize salmon Personal Loan Account synergies Florida connect input 24/7 Analyst Bedfordshire Cuban Peso web-readiness Organized contingency mesh Terrace matrix seamless Berkshire Dominican Peso Shore Mobility Camp Identity Manager.", 4, 856.2581f, false, "73a46980-91f6-44c9-9df0-617a09546e35", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Fritsch - JenkinsBedfordshire Handcrafted Metal Bike Tasty Metal client-server Product Fiji Dollar Officer payment Architect panel e-commerce.", 6, 928.0153f, false, "73a46980-91f6-44c9-9df0-617a09546e35", 9, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 3, 120f, false, "5bf11eca-e271-45ee-b681-769483e68f6d", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 4, 120f, false, "5bf11eca-e271-45ee-b681-769483e68f6d", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Mills - TowneGreece Granite invoice CSS withdrawal Uganda Shilling invoice Designer North Korean Won knowledge base Advanced Corporate holistic Burgs Liaison repurpose Auto Loan Account.", 4, 139.72072f, false, "5bf11eca-e271-45ee-b681-769483e68f6d", 20, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 26, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Beer IncHuman Central African Republic invoice Incredible Plastic Chair Rustic multi-byte Cotton Junctions withdrawal primary bypass Electronics synthesizing Won Ranch productivity niches experiences reciprocal purple Sudan object-oriented Flat Avon AI bypass back-end Crest.", 4, 377.2216f, false, "5bf11eca-e271-45ee-b681-769483e68f6d", 15, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hamill - DeckowBulgaria Overpass compressing Saint Martin District Health, Grocery & Sports Persevering hack Automotive & Computers Kids Forint ivory multi-byte Granite.", 1, 735.64825f, false, "73a46980-91f6-44c9-9df0-617a09546e35", 10, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 23, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Tillman IncOklahoma Gorgeous Steel Mouse Ergonomic Cambridgeshire e-enable Quetzal value-added models deposit Courts monitor Ireland silver Brook Small Fresh Table Club Automotive approach Ergonomic Cotton Bike unleash grey Cambridgeshire Savings Account Concrete Way impactful Personal Loan Account.", 6, 124.567795f, false, "82a24a83-5e9c-485c-896d-16e733e58cf4", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bartell, Waelchi and KochChief capability Refined Congolese Franc ivory Bahamian Dollar drive USB Palladium Meadow Lead zero tolerance primary blockchains Bedfordshire Generic Cotton Soap.", 6, 271.69986f, false, "82a24a83-5e9c-485c-896d-16e733e58cf4", 17, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 28, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Halvorson IncPNG Cape Junction Fall leading edge Cuban Peso Convertible Rial Omani Rubber SSL Customer-focused Ouguiya Incredible Soft Hat deposit black Agent Kids, Jewelery & Health Inverse array Western Sahara leading-edge Buckinghamshire Investor Direct Ergonomic RAM bricks-and-clicks Gorgeous Steel Fish.", 4, 415.8002f, false, "82a24a83-5e9c-485c-896d-16e733e58cf4", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 3, 120f, false, "823e22b0-f278-4dd7-bbcb-7bf682d85eac", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 7, 120f, false, "823e22b0-f278-4dd7-bbcb-7bf682d85eac", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 4, 120f, false, "73a46980-91f6-44c9-9df0-617a09546e35", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Mayert LLCBedfordshire Trail dynamic mobile Taka Home & Shoes Maldives Gorgeous Soft Shoes Ergonomic mindshare PCI high-level Union Berkshire Radial Mobility open-source eyeballs Automotive backing up Security Roads AI PNG Reverse-engineered metrics JBOD.", 4, 993.59015f, false, "823e22b0-f278-4dd7-bbcb-7bf682d85eac", 1, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 5, 120f, false, "73a46980-91f6-44c9-9df0-617a09546e35", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 6, 120f, false, "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 5, 120f, false, "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 30, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kreiger - KrajcikLek turquoise e-markets Vista Exclusive hard drive bluetooth matrix Florida Dynamic Engineer Functionality New Jersey North Dakota United Kingdom wireless motivating Kiribati District Officer Svalbard & Jan Mayen Islands Dynamic revolutionize HDD Ameliorated Toys.", 1, 261.95422f, false, "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Crona and SonsExpressway invoice Union transmit Prairie Montenegro open-source mobile Profound Expressway.", 2, 612.4903f, false, "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 30, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Aufderhar, Hane and Casperonline digital Oklahoma black input solutions Fresh back-end compress Incredible Frozen Pants Beauty, Industrial & Jewelery flexibility Accountability project Finland Common Accounts Books, Home & Industrial Sports, Baby & Books Shoes responsive withdrawal Cambridgeshire.", 7, 671.5753f, false, "5bf11eca-e271-45ee-b681-769483e68f6d", 4, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 30, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Williamson - BoyerSleek Soft Chicken gold wireless green Landing Accounts value-added Plastic calculate Home Loan Account copying West Virginia GB Optimization Practical Sleek Cotton Mouse Gorgeous Steel Shoes Incredible Investment Account French Guiana override open-source SQL violet Operative Investment Account Concrete.", 5, 954.44965f, false, "823e22b0-f278-4dd7-bbcb-7bf682d85eac", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "823e22b0-f278-4dd7-bbcb-7bf682d85eac" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "5bf11eca-e271-45ee-b681-769483e68f6d" });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 33, "проспект Перемоги, ст. метро Житомирська", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.36545 50.45624)"), 1, "02000", "Київcька область", "Київ", 2 },
                    { 34, "вулиця Київська, 77", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.68603 50.26679)"), 2, "10001", "Житомирська область", "Житомир", 2 },
                    { 35, "вулиця Житомирська, 41-А", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (27.62649 50.58838)"), 3, "11702", "Житомирська область", "Новоград-Волинський", 2 },
                    { 36, "майдан Незалежності, 2", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2517 50.62034)"), 4, "33000", "Рівненська область", "Рівне", 2 },
                    { 37, "вулиця Сухомлинського, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.35595 50.7553)"), 1, "43000", "Волинська область", "Луцьк", 3 },
                    { 38, "вулиця Луцька, 27", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.76512 50.50216)"), 2, "45700", "Волинська область", "Горохів", 3 },
                    { 39, "вулиця Витківська", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.63097 50.28358)"), 3, "80200", "Львівська область", "Радехів", 3 },
                    { 40, "вулиця Стрийська, 30 ТРЦ King Cross Leopolis", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.00991 49.77351)"), 4, "81130", "Львівська область", "Сокільники", 3 },
                    { 41, "вулиця Дубравського, 6", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (23.85867 49.26081)"), 5, "82400", "Львівська область", "Стрий", 3 },
                    { 42, "вулиця Верещагіна, 16", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3112 48.60822)"), 6, "88000", "Закарпатська область", "Ужгород", 3 },
                    { 29, "вулиця Волкова, 2", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.2557039 48.7424709)"), 1, "20300", "Черкаська область", "Умань", 1 },
                    { 30, "48Q2+JJ", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), 2, "20300", "Одеська область", "Дубинове", 1 },
                    { 31, "28F8+9X", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3174055 47.0235592)"), 3, "20300", "Одеська область", "Знам'янка", 1 },
                    { 32, "вулиця Мічуріна, 41", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.6598914 46.4932837)"), 4, "65000", "Одеська область", "Одеса", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fa3f495-c9d2-41e4-9c62-12334c49a290");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "524bcb8e-5cc6-438d-8234-8b09f73f20ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "5bf11eca-e271-45ee-b681-769483e68f6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "73a46980-91f6-44c9-9df0-617a09546e35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "7fb791f6-c093-458a-9c02-d19fbc924f36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "823e22b0-f278-4dd7-bbcb-7bf682d85eac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "86a53a4c-ae53-42a2-b443-0f635d756307", "82a24a83-5e9c-485c-896d-16e733e58cf4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b85f2115-c1dc-42c5-b8b1-b60feab436d6", "92fa9d91-856c-4412-a966-0f71c2f42188" });

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
                keyValue: "86a53a4c-ae53-42a2-b443-0f635d756307");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b85f2115-c1dc-42c5-b8b1-b60feab436d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "524bcb8e-5cc6-438d-8234-8b09f73f20ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73a46980-91f6-44c9-9df0-617a09546e35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fb791f6-c093-458a-9c02-d19fbc924f36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a24a83-5e9c-485c-896d-16e733e58cf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92fa9d91-856c-4412-a966-0f71c2f42188");

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
                keyValue: "0dc0ce68-af4a-4b3b-9704-f0c3849fb10b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bf11eca-e271-45ee-b681-769483e68f6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "823e22b0-f278-4dd7-bbcb-7bf682d85eac");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
