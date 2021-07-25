using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Product;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Category;
using AutoMapper;

namespace Api.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;

        private IRepository<Api.Domain.Entities.Category> _repository;
       
        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
      
        public CategoryService(IRepository<Api.Domain.Entities.Category> repository)
        {
            _repository = repository;
        }
         
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CategoryDto> Get(Guid id)
        {
            var result = await _repository.SelectAsync(id);

            return _mapper.Map<CategoryDto>(result);
        }

        public async Task<IEnumerable<CategoryDto>> GetAll()
        {
            var listresult =  await _repository.SelectAsync();
              return _mapper.Map<IEnumerable<CategoryDto>>(listresult);
        } 

        public async Task<CategoryDto> Post(CategoryDto category)
        {
            var model = _mapper.Map<CategoryDto>(category); 
            var entity = _mapper.Map<Category>(model); 
              
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<CategoryDto>(result);
        }

        public async Task<CategoryDto> Put(CategoryDto user)
        {
             var model = _mapper.Map<CategoryDto>(user);
             var entity = _mapper.Map<Category>(user); 
              
             var result = await _repository.UpdateAsync(entity);

             return _mapper.Map<CategoryDto>(result);
        }
    }
}
