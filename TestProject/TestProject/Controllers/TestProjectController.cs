using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Interfaces;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestProjectController: ControllerBase
    {
        private readonly IGeneralService generalService;

        public TestProjectController(IGeneralService generalService)
        {
            this.generalService = generalService;
        }

        [HttpGet()]
        [EnableCors("CorsPolicy")]
        public async Task<IActionResult>UserList()
        {
            var userList = this.generalService.GetListOfUsers();

            return Ok(userList);
        }

    }
}
