﻿using System;
using Core.Entities.GoodCategoryEntity;

namespace Core.DTO.OfferDTO
{
    public class OfferCreateDTO
    {
        public string Description { get; set; }
        public float GoodsWeight { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public int GoodCategoryId { get; set; }
        public int OfferPointId { get; set; }
        public string OfferCreatorId { get; set; }
        public string CreatorRoleId { get; set; }
    }
}
