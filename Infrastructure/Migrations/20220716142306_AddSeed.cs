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
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                    { "69ddf2d5-e24d-49a4-9142-b92dfc618251", "69ddf2d5-e24d-49a4-9142-b92dfc618251", "Logist", "LOGIST" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "4cae7dec-9d43-4314-9cae-5baa3612aa91", "User", "USER" },
                    { "ad1a6e5f-6714-47f0-b5d3-6fa79a12f9f0", "ad1a6e5f-6714-47f0-b5d3-6fa79a12f9f0", "Admin", "ADMIN" }
========
                    { "08a62f14-7295-441a-b456-639704f5d05a", "08a62f14-7295-441a-b456-639704f5d05a", "Logist", "LOGIST" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "0bac1c28-2240-4f93-8011-6354136f1ce2", "User", "USER" },
                    { "095f0ade-38fc-47c6-b275-4c90055714bc", "095f0ade-38fc-47c6-b275-4c90055714bc", "Admin", "ADMIN" }
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                    { "3cd07bd6-5909-4b72-9fcd-42959f303f96", 0, "7c360730-afb0-4646-a83a-8e5855a7d7f2", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEMlQ72pqJoMpx7oCM/k4MknjIMZfLgHdqh7nObV2TE17H4azF11USs/RO9vc0zTPRw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5177), new TimeSpan(0, 0, 0, 0, 0)), "d69186e6-90f6-4508-b2db-c7d50db6e7e1", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "16654c07-9120-49ad-a16b-7dedb73159d0", 0, "77633afa-f1a6-4a0d-837b-a6a1fc86ef99", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEEC+El5jn86E7Nr4F496G2z4J65lPznFPcrID6bS+QqdoJr2TLDtWrw5ylXGCuyRnQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5170), new TimeSpan(0, 0, 0, 0, 0)), "d537a966-b2ca-4e25-b29b-7d0ef94e80b2", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "2f564689-d119-473f-a292-75fdee3977bd", 0, "253af6df-1723-412e-85be-9889a680859b", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEOZTgpI7c3rezipk4BKB0nujAwxYRWGe4qN6E3o+WGwOKWVAWDkDqZxgXThrpB+E5g==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5159), new TimeSpan(0, 0, 0, 0, 0)), "ba152584-d5bf-44d8-bfc0-fd81f712b07e", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "a4c898bd-90a6-48e7-ab07-210abb714d21", 0, "bfa61a21-06cf-497a-8183-7d3f0277b682", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEEde8IlRsKqxgLrjIZ2XH/Jr8y9+7303BB+oqhU/JjEE5fq8Hx3TwRe18HPM+jsIcg==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5152), new TimeSpan(0, 0, 0, 0, 0)), "a28834d7-26d7-4b35-a43c-35abd220c82b", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "b9fa0fe3-faa8-4492-be2f-c753162cf012", 0, "fd1bc820-fdb8-4cc0-8c7c-bf3a8a4a58f3", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEOU6GfCJqmjOt0/Neu5p8PHlxZ+SshCi4SjzVNndb+Qxyk2kadnLRwtwyjg12M94kw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5118), new TimeSpan(0, 0, 0, 0, 0)), "ec019927-1000-4969-aae6-1d7bbc577343", "Kernychna", false, "mapourse@gmail.com" },
                    { "7bbaa636-ee1e-4e53-bbae-42e6732fed4e", 0, "0a1e283e-e9b8-4e15-8319-1fc8bac7886a", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEPRvxF9wXJoYVcJ/3EFXD1ZylAQXenRjj2tD01lW/s1Fz/wDmBPwIKzjSkYeEnEoew==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5098), new TimeSpan(0, 0, 0, 0, 0)), "95dd76a7-a1b9-441d-ad12-80af011a4617", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 0, "299643c5-3296-4fd2-ab51-79528437d0ee", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAELvSqoRyE2nIDM3WFsD8K4LXqqMSST7yMV8CPvn6/QCcy5mDNHDSp+V+X4yrXY940g==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(5018), new TimeSpan(0, 0, 0, 0, 0)), "8dcf71bd-4cfe-4e6d-859e-93cc0fc0cb45", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "827617a5-5c27-4330-8f58-3d220522dbd9", 0, "b8c1c089-ccb9-488a-804a-ab70fb358227", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEBW6lyvvRJmLzdW54zSBdF4R6N02n8M7XvH/NE0ub/aNoTvdcq8/1pu6jk95JHJ6+Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 17, 20, 37, DateTimeKind.Unspecified).AddTicks(4179), new TimeSpan(0, 0, 0, 0, 0)), "c4d14aa6-1928-4614-9251-d06fb1071e03", "Chorrny", false, "chorrny228@gmail.com" }
