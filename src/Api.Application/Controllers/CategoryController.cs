 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using System;
using System.Net; 
using Microsoft.AspNetCore.Authorization;
using Api.Domain.Dtos.Product;
using Api.Domain.Interfaces.Services.Category;

namespace Api.Application.Controllers

{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)System.Net.HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [Authorize("Bearer")]
        [HttpGet]
        [Route("{id}", Name = "Id")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        } 
        
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CategoryDto categoryDto)
        {
           if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } 
            try{
             var result = await _service.Post(categoryDto);
             if (result != null){
                    return Created(new Uri(Url.Link("GetWithId" , new {id = result})),result);
             }else{
                  return BadRequest(); 
             }

            }catch(ArgumentException e){
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CategoryDto categoryDto)
        {
           if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } 
            try{
             var result = await _service.Put(categoryDto);
             if (result != null){
                    return Ok(result);
             }else{
                  return BadRequest(); 
             }

            }catch(ArgumentException e){
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
          [Authorize("Bearer")]
          [HttpDelete ("{id}")] 
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        } 
    }
}
