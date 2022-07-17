using Bogus;
using Core.Constants;
using Core.Entities.CarCategoryEntity;
using Core.Entities.CarEntity;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.RoleEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using System;

namespace Infrastructure.Data.SeedData
{

    public static class SeedData
    {
        #region Users

        private static readonly string VADIM_ID = Guid.NewGuid().ToString();
        private static readonly string VLAD_ID = Guid.NewGuid().ToString();
        private static readonly string ANDREW_ID = Guid.NewGuid().ToString();
        private static readonly string MARYNA_ID = Guid.NewGuid().ToString();
        private static readonly string EUGEN_ID = Guid.NewGuid().ToString();
        private static readonly string VOLODYA_ID = Guid.NewGuid().ToString();
        private static readonly string ANTONINA_ID = Guid.NewGuid().ToString();
        private static readonly string SERGEY_ID = Guid.NewGuid().ToString();

        #endregion

        #region Roles

        private static readonly string ROLE_USER_ID = Guid.NewGuid().ToString();
        private static readonly string ROLE_ADMIN_ID = Guid.NewGuid().ToString();
        private static readonly string ROLE_LOGIST_ID = Guid.NewGuid().ToString();

        #endregion

        #region ArraysOfRoutesCoordinates

        private static readonly Coordinate[] FirstRouteCoordinates = new Coordinate[] {
            new Coordinate(30.2557039, 48.7424709),
            new Coordinate(30.3017199, 48.1390924),
            new Coordinate(30.3174055, 47.0235592),
            new Coordinate(30.6598914, 46.4932837)};
        private static readonly Coordinate[] SecondRouteCoordinates = new Coordinate[] {
            new Coordinate(30.36545, 50.45624),
            new Coordinate(28.68603, 50.26679),
            new Coordinate(27.62649, 50.58838),
            new Coordinate(26.2517, 50.62034)};
        private static readonly Coordinate[] ThirdRouteCoordinates = new Coordinate[] {
            new Coordinate(25.35595, 50.7553),
            new Coordinate(24.76512, 50.50216),
            new Coordinate(24.63097, 50.28358),
            new Coordinate(24.00991, 49.77351),
            new Coordinate(23.85867, 49.26081),
            new Coordinate(22.3112, 48.60822)};

        #endregion

        private static readonly string[] _colors = new[]
            {"Red","Black","White","Grey","Green","Blue","Yellow"};

        private static readonly string[] _cars = new[]
            {
                "Jeep,Wrangler, SUV",
                "Jeep,Wrangler Unlimited, SUV",
                "Ford,F250 Super Duty Super Cab, Pickup",
                "Ford,F350 Super Duty Crew Cab, Pickup",
                "Ford,F350 Super Duty Super Cab, Pickup",
                "Nissan,Titan Crew Cab, Pickup",
                "Nissan,Titan King Cab, Pickup",
                "Nissan,TITAN XD Crew Cab, Pickup",
                "Porsche,911, Convertible, Coupe",
                "Porsche,Cayenne, SUV"
            };

        private static readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
        private static readonly Faker _faker = new Faker();
        private static readonly float _maxWeight = 1000f;

        public static void Seed(this ModelBuilder builder)
        {
            SeedRole(builder);
            SeedIdentityRole(builder);
            SeedGoodCategory(builder);
            SeedCarCategory(builder);
            SeedUser(builder);
            SeedIdentityUserRole(builder);
            SeedPoint(builder);
            SeedRoute(builder);
            SeedOffer(builder);
            SeedCar(builder);
        }

        #region SeedUser

