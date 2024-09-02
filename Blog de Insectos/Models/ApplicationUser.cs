using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blog_de_Insectos.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // Relação, um user tem 1 ou mais posts mas 1 post pertence a 1 user apenas

        public List<Post> Posts { get; set; }
    }
}
