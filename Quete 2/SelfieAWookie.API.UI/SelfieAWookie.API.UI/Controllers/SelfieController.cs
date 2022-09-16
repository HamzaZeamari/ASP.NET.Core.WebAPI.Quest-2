using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SelfieAWookie.Core.Selfies.Domain;

namespace SelfieAWookie.API.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfieController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<Selfie> Get()
        //{
        //    return Enumerable.Range(1,10).Select(item => new Selfie() { Id = item });
        //}

        [HttpGet]
        public IActionResult Get()
        {
            var model = Enumerable.Range(1, 10).Select(item => new Selfie() { Id = item });
            return this.Ok(model);
        }
    }
}
