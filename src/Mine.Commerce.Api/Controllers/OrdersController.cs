using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Mine.Commerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Getstrings()
        {
            return new List<string> { };
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        [HttpPost("")]
        public void Poststring(string value)
        {
        }

        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
    }
}