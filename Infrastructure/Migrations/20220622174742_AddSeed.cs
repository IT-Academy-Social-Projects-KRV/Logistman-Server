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
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                    { "629737e5-e92b-4f40-b971-fd105cae9315", "629737e5-e92b-4f40-b971-fd105cae9315", "Logist", "LOGIST" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "User", "USER" },
                    { "471ab40e-21c4-4a3b-a08a-f347605f4275", "471ab40e-21c4-4a3b-a08a-f347605f4275", "Admin", "ADMIN" }
========
                    { "e38d2623-73dd-4822-9102-4b3f3238da5f", "e38d2623-73dd-4822-9102-4b3f3238da5f", "Logist", "LOGIST" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "User", "USER" },
                    { "0d127f67-0fa9-4b1a-aeca-4b7a3b2e05d4", "0d127f67-0fa9-4b1a-aeca-4b7a3b2e05d4", "Admin", "ADMIN" }
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ConfirmationEmailToken", "ConfirmationEmailTokenExpirationDate", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                    { "78fe6d92-b365-41d5-96dd-a570f192d497", 0, "70e8f6f6-4ef0-4466-b0a9-f6039f71890a", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEOj6IzQDcB1KrW0YnfiMvvEXOMDcaBjukqgqrGfJr7CB8gsiFYMrCQoy4FQcUEYUvw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5467), new TimeSpan(0, 0, 0, 0, 0)), "3006d5e2-b5fd-4b28-b4b0-a529dbe8a54f", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "ac41d808-d947-45c3-932b-43fcf89258a4", 0, "6f0f3f31-5165-475e-857f-66d5bebac7d7", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAENOnBDiHcsrJWqt0VK2d0ESY5pOcNTJnKkaOdNtVAxhN9Rix8zzdFPP87PaKDWQeQg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5455), new TimeSpan(0, 0, 0, 0, 0)), "8283be7a-0220-4022-9df6-cd8f3e81f177", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "60bb67f5-8040-49b1-bdc2-01f888d7947f", 0, "6f0e9554-67ac-4d45-bc3f-011a34a5a485", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEPvmOVZVPPiC9eYMJhWhrUXaniN1oVjdLARB2i0gICQUHsnB5AfsN4GCpJqtVfwxuQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 0, 0, 0, 0)), "bf4d9b84-5b78-4da1-936e-0420a6a31def", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "716aa457-9187-4871-80a7-be0babb22b55", 0, "8ef908b4-3b76-4236-a97e-e7eb853ebad1", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEOYsUTtULVSm+Gt8CwzCW8MgGWBT+gOjqEBZQfTxBdIadDkNI+jaL4wW/DfeMXz3Aw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5405), new TimeSpan(0, 0, 0, 0, 0)), "764338e7-018f-4311-9aeb-6ece1a0a5f90", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "441ff6fd-8810-4813-bf09-884380221cb5", 0, "a6195b16-c57b-40a1-980c-040f137b1225", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEEa7+DGvtvrd51n3+o7kKSPgU/656KPiKZy90fcT/aBupUf5beaqgZSVzCn2u/Y3QA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5385), new TimeSpan(0, 0, 0, 0, 0)), "fc0008a5-0169-41c0-ba7d-e2b088d0c0cc", "Kernychna", false, "mapourse@gmail.com" },
                    { "2709afa4-8348-41ac-8ba5-4a4cf0eb5ff6", 0, "7263f743-76b0-40b9-a90d-5b8dd437e1ed", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEAwC/ltgIMDCsea4EQ5STfg7HWRJnCxEaZJPYlWm7mBRqU6yDeGEqAjq99q9amhqjw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5354), new TimeSpan(0, 0, 0, 0, 0)), "7784e3f3-3976-4fd0-b962-1318ef5b08ed", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 0, "3edfca43-c6c0-47df-8ec5-8be64bd96f6f", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEC6dCvz0fGYGvnEZsULz1Ln3C3OyAywlb6dTbOoINh2GAoSzxpYrV/xQJCIH6ogtMw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(5306), new TimeSpan(0, 0, 0, 0, 0)), "cc15d748-4bf7-405b-980b-d850839d266f", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "f5a1d598-d203-4dba-bc63-8f0077b72836", 0, "cf0fead7-25d1-47da-8050-0fd649c38228", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEKQTQKO3GU6S0GcMpFi42YXos/w+LEuO0Nbc43O+RwGK6PuuK8MV6Xy1D5+hLOwrSg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 42, 4, 598, DateTimeKind.Unspecified).AddTicks(3857), new TimeSpan(0, 0, 0, 0, 0)), "2352fa92-2aba-4952-9975-c1a44a1d5a42", "Chorrny", false, "chorrny228@gmail.com" }