========
                    { "71390e9a-2f46-4bd4-bbf5-de027b374201", 0, "45b9b39e-a8a7-4f8c-ba45-4ef2af5f9456", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEKxFtEXADefEDqUWDXnpUuxMd7pw/M2CoPY5IcbhS3UPY4+zHUAqb+NrwWKcY7oQ2A==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(7463), new TimeSpan(0, 0, 0, 0, 0)), "4466ed1f-d6ed-48da-a34c-df77b17052c9", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "875f6252-b065-423f-b765-6a2c58d0d1a4", 0, "3e5d5853-642b-423d-8ac2-aab8133343b4", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEDIPW+LTSVp3h9b+jqhqwkCNzBn7Eq+zuZ/YBnIqnoX6j41dHYm0Y+taenjyHjbb1Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, 0, 0, 0, 0)), "2ca86bad-7b28-4e3b-a70f-ca7357135945", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "7f1eb4c0-3473-4c57-9ae3-d33e5b343759", 0, "3e6c08fa-668a-4d9e-bc53-1e3ba11b60a2", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEICl4GusSeR4DGkCQpEEK7qsjx1gHzIwB51uDHrRgQnCp6euOPvEoWpHy6cQsnq3aA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(7371), new TimeSpan(0, 0, 0, 0, 0)), "98f796d7-0d2d-4459-970f-2b63fcc32402", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "c3f247b4-9d43-418e-9577-02d84f2e73c4", 0, "819c81b6-c292-4466-876d-98698d723f0d", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEBlDGUudYTT+TxXRnMuiIjLOmOqcccUWBAXn8+P8GB/rHnewGSG6YOtlIBICEwjhAw==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(7335), new TimeSpan(0, 0, 0, 0, 0)), "915fc6d9-b7d0-4c0d-8645-fed2222657f2", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "6ab34f01-150c-483e-a774-2341c1325168", 0, "264cf776-fc8b-421c-a7a3-c05908aa0773", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAELjcAPBBFEw/He9HcD3naTkiP+skjEZpWqMOTNv8PvTaM3FzyhGB6VvmRFw4NHsW2Q==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(7159), new TimeSpan(0, 0, 0, 0, 0)), "6105582e-774f-4b6d-844f-54de85ffa02b", "Kernychna", false, "mapourse@gmail.com" },
                    { "0b4b3d31-195e-4426-8b93-0b9f213214a2", 0, "d7ccf3a3-9dca-4aec-9aa8-91bad63f1dc4", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEMTAeO9f93pAtQl06OGR/4O4URrD6wNtdyK8bNgf1SBm9x5WzlOExAsfa2RZ6Xmlqg==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(7094), new TimeSpan(0, 0, 0, 0, 0)), "76032970-a592-4528-b4cd-904352714365", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 0, "d5d1062e-e479-4c3f-9386-73f9cdc7271a", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEJHsrdt2t7G0nW1vLRovNZjjDiMqdD2vlEkxmzupyaB6o5SbdFO8OPlo9dmsSfyxwA==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(6895), new TimeSpan(0, 0, 0, 0, 0)), "f46d805f-bb6d-4fd8-89da-34c8ae497b08", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "c6b27a07-440d-4c84-a49c-02c730a7cdc8", 0, "88f949c3-7904-43ee-8ed7-26a5add7ab2e", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEPXbppTy5cWop3ooVBxmXH3VkLX3/lnhc6YnbaiFwJWyoPv+e1uf+VCLnHRpQ+Ke8g==", null, false, null, new DateTimeOffset(new DateTime(2022, 7, 16, 14, 23, 4, 917, DateTimeKind.Unspecified).AddTicks(3869), new TimeSpan(0, 0, 0, 0, 0)), "fafe95ac-a18e-4f31-ad86-86ef9c7c7b42", "Chorrny", false, "chorrny228@gmail.com" }
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
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
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                    { "69ddf2d5-e24d-49a4-9142-b92dfc618251", "7bbaa636-ee1e-4e53-bbae-42e6732fed4e" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "a4c898bd-90a6-48e7-ab07-210abb714d21" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "16654c07-9120-49ad-a16b-7dedb73159d0" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "b9fa0fe3-faa8-4492-be2f-c753162cf012" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "2f564689-d119-473f-a292-75fdee3977bd" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "827617a5-5c27-4330-8f58-3d220522dbd9" },
                    { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "3cd07bd6-5909-4b72-9fcd-42959f303f96" }
