using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.RepoImplementation;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestEntityController : ControllerBase
    {
        public IRepositoryManager _repository { get; }
        public MyTestEntityController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<MyTestEntity>> Get()
        {
            return Ok(_repository.MyTestEntity.GetAllMyTestEntities(false));
        }
    }
}