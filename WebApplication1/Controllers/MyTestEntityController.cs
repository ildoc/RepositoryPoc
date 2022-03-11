using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure;
using WebApplication1.Models;
using WebApplication1.RepoImplementation;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestEntityController : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public MyTestEntityController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<MyTestEntity>> Get()
        {
            return Ok(_repository.Get<MyTestEntity>().FindAll(false));
        }
    }
}
