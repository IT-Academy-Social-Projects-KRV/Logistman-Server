using Core.DTO.InviteDTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageTripInvitesAsync(CreateTripInvitesDTO createTripInvitesDTO);
        Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId);
        Task<List<InvitePreviewDTO>> OffersInvitesAsync(string userId);
    }
}
