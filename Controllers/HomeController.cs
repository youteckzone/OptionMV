using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OptionMV.Models;
using OptionMV.Interfaces;

namespace OptionMV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlobService _blobService;

        public HomeController(ILogger<HomeController> logger,IBlobService blobservice)
        {
            _logger = logger;
            _blobService = blobservice;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Products()
        {
            var blob = await _blobService.GetBlobAsync("ganesh3.jpg");
            return File(blob.MediaContent, blob.MediaType);
            // return View();
        }


        [HttpGet("blobName")]
        public async Task<IActionResult> GetBlobInfo(string blobName)
        {
            var blob = await _blobService.GetBlobAsync(blobName);
            return File(blob.MediaContent, blob.MediaType);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
