using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class VideosController : Controller
    {
        private ICollection<Video> _videos = new List<Video> ()
        {
            new Video("Filme 1", new DateTime(2016, 5, 25)),
            new Video("Filme 2", new DateTime(2016, 7, 31)),
            new Video("Filme 3", new DateTime(2016, 12, 21)),
            new Video("Filme 4", new DateTime(2016, 8, 13)),
            new Video("Filme 5", new DateTime(2016, 2, 5))
        };

        public IActionResult Index()
        {
            var videos = _videos
                            .OrderByDescending(x => x.PublishDate)
                            .ToList();
            return View(videos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Video video)
        {
            return View();
        }
    }
}