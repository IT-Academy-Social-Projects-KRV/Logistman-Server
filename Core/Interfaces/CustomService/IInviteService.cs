using Core.DTO;
using Core.DTO.InviteDTO;
using Core.Helpers;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageTripInvitesAsync(CreateTripInvitesDTO createTripInvitesDTO);
        Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId);
        Task<PaginatedList<InvitePreviewDTO>> OffersInvitesAsync(string userId, PaginationFilterDTO paginationFilter);
        Task<PaginatedList<DriverInvitePreviewDTO>> DriversInvitesAsync(string userId, PaginationFilterDTO paginationFilter);
    }
}
