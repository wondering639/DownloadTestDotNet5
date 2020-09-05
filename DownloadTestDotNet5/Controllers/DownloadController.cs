using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadTestDotNet5.Controllers
{
    public class DownloadController : ControllerBase
    {

        [HttpGet("~/download/{downloadId}")]
        public async Task<IActionResult> Download(long downloadId)
        {
            var buffer = Encoding.UTF8.GetBytes("Hello! Content is here.");
            var stream = new MemoryStream(buffer);

            var result = new FileStreamResult(stream, "text/plain");
            result.FileDownloadName = "test.txt";
            return result;
        }
    }
}
