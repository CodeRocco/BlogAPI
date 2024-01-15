namespace BlogAPI.Persistence.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public ICollection<string> Tags { get; set; } = new List<string>();
    }
}