        public static void SeedUser(ModelBuilder builder)
        {
            var userVadim = new User()
            {
                Id = VADIM_ID,
                Name = "Vadym",
                Surname = "Chorrny",
                UserName = "chorrny228@gmail.com",
                NormalizedEmail = "chorrny228@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "chorrny228@gmail.com".ToUpper(),
                Email = "chorrny228@gmail.com"
            };
            var userVlad = new User()
            {
                Id = VLAD_ID,
                Name = "Vlad",
                Surname = "Sievostyanov",
                UserName = "oppaiarchmaster@gmail.com",
                NormalizedEmail = "oppaiarchmaster@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "oppaiarchmaster@gmail.com".ToUpper(),
                Email = "oppaiarchmaster@gmail.com"
            };
            var userAndrew = new User()
            {
                Id = ANDREW_ID,
                Name = "Andrii",
                Surname = "Chepeliuk",
                UserName = "andrewchepeliuk@gmail.com",
                NormalizedEmail = "andrewchepeliuk@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "andrewchepeliuk@gmail.com".ToUpper(),
                Email = "andrewchepeliuk@gmail.com"
            };
            var userMaryna = new User()
            {
                Id = MARYNA_ID,
                Name = "Maryna",
                Surname = "Kernychna",
                UserName = "mapourse@gmail.com",
                NormalizedEmail = "mapourse@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "mapourse@gmail.com".ToUpper(),
                Email = "mapourse@gmail.com"
            };
            var userEugen = new User()
            {
                Id = EUGEN_ID,
                Name = "Eugen",
                Surname = "Pasichnyk",
                UserName = "yevhen.pasichnyk@oa.edu.ua",
                NormalizedEmail = "yevhen.pasichnyk@oa.edu.ua".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "yevhen.pasichnyk@oa.edu.ua".ToUpper(),
                Email = "yevhen.pasichnyk@oa.edu.ua"
            };
            var userVolodya = new User()
            {
                Id = VOLODYA_ID,
                Name = "Volodya",
                Surname = "Pashunskyi",
                UserName = "pashunskyi@gmail.com",
                NormalizedEmail = "pashunskyi@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "pashunskyi@gmail.com".ToUpper(),
                Email = "pashunskyi@gmail.com"
            };
            var userAntonina = new User()
            {
                Id = ANTONINA_ID,
                Name = "Antonina",
                Surname = "Loboda",
                UserName = "antonina.loboda@oa.edu.ua",
                NormalizedEmail = "antonina.loboda@oa.edu.ua".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "antonina.loboda@oa.edu.ua".ToUpper(),
                Email = "antonina.loboda@oa.edu.ua"
            };
            var userSergey = new User()
            {
                Id = SERGEY_ID,
                Name = "Sergey",
                Surname = "Eremenko",
                UserName = "sergeyeremenko@gmail.com",
                NormalizedEmail = "sergeyeremenko@gmail.com".ToUpper(),
                EmailConfirmed = true,
                NormalizedUserName = "sergeyeremenko@gmail.com".ToUpper(),
                Email = "sergeyeremenko@gmail.com"
            };
            userVadim.PasswordHash = _passwordHasher
                .HashPassword(userVadim, "Password_1");
            userVlad.PasswordHash = _passwordHasher
                .HashPassword(userVlad, "Password_1");
            userAndrew.PasswordHash = _passwordHasher
                .HashPassword(userAndrew, "Password_1");
            userMaryna.PasswordHash = _passwordHasher
                .HashPassword(userMaryna, "Password_1");
            userEugen.PasswordHash = _passwordHasher
                .HashPassword(userEugen, "Password_1");
            userVolodya.PasswordHash = _passwordHasher
                .HashPassword(userVolodya, "Password_1");
            userAntonina.PasswordHash = _passwordHasher
                .HashPassword(userAntonina, "Password_1");
            userSergey.PasswordHash = _passwordHasher
                .HashPassword(userSergey, "Password_1");
            builder.Entity<User>()
                .HasData(
                    userVadim,
                    userVlad,
                    userAndrew,
                    userMaryna,
                    userEugen,
                    userVolodya,
                    userAntonina,
                    userSergey
                    );
        }

        #endregion

        #region SeedIdentityRole