========
                    { "08a62f14-7295-441a-b456-639704f5d05a", "0b4b3d31-195e-4426-8b93-0b9f213214a2" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "c3f247b4-9d43-418e-9577-02d84f2e73c4" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "875f6252-b065-423f-b765-6a2c58d0d1a4" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "6ab34f01-150c-483e-a774-2341c1325168" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "7f1eb4c0-3473-4c57-9ae3-d33e5b343759" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "37309b95-6a9b-4ee4-ade0-8484e09d6af7" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "c6b27a07-440d-4c84-a49c-02c730a7cdc8" },
                    { "0bac1c28-2240-4f93-8011-6354136f1ce2", "71390e9a-2f46-4bd4-bbf5-de027b374201" }
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                    { 8, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 857f, "Ford,F250 Super Duty Super Cab, Pickup", "BH2333XI", "U7F8WKT9PLIT4J1HIG74", "3cd07bd6-5909-4b72-9fcd-42959f303f96", "Y6GMFCCYUEAKI8XTY" },
                    { 7, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 953f, "Nissan,TITAN XD Crew Cab, Pickup", "BC7739AA", "YWGUKBKCNQ61SNLMBKQL", "3cd07bd6-5909-4b72-9fcd-42959f303f96", "DFC1UD8WT8UB059YM" },
                    { 5, 4, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 468f, "Porsche,Cayenne, SUV", "BH1232AA", "9XMCH56UHQQW0GTYWZ2F", "3cd07bd6-5909-4b72-9fcd-42959f303f96", "V7TTO2AINQUANMQ40" },
                    { 1, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 2, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 818f, "Jeep,Wrangler Unlimited, SUV", "AA4567XI", "9CXBLXJA6KXX9D8F81IW", "16654c07-9120-49ad-a16b-7dedb73159d0", "4O9DPJAG12GNWPOZZ" },
                    { 10, 4, "Green", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 940f, "Ford,F350 Super Duty Super Cab, Pickup", "AC1273IX", "ER1LZO2OOXPCU8YCMFVF", "a4c898bd-90a6-48e7-ab07-210abb714d21", "SD3XETJCC0WBPSIET" },
                    { 9, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 853f, "Jeep,Wrangler, SUV", "AA8992BH", "MCIWM8G3F0IIX98R94GW", "b9fa0fe3-faa8-4492-be2f-c753162cf012", "3JK0SKOIDP5TBUYQS" },
                    { 2, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 833f, "Nissan,Titan King Cab, Pickup", "BC2234OP", "53MBC6I4QXOGA88187Z0", "827617a5-5c27-4330-8f58-3d220522dbd9", "VGLGIQ8282JBYLN1C" },
                    { 4, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 536f, "Jeep,Wrangler Unlimited, SUV", "AC6344AC", "8DDCDHCHPYGLE69N7SKK", "827617a5-5c27-4330-8f58-3d220522dbd9", "XKDGHA1LILDKDKLWA" },
                    { 6, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 987f, "Jeep,Wrangler, SUV", "AA5421BH", "UNND3RYDWRYTS2FJOH4K", "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", "Z2QS67SZXKDG0K5GK" },
                    { 3, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 813f, "Ford,F250 Super Duty Super Cab, Pickup", "BH4456AI", "4S6MGGYR2U5YM85PVNSV", "b9fa0fe3-faa8-4492-be2f-c753162cf012", "LXY9NE6UM8D8ROFU2" }
