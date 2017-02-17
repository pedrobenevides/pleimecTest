using System.Web.Http;
using PleimecProject.Core.Interfaces;
using PleimecProject.Core.Services;

namespace PleimecProject.Presentation.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ICustomService _customService;

        public HomeController()
        {
            _customService = new CustomService();
        }

        [HttpPost]
        public IHttpActionResult Post(CustomViewModel value)
        {
            if (value == null)
                return BadRequest("Invalid data");

            return Ok(_customService.ProcessInput($"{value.Name}{value.LastName}"));
        }

        [HttpGet]
        public IHttpActionResult Get(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest("Invalid data");

            return Ok(_customService.ProcessInput(name));
        }
    }

    public class CustomViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}