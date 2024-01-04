using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RashisCodeRiff.API.Models.Domain;
using RashisCodeRiff.API.Models.DTO;
using RashisCodeRiff.API.Repositories.Implementation;
using RashisCodeRiff.API.Repositories.Interface;

namespace RashisCodeRiff.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };

            await categoryRepository.CreateAsync(category);

            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };

            return Ok(response);

        }
    }
}
