using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.RepoImplementation;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestEntityController : ControllerBase
    {
        public IUnitOfWork _uof { get; }
        public MyTestEntityController(IUnitOfWork uof)
        {
            _uof = uof;
        }


        [HttpGet]
        public ActionResult<IEnumerable<MyTestEntity>> Get()
        {
            return Ok(_uof.MyTestEntity.GetAllMyTestEntities(false));
        }
    }
}
