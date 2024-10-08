﻿namespace Blog_de_Insectos.ViewModels
{
    public class PostVM
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? AuthorName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ThumbnailUrl { get; set; }
    }
}
