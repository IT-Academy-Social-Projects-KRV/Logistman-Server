using System.Collections.Generic;
using Core.DTO;
using Core.DTO.OfferDTO;
using Core.Helpers;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IOfferService
    {
        Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId);
        Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId);
        Task<PaginatedList<OfferPreviewDTO>> GetUsersOffersAsync(
            string userId, PaginationFilterDTO paginationFilter);
        Task<List<PointOfferCreateTripDTO>> GetNearRouteAsync(int routeId);
        Task DeleteAsync(OfferIdDTO offerIdDTO, string userId);
        Task ConfirmGoodsTransferAsync(
            ConfirmGoodsTransferDTO confirmGoodTransferDTO, string userId);
        Task<PaginatedList<OfferPreviewForConfirmDTO>> GetOffersToConfirmAsync(
            string userId, PaginationFilterDTO paginationFilter);
        Task UnlinkFromTripAsync(int tripId);
        Task<List<OfferPreviewForInviteDTO>> GetDriverConfirmGoodsDeliveryAsync(
            int tripId, string userId);
    }
}
