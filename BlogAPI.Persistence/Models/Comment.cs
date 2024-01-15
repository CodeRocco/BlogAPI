namespace BlogAPI.Persistence.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public BlogPost BlogPost { get; set; } = new BlogPost();
        public int BlogPostId { get; set; }
        public Comment? RepliedToComment { get; set; }
    }
}
