using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeetupDISample.WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class FileController : Controller
    {

        // POST api/values
        [HttpPost("UploadText")]
        public void UploadText([FromBody]string value)
        {
        }

    }
}
