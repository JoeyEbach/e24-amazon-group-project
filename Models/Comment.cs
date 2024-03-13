namespace E24_Amazon.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }

        // Navigation properties
        public User Author { get; set; }
        public Post Post { get; set; }
    }
}
