using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Product;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Product;
using AutoMapper;

namespace Api.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;

        private IRepository<Api.Domain.Entities.Product> _repository;
       
        public ProductService(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
      
        public ProductService(IRepository<Api.Domain.Entities.Product> repository)
        {
            _repository = repository;
        }
         
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ProductDto> Get(Guid id)
        {
            var result = await _repository.SelectAsync(id);

            return _mapper.Map<ProductDto>(result);
        }

        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            var listresult =  await _repository.SelectAsync();
              return _mapper.Map<IEnumerable<ProductDto>>(listresult);
        } 

        public async Task<ProductDto> Post(ProductDto product)
        { 
             
            var model = _mapper.Map<ProductDto>(product);
            var entity = _mapper.Map<Product>(model);
            
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ProductDto>(result);
        }

        public async Task<ProductDto> Put(ProductDto product)
        {
            
             var model = _mapper.Map<ProductDto>(product);
             var entity = _mapper.Map<Product>(product); 
              
             var result = await _repository.UpdateAsync(entity);

             return _mapper.Map<ProductDto>(result);
        }
    }
}
