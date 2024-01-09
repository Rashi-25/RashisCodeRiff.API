﻿using RashisCodeRiff.API.Models.Domain;

namespace RashisCodeRiff.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category?> GetById(Guid id);

    }
}
