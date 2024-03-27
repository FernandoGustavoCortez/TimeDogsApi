using Microsoft.AspNetCore.Mvc;
using TimeDogsApi.Model;
using TimeDogsApi.ViewModel;

namespace TimeDogsApi.Controllers
{
    [ApiController]
    [Route("api/v1/raca")]
    public class RacaController : ControllerBase
    {
        private readonly IRacaRepository _racaRepository;

        public RacaController(IRacaRepository racaRepository)
        {
            _racaRepository = racaRepository ?? throw new ArgumentNullException(nameof(racaRepository));
        }

        [HttpPost]
        public IActionResult Add(RacaViewModel racaViewModel)
        {
            var raca = new Raca(racaViewModel.name, racaViewModel.apresentacao, racaViewModel.sobre);
            _racaRepository.Add(raca);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetRaca(int id)
        {
            var raca = _racaRepository.GetRaca(id);
            if (raca == null)
            {
                return Ok("Nao existe essa raca");
            }
            return Ok(raca);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var racas = _racaRepository.Get();
            return Ok(racas);
        }
    }
}
