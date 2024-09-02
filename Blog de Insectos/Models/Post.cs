namespace Blog_de_Insectos.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        // Relação, um user tem 1 ou mais posts mas 1 post pertence a 1 user apenas
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public string? Slug { get; set; }
    }
}
