using BookStore.BL.Interfaces;
using BookStore.Models.Base;
using BookStore.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        
        private readonly ILogger<AuthorController> _logger;
        private readonly IAuthorService _authorService;
        public AuthorController(ILogger<AuthorController> logger, IAuthorService authorService)
        {
            _logger = logger;
            _authorService = authorService;
        }

        [HttpGet("GetAllAuthors")]
        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _authorService.GetAll();
        }

        [HttpGet("GetByID")]
        public async Task<Author> GetById(int id)
        {
            return await _authorService.GetById(id);
        }

        [HttpPost("Add")]
        public async Task Add([FromBody] AddAuthorRequest authorRequest)
        {
            await _authorService.Add(authorRequest);
        }

        [HttpPost("Update")]
        public async Task Update([FromBody] UpdateAuthorRequest author)
        {
            await _authorService.Update(author);
        }

        [HttpDelete("Delete")]
        public async Task Delete(int id)
        {
            await _authorService.Delete(id);
        }
    }
}