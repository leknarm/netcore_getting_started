using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.ViewModel;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : Controller
    {
        private readonly ITodoRepository _todoRepository;

        public TodosController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository ?? throw new ArgumentNullException(nameof(todoRepository));
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var entities = await _todoRepository.GetAll();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var entity = await _todoRepository.Get(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] TodoInsert dto)
        {
            var entity = await _todoRepository.Insert(dto);
            return Ok(entity);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete()
        {
            await _todoRepository.Delete();
            return Ok();
        }
    }
}
