using BlogPostApi.Controllers;
using BlogPostApi.Data.Static;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using BlogPostApi.Models;

namespace BlogPostApi.Tests
{
    [TestClass]
    public class PostControllerTests
    {

        [TestMethod]
        public void GetAsync_ShouldCallRepository()
        {
            var repository = new Mock<EfCorePostRepository>();

            repository.Setup(x => x.GetAll()).Returns(Task.FromResult(new List<Post>()));

            var logger = new Mock<ILogger<PostsController>>();

            var controller = new PostsController(repository.Object, logger.Object);

            var result = controller.GetAsync();
        }
    }
}
