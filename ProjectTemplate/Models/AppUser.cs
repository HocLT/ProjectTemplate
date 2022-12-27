using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectTemplate.Models
{
    public class AppUser: IdentityUser
    {
        public string? Fullname { get; set; }
    }
}
