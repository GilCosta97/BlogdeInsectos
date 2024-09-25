using Blog_de_Insectos.Models;

namespace Blog_de_Insectos.ViewModels
{
    public class CreatePostVM
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        // Relação, um user tem 1 ou mais posts mas 1 post pertence a 1 user apenas
        public string? ApplicationUserId { get; set; }
        public string? Description { get; set; }
        public string? ThumbnailUrl { get; set; }
        public IFormFile? Thumbnail { get; set; }
    }
}
