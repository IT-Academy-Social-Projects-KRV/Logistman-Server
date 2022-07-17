using Core.DTO.InviteDTO;
using Core.DTO;
using Core.Helpers;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId);
        Task CreateAsync(int tripId, string userId);
        Task<PaginatedList<InvitePreviewDTO>> GetByUserIdAsync(
            string userId, PaginationFilterDTO paginationFilter);
    }
}
