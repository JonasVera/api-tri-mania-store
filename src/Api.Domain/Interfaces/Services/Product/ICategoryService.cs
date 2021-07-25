using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Product;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Category {
    public interface ICategoryService {
        Task<CategoryDto> Get (Guid id);
        Task<IEnumerable<CategoryDto>> GetAll ();
        Task<CategoryDto> Post (CategoryDto category);
        Task<CategoryDto> Put (CategoryDto category);
        Task<bool> Delete (Guid id);
    }
}