========
                    { 8, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 919f, "Jeep,Wrangler, SUV", "BH2333XI", "CJ0D8G51UB92D41DH86Y", "71390e9a-2f46-4bd4-bbf5-de027b374201", "I5PQXS10O5XJTQC4Z" },
                    { 7, 3, "Green", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 586f, "Ford,F350 Super Duty Crew Cab, Pickup", "BC7739AA", "ZBBQZGN2G406TJUMB4CD", "71390e9a-2f46-4bd4-bbf5-de027b374201", "69CH7G4K3H04TWU94" },
                    { 5, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 838f, "Nissan,Titan Crew Cab, Pickup", "BH1232AA", "L823HKB9JNW7B9SK9EVO", "71390e9a-2f46-4bd4-bbf5-de027b374201", "J3CKN83V43Z5AOFEY" },
                    { 1, 3, "White", new DateTimeOffset(new DateTime(2016, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 739f, "Ford,F250 Super Duty Super Cab, Pickup", "AA4567XI", "KZRDHQ39SNVFGQ2IRC1K", "875f6252-b065-423f-b765-6a2c58d0d1a4", "UH02XFKJQOFO5EXLD" },
                    { 10, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 499f, "Ford,F250 Super Duty Super Cab, Pickup", "AC1273IX", "4ICHQGGHGLKEJMWMGJU8", "c3f247b4-9d43-418e-9577-02d84f2e73c4", "GWLOG07EETGE0MHUK" },
                    { 9, 3, "Green", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 909f, "Ford,F250 Super Duty Super Cab, Pickup", "AA8992BH", "6Q1FRTWMF1F7C0VOIJDZ", "6ab34f01-150c-483e-a774-2341c1325168", "45TBA1D96ZBRCENA5" },
                    { 2, 3, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 550f, "Porsche,Cayenne, SUV", "BC2234OP", "UGLINGV277LQ64ADETOP", "c6b27a07-440d-4c84-a49c-02c730a7cdc8", "70RKNK5YDG0F00EKA" },
                    { 4, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 590f, "Nissan,Titan Crew Cab, Pickup", "AC6344AC", "05P3RTT75EJBNP895D94", "c6b27a07-440d-4c84-a49c-02c730a7cdc8", "VXIHFXIFDZ7A4K01I" },
                    { 6, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 796f, "Porsche,911, Convertible, Coupe", "AA5421BH", "CB2SA8G8Q4NUJOZQWX35", "37309b95-6a9b-4ee4-ade0-8484e09d6af7", "S85Z34VFIHK77RASC" },
                    { 3, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 536f, "Nissan,Titan Crew Cab, Pickup", "BH4456AI", "GUYZ9N8YUFVPW9LQ3TAX", "6ab34f01-150c-483e-a774-2341c1325168", "5QQ49YUJPZSER6SKE" }
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodTransferConfirmedByCreator", "GoodTransferConfirmedByDriver", "GoodsWeight", "IsAnsweredByCreator", "IsAnsweredByDriver", "IsClosed", "NotificationId", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Towne - LuettgenBuckinghamshire Bermudian Dollar (customarily known as Bermuda Dollar) Sudanese Pound El Salvador Colon North Dakota Plaza Awesome Wooden Sausages Checking Account generating fresh-thinking Marketing Legacy Ghana wireless Function-based Accounts markets coherent.", 3, 455.46054f, false, null, "b9fa0fe3-faa8-4492-be2f-c753162cf012", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schmeler IncEgyptian Pound payment bi-directional zero defect foreground calculate client-driven Clothing, Music & Books virtual copying solid state Wyoming toolset Bahraini Dinar Norfolk Island platforms payment.", 6, 361.0103f, false, null, "827617a5-5c27-4330-8f58-3d220522dbd9", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Mayer, Keebler and WelchPersonal Loan Account optical process improvement Gourde Spur Integration Small Granite Towels Cambridgeshire Intelligent Soft Fish 24/365 Senegal transmitting Indiana Fresh drive bypass Handmade Frozen Salad Wooden SQL Georgia panel bus deliverables unleash Unbranded Rubber Table sexy Internal copy deposit.", 4, 852.6331f, false, null, "827617a5-5c27-4330-8f58-3d220522dbd9", 12, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kshlerin IncFresh Computers Consultant Ferry Incredible Metal Bike connecting metrics infrastructure Tasty Wooden Cheese Small Cotton Sausages experiences Future connecting sexy Virginia Corner action-items purple Wooden connecting card e-services JBOD Books, Books & Industrial Refined Steel Shirt withdrawal Central Refined Plastic Sausages.", 1, 495.88443f, false, null, "827617a5-5c27-4330-8f58-3d220522dbd9", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kassulke, Roob and BraunCape Verde Rustic Soft Chicken Swiss Franc overriding XML zero defect copy Ergonomic Metal Sausages grey Auto Loan Account Savings Account Cedi Tala Plastic Ergonomic Crest Trafficway Assistant Sleek Oman open architecture Agent Expressway compressing Rustic Savings Account Maryland.", 3, 496.42056f, false, null, "827617a5-5c27-4330-8f58-3d220522dbd9", 19, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Littel - Bergstromdriver teal applications Awesome Steel Computer Officer Ethiopian Birr open architecture blockchains Planner neural-net navigating Avon.", 2, 455.5708f, false, null, "3cd07bd6-5909-4b72-9fcd-42959f303f96", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Zemlak - Rogahnsuccess Practical Steel Chips Ergonomic Metal Hat Unbranded Concrete Shirt Facilitator Freeway Jordanian Dinar Small Metal Table Extension Switchable Small Rubber Sausages Books Global compressing Web forecast driver Kazakhstan.", 4, 969.90857f, false, null, "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 6, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 24, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Goldner - Funktransmitter synthesizing throughput Lesotho Loti tertiary Fantastic Fantastic Rubber Chips application calculating Group Handmade Concrete Shirt generate Pre-emptive invoice.", 1, 772.31976f, false, null, "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Roob IncOptimization Metal innovate SCSI Borders multi-byte Fresh utilize Fantastic Concrete Salad Incredible Rubber Keyboard Yemen seamless.", 2, 65.9285f, false, null, "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 9, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 4, 120f, false, null, "16654c07-9120-49ad-a16b-7dedb73159d0", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 7, 120f, false, null, "16654c07-9120-49ad-a16b-7dedb73159d0", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Marquardt and SonsNorth Carolina port Refined Fresh Fish parsing Villages Self-enabling connecting Refined Concrete Car Money Market Account Field.", 5, 375.50092f, false, null, "16654c07-9120-49ad-a16b-7dedb73159d0", 20, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Ortiz, Tillman and Doyleblue Montenegro next-generation Ireland Borders Future Implemented Operations overriding payment withdrawal iterate SMTP Implementation Small Plastic Computer Usability compressing Metal North Carolina Investment Account navigating Florida Developer AGP Cotton sky blue Secured pixel.", 3, 701.4669f, false, null, "16654c07-9120-49ad-a16b-7dedb73159d0", 15, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Rau - Gleichnergenerating haptic US Dollar salmon circuit invoice web services Bulgaria Generic Chief Cotton ROI open-source world-class Central African Republic Ports override Norfolk Island Sleek Auto Loan Account Representative Canadian Dollar Research copying invoice PNG copying.", 4, 743.85724f, false, null, "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 10, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Simonis, Zemlak and SchinnerHandmade Concrete Chips parsing Forward Supervisor Handcrafted Small Auto Loan Account matrix Concrete Internal Savings Account deposit Manager cohesive repurpose solid state copying Brand Rustic back-end transmitter firewall Creative Borders Czech Republic COM Incredible Steel Sausages pricing structure Beauty, Jewelery & Kids iterate.", 7, 176.92888f, false, null, "2f564689-d119-473f-a292-75fdee3977bd", 18, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Fadel GroupSupervisor invoice back-end value-added EXE Avon RAM virtual Netherlands Antillian Guilder magenta Trail Associate Steel Research Platinum transmitter.", 6, 813.09454f, false, null, "2f564689-d119-473f-a292-75fdee3977bd", 17, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 27, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Treutel - HillsBuckinghamshire Handmade Wooden Cheese integrate JSON calculating panel Supervisor Kansas zero defect backing up.", 3, 365.8376f, false, null, "2f564689-d119-473f-a292-75fdee3977bd", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 3, 120f, false, null, "a4c898bd-90a6-48e7-ab07-210abb714d21", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 5, 120f, false, null, "a4c898bd-90a6-48e7-ab07-210abb714d21", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 3, 120f, false, null, "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Doyle, Krajcik and StarkSenior Cambridgeshire quantifying Refined Wooden Gloves service-desk optical CSS Executive Cape bandwidth feed.", 6, 9.170117f, false, null, "a4c898bd-90a6-48e7-ab07-210abb714d21", 1, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 4, 120f, false, null, "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 6, 120f, false, null, "b9fa0fe3-faa8-4492-be2f-c753162cf012", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 6, 120f, false, null, "b9fa0fe3-faa8-4492-be2f-c753162cf012", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
========
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 21, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Nienow Incprogramming pixel Square Kina New Caledonia De-engineered IB Awesome Metal Ball Versatile deposit Eritrea Licensed Metal Chicken Buckinghamshire Tasty Frozen Soap Fields withdrawal.", 3, false, false, 493.58643f, false, false, false, null, "6ab34f01-150c-483e-a774-2341c1325168", 5, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Boyer, Ward and BinsADP Money Market Account online Unbranded bluetooth North Dakota Underpass Port District multi-byte Data Sao Tome and Principe Wyoming cutting-edge ROI Metal.", 6, false, false, 691.55023f, false, false, false, null, "c6b27a07-440d-4c84-a49c-02c730a7cdc8", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bauch - KoeppPrairie Producer Fall explicit Integration Handcrafted Frozen Pizza Investor FTP Incredible Switchable Lodge systems product Beauty Corner circuit driver Wisconsin Granite Avon Interactions Investment Account Tasty Concrete Cheese User-friendly Rubber compress Greece.", 3, false, false, 820.90485f, false, false, false, null, "c6b27a07-440d-4c84-a49c-02c730a7cdc8", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Deckow GroupMetical Berkshire Arkansas index Village platforms Money Market Account Dominican Peso empower Berkshire application Squares withdrawal Centralized Switchable Orchestrator RSS e-commerce intangible Fantastic Sao Tome and Principe.", 7, false, false, 288.0754f, false, false, false, null, "c6b27a07-440d-4c84-a49c-02c730a7cdc8", 14, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Romaguera IncWashington Tasty Soft Computer Group Creek GB Cayman Islands Underpass Practical Steel Bacon Liaison infrastructures Customer Solutions Home Loan Account Riel card niches Fort Unbranded Cotton Keyboard Fantastic mobile Parks feed.", 3, false, false, 937.6644f, false, false, false, null, "c6b27a07-440d-4c84-a49c-02c730a7cdc8", 19, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Keeling, Goodwin and KuhnMission Dynamic compressing open-source Maine middleware ivory partnerships Refined Home Loan Account Afghani moderator programming Generic Rubber Towels India Grocery portal parsing green.", 7, false, false, 287.24734f, false, false, false, null, "71390e9a-2f46-4bd4-bbf5-de027b374201", 11, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 24, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Nader, Corkery and FramiRAM Coordinator Generic Investment Account Borders back-end Clothing Fort Face to face Upgradable CSS calculate AI Sleek technologies withdrawal Generic deposit Throughway Metrics overriding SMS.", 3, false, false, 438.42502f, false, false, false, null, "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 6, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Stiedemann - AbbottRepresentative Re-contextualized white Virginia Rustic Wooden Fish Infrastructure Awesome Indian Rupee global Handcrafted approach Secured Programmable Licensed Steel Bacon niches River transmitting payment Valleys Metal Oklahoma Rubber customized Senior.", 3, false, false, 530.1173f, false, false, false, null, "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 29, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Goldner IncDirector Facilitator Money Market Account index Wyoming Fantastic Granite Gloves Beauty & Tools Handmade Fresh Chair deposit Trace Technician.", 3, false, false, 293.20004f, false, false, false, null, "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 2, false, false, 120f, false, false, false, null, "875f6252-b065-423f-b765-6a2c58d0d1a4", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 3, false, false, 120f, false, false, false, null, "875f6252-b065-423f-b765-6a2c58d0d1a4", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 23, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Bechtelar - BednarUnbranded Soft Chair Lock Fall microchip Springs platforms next-generation Small Plastic Sausages Identity uniform Ways interface Namibia Dollar AI.", 4, false, false, 209.35818f, false, false, false, null, "875f6252-b065-423f-b765-6a2c58d0d1a4", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kirlin, Hermiston and Vandervortstable Direct Rwanda Franc Refined Djibouti Franc Personal Loan Account open-source Unbranded Steel Sausages overriding Tasty Optimization didactic parse Maine connect Unbranded Rubber Tuna Lao People's Democratic Republic Streets Planner generating deposit pixel scale Home Loan Account.", 3, false, false, 502.46075f, false, false, false, null, "875f6252-b065-423f-b765-6a2c58d0d1a4", 15, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 24, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Dietrich - ReillyRidge FTP Incredible Liaison Technician Re-engineered Rubber Fantastic User-friendly Tanzanian Shilling radical markets Granite Quality Senegal IB deposit online XML Identity.", 3, false, false, 173.54837f, false, false, false, null, "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 10, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Connelly Incvirtual Incredible Fresh Chips Administrator copy Checking Account Associate Games & Outdoors Indiana proactive salmon reboot auxiliary Credit Card Account sticky Swaziland Refined Fresh Chips migration Synchronised Toys & Baby Panama.", 3, false, false, 116.76492f, false, false, false, null, "7f1eb4c0-3473-4c57-9ae3-d33e5b343759", 18, null, new DateTimeOffset(new DateTime(2022, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Stark, Hand and BalistreriBerkshire Rustic Montserrat optical generate Mountains Rustic Granite Towels enterprise holistic Ergonomic Plastic Mouse Savings Account radical Cuban Peso.", 1, false, false, 744.3036f, false, false, false, null, "7f1eb4c0-3473-4c57-9ae3-d33e5b343759", 17, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kihn - Kuvalistertiary Saint Helena Generic copy wireless Granite optimize Internal neural Intelligent Granite Towels Turkey Analyst pixel Usability copying Practical Granite Soap secondary International Ergonomic Berkshire.", 1, false, false, 538.32f, false, false, false, null, "7f1eb4c0-3473-4c57-9ae3-d33e5b343759", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 6, false, false, 120f, false, false, false, null, "c3f247b4-9d43-418e-9577-02d84f2e73c4", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 7, false, false, 120f, false, false, false, null, "c3f247b4-9d43-418e-9577-02d84f2e73c4", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 4, false, false, 120f, false, false, false, null, "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 22, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "O'Hara, Parker and Goldnerinvoice enhance overriding Cambridgeshire Human Dynamic olive connect Grenada focus group Gorgeous Soft Pizza Practical Metal Sausages matrix gold panel visionary Refined Frozen Hat bypassing collaborative plum compress Gorgeous Plastic Gloves cultivate Lake Awesome.", 4, false, false, 91.717606f, false, false, false, null, "c3f247b4-9d43-418e-9577-02d84f2e73c4", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 2, false, false, 120f, false, false, false, null, "37309b95-6a9b-4ee4-ade0-8484e09d6af7", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 4, false, false, 120f, false, false, false, null, "6ab34f01-150c-483e-a774-2341c1325168", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 3, false, false, 120f, false, false, false, null, "6ab34f01-150c-483e-a774-2341c1325168", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodTransferConfirmedByCreator", "GoodTransferConfirmedByDriver", "GoodsWeight", "IsAnsweredByCreator", "IsAnsweredByDriver", "IsClosed", "NotificationId", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Simonis and SonsNew Caledonia platforms deposit Intelligent Rubber Sausages bricks-and-clicks Kroon customized Human ADP protocol Mills Shoes, Garden & Electronics incentivize bus Colombian Peso.", 6, 230.69057f, false, null, "b9fa0fe3-faa8-4492-be2f-c753162cf012", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hessel LLCcalculate seamless integrate National New Jersey Oval encryption bypass Tunisia teal alarm Face to face Keys New Jersey Nevada Manor Intelligent Metal Shirt expedite Kids, Automotive & Movies Fantastic Implemented Bedfordshire neural-net initiatives Bridge.", 1, 136.47464f, false, null, "b9fa0fe3-faa8-4492-be2f-c753162cf012", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Abshire - ZemlakMadagascar Malta mobile Producer functionalities optimal Philippine Peso Intelligent calculating 3rd generation Investment Account Practical Cotton Chair engineer Plastic Trace Chief teal Investment Account salmon back-end Kip pixel Ridges tan cyan matrix capability proactive Licensed Rubber Mouse.", 3, 616.1658f, false, null, "16654c07-9120-49ad-a16b-7dedb73159d0", 4, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Casper, Bechtelar and OsinskiUnbranded Concrete Chair Brazilian Real Vatu strategize Plains XML interface Alley extranet Plain brand Cambridgeshire initiative invoice non-volatile Avon Borders Granite lime Practical open system Profit-focused cultivate Money Market Account infrastructures navigate high-level.", 6, 509.43704f, false, null, "a4c898bd-90a6-48e7-ab07-210abb714d21", 13, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
========
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Jenkins, Veum and Cartwrighthardware Fresh THX Israel Hollow Beauty Fantastic Fresh Car Delaware Stravenue compress Coordinator encryption bypass Savings Account Accountability.", 4, false, false, 316.62097f, false, false, false, null, "6ab34f01-150c-483e-a774-2341c1325168", 16, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Johns - Bahringercompressing Incredible Plastic Towels Identity US Dollar Balboa digital New Hampshire Macao payment strategic Principal multi-tasking virtual Handcrafted Plastic Bike Mexican Peso Refined Rubber Bike e-markets invoice green ubiquitous Regional protocol Personal Loan Account navigate Ohio mission-critical Generic Soft Tuna adapter.", 2, false, false, 490.4664f, false, false, false, null, "6ab34f01-150c-483e-a774-2341c1325168", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Schimmel and SonsProducer maximize quantify CSS generate calculating Views Kansas Personal Loan Account District Cotton Ergonomic engineer Dynamic deposit.", 6, false, false, 797.35803f, false, false, false, null, "875f6252-b065-423f-b765-6a2c58d0d1a4", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Marks - GleichnerAwesome Plastic Pants Facilitator transmitter Borders open-source Licensed Soft Table multimedia Executive Sleek Granite Bike Intelligent Steel Computer one-to-one proactive Concrete bluetooth Trail Engineer Principal capacitor Micronesia alarm Forks Underpass Drive bluetooth Ergonomic Concrete Cheese HDD Bedfordshire Reverse-engineered Frozen.", 3, false, false, 18.182854f, false, false, false, null, "c3f247b4-9d43-418e-9577-02d84f2e73c4", 13, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Trips",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                columns: new[] { "Id", "CreationDate", "DepartureDate", "Description", "Distance", "EndDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "I'm going from Kyiv to Rivne. So welcome!", 400f, null, false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.36545 50.45624, 28.68603 50.26679, 27.62649 50.58838, 26.2517 50.62034)"), 3, "b9fa0fe3-faa8-4492-be2f-c753162cf012" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreationDate", "DepartureDate", "Description", "Distance", "EndDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (25.35595 50.7553, 24.76512 50.50216, 24.63097 50.28358, 24.00991 49.77351, 23.85867 49.26081, 22.3112 48.60822)"), 10, "a4c898bd-90a6-48e7-ab07-210abb714d21" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreationDate", "DepartureDate", "Description", "Distance", "EndDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "It`s my first offer!", 150f, null, false, false, 2000f, 20, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.2557039 48.7424709, 30.3017199 48.1390924, 30.3174055 47.0235592, 30.6598914 46.4932837)"), 1, "16654c07-9120-49ad-a16b-7dedb73159d0" });
========
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.36545 50.45624, 28.68603 50.26679, 27.62649 50.58838, 26.2517 50.62034)"), new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "6ab34f01-150c-483e-a774-2341c1325168" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (25.35595 50.7553, 24.76512 50.50216, 24.63097 50.28358, 24.00991 49.77351, 23.85867 49.26081, 22.3112 48.60822)"), new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "c3f247b4-9d43-418e-9577-02d84f2e73c4" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "RouteGeographyData", "StartDate", "TransportationCarId", "TripCreatorId" },
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, (NetTopologySuite.Geometries.LineString)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;LINESTRING (30.2557039 48.7424709, 30.3017199 48.1390924, 30.3174055 47.0235592, 30.6598914 46.4932837)"), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "875f6252-b065-423f-b765-6a2c58d0d1a4" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

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
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "ad1a6e5f-6714-47f0-b5d3-6fa79a12f9f0");
========
                keyValue: "095f0ade-38fc-47c6-b275-4c90055714bc");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "16654c07-9120-49ad-a16b-7dedb73159d0" });