        public static void SeedIdentityRole(ModelBuilder builder) =>
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Id = ROLE_USER_ID,
                    Name = IdentityRoleNames.User.ToString(),
                    NormalizedName = IdentityRoleNames.User.ToString().ToUpper(),
                    ConcurrencyStamp = ROLE_USER_ID
                },
                new IdentityRole()
                {
                    Id = ROLE_ADMIN_ID,
                    Name = IdentityRoleNames.Admin.ToString(),
                    NormalizedName = IdentityRoleNames.Admin.ToString().ToUpper(),
                    ConcurrencyStamp = ROLE_ADMIN_ID
                },
                new IdentityRole()
                {
                    Id = ROLE_LOGIST_ID,
                    Name = IdentityRoleNames.Logist.ToString(),
                    NormalizedName = IdentityRoleNames.Logist.ToString().ToUpper(),
                    ConcurrencyStamp = ROLE_LOGIST_ID
                });

        #endregion

        #region SeedIdentityUserRole

        public static void SeedIdentityUserRole(ModelBuilder builder) =>
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = VADIM_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = VLAD_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = VOLODYA_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = MARYNA_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = ANTONINA_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_LOGIST_ID,
                    UserId = ANDREW_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = EUGEN_ID
                }, new IdentityUserRole<string>()
                {
                    RoleId = ROLE_USER_ID,
                    UserId = SERGEY_ID
                });

        #endregion

        #region SeedRole

        public static void SeedRole(ModelBuilder builder) =>
            builder.Entity<OfferRole>().HasData(
                new OfferRole()
                {
                    Id = 1,
                    Name = TripRoles.Sender
                },
                new OfferRole()
                {
                    Id = 2,
                    Name = TripRoles.Recipient
                });

        #endregion

        #region SeedGoodCategory

        public static void SeedGoodCategory(ModelBuilder builder) =>
            builder.Entity<GoodCategory>().HasData(
                new GoodCategory()
                {
                    Id = 1,
                    Name = "FOOD"
                },
                new GoodCategory()
                {
                    Id = 2,
                    Name = "DRINKS"
                }, new GoodCategory()
                {
                    Id = 3,
                    Name = "CLOTHING"
                }, new GoodCategory()
                {
                    Id = 4,
                    Name = "FOOTWEAR"
                }, new GoodCategory()
                {
                    Id = 5,
                    Name = "HYGIENE PRODUCTS"
                }, new GoodCategory()
                {
                    Id = 6,
                    Name = "CAMOUFLAGE"
                }, new GoodCategory()
                {
                    Id = 7,
                    Name = "MEDICINES"
                });

        #endregion

        #region SeedCarCategory

        public static void SeedCarCategory(ModelBuilder builder) =>
            builder.Entity<CarCategory>().HasData(
                new CarCategory()
                {
                    Id = 1,
                    Name = CarCategories.A
                },
                new CarCategory()
                {
                    Id = 2,
                    Name = CarCategories.B
                },
                new CarCategory()
                {
                    Id = 3,
                    Name = CarCategories.C
                },
                new CarCategory()
                {
                    Id = 4,
                    Name = CarCategories.D
                });

        #endregion

        #region SeedPoint

        public static void SeedPoint(ModelBuilder builder) =>
           builder.Entity<PointData>().HasData(
               new PointData()
               {
                   Id = 1,
                   Location = new Point(26.5283633, 50.3288577) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Східна, 32",
                   Settlement = "Острог",
                   Region = "Рівненська область",
                   Country = "Україна",
                   Postcode = "35800",
                   Order = 0,
                   OfferId = 1
               },
               new PointData()
               {
                   Id = 2,
                   Location = new Point(26.2614291, 50.6175848) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Соборна, 5",
                   Settlement = "Рівне",
                   Region = "Рівненська область",
                   Country = "Україна",
                   Postcode = "33000",
                   Order = 0,
                   OfferId = 2
               },
               new PointData()
               {
                   Id = 3,
                   Location = new Point(25.3839251, 50.724626) { SRID = GeodeticSystem.WGS84 },
                   Address = "Вишнівецька вулиця, 30",
                   Settlement = "Луцьк",
                   Region = "Волинська область",
                   Country = "Україна",
                   Postcode = "43000",
                   Order = 0,
                   OfferId = 3
               },
               new PointData()
               {
                   Id = 4,
                   Location = new Point(35.0256349, 48.4674516) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Юрія Савченко, 1",
                   Settlement = "Дніпро",
                   Region = "Дніпропетровська область",
                   Country = "Україна",
                   Postcode = "49000",
                   Order = 0,
                   OfferId = 4
               },
               new PointData()
               {
                   Id = 5,
                   Location = new Point(37.3386598, 47.1917281) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Пушкіна, 1",
                   Settlement = "Нікольське",
                   Region = "Донецька область",
                   Country = "Україна",
                   Postcode = "87000",
                   Order = 0,
                   OfferId = 5
               },
               new PointData()
               {
                   Id = 6,
                   Location = new Point(32.0033648, 46.9690278) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Садова, 1",
                   Settlement = "Миколаїв",
                   Region = "Миколаївська область",
                   Country = "Україна",
                   Postcode = "54000",
                   Order = 0,
                   OfferId = 6
               },
               new PointData()
               {
                   Id = 7,
                   Location = new Point(32.2345305, 48.5175858) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Павлова, 1",
                   Settlement = "Кропивницький",
                   Region = "Кіровоградська область",
                   Country = "Україна",
                   Postcode = "25000",
                   Order = 0,
                   OfferId = 7
               },
               new PointData()
               {
                   Id = 8,
                   Location = new Point(32.2277797, 48.5183484) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Чкалова, 20",
                   Settlement = "Кропивницький",
                   Region = "Кіровоградська область",
                   Country = "Україна",
                   Postcode = "25000",
                   Order = 0,
                   OfferId = 8
               },
               new PointData()
               {
                   Id = 9,
                   Location = new Point(32.2269653, 48.5181244) { SRID = GeodeticSystem.WGS84 },
                   Address = "Посадочна вулиця, 5",
                   Settlement = "Кропивницький",
                   Region = "Кіровоградська область",
                   Country = "Україна",
                   Postcode = "25000",
                   Order = 0,
                   OfferId = 9
               },
               new PointData()
               {
                   Id = 10,
                   Location = new Point(35.0247707, 48.4658504) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Юрія Савченка, 3",
                   Settlement = "Дніпро",
                   Region = "Дніпропетровська область",
                   Country = "Україна",
                   Postcode = "49000",
                   Order = 0,
                   OfferId = 10
               },
               new PointData()
               {
                   Id = 11,
                   Location = new Point(24.0253381, 49.8468734) { SRID = GeodeticSystem.WGS84 },
                   Address = "просп. Вячеслава Черновола, 11",
                   Settlement = "Львів",
                   Region = "Львівська область",
                   Country = "Україна",
                   Postcode = "79000",
                   Order = 0,
                   OfferId = 11
               },
               new PointData()
               {
                   Id = 12,
                   Location = new Point(22.3178905, 48.6102995) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Шишкіна, 1",
                   Settlement = "Ужгород",
                   Region = "Закарпатська область",
                   Country = "Україна",
                   Postcode = "88000",
                   Order = 0,
                   OfferId = 12
               },
               new PointData()
               {
                   Id = 13,
                   Location = new Point(26.9919167, 49.4178562) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Козацька, 1",
                   Settlement = "Хмельницький",
                   Region = "Хмельницька  область",
                   Country = "Україна",
                   Postcode = "29000",
                   Order = 0,
                   OfferId = 13
               },
               new PointData()
               {
                   Id = 14,
                   Location = new Point(33.3286723, 47.8847308) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Братиславська, 1",
                   Settlement = "Кривий Ріг",
                   Region = "Дніпропетровська область",
                   Country = "Україна",
                   Postcode = "50000",
                   Order = 0,
                   OfferId = 14
               },
               new PointData()
               {
                   Id = 15,
                   Location = new Point(32.0147107, 47.031949) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Слов'янська, 1",
                   Settlement = "Миколаїв",
                   Region = "Миколаївська область",
                   Country = "Україна",
                   Postcode = "54000",
                   Order = 0,
                   OfferId = 15
               },
               new PointData()
               {
                   Id = 16,
                   Location = new Point(32.0222338, 46.9858772) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Привільна, 1",
                   Settlement = "Миколаїв",
                   Region = "Миколаївська область",
                   Country = "Україна",
                   Postcode = "54000",
                   Order = 0,
                   OfferId = 16
               },
               new PointData()
               {
                   Id = 17,
                   Location = new Point(32.0210963, 46.9880672) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Привільна, 10",
                   Settlement = "Миколаїв",
                   Region = "Миколаївська область",
                   Country = "Україна",
                   Postcode = "54000",
                   Order = 0,
                   OfferId = 17
               },
               new PointData()
               {
                   Id = 18,
                   Location = new Point(25.36196, 50.7556030) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця В'ячеслава Чорновола, 1",
                   Settlement = "Луцьк",
                   Region = "Волинська область",
                   Country = "Україна",
                   Postcode = "43000",
                   Order = 0,
                   OfferId = 18
               },
               new PointData()
               {
                   Id = 19,
                   Location = new Point(26.8544323, 50.3006939) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Острозька, 1",
                   Settlement = "Славута",
                   Region = "Хмельницька область",
                   Country = "Україна",
                   Postcode = "30000",
                   Order = 0,
                   OfferId = 19
               },
               new PointData()
               {
                   Id = 20,
                   Location = new Point(28.6727154, 50.2541948) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Бориса Тена, 2",
                   Settlement = "Житомир",
                   Region = "Житомирська область",
                   Country = "Україна",
                   Postcode = "10001",
                   Order = 0,
                   OfferId = 20
               },
               new PointData()
               {
                   Id = 21,
                   Location = new Point(30.4570465, 48.3880023) { SRID = GeodeticSystem.WGS84 },
                   Address = "вул Соборна 44б",
                   Settlement = "Голованівськ",
                   Region = "Кіровоградська область",
                   Country = "Україна",
                   Postcode = "26500",
                   Order = 0,
                   OfferId = 21
               },
               new PointData()
               {
                   Id = 22,
                   Location = new Point(30.1641172, 48.1413224) { SRID = GeodeticSystem.WGS84 },
                   Address = "Центральна 119",
                   Settlement = "Вільшанка",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "66221",
                   Order = 0,
                   OfferId = 22
               },
               new PointData()
               {
                   Id = 23,
                   Location = new Point(30.3443027, 47.9484405) { SRID = GeodeticSystem.WGS84 },
                   Address = "Криве Озеро",
                   Settlement = "Криве Озеро",
                   Region = "Миколаївська область",
                   Country = "Україна",
                   Postcode = "55100",
                   Order = 0,
                   OfferId = 23
               },
               new PointData()
               {
                   Id = 24,
                   Location = new Point(30.9116167, 47.1991193) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Шевченка, 10",
                   Settlement = "Березівка",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "67301",
                   Order = 0,
                   OfferId = 24
               },
               new PointData()
               {
                   Id = 25,
                   Location = new Point(30.3173710, 47.0234622) { SRID = GeodeticSystem.WGS84 },
                   Address = "Трасса Е 95",
                   Settlement = "Знам'янка",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "67211",
                   Order = 0,
                   OfferId = 25
               },
               new PointData()
               {
                   Id = 26,
                   Location = new Point(30.3017199, 48.1390924) { SRID = GeodeticSystem.WGS84 },
                   Address = "48Q2+JJ Дубинове",
                   Settlement = "Дубинове",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "66220",
                   Order = 0,
                   OfferId = 26
               },
               new PointData()
               {
                   Id = 27,
                   Location = new Point(33.3832712, 47.8876902) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Медична, 19",
                   Settlement = "Кривий Ріг",
                   Region = "Дніпропетровська область",
                   Country = "Україна",
                   Postcode = "50005",
                   Order = 0,
                   OfferId = 27
               },
               new PointData()
               {
                   Id = 28,
                   Location = new Point(32.4974225, 47.5464278) { SRID = GeodeticSystem.WGS84 },
                   Address = "вул. Станціонна, 1",
                   Settlement = "Новополтавка",
                   Region = "Миколаївська область",
                   Country = "Україна",
                   Postcode = "55642",
                   Order = 0,
                   OfferId = 28
               },
               new PointData()
               {
                   Id = 29,
                   Location = new Point(30.2557039, 48.7424709) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Волкова, 2",
                   Settlement = "Умань",
                   Region = "Черкаська область",
                   Country = "Україна",
                   Postcode = "20300",
                   Order = 1,
                   TripId = 1
               },
               new PointData()
               {
                   Id = 30,
                   Location = new Point(30.3017199, 48.1390924) { SRID = GeodeticSystem.WGS84 },
                   Address = "48Q2+JJ",
                   Settlement = "Дубинове",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "20300",
                   Order = 2,
                   TripId = 1
               },
               new PointData()
               {
                   Id = 31,
                   Location = new Point(30.3174055, 47.0235592) { SRID = GeodeticSystem.WGS84 },
                   Address = "28F8+9X",
                   Settlement = "Знам'янка",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "20300",
                   Order = 3,
                   TripId = 1
               },
               new PointData()
               {
                   Id = 32,
                   Location = new Point(30.6598914, 46.4932837) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Мічуріна, 41",
                   Settlement = "Одеса",
                   Region = "Одеська область",
                   Country = "Україна",
                   Postcode = "65000",
                   Order = 4,
                   TripId = 1
               },
               new PointData()
               {
                   Id = 33,
                   Location = new Point(30.36545, 50.45624) { SRID = GeodeticSystem.WGS84 },
                   Address = "проспект Перемоги, ст. метро Житомирська",
                   Settlement = "Київ",
                   Region = "Київcька область",
                   Country = "Україна",
                   Postcode = "02000",
                   Order = 1,
                   TripId = 2
               },
               new PointData()
               {
                   Id = 34,
                   Location = new Point(28.68603, 50.26679) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Київська, 77",
                   Settlement = "Житомир",
                   Region = "Житомирська область",
                   Country = "Україна",
                   Postcode = "10001",
                   Order = 2,
                   TripId = 2
               },
               new PointData()
               {
                   Id = 35,
                   Location = new Point(27.62649, 50.58838) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Житомирська, 41-А",
                   Settlement = "Новоград-Волинський",
                   Region = "Житомирська область",
                   Country = "Україна",
                   Postcode = "11702",
                   Order = 3,
                   TripId = 2
               },
               new PointData()
               {
                   Id = 36,
                   Location = new Point(26.2517, 50.62034) { SRID = GeodeticSystem.WGS84 },
                   Address = "майдан Незалежності, 2",
                   Settlement = "Рівне",
                   Region = "Рівненська область",
                   Country = "Україна",
                   Postcode = "33000",
                   Order = 4,
                   TripId = 2
               },
               new PointData()
               {
                   Id = 37,
                   Location = new Point(25.35595, 50.7553) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Сухомлинського, 1",
                   Settlement = "Луцьк",
                   Region = "Волинська область",
                   Country = "Україна",
                   Postcode = "43000",
                   Order = 1,
                   TripId = 3
               },
               new PointData()
               {
                   Id = 38,
                   Location = new Point(24.76512, 50.50216) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Луцька, 27",
                   Settlement = "Горохів",
                   Region = "Волинська область",
                   Country = "Україна",
                   Postcode = "45700",
                   Order = 2,
                   TripId = 3
               },
               new PointData()
               {
                   Id = 39,
                   Location = new Point(24.63097, 50.28358) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Витківська",
                   Settlement = "Радехів",
                   Region = "Львівська область",
                   Country = "Україна",
                   Postcode = "80200",
                   Order = 3,
                   TripId = 3
               },
               new PointData()
               {
                   Id = 40,
                   Location = new Point(24.00991, 49.77351) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Стрийська, 30 ТРЦ King Cross Leopolis",
                   Settlement = "Сокільники",
                   Region = "Львівська область",
                   Country = "Україна",
                   Postcode = "81130",
                   Order = 4,
                   TripId = 3
               },
               new PointData()
               {
                   Id = 41,
                   Location = new Point(23.85867, 49.26081) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Дубравського, 6",
                   Settlement = "Стрий",
                   Region = "Львівська область",
                   Country = "Україна",
                   Postcode = "82400",
                   Order = 5,
                   TripId = 3
               },
               new PointData()
               {
                   Id = 42,
                   Location = new Point(22.3112, 48.60822) { SRID = GeodeticSystem.WGS84 },
                   Address = "вулиця Верещагіна, 16",
                   Settlement = "Ужгород",
                   Region = "Закарпатська область",
                   Country = "Україна",
                   Postcode = "88000",
                   Order = 6,
                   TripId = 3
               });

        #endregion

        #region SeedRoute
        public static void SeedRoute(ModelBuilder builder) =>
            builder.Entity<Trip>().HasData(
                new Trip()
                {
                    Id = 1,
                    CreationDate = DateTimeOffset.Parse("10.07.2022 12:00"),
                    DepartureDate = DateTimeOffset.Parse("22.08.2022 12:00"),
                    Description = "It`s my first offer!",
                    LoadCapacity = 2000,
                    MaxRouteDeviationKm = 20,
                    TripCreatorId = ANTONINA_ID,
                    TransportationCarId = 1,
                    InitialDistance = 150,
                    Distance = 150,
                    RouteGeographyData = NtsGeometryFactories.geometryFactoryWGS84.CreateLineString(FirstRouteCoordinates)
                },
                new Trip()
                {
                    Id = 2,
                    CreationDate = DateTimeOffset.Parse("01.07.2022 12:00"),
                    DepartureDate = DateTimeOffset.Parse("15.07.2022 12:00"),
                    Description = "I'm going from Kyiv to Rivne. So welcome!",
                    LoadCapacity = 2000,
                    MaxRouteDeviationKm = 15,
                    TripCreatorId = MARYNA_ID,
                    TransportationCarId = 3,
                    InitialDistance = 400,
                    Distance = 400,
                    RouteGeographyData = NtsGeometryFactories.geometryFactoryWGS84.CreateLineString(SecondRouteCoordinates)
                },
                new Trip()
                {
                    Id = 3,
                    CreationDate = DateTimeOffset.Parse("02.07.2022 12:00"),
                    DepartureDate = DateTimeOffset.Parse("18.07.2022 12:00"),
                    Description = "I'm going from Lutsk to Uzhhorod. So welcome!",
                    LoadCapacity = 2000,
                    MaxRouteDeviationKm = 15,
                    TripCreatorId = EUGEN_ID,
                    TransportationCarId = 10,
                    InitialDistance = 400,
                    Distance = 400,
                    RouteGeographyData = NtsGeometryFactories.geometryFactoryWGS84.CreateLineString(ThirdRouteCoordinates)
                });
        #endregion

        #region SeedOffer

        public static void SeedOffer(ModelBuilder builder) =>
            builder.Entity<Offer>().HasData(
                new Offer()
                {
                    Id = 1,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 1,
                    OfferCreatorId = EUGEN_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 2,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 2,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")

                },
                new Offer()
                {
                    Id = 3,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 3,
                    OfferCreatorId = VOLODYA_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 4,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 4,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 5,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 5,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 6,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 6,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                }
                ,
                new Offer()
                {
                    Id = 7,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 7,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 8,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 8,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 9,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 9,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 10,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 10,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                }
                ,
                new Offer()
                {
                    Id = 11,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 11,
                    OfferCreatorId = SERGEY_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 12,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 12,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 13,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 13,
                    OfferCreatorId = EUGEN_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 14,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 14,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 15,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 15,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 16,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 16,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 17,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 17,
                    OfferCreatorId = VOLODYA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 18,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 18,
                    OfferCreatorId = VOLODYA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 19,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 19,
                    OfferCreatorId = VADIM_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 20,
                    Description = $"{_faker.Company.CompanyName() + _faker.Random.Words(_faker.Random.Int(10, 30))}.",
                    IsClosed = false,
                    GoodsWeight = _faker.Random.Float(0.1f, _maxWeight),
                    StartDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2022 {_faker.Random.Int(5, 12)}:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 20,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(20, 30)}.06.2022 {_faker.Random.Int(5, 21)}:00")
                },
                new Offer()
                {
                    Id = 21,
                    Description = "My 1 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("13.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 21,
                    OfferCreatorId = EUGEN_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse("13.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 22,
                    Description = "My 2 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("18.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 22,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse("18.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 23,
                    Description = "My 3 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("20.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 23,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse("20.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 24,
                    Description = "My 4 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("22.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 24,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse("22.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 25,
                    Description = "My 5 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("24.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 25,
                    OfferCreatorId = EUGEN_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse("24.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 26,
                    Description = "My 6 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("01.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 26,
                    OfferCreatorId = MARYNA_ID,
                    CreatorRoleId = 2,
                    CreationDate = DateTimeOffset.Parse("01.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 27,
                    Description = "My 7 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("28.07.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 27,
                    OfferCreatorId = VLAD_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse("28.07.2022 11:00")
                },
                new Offer()
                {
                    Id = 28,
                    Description = "My 8 offer",
                    IsClosed = false,
                    GoodsWeight = 120,
                    StartDate = DateTimeOffset.Parse("01.08.2022 12:00"),
                    GoodCategoryId = _faker.Random.Int(1, 7),
                    OfferPointId = 28,
                    OfferCreatorId = ANTONINA_ID,
                    CreatorRoleId = 1,
                    CreationDate = DateTimeOffset.Parse("01.08.2022 11:00")
                }
                );

        #endregion

        #region SeedCar

        public static void SeedCar(ModelBuilder builder) =>
           builder.Entity<Car>().HasData(
               new Car()
               {
                   Id = 1,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"AA4567XI",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = ANTONINA_ID
               },
               new Car()
               {
                   Id = 2,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"BC2234OP",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = VADIM_ID
               },
               new Car()
               {
                   Id = 3,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"BH4456AI",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = MARYNA_ID
               },
               new Car()
               {
                   Id = 4,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"AC6344AC",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = VADIM_ID
               },
               new Car()
               {
                   Id = 5,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"BH1232AA",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 6,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"AA5421BH",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = VLAD_ID
               },
               new Car()
               {
                   Id = 7,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"BC7739AA",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 8,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"BH2333XI",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = SERGEY_ID
               },
               new Car()
               {
                   Id = 9,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"AA8992BH",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = MARYNA_ID
               },
               new Car()
               {
                   Id = 10,
                   Model = $"{_cars[_faker.Random.Int(0, 9)]}",
                   RegistrationNumber = $"AC1273IX",
                   TechnicalPassport = $"{_faker.Random.AlphaNumeric(20).ToUpper()}",
                   LoadCapacity = _faker.Random.Int(400, 1000),
                   Color = _colors[_faker.Random.Int(0, 6)],
                   Vin = $"{_faker.Random.AlphaNumeric(17).ToUpper()}",
                   CreationDate = DateTimeOffset.Parse($"{_faker.Random.Int(1, 5)}.07.2016 {_faker.Random.Int(9, 18)}:00"),
                   CategoryId = _faker.Random.Int(2, 4),
                   IsVerified = true,
                   UserId = EUGEN_ID
               }

               );

        #endregion

    }
}
