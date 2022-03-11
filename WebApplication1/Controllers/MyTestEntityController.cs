using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.UoWImplementation;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestEntityController : ControllerBase
    {
        public IUnitOfWork _uow { get; }
        public MyTestEntityController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MyTestEntity>> Get()
        {
            return Ok(_uow.MyTestEntity.GetAllMyTestEntities(false));
        }
    }
}