========
                keyValues: new object[] { "08a62f14-7295-441a-b456-639704f5d05a", "0b4b3d31-195e-4426-8b93-0b9f213214a2" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "2f564689-d119-473f-a292-75fdee3977bd" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "37309b95-6a9b-4ee4-ade0-8484e09d6af7" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "3cd07bd6-5909-4b72-9fcd-42959f303f96" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "6ab34f01-150c-483e-a774-2341c1325168" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "71390e9a-2f46-4bd4-bbf5-de027b374201" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "69ddf2d5-e24d-49a4-9142-b92dfc618251", "7bbaa636-ee1e-4e53-bbae-42e6732fed4e" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "7f1eb4c0-3473-4c57-9ae3-d33e5b343759" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "827617a5-5c27-4330-8f58-3d220522dbd9" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "875f6252-b065-423f-b765-6a2c58d0d1a4" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "a4c898bd-90a6-48e7-ab07-210abb714d21" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "c3f247b4-9d43-418e-9577-02d84f2e73c4" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValues: new object[] { "4cae7dec-9d43-4314-9cae-5baa3612aa91", "b9fa0fe3-faa8-4492-be2f-c753162cf012" });
========
                keyValues: new object[] { "0bac1c28-2240-4f93-8011-6354136f1ce2", "c6b27a07-440d-4c84-a49c-02c730a7cdc8" });
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

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
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
========
                table: "GoodCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
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
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "4cae7dec-9d43-4314-9cae-5baa3612aa91");
========
                keyValue: "08a62f14-7295-441a-b456-639704f5d05a");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "69ddf2d5-e24d-49a4-9142-b92dfc618251");
