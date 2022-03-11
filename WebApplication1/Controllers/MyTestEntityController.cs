using Microsoft.AspNetCore.Mvc;
using WebApplication1.Infrastructure;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestEntityController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public MyTestEntityController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MyTestEntity>> Get()
        {
            return Ok(_uow.Get<MyTestEntity>().FindAll(false));
        }
    }
}
