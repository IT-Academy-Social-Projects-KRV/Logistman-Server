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
                values: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2f59e656-1c8c-4380-8f5e-c9af1d9f923e", 0, "e35f3dd5-b81b-4e31-9472-86819cc33269", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antinina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEGA/q1ZCHh9MfMj2Ywflnd4nbTs9e5nFf7HXrCHgnGbiDRoSr/hrtf1yxiicQFMNtA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8774), new TimeSpan(0, 0, 0, 0, 0)), "1623873c-e74b-4ffb-9469-1d1baa1fc3f9", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "18dc3653-76b8-402f-8565-fec00f4ba88e", 0, "a84f1047-d9e6-408a-af4e-6f92b943f9e6", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAEKkNOX5ynf8xiO4c0gSUUM/jG5GW2rajh1g3gYgtHF9KISv0ArRIcAdc3i2UrVVcrQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8763), new TimeSpan(0, 0, 0, 0, 0)), "030745da-c9ee-47d6-88d4-0f580207a70b", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "eed5528c-22e0-4720-a3dc-63589ce5baaa", 0, "747bf6e3-659f-4fd4-85a1-b64e87beaa7b", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAECp9/av7PXo3N8GJSP3bKrt3ZSzLVnbVdfAiY8N6bXYmA4Q3sN/mpcwwSgp52wfdbA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8719), new TimeSpan(0, 0, 0, 0, 0)), "82daeaa1-e456-4a77-b6a7-59f83c759b8f", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d", 0, "946b4b53-0b17-4f23-99cc-7d77b687079e", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEGtlbH1aGqh/Ml3myv8i+yyAXIOm9Rh/Jk08jYkqfT8RhbYgzp8sNNysQPJDH3zQ8g==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 0, 0, 0, 0)), "88d5207f-92dc-4979-9b99-7efafb6755d6", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "84a076ee-a5ca-4c5f-99d0-bcb3f3725719", 0, "6edfa43d-6a9c-49df-970d-c8b62c5888ae", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEL3Xn3puQ7mwpLoY7KGR48ljU6pqrBJ7UfOjIiHmCHvbEVRP0VvLJpNhuxyH7kf3zw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "05419675-027e-44bd-8789-ddf1969c07d2", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "954f2ae5-4fa9-486e-b849-5a34163eadde", 0, "54ee598a-d32a-4689-ba8b-4ac8e3f04eb5", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAEKCH3yCsun0QiWS7rnosLA02Repwp98ZLY8acwfH0h4x9P0KtXeCdBBaNjVvzlt8Yw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8676), new TimeSpan(0, 0, 0, 0, 0)), "2d89b7c5-b45f-4234-b0d8-4c37b67c0413", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "9aabadb8-7e76-4908-b41a-787ab14958b8", 0, "416a99c0-55be-4f6e-b15e-0b57c7b971b9", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAEGSrBpmDb7TzT8JhzbnMAksuN3rAFppmFaYkXsVT3vR/S4gMUih/kxuZf3yrqrmWig==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(5655), new TimeSpan(0, 0, 0, 0, 0)), "c4ba14b9-e477-4f6f-9d5c-c91bfe95fafe", "Chorrny", false, "chorrny228@gmail.com" },
                    { "72dc18b2-5985-480c-a5e0-9565aba8b1e2", 0, "d20c0f14-821c-4757-b411-049cc9b94f38", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEGgg4PmP4cACm5PHfpIC4Q2ELmaCvPBkXk0FGtYZ66ewctKjZNq906jNhe/pYk6ZBA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 13, 13, 38, 52, 690, DateTimeKind.Unspecified).AddTicks(8782), new TimeSpan(0, 0, 0, 0, 0)), "cb91af82-12ba-434c-ae8f-9b7aedf00277", "Eremenko", false, "sergeyeremenko@gmail.com" }
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
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "72dc18b2-5985-480c-a5e0-9565aba8b1e2" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "84a076ee-a5ca-4c5f-99d0-bcb3f3725719" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "2f59e656-1c8c-4380-8f5e-c9af1d9f923e" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "18dc3653-76b8-402f-8565-fec00f4ba88e" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "954f2ae5-4fa9-486e-b849-5a34163eadde" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "9aabadb8-7e76-4908-b41a-787ab14958b8" },
                    { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "eed5528c-22e0-4720-a3dc-63589ce5baaa" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 2, "Сірий", new DateTimeOffset(new DateTime(2016, 7, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 750.5809f, "Z 803 I", "FXNTIR51AWOFHC5KWUXS", "PBZIOHLWYXCEUUA2DMOE", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "ZW9CXK4KS52ZM4X54" },
                    { 9, 2, "Білий", new DateTimeOffset(new DateTime(2016, 7, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 614.93616f, "F 140 B", "T40FR122BN1P49FAC5X9", "31O34LC22JBLSGGXI64M", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "M6QZ1F75QLASYSFXA" },
                    { 8, 4, "Синій", new DateTimeOffset(new DateTime(2016, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 436.19183f, "X 601 P", "8R9480RSQLUMV9I2RKYP", "UJMKHTX0LOJ0IUTR0PHM", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "UIA1JLVNFGYURO5ON" },
                    { 7, 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 739.3416f, "E 327 W", "DP6F2SBJ31BHX9GT53L5", "RPBB1CLAMJF3PO57SEBV", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "2G2J9TQNTLK34OEUD" },
                    { 6, 4, "Чорний", new DateTimeOffset(new DateTime(2016, 7, 3, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 483.30783f, "U 691 Z", "IPUKAZ6FA38IVIMGSNM6", "LGIRDSZH917VSP3JNH3J", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "ZKIXZUDNVG6HE1726" },
                    { 5, 2, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 583.24146f, "G 132 R", "FEGV2I5Y5B8VDDYCNTZE", "WZK3VYU15HBQ5JTNCGDP", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "GPL9I1EIBP9NRFUCZ" },
                    { 1, 2, "Синій", new DateTimeOffset(new DateTime(2016, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 635.50415f, "W 777 L", "6G19QGJSIH962KEF6JNK", "513TQR77OOSC2L726CU3", "72dc18b2-5985-480c-a5e0-9565aba8b1e2", "O81EYJ3EFL76A4D7J" },
                    { 2, 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 772.0755f, "C 830 R", "X3HCC8TOJ6FCUSBSO498", "74WA2PZTWV2LVK3AH6R6", "9aabadb8-7e76-4908-b41a-787ab14958b8", "NZVSIE75K7UKHT769" },
                    { 3, 3, "Синій", new DateTimeOffset(new DateTime(2016, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 455.22202f, "U 717 D", "THAP1BHC3MAGWFA6KLQA", "VRB2A2BX3WL4ZV2B7P5U", "84a076ee-a5ca-4c5f-99d0-bcb3f3725719", "RX6CARZGPE2E9167E" },
                    { 4, 3, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 920.7571f, "G 271 A", "6H1CZZUFV70ZDVYRJXN6", "71KM04ZA6UJLKX0V9EZH", "9aabadb8-7e76-4908-b41a-787ab14958b8", "6782SCG7GMM0T4WFC" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Forward internet solution Sleek Checking Account hacking interface enhance wireless compress Dale payment Rubber parse innovative North Carolina Fresh bus engineer invoice Central SCSI National Hong Kong Australia THX standardization.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 301.84183f, false, "9aabadb8-7e76-4908-b41a-787ab14958b8", 2, null, new DateTimeOffset(new DateTime(2022, 7, 5, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Steel Moldova Buckinghamshire Drive Cotton Principal Solutions sensor Wooden Forge Rustic Quality.", new DateTimeOffset(new DateTime(2022, 7, 7, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 386.2735f, false, "9aabadb8-7e76-4908-b41a-787ab14958b8", 12, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "optimal bypass Buckinghamshire Czech Koruna sexy open-source Gorgeous withdrawal Iceland Krona index data-warehouse Circle contingency.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 43.040337f, false, "9aabadb8-7e76-4908-b41a-787ab14958b8", 14, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Money Market Account override withdrawal Buckinghamshire Analyst Forest Fantastic Cotton Keyboard Island Borders primary Handmade Soft Computer Integration River Fall Accountability programming leverage Handcrafted Concrete Gloves Ergonomic transmit initiatives.", new DateTimeOffset(new DateTime(2022, 7, 9, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 94.41248f, false, "9aabadb8-7e76-4908-b41a-787ab14958b8", 19, null, new DateTimeOffset(new DateTime(2022, 7, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Montana teal red sensor Manager Borders Lithuanian Litas customer loyalty Locks Paradigm Tasty Generic Plastic Computer withdrawal.", new DateTimeOffset(new DateTime(2022, 7, 9, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 272.72256f, false, "954f2ae5-4fa9-486e-b849-5a34163eadde", 6, null, new DateTimeOffset(new DateTime(2022, 7, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "SMS cohesive Intelligent Fantastic deliverables Legacy Terrace Marketing front-end deposit Money Market Account Track Incredible mission-critical ADP bluetooth regional Neck white RAM Shoes & Sports Isle sky blue compelling.", new DateTimeOffset(new DateTime(2022, 7, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 454.97372f, false, "954f2ae5-4fa9-486e-b849-5a34163eadde", 7, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "schemas Wooden bottom-line Handmade Dynamic Global Frozen Tools & Clothing proactive Regional Coordinator Circles Books & Home connecting Applications Officer Planner structure Accountability overriding bluetooth invoice Investor object-oriented Port Sports generate yellow Buckinghamshire.", new DateTimeOffset(new DateTime(2022, 7, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 614.5894f, false, "954f2ae5-4fa9-486e-b849-5a34163eadde", 9, null, new DateTimeOffset(new DateTime(2022, 7, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "revolutionize deploy Steel South Carolina Walk partnerships Som Industrial hub Tactics red Soft Dam Self-enabling Camp Movies, Computers & Grocery innovative Yemen Avon Awesome Soft Chair copy Glen ROI green Bedfordshire open-source Zloty.", new DateTimeOffset(new DateTime(2022, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 880.2237f, false, "954f2ae5-4fa9-486e-b849-5a34163eadde", 10, null, new DateTimeOffset(new DateTime(2022, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Director International Upgradable bypassing Fantastic Cotton Mouse withdrawal technologies Kroon Research Avenue Keys SQL Tools & Baby demand-driven systems withdrawal Investment Account Vatu Auto Loan Account Legacy Persevering calculate matrices Operations Strategist Cambridgeshire generate solid state Product.", new DateTimeOffset(new DateTime(2022, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 681.33453f, false, "eed5528c-22e0-4720-a3dc-63589ce5baaa", 1, null, new DateTimeOffset(new DateTime(2022, 7, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "deposit Rhode Island synthesizing Berkshire algorithm Hollow feed HDD Antigua and Barbuda transmit Customer Generic Steel Table RAM.", new DateTimeOffset(new DateTime(2022, 7, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 123.667435f, false, "84a076ee-a5ca-4c5f-99d0-bcb3f3725719", 11, null, new DateTimeOffset(new DateTime(2022, 7, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Colorado Practical Granite Shirt attitude-oriented analyzing morph Awesome Granite Cheese disintermediate redundant Cambridgeshire Tasty Quality hack Object-based Savings Account back-end productivity policy French Polynesia Implementation auxiliary synthesize Polarised Parkway Optimization lime local area network.", new DateTimeOffset(new DateTime(2022, 7, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 21.822515f, false, "84a076ee-a5ca-4c5f-99d0-bcb3f3725719", 20, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Money Market Account optical haptic Parkway Ridge Savings Account Customer fault-tolerant RSS partnerships Global world-class Multi-lateral web services.", new DateTimeOffset(new DateTime(2022, 7, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 173.43477f, false, "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d", 5, null, new DateTimeOffset(new DateTime(2022, 7, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "24/365 Handmade hacking Ways distributed Berkshire hard drive quantifying XML Frozen Refined Frozen Keyboard Tunisian Dinar optimal vortals Plains intranet program New Jersey SSL killer Quality Generic North Carolina Proactive.", new DateTimeOffset(new DateTime(2022, 7, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 866.15686f, false, "2f59e656-1c8c-4380-8f5e-c9af1d9f923e", 15, null, new DateTimeOffset(new DateTime(2022, 7, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "synthesize RAM New Hampshire invoice Causeway Wells connect Incredible projection microchip hub digital static Cotton Handmade Frozen Hat Metal Multi-channelled Industrial & Automotive Saudi Riyal FTP Buckinghamshire Field optical value-added Handmade Rubber Gloves Dynamic calculating Freeway.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 748.21265f, false, "2f59e656-1c8c-4380-8f5e-c9af1d9f923e", 4, null, new DateTimeOffset(new DateTime(2022, 7, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "repurpose Checking Account Movies & Jewelery Field Executive enterprise Refined Frozen Ball SSL card Gorgeous Analyst Customer project Sleek Plastic Cheese Soft Licensed Mount protocol distributed payment Mews Rustic Plastic Chicken Industrial, Movies & Kids integrate Borders.", new DateTimeOffset(new DateTime(2022, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 492.1706f, false, "18dc3653-76b8-402f-8565-fec00f4ba88e", 18, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "New Jersey bus JBOD California Chief virtual Licensed Plastic Computer Computers & Beauty Berkshire transmitter Checking Account program transmit invoice compress.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 231.08293f, false, "18dc3653-76b8-402f-8565-fec00f4ba88e", 17, null, new DateTimeOffset(new DateTime(2022, 7, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "transform bus XML Representative Multi-lateral withdrawal methodologies Handmade Alaska Clothing & Grocery panel optical.", new DateTimeOffset(new DateTime(2022, 7, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 901.48065f, false, "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d", 8, null, new DateTimeOffset(new DateTime(2022, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Facilitator Pennsylvania Ways Groves Plastic experiences bifurcated Valley Fantastic Valley Buckinghamshire Checking Account Executive overriding Louisiana Triple-buffered Rubber Research solutions Sleek Metal Pizza Cambridgeshire deposit payment Principal value-added Bahraini Dinar.", new DateTimeOffset(new DateTime(2022, 7, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 297.519f, false, "eed5528c-22e0-4720-a3dc-63589ce5baaa", 13, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Program Unbranded Metal Towels GB CSS gold Security motivating Dynamic Personal Loan Account analyzer Intelligent Home Loan Account quantify Refined Soft Sausages implementation Parks compressing invoice.", new DateTimeOffset(new DateTime(2022, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 69.55308f, false, "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d", 16, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Wooden Borders Small Granite Cheese Tanzania Associate cross-platform Response neural protocol deploy dedicated National interactive PNG Rustic Frozen Bike copy facilitate copy Generic Frozen Mouse Investor Libyan Arab Jamahiriya distributed function Branding whiteboard.", new DateTimeOffset(new DateTime(2022, 7, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 908.89954f, false, "18dc3653-76b8-402f-8565-fec00f4ba88e", 3, null, new DateTimeOffset(new DateTime(2022, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "18dc3653-76b8-402f-8565-fec00f4ba88e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "2f59e656-1c8c-4380-8f5e-c9af1d9f923e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "72dc18b2-5985-480c-a5e0-9565aba8b1e2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "84a076ee-a5ca-4c5f-99d0-bcb3f3725719" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "954f2ae5-4fa9-486e-b849-5a34163eadde" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "9aabadb8-7e76-4908-b41a-787ab14958b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f30d4979-096d-48b9-aa73-ac9d147c2ce9", "eed5528c-22e0-4720-a3dc-63589ce5baaa" });

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
                keyValue: "f30d4979-096d-48b9-aa73-ac9d147c2ce9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18dc3653-76b8-402f-8565-fec00f4ba88e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f59e656-1c8c-4380-8f5e-c9af1d9f923e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66ce7899-9b6b-4c8a-97c3-a27bab0ca56d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72dc18b2-5985-480c-a5e0-9565aba8b1e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84a076ee-a5ca-4c5f-99d0-bcb3f3725719");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "954f2ae5-4fa9-486e-b849-5a34163eadde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9aabadb8-7e76-4908-b41a-787ab14958b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eed5528c-22e0-4720-a3dc-63589ce5baaa");

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
