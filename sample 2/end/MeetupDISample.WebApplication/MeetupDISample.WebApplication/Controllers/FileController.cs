using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetupDISample.BaseStorage;
using MeetupDISample.WebApplication.Model;
using Microsoft.AspNetCore.Mvc;

namespace MeetupDISample.WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class FileController : Controller
    {
        private readonly IFileUpload _fileUpload;

        public FileController(IFileUpload fileUpload)
        {
            _fileUpload = fileUpload;
        }

        // POST api/values
        [HttpPost("UploadText")]
        public void UploadText([FromBody]FileUploadModel model)
        {
            _fileUpload.Upload(model.FileName,model.Text);
        }

    }
}
