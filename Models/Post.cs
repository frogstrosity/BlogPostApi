using BlogPostApi.Data;

namespace BlogPostApi.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tagline { get; set; }
        public string Text { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
