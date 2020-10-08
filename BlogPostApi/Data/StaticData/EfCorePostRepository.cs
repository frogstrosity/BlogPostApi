using BlogPostApi.Models;

namespace BlogPostApi.Data.Static
{
    public class EfCorePostRepository : EfCoreRepository<Post, PostContext>
    {
        public EfCorePostRepository(PostContext context) : base(context)
        {

        }
    }
}