========
                keyValue: "0bac1c28-2240-4f93-8011-6354136f1ce2");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "2f564689-d119-473f-a292-75fdee3977bd");
========
                keyValue: "0b4b3d31-195e-4426-8b93-0b9f213214a2");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "3cd07bd6-5909-4b72-9fcd-42959f303f96");
========
                keyValue: "37309b95-6a9b-4ee4-ade0-8484e09d6af7");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "6d4818e4-ff28-4b6b-bcad-6f27c6ba8a43");
========
                keyValue: "71390e9a-2f46-4bd4-bbf5-de027b374201");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "7bbaa636-ee1e-4e53-bbae-42e6732fed4e");
========
                keyValue: "7f1eb4c0-3473-4c57-9ae3-d33e5b343759");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "827617a5-5c27-4330-8f58-3d220522dbd9");

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 3);
========
                keyValue: "c6b27a07-440d-4c84-a49c-02c730a7cdc8");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

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
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "16654c07-9120-49ad-a16b-7dedb73159d0");
========
                keyValue: "6ab34f01-150c-483e-a774-2341c1325168");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "a4c898bd-90a6-48e7-ab07-210abb714d21");
========
                keyValue: "875f6252-b065-423f-b765-6a2c58d0d1a4");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
                keyValue: "b9fa0fe3-faa8-4492-be2f-c753162cf012");
========
                keyValue: "c3f247b4-9d43-418e-9577-02d84f2e73c4");
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220716141720_AddSeed.cs
========
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
>>>>>>>> dev:Infrastructure/Migrations/20220716142306_AddSeed.cs
                keyValue: 4);
        }
    }
}
