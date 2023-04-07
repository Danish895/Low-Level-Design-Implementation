using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LowLevelDesign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LLDController : ControllerBase
    {
        [HttpGet]
        public string GetLLD() {
            return "Here is the implementation of Low level design, in subfolders ";
        }

        
    }
}
