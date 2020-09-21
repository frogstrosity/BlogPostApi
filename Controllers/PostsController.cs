using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogPostApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private static readonly Post[] Posts = new[]
        {
            new Post() { Title = "Blog post 1" },
            new Post() { Title = "Blog post 2" },

        };

        private readonly ILogger<WeatherForecastController> _logger;

        public PostsController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
           return Posts;
        }
    }
}