========
                    { "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9", 0, "e75d95bd-2878-4bed-9ecf-32e564979bc2", null, null, "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEKguMc4/GgTOuKt0Fh8OfuVjME4bfO9KBjMoc95dJ4q9+k/Bzn0jWEeW7VCSCObvvw==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9819), new TimeSpan(0, 0, 0, 0, 0)), "72e0bf1f-0afa-4fe1-8cf5-e39a1ceddf42", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "1a48cc8d-49ee-4474-bbc7-42c670493ead", 0, "ffbbbcd8-efd4-43bd-aece-80091736907a", null, null, "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEH9OrTi5VSfsSImSOJu1KGw4ehYTuWUjGG3Ii2pejdmszlkZaKihRJJcesmTonehEg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9781), new TimeSpan(0, 0, 0, 0, 0)), "d22982f7-2927-4422-b43a-26b5419656b6", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "09b67a9c-a425-4e00-ab93-b8fbdfda9935", 0, "a86e8c34-b706-458b-b89f-c0f6641cba2e", null, null, "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEM2hcaZxl7Q1u6QQj6XAZbqplIpSLDmYf8ZMdFnmGvZNz0aquYQD8yBbrsib7c6OOA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9742), new TimeSpan(0, 0, 0, 0, 0)), "2469a52b-c203-4166-9a92-ea96ab81a433", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "44b5c39f-6843-4e6a-9857-578f6468a85f", 0, "09c97905-7172-401a-83dc-82fd1a46cc78", null, null, "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEFsEAD2QA2pyhWbwTOLi25KhcqYrreoMOhLUkK7tqn/oQJx1zxs4/BKxaY6q018NXQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9696), new TimeSpan(0, 0, 0, 0, 0)), "89eae9d8-c81e-4c73-af57-e10a1f654c6b", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", 0, "830b886b-78af-4576-a10a-68dba6205f59", null, null, "User", "mapourse@gmail.com", true, false, null, "Maryna", "MAPOURSE@GMAIL.COM", "MAPOURSE@GMAIL.COM", "AQAAAAEAACcQAAAAEFLc7gIGuUqkjx6Lr/fQLTyLIrarwoPJJXKz7cSeBHdt1gdKsTalYzwbIdslT0olTA==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9663), new TimeSpan(0, 0, 0, 0, 0)), "b7204621-b5aa-4eda-844d-ed6fc05141f0", "Kernychna", false, "mapourse@gmail.com" },
                    { "bcfefda4-d827-444c-adbf-fa0ba2c4ce99", 0, "f4a5f75d-ec27-431e-ac17-ff4e2b15f6fc", null, null, "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAECbn+ZFLCIHC5ZrIF9LFFrZERnsSyswbE0x2dyjAoBpExxU7X0dUKlaeMDtnehc3jg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9622), new TimeSpan(0, 0, 0, 0, 0)), "8058a4d0-19f7-490f-a029-b7de7dbfd4fe", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "03a4256d-832b-42a3-b801-91ee119e052b", 0, "cf3587af-7d73-4217-a4ba-3c46caa9b88b", null, null, "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEN1Ofqx5yxvg5A4AxIGmurwUOhZLIs9kyTzWnfrskm5inOnLC4oHSz1+nt2PWPYxvg==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(9384), new TimeSpan(0, 0, 0, 0, 0)), "644e04ec-3f5b-461a-ad08-55c97dd64de0", "Sievostyanov", false, "oppaiarchmaster@gmail.com" },
                    { "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", 0, "cf0e57f7-f157-4519-a64f-3a612ef950a6", null, null, "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEP1BVvdXjJpkcO3Y+y2oBAGtXWcPQF+JJAjuo2S9J9Hlp7VMQHYgQIpYB2p/x7TtTQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 6, 22, 17, 47, 39, 188, DateTimeKind.Unspecified).AddTicks(3724), new TimeSpan(0, 0, 0, 0, 0)), "fbb4ce49-6e57-4a3a-833e-08163d0f3fd1", "Chorrny", false, "chorrny228@gmail.com" }
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
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
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                    { "629737e5-e92b-4f40-b971-fd105cae9315", "2709afa4-8348-41ac-8ba5-4a4cf0eb5ff6" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "716aa457-9187-4871-80a7-be0babb22b55" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "ac41d808-d947-45c3-932b-43fcf89258a4" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "441ff6fd-8810-4813-bf09-884380221cb5" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "60bb67f5-8040-49b1-bdc2-01f888d7947f" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "f2c5fd07-7cdd-4da3-b779-74cebb4cba18" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "f5a1d598-d203-4dba-bc63-8f0077b72836" },
                    { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "78fe6d92-b365-41d5-96dd-a570f192d497" }
========
                    { "e38d2623-73dd-4822-9102-4b3f3238da5f", "bcfefda4-d827-444c-adbf-fa0ba2c4ce99" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "44b5c39f-6843-4e6a-9857-578f6468a85f" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "1a48cc8d-49ee-4474-bbc7-42c670493ead" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "c7a25c60-0e37-4d7d-8d79-1e136b1de05f" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "09b67a9c-a425-4e00-ab93-b8fbdfda9935" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "03a4256d-832b-42a3-b801-91ee119e052b" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "34fc4e4e-04b6-4252-97d1-4dd8d73b4183" },
                    { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9" }
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                    { 8, 3, "Blue", new DateTimeOffset(new DateTime(2016, 7, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 495f, "Nissan,Titan Crew Cab, Pickup", "BH2333XI", "U4728EIMV0YA3VLEMYCI", "78fe6d92-b365-41d5-96dd-a570f192d497", "7CI6FFCL94S0SB8NG" },
                    { 7, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 674f, "Nissan,TITAN XD Crew Cab, Pickup", "BC7739AA", "NI2TCOYVB591W94JZLYO", "78fe6d92-b365-41d5-96dd-a570f192d497", "MGFPPLD5E1PE3O4MZ" },
                    { 5, 2, "Green", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 784f, "Ford,F350 Super Duty Super Cab, Pickup", "BH1232AA", "BNO26RA96USD2XC8LUX1", "78fe6d92-b365-41d5-96dd-a570f192d497", "ZHWR0E9TQ25WH0V3B" },
                    { 1, 3, "Black", new DateTimeOffset(new DateTime(2016, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 739f, "Nissan,TITAN XD Crew Cab, Pickup", "AA4567XI", "OQS59MTWE1X4DE02P0SU", "ac41d808-d947-45c3-932b-43fcf89258a4", "2OEEVHSOUOKQHT7JC" },
                    { 10, 2, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 526f, "Nissan,Titan Crew Cab, Pickup", "AC1273IX", "XNNPED3E7R98AWMWQ81D", "716aa457-9187-4871-80a7-be0babb22b55", "IRTR95WC6406WTFDV" },
                    { 9, 2, "Blue", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 567f, "Nissan,Titan Crew Cab, Pickup", "AA8992BH", "1Q3ZTI7CP75D2XVJ2Z39", "441ff6fd-8810-4813-bf09-884380221cb5", "UH23A6ZH5MM96LE6M" },
                    { 2, 2, "Black", new DateTimeOffset(new DateTime(2016, 7, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 831f, "Porsche,Cayenne, SUV", "BC2234OP", "P3TM7R7IM3Q8IO3RUQC3", "f5a1d598-d203-4dba-bc63-8f0077b72836", "9KNX6V6N5H38CLLRO" },
                    { 4, 4, "White", new DateTimeOffset(new DateTime(2016, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 912f, "Ford,F250 Super Duty Super Cab, Pickup", "AC6344AC", "GR0TQCRD58V9MKDOSLKD", "f5a1d598-d203-4dba-bc63-8f0077b72836", "TOK5HUBIKVSQSD9JR" },
                    { 6, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 615f, "Ford,F350 Super Duty Super Cab, Pickup", "AA5421BH", "0ZCPFXA6ZENUOO75FRV0", "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", "Q76GBCHJU0D8YHJ1L" },
                    { 3, 2, "Yellow", new DateTimeOffset(new DateTime(2016, 7, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 980f, "Ford,F250 Super Duty Super Cab, Pickup", "BH4456AI", "KTHY53RHX0C7JU8ZAKCB", "441ff6fd-8810-4813-bf09-884380221cb5", "94ACI632MJJYOQ5Y1" }
========
                    { 8, 3, "Grey", new DateTimeOffset(new DateTime(2016, 7, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 741.8523f, "Nissan,Titan King Cab, Pickup", "463VKWT3DKOHQT83ZI36", "U38RNU1GE7BX755QI9K1", "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9", "Y35PLYT5ITMPR0YB7" },
                    { 7, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 453.2489f, "Porsche,911, Convertible, Coupe", "V7XLZRG3K3PQRQCQ18CK", "H35P4N1KHFXLU6TJMONN", "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9", "AWM55YEMBOU6BR28H" },
                    { 5, 2, "Black", new DateTimeOffset(new DateTime(2016, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 506.97357f, "Jeep,Wrangler, SUV", "8793G20M20IWVN9CZDUR", "TBWGVJ8TYY6U73PE551U", "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9", "T5IIMQH6J2JV7XAS7" },
                    { 1, 4, "Blue", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 732.0841f, "Jeep,Wrangler, SUV", "36PG3K3HF7S2U9F9KX5L", "9ZBI3EB9OIVK9B5F5G08", "1a48cc8d-49ee-4474-bbc7-42c670493ead", "067FA3B8I8K2T3V6D" },
                    { 10, 2, "Grey", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 721.6177f, "Ford,F350 Super Duty Crew Cab, Pickup", "N3VDGCA8I9TCOWLPDX8Y", "HREFIEC1WNTQK74SPQ0I", "44b5c39f-6843-4e6a-9857-578f6468a85f", "R6YDRK6RE8BSVWOGV" },
                    { 9, 4, "Green", new DateTimeOffset(new DateTime(2016, 7, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 586.09845f, "Nissan,Titan King Cab, Pickup", "59R9KOIKPX2LA54MX93N", "9PHAHE4R71U67USUDF0A", "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", "SVK3GVTP9GRPFGSGS" },
                    { 2, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 585.9063f, "Nissan,TITAN XD Crew Cab, Pickup", "XC7SI4043XX1GZ4BO47X", "GZM07I1KY3CZQ03UZMRZ", "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", "FBM0C4QVPK1WCYP6L" },
                    { 4, 3, "Red", new DateTimeOffset(new DateTime(2016, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 894.0181f, "Nissan,Titan Crew Cab, Pickup", "0MBRD5KPG9PDJPL4KNQQ", "ZLVR8WRYO82GA2NKIHM8", "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", "YLF8IX7VW50FIERJI" },
                    { 6, 4, "Red", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 767.6021f, "Nissan,Titan King Cab, Pickup", "3UNPSYV6TCZKKHRYDXHC", "RF3ACVR3CY41ZKPBUSTS", "03a4256d-832b-42a3-b801-91ee119e052b", "PQKANFJUUZBVWOQDD" },
                    { 3, 2, "Grey", new DateTimeOffset(new DateTime(2016, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 669.4889f, "Jeep,Wrangler Unlimited, SUV", "0KYBGWAB1D7MCKBD65XT", "3DSYUN44T1QWVYEQOPV7", "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", "N7T90EETFV4M1MS0H" }
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 20, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Lemke, Brakus and Hilpertfresh-thinking ADP Granite Technician reinvent Berkshire Electronics & Computers didactic Credit Card Account copying Wooden Refined Avon reboot unleash Alley HTTP Junction Incredible Wooden Fish networks Metal portals Accounts Indiana Borders Factors.", 3, 295.00455f, false, "441ff6fd-8810-4813-bf09-884380221cb5", 5, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 26, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Klocko IncSSL Industrial & Games Brunei Dollar Agent calculating Plastic Practical Awesome Borders solution port efficient multimedia Checking Account Refined Frozen Fish back up copy Division Washington wireless Handcrafted Fresh Cheese human-resource Malawi Designer Checking Account Buckinghamshire full-range HTTP Vista.", 3, 747.5013f, false, "f5a1d598-d203-4dba-bc63-8f0077b72836", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kuvalis IncTHX bypassing Handmade Wooden Gloves Road Regional mobile Street Vista Dominican Republic Consultant port aggregate Books Gorgeous Borders sticky Swiss Franc payment Sports Refined Metal Sausages web-enabled Small Nakfa Consultant bypassing Customer.", 1, 749.6888f, false, "f5a1d598-d203-4dba-bc63-8f0077b72836", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Jast, Windler and Conroyinvoice Frozen panel Awesome Soft Shirt niches Facilitator New Mexico Burundi Executive bluetooth quantify Mountains Handmade Plastic Pizza Outdoors Lead ROI Officer bleeding-edge Handcrafted Rubber Towels Direct moratorium withdrawal zero tolerance Movies sky blue e-business Administrator User-friendly reinvent Belize.", 4, 838.6254f, false, "f5a1d598-d203-4dba-bc63-8f0077b72836", 14, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 21, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Weimann, Rippin and Carteroverriding mint green zero administration Mountain Nevada utilisation Wooden overriding Practical Frozen Salad cross-media driver Configuration Guinea Franc AGP Music Legacy Mongolia indexing complexity Rustic Concrete Towels object-oriented Money Market Account Oklahoma Serbia.", 4, 215.47345f, false, "f5a1d598-d203-4dba-bc63-8f0077b72836", 19, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 29, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Thompson, Hessel and HarberField Sleek paradigm plug-and-play connect Response Web generate olive magenta cyan Chief Licensed Fresh Mouse port Avon e-services bluetooth grow Virginia Multi-tiered Designer Steel rich input program Generic Rubber Towels.", 4, 305.22983f, false, "78fe6d92-b365-41d5-96dd-a570f192d497", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kreiger, Shields and PurdyGames & Baby SSL knowledge base Unbranded toolset content Intelligent Coordinator Gorgeous primary.", 1, 951.1007f, false, "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 6, null, new DateTimeOffset(new DateTime(2022, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Stark - WeimannPort cultivate primary deposit Ergonomic Fresh Chair Assistant Human Investor RAM interface Versatile India IB Yemen Ergonomic Director South Carolina Intelligent Cotton Salad Barbados Dollar Soft lavender parse Fresh innovate Assistant 24/7 technologies niches Streamlined Christmas Island.", 5, 853.4419f, false, "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Denesik, Wunsch and DenesikColorado engage Handcrafted Granite Mouse alarm Usability pricing structure Buckinghamshire blockchains Future out-of-the-box New Israeli Sheqel Ethiopia Industrial & Electronics quantifying cross-platform indexing.", 2, 365.34372f, false, "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 9, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", 5, 120f, false, "ac41d808-d947-45c3-932b-43fcf89258a4", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", 2, 120f, false, "ac41d808-d947-45c3-932b-43fcf89258a4", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Gleichner - Greeninternet solution Team-oriented grey model User-friendly Credit Card Account salmon Berkshire deposit Unbranded back-end Bedfordshire COM Camp e-markets Small Frozen Shoes calculating 24/365 Egypt Unbranded Granite Towels Sleek Wooden Towels Developer Freeway.", 6, 192.37128f, false, "ac41d808-d947-45c3-932b-43fcf89258a4", 20, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 27, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Murazik - WestGrocery, Outdoors & Music Investment Account compress SMS Integration alarm Director Unbranded Metal Ball synergize Toys & Home SQL seize.", 4, 548.7604f, false, "ac41d808-d947-45c3-932b-43fcf89258a4", 15, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Donnelly - MullerRustic Wooden Sausages reinvent Unbranded Creative synergies Refined Metal Chips tan compressing Home Loan Account Principal Causeway Buckinghamshire Garden Buckinghamshire Concrete RSS Kids, Toys & Grocery driver.", 5, 61.020664f, false, "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Reichert - RohanAGP website Passage Saint Pierre and Miquelon optical Tasty wireless Reduced Fantastic Architect Intelligent Mills Concrete application Alabama Rustic Quality-focused Beauty & Outdoors lime Borders deposit Creative plum Credit Card Account auxiliary port wireless Tunisian Dinar.", 6, 855.76587f, false, "60bb67f5-8040-49b1-bdc2-01f888d7947f", 18, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Howell, Hilll and Pagacsystem engine Ergonomic Wooden Mouse Grocery, Automotive & Clothing Refined Cotton Chair Ergonomic Buckinghamshire programming payment Soft Hong Kong Dollar Representative e-commerce COM Supervisor info-mediaries benchmark Overpass Dynamic Generic Steel Salad Trail Planner Dynamic transmitting Money Market Account Grocery HTTP.", 6, 788.1108f, false, "60bb67f5-8040-49b1-bdc2-01f888d7947f", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Rutherford - MullerIdentity Ergonomic Concrete Tuna Lithuanian Litas enable New Caledonia ADP Handmade Wyoming Awesome Rubber Hat Cambridgeshire.", 4, 922.7722f, false, "60bb67f5-8040-49b1-bdc2-01f888d7947f", 3, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", 2, 120f, false, "716aa457-9187-4871-80a7-be0babb22b55", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", 1, 120f, false, "716aa457-9187-4871-80a7-be0babb22b55", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", 6, 120f, false, "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Zulauf and Sonscross-platform Money Market Account Handmade Granite Shirt Designer Money Market Account workforce payment Seamless Chief Gardens Licensed Rubber Salad.", 3, 393.99808f, false, "716aa457-9187-4871-80a7-be0babb22b55", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", 7, 120f, false, "f2c5fd07-7cdd-4da3-b779-74cebb4cba18", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", 5, 120f, false, "441ff6fd-8810-4813-bf09-884380221cb5", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", 5, 120f, false, "441ff6fd-8810-4813-bf09-884380221cb5", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
========
                    { 5, new DateTimeOffset(new DateTime(2022, 6, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Kertzmann GroupPhased Buckinghamshire Auto Loan Account auxiliary Practical Rubber Fish Intelligent Wooden Shirt Toys, Computers & Tools embrace human-resource Awesome Concrete Chips Associate local area network Ergonomic Metal Chips Multi-channelled Louisiana pricing structure Identity HTTP Baby & Industrial Terrace.", new DateTimeOffset(new DateTime(2022, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 573.05115f, false, "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", 5, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2022, 6, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Watsica - StrosinWyoming payment program Internal Intranet alarm Aruban Guilder UIC-Franc solutions Small PCI bypass bricks-and-clicks customized motivating Virginia firewall Guyana Dollar silver.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 895.8305f, false, "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", 2, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(2022, 6, 28, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Fritsch - Colewithdrawal Granite toolset JSON transmitting invoice Vermont Profound payment transmitting Canyon Arizona Manager content.", new DateTimeOffset(new DateTime(2022, 7, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 919.67303f, false, "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", 12, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(2022, 6, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Torp - BarrowsSavings Account lavender Handcrafted Wooden Pizza quantifying Rustic Fresh Hat Cocos (Keeling) Islands panel content-based Neck Nuevo Sol open system generating 6th generation Beauty National intranet capacity implement invoice back-end.", new DateTimeOffset(new DateTime(2022, 7, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 939.08124f, false, "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", 14, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(2022, 6, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hackett - AbbottClothing, Jewelery & Toys New York vortals compress Forge intranet driver ivory primary Synergistic Bhutanese Ngultrum deposit Incredible Rubber Mouse engineer Small Rubber Salad Practical Concrete Cheese Sleek parsing Field Alabama overriding.", new DateTimeOffset(new DateTime(2022, 7, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 282.4384f, false, "34fc4e4e-04b6-4252-97d1-4dd8d73b4183", 19, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(2022, 6, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Metz LLCSleek Soft Keyboard Rubber program connect withdrawal back up B2B morph magnetic card Sleek Agent SQL port Metal Auto Loan Account sky blue Home Loan Account system blue payment Canadian Dollar Street.", new DateTimeOffset(new DateTime(2022, 7, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 751.9098f, false, "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9", 11, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(2022, 6, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bartoletti - Daughertybottom-line Ergonomic Lake cross-platform Movies, Kids & Games Investor Granite Harbors Grocery & Books Integration Licensed Steel Chair pricing structure logistical California Palladium Implementation client-driven Licensed Metal Chair.", new DateTimeOffset(new DateTime(2022, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 234.43843f, false, "03a4256d-832b-42a3-b801-91ee119e052b", 6, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(2022, 6, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Roob GroupRefined Concrete Tuna navigate panel auxiliary Auto Loan Account Corporate Junction Refined Rubber Soap collaborative Facilitator Berkshire payment hard drive.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 428.2629f, false, "03a4256d-832b-42a3-b801-91ee119e052b", 7, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(2022, 6, 27, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Grimes, Runte and Nicolasfuchsia national Sleek Steel Bike Practical indigo encompassing Bedfordshire Borders virtual Principal plug-and-play Credit Card Account compress.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 261.45047f, false, "03a4256d-832b-42a3-b801-91ee119e052b", 9, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 28, new DateTimeOffset(new DateTime(2022, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 8 offer", new DateTimeOffset(new DateTime(2022, 8, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 120f, false, "1a48cc8d-49ee-4474-bbc7-42c670493ead", 28, null, new DateTimeOffset(new DateTime(2022, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 24, new DateTimeOffset(new DateTime(2022, 7, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 4 offer", new DateTimeOffset(new DateTime(2022, 7, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 120f, false, "1a48cc8d-49ee-4474-bbc7-42c670493ead", 24, null, new DateTimeOffset(new DateTime(2022, 7, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(2022, 6, 30, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Hermiston, MacGyver and BergstromSummit digital user-facing parsing generate Tasty Soft Chair capacitor Ports Sleek Plastic Salad generating Ford invoice Mountain CSS Generic Concrete Computer deposit analyzing Beauty Rustic Granite Car Integration Jamaica Moroccan Dirham Mountain Netherlands Antillian Guilder Generic Steel Ball Markets Polarised programming.", new DateTimeOffset(new DateTime(2022, 7, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 111.21928f, false, "1a48cc8d-49ee-4474-bbc7-42c670493ead", 20, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(2022, 6, 26, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Bode, Boyer and Kozeywithdrawal EXE Spur invoice Personal Loan Account white withdrawal Computers, Jewelery & Baby Global productize Club 1080p hard drive transmitter Stand-alone Technician Kyat Cape Wooden Incredible Soft Mouse responsive.", new DateTimeOffset(new DateTime(2022, 7, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 846.0786f, false, "1a48cc8d-49ee-4474-bbc7-42c670493ead", 15, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(2022, 6, 30, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Hudson - ParkerPlastic reintermediate hack THX Handmade infomediaries Specialist context-sensitive Grenada Fantastic Metal Pizza Representative Division.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 16.606855f, false, "03a4256d-832b-42a3-b801-91ee119e052b", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(2022, 6, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Grimes - CummerataCorporate Peso Uruguayo Configurable black Illinois hard drive empowering fresh-thinking District copying Specialist Dynamic Hawaii Drives Tunnel Crest Automotive & Jewelery payment multi-byte Toys & Sports Tools, Beauty & Automotive.", new DateTimeOffset(new DateTime(2022, 7, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 582.5323f, false, "09b67a9c-a425-4e00-ab93-b8fbdfda9935", 18, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(2022, 6, 30, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Senger, Reichel and EbertGeneric Soft Car Mayotte Rufiyaa Rustic Soft Shirt Intelligent Soft Table Mountain North Dakota Avenue Interactions ADP deploy Agent Extension Licensed Frozen Pants Alaska Dominican Peso Congolese Franc.", new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 106.79782f, false, "09b67a9c-a425-4e00-ab93-b8fbdfda9935", 17, null, new DateTimeOffset(new DateTime(2022, 7, 4, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(2022, 6, 30, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Marquardt LLCscalable transmitting Drives Organic Adaptive Lead Kansas Automotive, Games & Garden scale Key reboot Personal Loan Account copying Practical Soft Pants virtual Canyon Principal Bermuda Credit Card Account.", new DateTimeOffset(new DateTime(2022, 7, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 887.9175f, false, "09b67a9c-a425-4e00-ab93-b8fbdfda9935", 3, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 25, new DateTimeOffset(new DateTime(2022, 7, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 5 offer", new DateTimeOffset(new DateTime(2022, 7, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 120f, false, "44b5c39f-6843-4e6a-9857-578f6468a85f", 25, null, new DateTimeOffset(new DateTime(2022, 7, 24, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 21, new DateTimeOffset(new DateTime(2022, 7, 13, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 1 offer", new DateTimeOffset(new DateTime(2022, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 120f, false, "44b5c39f-6843-4e6a-9857-578f6468a85f", 21, null, new DateTimeOffset(new DateTime(2022, 7, 13, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 23, new DateTimeOffset(new DateTime(2022, 7, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 3 offer", new DateTimeOffset(new DateTime(2022, 7, 21, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 120f, false, "03a4256d-832b-42a3-b801-91ee119e052b", 23, null, new DateTimeOffset(new DateTime(2022, 7, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(2022, 6, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Ledner LLCwithdrawal Consultant Interactions Checking Account International interactive neutral Research withdrawal Creative Walks disintermediate connecting Home Loan Account Garden.", new DateTimeOffset(new DateTime(2022, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 503.30984f, false, "44b5c39f-6843-4e6a-9857-578f6468a85f", 1, null, new DateTimeOffset(new DateTime(2022, 7, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 27, new DateTimeOffset(new DateTime(2022, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "My 7 offer", new DateTimeOffset(new DateTime(2022, 7, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 120f, false, "03a4256d-832b-42a3-b801-91ee119e052b", 27, null, new DateTimeOffset(new DateTime(2022, 7, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 26, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 6 offer", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 120f, false, "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", 26, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 22, new DateTimeOffset(new DateTime(2022, 7, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "My 2 offer", new DateTimeOffset(new DateTime(2022, 7, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 120f, false, "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", 22, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 29, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Haley LLCPersonal Loan Account Money Market Account SCSI invoice Specialist Ridge Synergistic withdrawal strategize Kansas Lodge XML Refined Wooden Bike Engineer Re-engineered conglomeration Investment Account calculate Ports invoice.", 6, 329.07138f, false, "441ff6fd-8810-4813-bf09-884380221cb5", 16, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Rodriguez, Douglas and Wymanwithdrawal Buckinghamshire New York SMS payment Bedfordshire Ergonomic Granite Pants invoice Sports, Beauty & Automotive HDD Direct matrix Beauty & Industrial e-markets capacitor invoice copy Fresh.", 7, 582.4918f, false, "441ff6fd-8810-4813-bf09-884380221cb5", 8, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 21, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Renner, Ullrich and Wizazero defect architectures River infomediaries hierarchy Wooden B2C online payment Practical Turnpike Customizable Metal demand-driven pink 1080p Human 1080p Practical Granite Bacon Refined Wooden Shirt auxiliary.", 5, 605.2618f, false, "ac41d808-d947-45c3-932b-43fcf89258a4", 4, null, new DateTimeOffset(new DateTime(2022, 7, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Kiehn - Thielinput Trinidad and Tobago Dollar target Rustic Rubber Pizza Investment Account connecting Principal web-readiness Buckinghamshire Bolivia multi-byte Dynamic holistic Squares Extensions Refined Metal Pants e-enable XML Credit Card Account Avon.", 2, 974.8312f, false, "716aa457-9187-4871-80a7-be0babb22b55", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
========
                    { 16, new DateTimeOffset(new DateTime(2022, 6, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Langworth and Sonsback up Identity Direct Markets invoice focus group input Pennsylvania robust Gorgeous Soft Chair Regional digital South Dakota transitional leverage Steel attitude-oriented Secured models.", new DateTimeOffset(new DateTime(2022, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 250.15788f, false, "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(2022, 6, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, "Pagac - Bodemint green Cayman Islands Dollar deposit Generic Metal Gloves Intelligent Fresh Mouse AI Gorgeous Metal Mouse ROI Auto Loan Account Louisiana syndicate Locks Turnpike Saudi Arabia transmitter Small Fresh Hat infrastructures Direct Checking Account pixel sky blue.", new DateTimeOffset(new DateTime(2022, 7, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 470.43555f, false, "c7a25c60-0e37-4d7d-8d79-1e136b1de05f", 8, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(2022, 6, 20, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Fay IncInternational Refined Directives architect salmon Metal back up Rhode Island Jewelery bandwidth-monitored Moroccan Dirham generate Interactions Group Hong Kong Dollar Florida Fantastic parse Garden interface Kentucky heuristic Senior strategic task-force.", new DateTimeOffset(new DateTime(2022, 7, 6, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 417.3492f, false, "1a48cc8d-49ee-4474-bbc7-42c670493ead", 4, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(2022, 6, 26, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "Deckow, Funk and ReillyAlbania Lead Greenland cultivate client-driven District reciprocal Personal Loan Account Sleek Awesome blockchains Buckinghamshire encompassing Rustic Buckinghamshire.", new DateTimeOffset(new DateTime(2022, 7, 8, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 475.59598f, false, "44b5c39f-6843-4e6a-9857-578f6468a85f", 13, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "441ff6fd-8810-4813-bf09-884380221cb5" });
========
                values: new object[] { 2, "I'm going from Kyiv to Rivne. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, "c7a25c60-0e37-4d7d-8d79-1e136b1de05f" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "716aa457-9187-4871-80a7-be0babb22b55" });
========
                values: new object[] { 3, "I'm going from Lutsk to Uzhhorod. So welcome!", 400f, null, new DateTimeOffset(new DateTime(2022, 7, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 15, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 10, "44b5c39f-6843-4e6a-9857-578f6468a85f" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "Description", "Distance", "EndDate", "ExpirationDate", "IsActive", "IsEnded", "LoadCapacity", "MaxRouteDeviationKm", "StartDate", "TransportationCarId", "TripCreatorId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "ac41d808-d947-45c3-932b-43fcf89258a4" });
========
                values: new object[] { 1, "It`s my first offer!", 150f, null, new DateTimeOffset(new DateTime(2022, 8, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), false, false, 2000f, 20, new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, "1a48cc8d-49ee-4474-bbc7-42c670493ead" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

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
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "471ab40e-21c4-4a3b-a08a-f347605f4275");
========
                keyValue: "0d127f67-0fa9-4b1a-aeca-4b7a3b2e05d4");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "629737e5-e92b-4f40-b971-fd105cae9315", "2709afa4-8348-41ac-8ba5-4a4cf0eb5ff6" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "03a4256d-832b-42a3-b801-91ee119e052b" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "441ff6fd-8810-4813-bf09-884380221cb5" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "09b67a9c-a425-4e00-ab93-b8fbdfda9935" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "60bb67f5-8040-49b1-bdc2-01f888d7947f" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "1a48cc8d-49ee-4474-bbc7-42c670493ead" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "716aa457-9187-4871-80a7-be0babb22b55" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "34fc4e4e-04b6-4252-97d1-4dd8d73b4183" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "78fe6d92-b365-41d5-96dd-a570f192d497" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "44b5c39f-6843-4e6a-9857-578f6468a85f" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "ac41d808-d947-45c3-932b-43fcf89258a4" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "f2c5fd07-7cdd-4da3-b779-74cebb4cba18" });
========
                keyValues: new object[] { "e38d2623-73dd-4822-9102-4b3f3238da5f", "bcfefda4-d827-444c-adbf-fa0ba2c4ce99" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValues: new object[] { "655757cc-8a45-4f29-8366-65a3d6ed7cb0", "f5a1d598-d203-4dba-bc63-8f0077b72836" });
========
                keyValues: new object[] { "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a", "c7a25c60-0e37-4d7d-8d79-1e136b1de05f" });
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

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
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "629737e5-e92b-4f40-b971-fd105cae9315");
========
                keyValue: "e38d2623-73dd-4822-9102-4b3f3238da5f");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "655757cc-8a45-4f29-8366-65a3d6ed7cb0");
========
                keyValue: "fe4ea1da-2a59-4592-8b3d-802f8c91dc6a");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "2709afa4-8348-41ac-8ba5-4a4cf0eb5ff6");
========
                keyValue: "03a4256d-832b-42a3-b801-91ee119e052b");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "60bb67f5-8040-49b1-bdc2-01f888d7947f");
========
                keyValue: "09b67a9c-a425-4e00-ab93-b8fbdfda9935");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "78fe6d92-b365-41d5-96dd-a570f192d497");
========
                keyValue: "34fc4e4e-04b6-4252-97d1-4dd8d73b4183");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "f2c5fd07-7cdd-4da3-b779-74cebb4cba18");
========
                keyValue: "8b7e8060-b6fa-49a4-84a3-7dfca8e67cb9");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "f5a1d598-d203-4dba-bc63-8f0077b72836");
========
                keyValue: "bcfefda4-d827-444c-adbf-fa0ba2c4ce99");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: 4);
========
                keyValue: 3);
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

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
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "441ff6fd-8810-4813-bf09-884380221cb5");
========
                keyValue: "1a48cc8d-49ee-4474-bbc7-42c670493ead");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "716aa457-9187-4871-80a7-be0babb22b55");
========
                keyValue: "44b5c39f-6843-4e6a-9857-578f6468a85f");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: "ac41d808-d947-45c3-932b-43fcf89258a4");
========
                keyValue: "c7a25c60-0e37-4d7d-8d79-1e136b1de05f");
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategory",
                keyColumn: "Id",
<<<<<<<< HEAD:Infrastructure/Migrations/20220622184205_AddSeed.cs
                keyValue: 3);
========
                keyValue: 4);
>>>>>>>> dev:Infrastructure/Migrations/20220622174742_AddSeed.cs
        }
    }
}
