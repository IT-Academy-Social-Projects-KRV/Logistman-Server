﻿using System.Net;
using Core.Resources;
using Core.Entities.UserEntity;
using Core.Entities.CarEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.CarCategoryEntity;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.RatingEntity;
using Core.Entities.ReportEntity;
using Core.Entities.RoleEntity;

namespace Core.Exceptions
{
    public static class ExceptionMethods
    {
        public static void UserNullCheck(User User)
        {
            if (User == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.UserNotFound);
            }
        }

        public static void CarNullCheck(Car Car)
        {
            if (Car == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.CarNotFound);
            }
        }

        public static void OfferNullCheck(Offer Offer)
        {
            if (Offer == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.OfferNotFound);
            }
        }

        public static void PointNullCheck(Point Point)
        {
            if (Point == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.PointNotFound);
            }
        }

        public static void CarCategoryNullCheck(CarCategory CarCategory)
        {
            if (CarCategory == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.CarCategoryNotFound);
            }
        }

        public static void GoodCategoryNullCheck(GoodCategory GoodCategory)
        {
            if (GoodCategory == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.GoodCategoryNotFound);
            }
        }

        public static void RatingNullCheck(Rating Rating)
        {
            if (Rating == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.RatingNotFound);
            }
        }

        public static void ReportNullCheck(Report Report)
        {
            if (Report == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.ReportNotFound);
            }
        }

        public static void RoleNullCheck(Role Role)
        {
            if (Role == null)
            {
                throw new HttpException(
                    HttpStatusCode.NotFound,
                    ErrorMessages.RoleNotFound);
            }
        }
    }
}