using System;
using System.Collections.Generic;
using Core.DTO.OfferDTO;

namespace Core.DTO.TripDTO
{
    public class TripOffersDTO
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
        public float LoadCapacity { get; set; }
        public float Distance { get; set; }
        public IList<OfferConfirmGoodsDeliveryDTO> Offers { get; set; }
    }
}
