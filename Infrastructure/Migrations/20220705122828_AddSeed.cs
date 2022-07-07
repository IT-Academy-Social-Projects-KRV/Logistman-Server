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
                    { "5fdc3f78-771a-439d-9958-65bda8ebc7b9", "5fdc3f78-771a-439d-9958-65bda8ebc7b9", "Logist", "LOGIST" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "d6d44967-f587-4009-8849-0916eadc072d", "User", "USER" },
                    { "1eb41f54-6e1a-4c5a-91e2-3070c522d747", "1eb41f54-6e1a-4c5a-91e2-3070c522d747", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f370cd81-7edc-491f-a656-4d816f156436", 0, "3bf9025e-77a6-4a65-82e0-2aaf12f2b54a", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEBp0cx676L22rC6tWIqCjuxkrtG0K+LdECDm0qwiyoDduJDwTy7ANCwtwVKX/6jd+A==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8207), new TimeSpan(0, 0, 0, 0, 0)), "9f089db2-4f05-429b-8be6-83de32192add", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", 0, "bb24816f-5f31-4c6c-9562-1a435148a5ae", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEBoKKyy4Gv7L1fSydZrl9cYlttnBKLekS77hV5qKZYDHzI1FlZxIXYp40zd45jyZqA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8197), new TimeSpan(0, 0, 0, 0, 0)), "58b12507-a7d2-47d4-9bf2-ce4ac3d96b5c", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "5cb8107f-f075-411c-9d97-07585237884e", 0, "fe3848be-094e-413e-b514-e1e7483efd66", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAELSvUt00/GfQABH4fRQFsXoHpbh6a8x3g1fUv/B/okE/0KKRZMdtggJGFjiWLgHpTw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, 0, 0, 0, 0)), "db59c1fc-8a1a-452e-a777-76a951433d27", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "16b21411-f0e6-421b-910f-4c22f075f9c6", 0, "36543443-b121-4a98-8c6f-a88b62a97cf7", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEDu9teSRZIa3p+f4c2W+p2Ze+KHmo0aNRV6BHTIRZh5n6zEEYG2fDd9ifpFc4dcZHA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8173), new TimeSpan(0, 0, 0, 0, 0)), "e7409fda-2714-4fe5-9b8d-05c623295a36", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", 0, "c9a271ad-fd09-4e96-b678-044bc97b6bd6", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEDcPtRxSVdFV5S5xXTqG6hxZjZAnmivX950C4NotAAUeqw5DA2rJ5GqoubchiReRYA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8164), new TimeSpan(0, 0, 0, 0, 0)), "deddb17d-1996-4899-8538-1fb9f7257777", "Kernychna", false, "mapourse@gmail.com" },
                    { "2fbab35b-1fc5-4e69-8331-432a9021e35a", 0, "6ff0ffd9-cecc-450e-8233-4145b096240e", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEIc40c0BW8q6dlNdcfmBPTbtkchdBtcirr9/kuUd8WXr5SejZ3WYq4NHsH1XS2Bu5w==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8141), new TimeSpan(0, 0, 0, 0, 0)), "74f8562a-3e0c-4495-ae8c-c43ad00bf87e", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 0, "4273cba6-925e-4876-884d-97fd60ec27fd", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEARAltDA3myXIm6BlZsVPMqXKo74VShkFLopnJd6OoW2xX5zY9jgtghTE3y7zPlJFg==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(8092), new TimeSpan(0, 0, 0, 0, 0)), "c1d16575-8a9e-4eac-814d-308e905deb58", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", 0, "d3388724-763c-48c2-8ad8-038a6e0d04aa", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEIQWkQ1AZkUMjSdqSXkeDy4BHdfVLd9RajzYMVTue6wPKZTsniyXUtLPm9RLuFJJAA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 28, 27, 110, DateTimeKind.Unspecified).AddTicks(6367), new TimeSpan(0, 0, 0, 0, 0)), "b99fbc56-489f-4a8c-b48d-eeac86c0c368", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 24, "вулиця Шевченка, 10", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.9116167 47.1991193)"), 24, 0, "67301", "Одеська область", "Березівка", null },
                    { 25, "Трасса Е 95", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.317371 47.0234622)"), 25, 0, "67211", "Одеська область", "Знам'янка", null },
                    { 26, "48Q2+JJ Дубинове", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), 26, 0, "66220", "Одеська область", "Дубинове", null },
                    { 2, "вулиця Соборна, 5", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2614291 50.6175848)"), 2, 0, "33000", "Рівненська область", "Рівне", null },
                    { 28, "вул. Станціонна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.4974225 47.5464278)"), 28, 0, "55642", "Миколаївська область", "Новополтавка", null },
                    { 23, "Криве Озеро", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3443027 47.9484405)"), 23, 0, "55100", "Миколаївська область", "Криве Озеро", null },
                    { 27, "вулиця Медична, 19", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3832712 47.8876902)"), 27, 0, "50005", "Дніпропетровська область", "Кривий Ріг", null },
                    { 22, "Центральна 119", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.1641172 48.1413224)"), 22, 0, "66221", "Одеська область", "Вільшанка", null },
                    { 21, "вул Соборна 44б", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.4570465 48.3880023)"), 21, 0, "26500", "Кіровоградська область", "Голованівськ", null },
                    { 20, "вулиця Бориса Тена, 2", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.6727154 50.2541948)"), 20, 0, "10001", "Житомирська область", "Житомир", null },
                    { 3, "Вишнівецька вулиця, 30", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.3839251 50.724626)"), 3, 0, "43000", "Волинська область", "Луцьк", null },
                    { 4, "вулиця Юрія Савченко, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0256349 48.4674516)"), 4, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 5, "вулиця Пушкіна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (37.3386598 47.1917281)"), 5, 0, "87000", "Донецька область", "Нікольське", null },
                    { 6, "вулиця Садова, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0033648 46.9690278)"), 6, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 7, "вулиця Павлова, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2345305 48.5175858)"), 7, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 8, "вулиця Чкалова, 20", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2277797 48.5183484)"), 8, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 9, "Посадочна вулиця, 5", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.2269653 48.5181244)"), 9, 0, "25000", "Кіровоградська область", "Кропивницький", null },
                    { 1, "вулиця Східна, 32", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.5283633 50.3288577)"), 1, 0, "35800", "Рівненська область", "Острог", null }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 10, "вулиця Юрія Савченка, 3", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (35.0247707 48.4658504)"), 10, 0, "49000", "Дніпропетровська область", "Дніпро", null },
                    { 12, "вулиця Шишкіна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3178905 48.6102995)"), 12, 0, "88000", "Закарпатська область", "Ужгород", null },
                    { 13, "вулиця Козацька, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.9919167 49.4178562)"), 13, 0, "29000", "Хмельницька  область", "Хмельницький", null },
                    { 14, "вулиця Братиславська, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (33.3286723 47.8847308)"), 14, 0, "50000", "Дніпропетровська область", "Кривий Ріг", null },
                    { 16, "вулиця Привільна, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0222338 46.9858772)"), 16, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 17, "вулиця Привільна, 10", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0210963 46.9880672)"), 17, 0, "54000", "Миколаївська область", "Миколаїв", null },
                    { 18, "вулиця В'ячеслава Чорновола, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.36196 50.755603)"), 18, 0, "43000", "Волинська область", "Луцьк", null },
                    { 19, "вулиця Острозька, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.8544323 50.3006939)"), 19, 0, "30000", "Хмельницька область", "Славута", null },
                    { 11, "просп. Вячеслава Черновола, 11", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.0253381 49.8468734)"), 11, 0, "79000", "Львівська область", "Львів", null },
                    { 15, "вулиця Слов'янська, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (32.0147107 47.031949)"), 15, 0, "54000", "Миколаївська область", "Миколаїв", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5fdc3f78-771a-439d-9958-65bda8ebc7b9", "2fbab35b-1fc5-4e69-8331-432a9021e35a" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "16b21411-f0e6-421b-910f-4c22f075f9c6" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "fc9e4c58-b7b8-4a08-ac85-786b62c44e48" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "5cb8107f-f075-411c-9d97-07585237884e" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "13b09adb-717d-4d10-bc58-1e74e20fd8c9" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "a4e78abe-826b-41d0-8ae5-b30e53c6efe3" },
                    { "d6d44967-f587-4009-8849-0916eadc072d", "f370cd81-7edc-491f-a656-4d816f156436" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 8, 2, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 871f, "Nissan,Titan Crew Cab, Pickup", "BH2333XI", "IHKZX6V6IV1JJPD9D9O8", "f370cd81-7edc-491f-a656-4d816f156436", "70TUWXE3E8UNQNOJD" },
                    { 7, 2, "Black", new DateTimeOffset(new DateTime(2016, 7, 4, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 952f, "Ford,F350 Super Duty Super Cab, Pickup", "BC7739AA", "SZIIWK7S59RDYWYS5Y21", "f370cd81-7edc-491f-a656-4d816f156436", "959JBIJDRKD512VRV" },
                    { 5, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 728f, "Porsche,Cayenne, SUV", "BH1232AA", "X0QU2IGUJVL3AZ4ZVVLA", "f370cd81-7edc-491f-a656-4d816f156436", "JK6US7B39R1WPDQV0" },
                    { 1, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 986f, "Ford,F350 Super Duty Crew Cab, Pickup", "AA4567XI", "PSD61EOYW05JRPLJSGP1", "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", "GF6C4RYP717PQQGHM" },
                    { 10, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 741f, "Porsche,Cayenne, SUV", "AC1273IX", "40VPD4DB2QFU6JWLDRWO", "16b21411-f0e6-421b-910f-4c22f075f9c6", "97SRWXPQHUSINP09C" },
                    { 9, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 643f, "Ford,F250 Super Duty Super Cab, Pickup", "AA8992BH", "OCLHCHHHF3US1AK529XR", "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", "SPWYPLTVCKL8IN7CJ" },
                    { 2, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 510f, "Nissan,Titan Crew Cab, Pickup", "BC2234OP", "WZS7FGYI239E9BYZP9X0", "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", "3C2YV2ATGMBVKGE4P" },
                    { 4, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 633f, "Ford,F350 Super Duty Super Cab, Pickup", "AC6344AC", "5NIGLX08O3ZWBB82M0WB", "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", "NDGP2EY5CGB5HFVBW" },
                    { 6, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 660f, "Porsche,911, Convertible, Coupe", "AA5421BH", "KQ16GQC1SY2E6H5N7P8J", "13b09adb-717d-4d10-bc58-1e74e20fd8c9", "U2DAR90VQS8XYU5OC" },
                    { 3, 4, "Green", new DateTimeOffset(new DateTime(2016, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 547f, "Jeep,Wrangler Unlimited, SUV", "BH4456AI", "YYBGEIIWYHOD3VG4GLW8", "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", "M3DRHLKKM0ZN5EQIG" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bayer - ColeWashington Soft Soft Usability Manager 1080p implement open-source hack Cross-platform auxiliary.", 1, 421.56802f, false, "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", 5, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 25, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kunde - Mosciskie-tailers Health dot-com bottom-line Factors Organic Islands Central Intelligent Granite Soap Exclusive Industrial Minnesota Representative.", 7, 586.51733f, false, "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Johns, Yundt and Vandervortcopying AI cultivate Intelligent Rubber Fish Music, Industrial & Jewelery enable Gardens groupware internet solution quantifying Cambridgeshire hardware SCSI visionary ivory.", 6, 992.4621f, false, "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", 12, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 23, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Mertz IncBranding Investment Account Optimization Union Beauty & Movies Credit Card Account Games, Movies & Sports Books & Home Applications Ergonomic Wooden Soap Steel parse Inlet Gorgeous Rubber Ball International Aruban Guilder Licensed Beauty Garden & Electronics compress uniform open-source Consultant Meadows user-centric.", 2, 632.72095f, false, "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", 14, null, new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Waelchi - VandervortOperations Avon bypass digital object-oriented Vista Awesome Soft Cheese Rubber SSL payment Bedfordshire Rwanda Belarussian Ruble Outdoors, Electronics & Jewelery Licensed Wooden Tuna pixel 5th generation circuit Granite.", 3, 995.07935f, false, "a4e78abe-826b-41d0-8ae5-b30e53c6efe3", 19, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Pfeffer IncGeneric Plastic Soap Sleek Plastic Shirt Guinea Franc embrace withdrawal Implementation Ergonomic Chief initiatives auxiliary dedicated Movies, Grocery & Beauty purple Savings Account integrate seamless Passage Generic Frozen Tuna encompassing reboot Mauritius Rupee Soft Optional Consultant focus group online Inlet regional silver Incredible Rubber Keyboard.", 3, 727.1763f, false, "f370cd81-7edc-491f-a656-4d816f156436", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Smitham, Howell and Schillerdeposit Bridge virtual matrix Security Savings Account Personal Loan Account Virginia Borders Buckinghamshire Beauty San Marino Avon withdrawal Rustic backing up feed compress value-added connecting Refined Frozen Bacon Rubber Awesome Lakes synergy Strategist models Gorgeous Plastic Mouse Sleek Fresh Sausages digital.", 5, 891.6105f, false, "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Grant - StehrCredit Card Account invoice Ergonomic Fresh Tuna programming Home, Movies & Games Kids & Grocery Personal Loan Account Strategist Assurance synthesizing Implementation port Pula Garden Landing Frozen deposit Fresh.", 6, 161.07285f, false, "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kulas, Osinski and Sanfordinput Haiti needs-based calculate Investor emulation Berkshire frame Route payment Optimized Intranet override Creative solid state Gorgeous Self-enabling Assimilated connect invoice invoice Branding Investment Account.", 7, 268.98477f, false, "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 9, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 2, 120f, false, "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 4, 120f, false, "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 21, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bayer LLCutilize matrix Baby & Games revolutionize client-driven USB Savings Account methodologies Drive Quality world-class Iceland Legacy Sports Wooden brand Plastic Rubber PCI Nebraska database indexing Sports, Health & Movies Motorway quantifying payment.", 7, 90.71428f, false, "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", 20, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 28, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Mills - Schmelerproduct Manager Practical Wooden Towels Small neural Games, Grocery & Clothing Parks Kyrgyz Republic grey turquoise Sports, Games & Books Handmade Cotton Bacon Central Direct Mali invoice e-services Licensed Soft Shirt Home, Automotive & Books hub Fantastic 1080p Awesome Plastic Shirt Tasty Steel Shirt indigo Malagasy Ariary Arkansas Kids, Jewelery & Movies Rubber.", 2, 280.5007f, false, "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", 15, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Franecki and Sonssolid state Burg matrix parsing Argentina Handcrafted Concrete Ball Vista Handmade Fresh Ball Grove Markets Branding Unbranded Kentucky Vision-oriented.", 6, 404.12906f, false, "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 10, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 28, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Parisian - WymanTasty Steel Fish THX Turnpike Wooden Manager Organic payment bleeding-edge JBOD Future Awesome Soft Pants Sleek Wooden Car protocol Global Handmade Auto Loan Account deposit copying cutting-edge Corporate JBOD.", 2, 962.62494f, false, "5cb8107f-f075-411c-9d97-07585237884e", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Davis - RauCrescent Ridges Concrete capacitor Cambridgeshire Gorgeous Metal Tuna Macedonia system homogeneous Interactions.", 5, 368.57526f, false, "5cb8107f-f075-411c-9d97-07585237884e", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 28, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ryan Groupyellow connecting Fall Awesome Cotton Shirt generate bifurcated Georgia Tasty Concrete Hat back up contingency clicks-and-mortar quantifying Gorgeous Soft Chicken motivating impactful mindshare Turnpike Lead Awesome Wooden Car deposit viral.", 2, 56.218857f, false, "5cb8107f-f075-411c-9d97-07585237884e", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 3, 120f, false, "16b21411-f0e6-421b-910f-4c22f075f9c6", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 7, 120f, false, "16b21411-f0e6-421b-910f-4c22f075f9c6", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 1, 120f, false, "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ritchie LLCFantastic Progressive South Carolina Garden & Music silver Re-engineered architectures Route Focused purple Well Frozen infrastructures Gorgeous International recontextualize Berkshire.", 6, 432.28418f, false, "16b21411-f0e6-421b-910f-4c22f075f9c6", 1, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 6, 120f, false, "13b09adb-717d-4d10-bc58-1e74e20fd8c9", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 4, 120f, false, "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 1, 120f, false, "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Boyle, Hermann and SchusterCotton rich grow facilitate Beauty & Kids function bus Sports & Home cross-media Fresh Music & Home.", 6, 821.38696f, false, "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", 16, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Abshire, Smith and ErdmanCredit Card Account Costa Rican Colon orange Central Generic turn-key zero administration navigating tan Vista bus Licensed Valleys Industrial & Jewelery systemic Investor Place AGP.", 6, 918.5931f, false, "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6", 8, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Monahan, Douglas and Klingconvergence Generic Wooden Bike invoice Licensed Plastic Shirt migration back up bypass encompassing Money Market Account Danish Krone deposit Music, Clothing & Jewelery British Indian Ocean Territory (Chagos Archipelago) Mississippi Tokelau Brand backing up.", 6, 374.37894f, false, "fc9e4c58-b7b8-4a08-ac85-786b62c44e48", 4, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Zulauf and Sonsdeposit web-enabled ivory Developer Summit Tennessee Handcrafted Frozen Chair input Hryvnia invoice AGP mobile alarm orange disintermediate Ergonomic Toys open-source Frozen withdrawal reinvent Incredible Metal Salad Intelligent Cotton Ball Checking Account card.", 1, 77.98786f, false, "16b21411-f0e6-421b-910f-4c22f075f9c6", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "16b21411-f0e6-421b-910f-4c22f075f9c6" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "fc9e4c58-b7b8-4a08-ac85-786b62c44e48" });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Country", "IsStopover", "Location", "OfferId", "Order", "Postcode", "Region", "Settlement", "TripId" },
                values: new object[,]
                {
                    { 33, "проспект Перемоги, ст. метро Житомирська", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.36545 50.45624)"), null, 1, "02000", "Київcька область", "Київ", 2 },
                    { 34, "вулиця Київська, 77", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (28.68603 50.26679)"), null, 2, "10001", "Житомирська область", "Житомир", 2 },
                    { 35, "вулиця Житомирська, 41-А", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (27.62649 50.58838)"), null, 3, "11702", "Житомирська область", "Новоград-Волинський", 2 },
                    { 36, "майдан Незалежності, 2", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (26.2517 50.62034)"), null, 4, "33000", "Рівненська область", "Рівне", 2 },
                    { 37, "вулиця Сухомлинського, 1", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (25.35595 50.7553)"), null, 1, "43000", "Волинська область", "Луцьк", 3 },
                    { 38, "вулиця Луцька, 27", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.76512 50.50216)"), null, 2, "45700", "Волинська область", "Горохів", 3 },
                    { 39, "вулиця Витківська", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.63097 50.28358)"), null, 3, "80200", "Львівська область", "Радехів", 3 },
                    { 40, "вулиця Стрийська, 30 ТРЦ King Cross Leopolis", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (24.00991 49.77351)"), null, 4, "81130", "Львівська область", "Сокільники", 3 },
                    { 41, "вулиця Дубравського, 6", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (23.85867 49.26081)"), null, 5, "82400", "Львівська область", "Стрий", 3 },
                    { 42, "вулиця Верещагіна, 16", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (22.3112 48.60822)"), null, 6, "88000", "Закарпатська область", "Ужгород", 3 },
                    { 29, "вулиця Волкова, 2", "Україна", false, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.2557039 48.7424709)"), null, 1, "20300", "Черкаська область", "Умань", 1 },
                    { 30, "48Q2+JJ", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3017199 48.1390924)"), null, 2, "20300", "Одеська область", "Дубинове", 1 },
                    { 31, "28F8+9X", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.3174055 47.0235592)"), null, 3, "20300", "Одеська область", "Знам'янка", 1 },
                    { 32, "вулиця Мічуріна, 41", "Україна", true, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (30.6598914 46.4932837)"), null, 4, "65000", "Одеська область", "Одеса", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eb41f54-6e1a-4c5a-91e2-3070c522d747");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "13b09adb-717d-4d10-bc58-1e74e20fd8c9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "16b21411-f0e6-421b-910f-4c22f075f9c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fdc3f78-771a-439d-9958-65bda8ebc7b9", "2fbab35b-1fc5-4e69-8331-432a9021e35a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "5cb8107f-f075-411c-9d97-07585237884e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "a4e78abe-826b-41d0-8ae5-b30e53c6efe3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "f370cd81-7edc-491f-a656-4d816f156436" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "fc9e4c58-b7b8-4a08-ac85-786b62c44e48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6d44967-f587-4009-8849-0916eadc072d", "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6" });

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
                keyValue: "5fdc3f78-771a-439d-9958-65bda8ebc7b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6d44967-f587-4009-8849-0916eadc072d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13b09adb-717d-4d10-bc58-1e74e20fd8c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fbab35b-1fc5-4e69-8331-432a9021e35a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cb8107f-f075-411c-9d97-07585237884e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4e78abe-826b-41d0-8ae5-b30e53c6efe3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f370cd81-7edc-491f-a656-4d816f156436");

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
                keyValue: "16b21411-f0e6-421b-910f-4c22f075f9c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc9e4c58-b7b8-4a08-ac85-786b62c44e48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd1f0824-69ea-47e4-b34d-b11a7ba1cfa6");

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
