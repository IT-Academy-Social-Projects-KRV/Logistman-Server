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
                    { "9bf1e14b-9416-470c-b603-29a80705e7e2", "9bf1e14b-9416-470c-b603-29a80705e7e2", "Logist", "LOGIST" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "2e4c52f5-d3a1-4325-a182-5490ee860b62", "User", "USER" },
                    { "1d805b7c-0f96-4180-9172-a9f0909e925a", "1d805b7c-0f96-4180-9172-a9f0909e925a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Rating", "RegistrationDate", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2697f4eb-663d-4359-b56d-82d7ee95554f", 0, "15149f5f-785f-4f63-9945-8d9415b4ff1c", "User", "sergeyeremenko@gmail.com", true, false, null, "Sergey", "SERGEYEREMENKO@GMAIL.COM", "SERGEYEREMENKO@GMAIL.COM", "AQAAAAEAACcQAAAAEIYQxAuZlrdggQ7+90ApMtm5aZL+yysc5uVypGVr+Fbbb1aRAuQTuOm/+4ktWJpVdQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3537), new TimeSpan(0, 0, 0, 0, 0)), "5f4ee6a0-0636-4540-a094-da5da861ffd3", "Eremenko", false, "sergeyeremenko@gmail.com" },
                    { "3de11f5d-2d60-4c5d-a33c-fec059e512cd", 0, "9e22c310-b7bf-4930-8c96-72ec343c7d49", "User", "antonina.loboda@oa.edu.ua", true, false, null, "Antonina", "ANTONINA.LOBODA@OA.EDU.UA", "ANTONINA.LOBODA@OA.EDU.UA", "AQAAAAEAACcQAAAAEK+IUI9PnLV/oeT188D4XZg+b3f9vlfUc3Q1M2Tcv19iKdXg+DJKLyfHGyTq6OG9pw==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 0, 0, 0, 0)), "63efa427-e3f9-4d85-9539-65c6cf6477d8", "Loboda", false, "antonina.loboda@oa.edu.ua" },
                    { "16a596a8-cb00-4867-a6e8-6b234be66838", 0, "18262704-d7c0-4dcf-980f-7086f17458e1", "User", "pashunskyi@gmail.com", true, false, null, "Volodya", "PASHUNSKYI@GMAIL.COM", "PASHUNSKYI@GMAIL.COM", "AQAAAAEAACcQAAAAECdJ5jfilSSOfchCe70NiSWCkyjgktisb05kzuMLVKF0xFCxbOMxkuTEfN3LyyvrsQ==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3500), new TimeSpan(0, 0, 0, 0, 0)), "a7bb94f8-1370-40a9-9fc0-0d92b47f915c", "Pashunskyi", false, "pashunskyi@gmail.com" },
                    { "920f703c-7a57-4c6e-a282-dba36ddad3f0", 0, "064b529a-7592-4fba-8eca-b72ec727a469", "User", "yevhen.pasichnyk@oa.edu.ua", true, false, null, "Eugen", "YEVHEN.PASICHNYK@OA.EDU.UA", "YEVHEN.PASICHNYK@OA.EDU.UA", "AQAAAAEAACcQAAAAENSt5bsSusSbjugE+xqdhMiKBO/0LUnb1ybAB4AP3auG3qfFEax0IM+9SoVuzsNd1A==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3301), new TimeSpan(0, 0, 0, 0, 0)), "b04d1332-d165-4b02-b3b0-bc3df0cfb000", "Pasichnyk", false, "yevhen.pasichnyk@oa.edu.ua" },
                    { "4c829669-2bcc-4513-a23b-b452340a914c", 0, "4834e417-531f-4c11-a2b5-a7c97ff15c96", "User", "marynakernychna@gmail.com", true, false, null, "Maryna", "MARYNAKERNYCHNA@GMAIL.COM", "MARYNAKERNYCHNA@GMAIL.COM", "AQAAAAEAACcQAAAAEBpc3oV3fSvjqWGTk+p65gEqoOZtA9k2+WoDnAdcDAmhTYIZN0SdFD6pVMDY/O5Iqg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3280), new TimeSpan(0, 0, 0, 0, 0)), "2b1e5d7d-3e9c-43e8-b505-95ff55867f30", "Kernychna", false, "marynakernychna@gmail.com" },
                    { "ce31f424-03f6-44c5-9cba-7e34bbb49a11", 0, "65f4698c-77d2-45ca-9963-3da4c1d86719", "User", "andrewchepeliuk@gmail.com", true, false, null, "Andrii", "ANDREWCHEPELIUK@GMAIL.COM", "ANDREWCHEPELIUK@GMAIL.COM", "AQAAAAEAACcQAAAAEH69JnMGHhzXQJ41ffgFr9N+k5blFUT3obmuM5eYfnGQCNHUO403IAsS5nvFTA5B1w==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3249), new TimeSpan(0, 0, 0, 0, 0)), "8f0e8b46-0d99-4350-8084-8e9dd5879d0b", "Chepeliuk", false, "andrewchepeliuk@gmail.com" },
                    { "d84d5d8b-b183-4e45-849e-e832af8c7b24", 0, "8efa8d69-9658-45b5-8183-9b1ac89bb9db", "User", "oppaiarchmaster@gmail.com", true, false, null, "Vlad", "OPPAIARCHMASTER@GMAIL.COM", "OPPAIARCHMASTER@GMAIL.COM", "AQAAAAEAACcQAAAAECR6YzAGRTJC8ixmc40M2FwIRtc/sq3/qPtH1svydnw300lNwSIov2sOvFtbax0eOg==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(3129), new TimeSpan(0, 0, 0, 0, 0)), "e39cd43f-4539-401f-9e8f-a8a5403b8978", "Sevastyanov", false, "oppaiarchmaster@gmail.com" },
                    { "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", 0, "673fe9b5-5d91-4516-a11a-8cc9dc00c85e", "User", "chorrny228@gmail.com", true, false, null, "Vadym", "CHORRNY228@GMAIL.COM", "CHORRNY228@GMAIL.COM", "AQAAAAEAACcQAAAAENNJS1aXaWXRM5SXLC3tixQnN1mmPzm6gwWYcq6S+keFNxMJFoFtqTvMg9OKJX68wA==", null, false, null, new DateTimeOffset(new DateTime(2022, 5, 22, 16, 14, 23, 418, DateTimeKind.Unspecified).AddTicks(724), new TimeSpan(0, 0, 0, 0, 0)), "fd5183a8-72a3-4e6c-b8b1-7f405eb00742", "Chorrny", false, "chorrny228@gmail.com" }
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
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "2697f4eb-663d-4359-b56d-82d7ee95554f" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "ce31f424-03f6-44c5-9cba-7e34bbb49a11" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "3de11f5d-2d60-4c5d-a33c-fec059e512cd" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "4c829669-2bcc-4513-a23b-b452340a914c" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "16a596a8-cb00-4867-a6e8-6b234be66838" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "d84d5d8b-b183-4e45-849e-e832af8c7b24" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619" },
                    { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "920f703c-7a57-4c6e-a282-dba36ddad3f0" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Color", "CreationDate", "IsVerified", "LoadCapacity", "Model", "RegistrationNumber", "TechnicalPassport", "UserId", "Vin" },
                values: new object[,]
                {
                    { 10, 4, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 932.127f, "L 748 N", "FW375NVJDYY7NI6GCHZ4", "8SAFAWN1XAQ96K5X1I6M", "2697f4eb-663d-4359-b56d-82d7ee95554f", "PBGIHBAR5OHL9NMNX" },
                    { 9, 2, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 938.9524f, "G 209 C", "TVYHTKZQLWBGY775EO6U", "O3Q40L2TAVEVKV01HI5S", "2697f4eb-663d-4359-b56d-82d7ee95554f", "W2LU4PBAR529FQ5UG" },
                    { 8, 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 535.97174f, "C 196 J", "F1YN1JHRU8EL0SHJBGM4", "G4X14LENIQ4KP1BOZCQ0", "2697f4eb-663d-4359-b56d-82d7ee95554f", "OZTXG0YCVGHZXA3XJ" },
                    { 7, 4, "Зелений", new DateTimeOffset(new DateTime(2016, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 422.94492f, "H 532 H", "XXCNEI69YP268B4QL7R9", "2EGJ6IB96UCN59N274FX", "2697f4eb-663d-4359-b56d-82d7ee95554f", "TFQPY0SKPWI77IGTG" },
                    { 6, 2, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 669.78357f, "X 385 W", "PX70LP6HYA3IOP35CR46", "1TRV4AD27H06LC2OM6H6", "2697f4eb-663d-4359-b56d-82d7ee95554f", "MJKZJRUF7YR5TV6BW" },
                    { 5, 4, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 832.4816f, "P 869 V", "X3ZMK2JX3B3JRN3J5AZ0", "6FVHPZJU0SHELKMIUZS1", "2697f4eb-663d-4359-b56d-82d7ee95554f", "W7RLU62VMGLUOI8HX" },
                    { 1, 3, "Синій", new DateTimeOffset(new DateTime(2016, 7, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 827.57336f, "W 450 F", "DXW0E0M19TX01BUMH6E9", "I6P89DI1VN0BSHZ7K4OH", "2697f4eb-663d-4359-b56d-82d7ee95554f", "GYUJSG3D4WG4P68OR" },
                    { 2, 2, "Білий", new DateTimeOffset(new DateTime(2016, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 861.55347f, "D 661 V", "L7JCM2DHXKQQQDPL1YII", "4VOSSZWDOZ4MT59C94GB", "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", "IJZGHA1FGMN3OPIQJ" },
                    { 3, 3, "Червоний", new DateTimeOffset(new DateTime(2016, 7, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 713.6705f, "V 953 L", "3WK3DBXH6QPC4SCHLC8J", "IYPGJTIKT4RKK4VJW7N3", "ce31f424-03f6-44c5-9cba-7e34bbb49a11", "GDZDDY75LOLEX464J" },
                    { 4, 4, "Жовтий", new DateTimeOffset(new DateTime(2016, 7, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), true, 526.28784f, "R 152 Z", "4R0XSKDO40DICH6FKCOJ", "3Z56QDSN3A6GEDULD0FK", "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", "GEJMTMD39Z0IV5LT6" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "CreationDate", "CreatorRoleId", "Description", "ExpirationDate", "GoodCategoryId", "GoodsWeight", "IsClosed", "OfferCreatorId", "OfferPointId", "RelatedTripId", "StartDate" },
                values: new object[,]
                {
                    { 2, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Practical Cotton Tuna SMS Forward Refined generate Optimization Avon Berkshire throughput Wooden Supervisor Awesome Concrete Salad HDD matrix input hard drive Incredible invoice Sports & Electronics Benin Georgia XSS transmit orchid deposit Berkshire.", new DateTimeOffset(new DateTime(2022, 7, 5, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 493.30215f, false, "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", 2, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 12, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Cotton firewall Idaho convergence demand-driven intermediate Total integrate Generic Harbors Avon Handmade 1080p world-class.", new DateTimeOffset(new DateTime(2022, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 223.12445f, false, "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", 12, null, new DateTimeOffset(new DateTime(2022, 7, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 14, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Platinum Checking Account Sleek ROI grey National mission-critical Camp Afghani Avon Handmade Wooden Pizza withdrawal array Legacy Chief Internal USB transmitting context-sensitive middleware Cliffs synthesizing override impactful Leone.", new DateTimeOffset(new DateTime(2022, 7, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 333.86057f, false, "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", 14, null, new DateTimeOffset(new DateTime(2022, 7, 3, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 19, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "firewall azure withdrawal Greenland Guatemala generate transmitter Ergonomic Fantastic Steel Sausages infomediaries value-added Toys system Sri Lanka efficient New Jersey Borders redundant transform Cambridgeshire Incredible Wooden Shirt Beauty Pine Consultant Arizona purple Customer input JBOD Jersey.", new DateTimeOffset(new DateTime(2022, 7, 8, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 993.4552f, false, "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619", 19, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 6, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "payment payment Intelligent Metal Car lime Handmade Health Fantastic aggregate Ohio cross-platform.", new DateTimeOffset(new DateTime(2022, 7, 7, 22, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 2, 268.13687f, false, "d84d5d8b-b183-4e45-849e-e832af8c7b24", 6, null, new DateTimeOffset(new DateTime(2022, 7, 4, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 7, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "South Africa best-of-breed Nebraska JBOD Tasty Soft Pants knowledge user Liaison North Carolina Valley visualize black granular AI bluetooth transmitting open-source black systems Cambridgeshire maroon database array Rustic Plastic Soap SMS harness Solomon Islands deposit Intelligent withdrawal.", new DateTimeOffset(new DateTime(2022, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 178.89758f, false, "d84d5d8b-b183-4e45-849e-e832af8c7b24", 7, null, new DateTimeOffset(new DateTime(2022, 7, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 9, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Regional Developer Analyst Gorgeous Brand portals Implementation Licensed Granite Cheese override web-enabled France calculate Street silver Legacy Bedfordshire empower Devolved Gorgeous Metal Fish connecting Borders Oklahoma Spring JSON optical Yemeni Rial SMTP National Future Tasty.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 155.71786f, false, "d84d5d8b-b183-4e45-849e-e832af8c7b24", 9, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 10, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "benchmark Mount Brunei Darussalam Games, Movies & Outdoors Mandatory Tasty Intranet Massachusetts architectures Stand-alone strategize Auto Loan Account revolutionize bus Internal Open-architected focus group leverage transmitting PNG 5th generation.", new DateTimeOffset(new DateTime(2022, 7, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 3, 12.00223f, false, "d84d5d8b-b183-4e45-849e-e832af8c7b24", 10, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 1, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Functionality IB Colorado syndicate JBOD Western Sahara Missouri Tactics Brand methodical Buckinghamshire.", new DateTimeOffset(new DateTime(2022, 7, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 341.50674f, false, "920f703c-7a57-4c6e-a282-dba36ddad3f0", 1, null, new DateTimeOffset(new DateTime(2022, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 11, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "envisioneer Executive primary Unbranded model Administrator lavender eyeballs Rest Savings Account incubate North Dakota.", new DateTimeOffset(new DateTime(2022, 7, 7, 23, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 7, 464.6276f, false, "ce31f424-03f6-44c5-9cba-7e34bbb49a11", 11, null, new DateTimeOffset(new DateTime(2022, 7, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 20, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Peso Uruguayo Mobility national Legacy Minnesota Direct Horizontal auxiliary Falkland Islands (Malvinas) functionalities generating distributed Infrastructure Direct ivory invoice Generic uniform Money Market Account Central Electronics, Home & Industrial Product Intelligent lime intuitive Crest Sleek wireless application generate.", new DateTimeOffset(new DateTime(2022, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 819.124f, false, "ce31f424-03f6-44c5-9cba-7e34bbb49a11", 20, null, new DateTimeOffset(new DateTime(2022, 7, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 5, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Clothing & Toys Pennsylvania pink Licensed Plastic Towels schemas Beauty, Kids & Shoes Oklahoma GB Borders Movies sky blue user-centric extranet District salmon Personal Loan Account Berkshire Rustic Fresh Sausages extensible Jewelery needs-based Ferry Practical Concrete Car New Hampshire Wooden Italy Bedfordshire Refined Radial.", new DateTimeOffset(new DateTime(2022, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 960.7867f, false, "4c829669-2bcc-4513-a23b-b452340a914c", 5, null, new DateTimeOffset(new DateTime(2022, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 15, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "application Incredible Granite Shoes Administrator Ghana CSS USB radical Gambia Small Frozen Soap Aruba Steel Generic Cotton Bike Human Practical Granite Shoes discrete Orchestrator copying Total.", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 465.58517f, false, "3de11f5d-2d60-4c5d-a33c-fec059e512cd", 15, null, new DateTimeOffset(new DateTime(2022, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "quantify Wooden SSL full-range Up-sized Games, Electronics & Clothing Qatari Rial Fresh sky blue index.", new DateTimeOffset(new DateTime(2022, 7, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 43.919323f, false, "3de11f5d-2d60-4c5d-a33c-fec059e512cd", 4, null, new DateTimeOffset(new DateTime(2022, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 18, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Wooden IB Skyway Illinois Soft Handcrafted Concrete Shirt Steel Soft morph French Polynesia Clothing, Movies & Clothing Auto Loan Account Lakes Metal Fresh.", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 385.80078f, false, "16a596a8-cb00-4867-a6e8-6b234be66838", 18, null, new DateTimeOffset(new DateTime(2022, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 17, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "artificial intelligence toolset Ford Configurable Gateway Berkshire Analyst Berkshire schemas composite compressing distributed Legacy.", new DateTimeOffset(new DateTime(2022, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 626.5111f, false, "16a596a8-cb00-4867-a6e8-6b234be66838", 17, null, new DateTimeOffset(new DateTime(2022, 7, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 8, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Singapore Dollar Dynamic Buckinghamshire Administrator Global Engineer bandwidth ivory Practical Granite Fish benchmark knowledge user Front-line Danish Krone RAM transmit Toys, Outdoors & Industrial Tokelau.", new DateTimeOffset(new DateTime(2022, 7, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1, 621.8133f, false, "4c829669-2bcc-4513-a23b-b452340a914c", 8, null, new DateTimeOffset(new DateTime(2022, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 13, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Architect Trace Officer pink Security Shoes Awesome responsive New York driver clicks-and-mortar Somoni Legacy incremental Islands indigo Toys & Kids system Gorgeous Soft Keyboard Auto Loan Account Parks Ohio Cambridgeshire repurpose bus withdrawal bypass Practical.", new DateTimeOffset(new DateTime(2022, 7, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 4, 914.9135f, false, "920f703c-7a57-4c6e-a282-dba36ddad3f0", 13, null, new DateTimeOffset(new DateTime(2022, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 16, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2, "Auto Loan Account connect Gorgeous Tools framework Specialist methodologies Practical Concrete Bacon Bedfordshire magnetic Awesome Cotton Soap.", new DateTimeOffset(new DateTime(2022, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 6, 582.3728f, false, "4c829669-2bcc-4513-a23b-b452340a914c", 16, null, new DateTimeOffset(new DateTime(2022, 7, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 3, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "Handmade Concrete Cheese Usability Soft Washington Fort generate Small Steel Car Internal Iceland Steel deposit bus envisioneer Planner benchmark viral killer Solutions Personal Loan Account payment Licensed Metal Bacon.", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 5, 433.21613f, false, "16a596a8-cb00-4867-a6e8-6b234be66838", 3, null, new DateTimeOffset(new DateTime(2022, 7, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d805b7c-0f96-4180-9172-a9f0909e925a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bf1e14b-9416-470c-b603-29a80705e7e2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "16a596a8-cb00-4867-a6e8-6b234be66838" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "2697f4eb-663d-4359-b56d-82d7ee95554f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "3de11f5d-2d60-4c5d-a33c-fec059e512cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "4c829669-2bcc-4513-a23b-b452340a914c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "920f703c-7a57-4c6e-a282-dba36ddad3f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "ce31f424-03f6-44c5-9cba-7e34bbb49a11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e4c52f5-d3a1-4325-a182-5490ee860b62", "d84d5d8b-b183-4e45-849e-e832af8c7b24" });

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
                keyValue: "2e4c52f5-d3a1-4325-a182-5490ee860b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a596a8-cb00-4867-a6e8-6b234be66838");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2697f4eb-663d-4359-b56d-82d7ee95554f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3de11f5d-2d60-4c5d-a33c-fec059e512cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c829669-2bcc-4513-a23b-b452340a914c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "920f703c-7a57-4c6e-a282-dba36ddad3f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b55d1ecb-5c7e-4d5f-bb71-4e19e69c0619");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce31f424-03f6-44c5-9cba-7e34bbb49a11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d84d5d8b-b183-4e45-849e-e832af8c7b24");

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
