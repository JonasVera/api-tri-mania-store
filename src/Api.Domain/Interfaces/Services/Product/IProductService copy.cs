using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Product; 
namespace Api.Domain.Interfaces.Services.Product {
    public interface IProductService {
        Task<ProductDto> Get (Guid id);
        Task<IEnumerable<ProductDto>> GetAll ();
        Task<ProductDto> Post (ProductDto user);
        Task<ProductDto> Put (ProductDto user);
        Task<bool> Delete (Guid id);
    }
}
