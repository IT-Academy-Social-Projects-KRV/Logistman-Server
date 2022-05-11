﻿using Core.DTO.GoodCategoryDTO;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IGoodCategoryService
    {
        Task<GoodCategoryListDTO> GetAllGoodCategoryAsync();
        int GetGoodCategoryByName(string name);
    }
}