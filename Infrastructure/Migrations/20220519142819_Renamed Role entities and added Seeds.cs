using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RenamedRoleentitiesandaddedSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Roles_CreatorRoleId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "Roles");

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

            migrationBuilder.CreateTable(
                name: "OfferRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferRoles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d0fcc4b-3661-4313-9eb3-90ac13f5390a", "1d0fcc4b-3661-4313-9eb3-90ac13f5390a", "Logist", "LOGIST" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "69fa01c1-e668-4614-a01d-e9716a07a2d5", "User", "USER" },
                    { "425a592e-8fc7-463f-87a7-77f5d5ac05a9", "425a592e-8fc7-463f-87a7-77f5d5ac05a9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07bd7727-f9d1-4258-a15d-a322adc28233", 0, "031166ce-9b33-4e34-801d-3a161ca1a45c", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEFjXuwi8t0aB5N+UPsJEDL0NfN+ltM7ezjDDkibTjcphuGOmnc9W5TttMXRyjwIJaw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6869), new TimeSpan(0, 0, 0, 0, 0)), "b03b1b2e-9c41-486b-a21c-154a08af724e", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "4eeb7de8-2ace-412e-8bd2-54ee369484ff", 0, "c047eba9-c20e-4471-9e7b-ddb793f0e9e5", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEPkP/UALVXFuYAvPXwwr5o0cYizkiWVeYUp9CsoMEwnuX6kldtpUz7+Q5yM1jb/MvA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6854), new TimeSpan(0, 0, 0, 0, 0)), "e827eee6-5499-4258-b0cd-6f203441b029", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4", 0, "25904b66-99d2-4fd6-bcd4-045b90b4a36d", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAELVbhhl2QSjFAFg2edwEHgoFx6PSKUqtgw4yqvSryelsgU41qrRMwxoBuIsUw50Lyg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 0, 0, 0, 0)), "bd0c5ece-2629-4be8-87f4-406d073acdf3", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "a59f1cac-b55c-4177-867a-76ce07d54dbf", 0, "88fb5fee-cd6d-47a7-bc9f-c624b8692e83", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAEOGhbB2v+wmTz8gCWHQVaXN0TWbWCMu8ekilsZ3bewzKGCouvgEg5PYoMbFWCtEGSA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6743), new TimeSpan(0, 0, 0, 0, 0)), "f9c854dc-18a4-45ff-9e86-54a1a6011993", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "3bf717ed-c2ae-4393-9ff7-5bece832e240", 0, "1108343c-954e-42d3-a50c-affd980cdc0e", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEJ7gXNFV0R9IP8NgzAAe8uhccQY3iu8FF8tFP0NWu2cdL98aDwHH0+FS3gMkXE+Cwg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, 0, 0, 0, 0)), "3f494238-2261-4def-9659-659534d1d98b", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "1229b494-9a5c-47af-9759-e987cbb1d4b2", 0, "fe842564-eb07-4889-bdb5-3772700c0fad", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEPeNiGWr3vxfYnIuIzTe/MilrYlaeuH/4G516aAEV9AlwHTlrWcnu2I6dsCl1VcfrA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6709), new TimeSpan(0, 0, 0, 0, 0)), "886c952f-2ba3-4142-a45d-bc2e18cd08e8", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "283e4baf-a46d-467e-8c3c-d7c58fa41046", 0, "deeb1aac-dc76-44fa-b6b7-607380a11224", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEB3/Kpast7pb6ZCJmZu23Py3TIhQxdsYAnMxVJJ6ZsAFlg2yrFQ/C9b0Ye3+mVRgTg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(6645), new TimeSpan(0, 0, 0, 0, 0)), "5bfc7653-6fcd-4466-87c5-1f1ae4d7d9ed", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", 0, "66e23b16-717a-45f3-91b6-b7801cd29994", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEKrinxDfGhsESgCrZ7X/faPALOT6vF1I514WNAlo/W5YHx3ISwUmpM0ZzdWgm4jBRg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 19, 14, 28, 18, 252, DateTimeKind.Unspecified).AddTicks(4967), new TimeSpan(0, 0, 0, 0, 0)), "3bb613bd-69cb-467c-87b7-f1a0e860f426", "Chorrny", false, "chorrny228@gmail.com" }
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
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement" },
                values: new object[,]
                {
                    { 2, "місто Шпанів, Рівненська область, вулиця Вереснева", 50.663542, 26.257569, 0, " Рівненська область", "Шпанів" },
                    { 20, "місто Житомир, Житомирська область, Богунський район", 50.259729999999998, 28.649229999999999, 0, "Житомирська область", "Житомир" },
                    { 19, "місто Біла церква, Київська область, вулиця Кірова", 49.807687086999998, 30.1144958, 0, "Київська область", "Біла церква" },
                    { 18, "Горбово, Чернігівська область, 16311", 51.45984, 31.561633, 0, "Чернігівська область", "Горбово" },
                    { 17, "Бобринець, Кіровоградська  область, вулиця Орджонікідзе", 48.061315, 32.158811, 0, "Кіровоградська  область", "Бобринець" },
                    { 16, "Центральний пайон, місто Миколаїв, Миколаївська область, вулиця Дачна", 47.044604, 32.030366999999998, 0, "Миколаївська область", "Миколаїв" },
                    { 15, "місто Миколаїв, Миколаївська область, вулиця Слов'янська", 47.032940848000003, 32.007182749999998, 0, "Миколаївська область", "Миколаїв" },
                    { 14, "місто Вінниця, Вінницька область, вулиця Братславська", 49.232585, 28.494243999999998, 0, "Вінницька область", "Вінниця" },
                    { 13, "Маків, Хмельницька  область, провулок Прорізний", 48.784157, 26.702999999999999, 0, "Хмельницька  область", "Маків" },
                    { 12, "місто Ужгород, Закарпатская область, вулиця Шишкіна, 1", 48.610622999999997, 22.317772999999999, 0, "Закарпатская область", "Ужгород" },
                    { 10, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.460256999999999, 35.018729, 0, "Дніпропетровська область", "Дніпро" },
                    { 9, "Новодонецьк, Донецька область, вулиця Благовісна", 48.633740000000003, 36.980499999999999, 0, "Донецька область", "Новодонецьк" },
                    { 8, "Ульянівка, Харківська область", 49.371445999999999, 35.513638, 0, "Харківська область", "Ульянівка" },
                    { 7, "Гаврилівка, Харківська область, вулиця Коцюбинського", 49.672877999999997, 35.660035000000001, 0, "Харківська область", "Дніпро" },
                    { 6, "Макаровка, Донецька область", 47.779212000000001, 36.801640999999996, 0, "Донецька область", "Макаровка" },
                    { 5, "місто Нікольське, Донецька область, вулиця Пушкіна", 47.200732350000003, 37.3148804, 0, "Донецька область", "Нікольське" },
                    { 4, "місто Дніпро, Дніпропетровська область, вулиця Юрія Савченко", 48.462322270000001, 35.021573400000001, 0, "Дніпропетровська область", "Дніпро" },
                    { 3, "місто Луцьк, Волинська область, вулиця Хрещата", 50.723970999999999, 25.386282000000001, 0, "Волинська область", "Луцьк" }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement" },
                values: new object[] { 1, "місто Остріг, Рівненська область, вулиця Східна", 50.328792, 26.527293, 0, "Рівненська область", "Острог" });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "Address", "Latitude", "Longitude", "Order", "Region", "Settlement" },
                values: new object[] { 11, "місто Львів, Львівська область, просп. Вячеслава Черновола, 11", 49.846894900000002, 4.0253360999999996, 0, "Львівська область", "Львів" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "07bd7727-f9d1-4258-a15d-a322adc28233" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "1229b494-9a5c-47af-9759-e987cbb1d4b2" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "4eeb7de8-2ace-412e-8bd2-54ee369484ff" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "3bf717ed-c2ae-4393-9ff7-5bece832e240" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "283e4baf-a46d-467e-8c3c-d7c58fa41046" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e" },
                    { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "a59f1cac-b55c-4177-867a-76ce07d54dbf" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 2, "Білий", new DateTimeOffset(new DateTime(2016, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 619.53314f, "M 542 M", "IEVDLP7F3I646M121HBY", "RJKZ3MT2M18AIAHI0A5Z", "07bd7727-f9d1-4258-a15d-a322adc28233", "XTSK1N7Y8I6JPZUVA" },
                    { 9, 4, "Синій", new DateTimeOffset(new DateTime(2016, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 535.33105f, "K 152 X", "U5X7YY7G0Z2AT6FSJ2EQ", "X5YNYXO7ZIIJVYST3CMA", "07bd7727-f9d1-4258-a15d-a322adc28233", "0R0WVNQOKR0BYP7A9" },
                    { 8, 4, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 600.7593f, "Q 179 D", "GENJB7H2820VOELGKXMB", "18PUEU3NN655PR6MIDGM", "07bd7727-f9d1-4258-a15d-a322adc28233", "YVNZ1KL9F70R37PT5" },
                    { 7, 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 588.2732f, "P 392 M", "JBZTDIV388V16TW8BGFD", "TOL0MNHQG53FNI9K1UD6", "07bd7727-f9d1-4258-a15d-a322adc28233", "SWM16XSTT16XOUQY6" },
                    { 6, 3, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 760.6366f, "N 999 K", "4JDHC3PPW882IJEQAMIU", "W06MS9Z74KQPQJQ08FJ9", "07bd7727-f9d1-4258-a15d-a322adc28233", "Y0SW0NQP6W05I3DQP" },
                    { 5, 3, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 3, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 565.36066f, "V 755 M", "R0K4SP2E520Y095919YH", "GSHDYC7IV5NWENRT5CK2", "07bd7727-f9d1-4258-a15d-a322adc28233", "QYUKLWVDAQV80YJ65" },
                    { 1, 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 824.19965f, "P 623 O", "BK1EQN2X80O6E5XWHB2W", "HA4NNRZVSG8YVSWAVV4D", "07bd7727-f9d1-4258-a15d-a322adc28233", "Y1FTNQHK70JO31GDR" },
                    { 2, 3, "Синій", new DateTimeOffset(new DateTime(2016, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 748.8656f, "D 802 U", "QAL8N1M6O7PC27U48E89", "8F7PVTH45PIN69PI1IUJ", "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", "UHDPD6XUFSWIJA3WD" },
                    { 3, 3, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 816.4727f, "A 988 S", "26SHB3QKOOFLQB6GA6B9", "PQNQFF550Y2SUSBILOLR", "1229b494-9a5c-47af-9759-e987cbb1d4b2", "7U4OCK6D9BPPZCJ22" },
                    { 4, 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 787.02655f, "O 752 P", "MQY0NVMKKKGISLQ3LYNP", "R35SZZIMQT3PH8HYDJJI", "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", "54JTQGCRBNW0UIL61" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "copying Missouri Planner rich New Israeli Sheqel Senior tan monitor Forges calculating.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 600.98145f, false, "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", 2, null, new DateTimeOffset(new DateTime(2022, 7, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Director matrix application Connecticut deposit Ergonomic Rubber Hat empowering Polarised syndicate grey Bond Markets Units European Composite Unit (EURCO) deploy payment alarm Generic Metal Mouse.", new DateTimeOffset(new DateTime(2022, 7, 8, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 952.275f, false, "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", 12, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "TCP architect Intelligent Soft Hat Estate Generic Intelligent Plastic Bike bypass Hawaii THX archive artificial intelligence parse Awesome Shoes, Outdoors & Garden Tasty Colombian Peso USB.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 684.08136f, false, "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", 14, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "firewall multi-byte pink Fresh Customer Identity olive synthesizing Beauty, Tools & Outdoors Inlet Bhutan payment bypassing Licensed Incredible Rubber Keyboard Borders Checking Account optimizing Steel Ridges magnetic Cameroon Investor withdrawal.", new DateTimeOffset(new DateTime(2022, 7, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 652.57825f, false, "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e", 19, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "invoice Granite IB strategize fuchsia intuitive generating Auto Loan Account Proactive Pennsylvania optimizing Diverse Future Assistant 5th generation Sri Lanka Baby Lithuanian Litas Bedfordshire open-source ivory metrics exuding calculate ROI deploy open system Customer Investor.", new DateTimeOffset(new DateTime(2022, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 588.6934f, false, "283e4baf-a46d-467e-8c3c-d7c58fa41046", 6, null, new DateTimeOffset(new DateTime(2022, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Soft Chief bricks-and-clicks enterprise Avon Consultant turn-key SSL Refined Soft Keyboard mindshare synergistic Awesome Fresh Fish Developer Movies & Tools Rubber calculating Sleek Handcrafted Fresh Tuna Mobility Walks.", new DateTimeOffset(new DateTime(2022, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 702.2551f, false, "283e4baf-a46d-467e-8c3c-d7c58fa41046", 7, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "neural-net system-worthy next generation Metal National withdrawal HTTP Parks Generic Granite Shirt Up-sized Corner Cotton Saint Helena niches parse Land Berkshire.", new DateTimeOffset(new DateTime(2022, 7, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 116.9796f, false, "283e4baf-a46d-467e-8c3c-d7c58fa41046", 9, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "e-commerce invoice hacking pink strategize Savings Account optimize Handmade Fresh Mouse architect Mauritius invoice Borders violet Universal deposit Berkshire tan Borders Balboa green mesh Engineer.", new DateTimeOffset(new DateTime(2022, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 110.36929f, false, "283e4baf-a46d-467e-8c3c-d7c58fa41046", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Markets innovate Balanced Baht communities Light Product Finland silver channels communities Baby & Books Wisconsin Tasty Frozen Soap Guyana Dollar Sleek Quality-focused Missouri.", new DateTimeOffset(new DateTime(2022, 7, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 126.26133f, false, "a59f1cac-b55c-4177-867a-76ce07d54dbf", 1, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Bangladesh parsing copying uniform hack Buckinghamshire whiteboard Baby, Home & Garden Buckinghamshire Games & Music overriding Unions Avon Steel web services encompassing New York violet Kuwaiti Dinar Chief multi-byte Cliff solutions index Steel Namibia.", new DateTimeOffset(new DateTime(2022, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 668.4513f, false, "1229b494-9a5c-47af-9759-e987cbb1d4b2", 11, null, new DateTimeOffset(new DateTime(2022, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Pound Sterling transmit transmitter Awesome Granite Pants maroon Fork invoice users 1080p blue Cape Verde Escudo Bedfordshire calculate optical didactic Awesome Rubber Shoes enhance programming tangible Clothing, Electronics & Movies Steel.", new DateTimeOffset(new DateTime(2022, 7, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 41.65277f, false, "1229b494-9a5c-47af-9759-e987cbb1d4b2", 20, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "International strategic Sharable RAM communities digital e-business sensor e-services Bedfordshire Sleek Granite Hat bypassing Specialist Borders Baby payment Engineer maroon pink.", new DateTimeOffset(new DateTime(2022, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 267.8336f, false, "3bf717ed-c2ae-4393-9ff7-5bece832e240", 5, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "dedicated Directives Nevada Bedfordshire port Factors metrics Causeway orange SQL overriding analyzing SMS Drives Re-contextualized Licensed Rubber Pants Peso Uruguayo Street Diverse.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 390.08023f, false, "4eeb7de8-2ace-412e-8bd2-54ee369484ff", 15, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Front-line Sports & Clothing Belize Dollar indexing primary Papua New Guinea Money Market Account deposit grey payment digital Street.", new DateTimeOffset(new DateTime(2022, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 394.5672f, false, "4eeb7de8-2ace-412e-8bd2-54ee369484ff", 4, null, new DateTimeOffset(new DateTime(2022, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "transmit hard drive quantifying Creek transmitter neural 3rd generation migration Small Frozen Pants Dale Assurance Rest Beauty, Beauty & Sports Concrete Research upward-trending convergence Licensed Plastic Bacon neural Belarussian Ruble Fantastic Plastic Salad Director Gorgeous Rubber Pizza Games, Baby & Clothing Savings Account.", new DateTimeOffset(new DateTime(2022, 7, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 976.43115f, false, "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Fantastic Passage navigating feed HTTP invoice secured line Intuitive New York Home Loan Account evolve.", new DateTimeOffset(new DateTime(2022, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 652.03516f, false, "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4", 17, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "vortals indigo program Auto Loan Account back up repurpose Analyst functionalities Buckinghamshire asymmetric circuit.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 710.86816f, false, "3bf717ed-c2ae-4393-9ff7-5bece832e240", 8, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Rustic Concrete Computer Representative Fantastic Buckinghamshire Iraq Bahamas Ports generating array AI Liaison portals e-markets Pound Sterling Auto Loan Account Generic Steel Bike schemas convergence Fort Universal Czech Republic yellow ubiquitous Automated Hawaii Producer Wooden Rial Omani.", new DateTimeOffset(new DateTime(2022, 7, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 546.89856f, false, "a59f1cac-b55c-4177-867a-76ce07d54dbf", 13, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Future 24/365 calculate Persevering Tasty Fresh Ball SDD website Manager Fantastic Steel Keyboard Lodge revolutionary invoice transmit Haven deposit Washington National benchmark enterprise.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 618.17096f, false, "3bf717ed-c2ae-4393-9ff7-5bece832e240", 16, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Practical Plastic Chicken Refined Producer Home Loan Account Cambridgeshire Fantastic Plastic Shirt Incredible Rubber Pants Administrator Object-based Sleek Practical Metal Pants Wallis and Futuna Point leading edge bandwidth digital Robust Intelligent Functionality cross-platform scalable calculating HTTP Branding indigo Home Loan Account multi-byte Gorgeous Grocery & Tools.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 99.324585f, false, "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4", 3, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_OfferRoles_CreatorRoleId",
                table: "Offers",
                column: "CreatorRoleId",
                principalTable: "OfferRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_OfferRoles_CreatorRoleId",
                table: "Offers");

            migrationBuilder.DropTable(
                name: "OfferRoles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d0fcc4b-3661-4313-9eb3-90ac13f5390a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "425a592e-8fc7-463f-87a7-77f5d5ac05a9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "07bd7727-f9d1-4258-a15d-a322adc28233" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "1229b494-9a5c-47af-9759-e987cbb1d4b2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "283e4baf-a46d-467e-8c3c-d7c58fa41046" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "3bf717ed-c2ae-4393-9ff7-5bece832e240" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "4eeb7de8-2ace-412e-8bd2-54ee369484ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "a59f1cac-b55c-4177-867a-76ce07d54dbf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69fa01c1-e668-4614-a01d-e9716a07a2d5", "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e" });

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
                keyValue: 7);

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
                keyValue: "69fa01c1-e668-4614-a01d-e9716a07a2d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07bd7727-f9d1-4258-a15d-a322adc28233");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1229b494-9a5c-47af-9759-e987cbb1d4b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283e4baf-a46d-467e-8c3c-d7c58fa41046");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bf717ed-c2ae-4393-9ff7-5bece832e240");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eeb7de8-2ace-412e-8bd2-54ee369484ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ae73725-bd78-4bd1-ad55-c92ec6ae41c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a59f1cac-b55c-4177-867a-76ce07d54dbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe0aae3f-c4b8-4e65-a9dd-37dc84f6395e");

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

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Roles_CreatorRoleId",
                table: "Offers",
                column: "CreatorRoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
