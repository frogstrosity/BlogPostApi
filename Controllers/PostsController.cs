using System;
using System.Collections.Generic;
using BlogPostApi.Data.Static;
using BlogPostApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogPostApi.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly StaticPostRepository _repository;

        public PostsController(StaticPostRepository repository, ILogger<PostsController> logger)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async System.Threading.Tasks.Task<IEnumerable<Post>> GetAsync()
        {
           return await _repository.GetAll();
        }
    }
}
