using Core.DTO.InviteDTO;
using Core.Entities.TripEntity;
using System.Collections.Generic;
﻿using Core.DTO;
using Core.Helpers;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageTripInvitesAsync(Trip trip, List<OfferInviteDTO> offers);
        Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId);
        Task<PaginatedList<InvitePreviewDTO>> OffersInvitesAsync(string userId, PaginationFilterDTO paginationFilter);
    }
}
