using Microsoft.AspNetCore.Mvc;
using TimeDogsApi.Infraestrutura;
using TimeDogsApi.Model;

namespace TimeDogsApi.Controllers
{
    [ApiController]
    [Route("api/v1/cachorro")]
    public class CachorroController : ControllerBase
    {
        private readonly ICachorroRepository _cachorroRepository;

        public CachorroController(ICachorroRepository cachorroRepository)
        {
            _cachorroRepository = cachorroRepository ?? throw new ArgumentNullException(nameof(cachorroRepository));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCachorro(int id)
        {
            var cachorro = _cachorroRepository.GetCachorro(id);
            if (cachorro == null)
            {
                return Ok("Nao existe esse cachorroo");
            }
            return Ok(cachorro);
        }
    }
}
