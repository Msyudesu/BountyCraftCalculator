using System.ComponentModel.DataAnnotations;

namespace BountyCraft.WebMVC7.Models
{
    public class ProfilesVM
    {
        public int ID { get; set; }
        [Required]
        [Display(Name="Profile Name")]
        public string ProfileName { get; set; }
        public string? Description { get; set; }

    }
}
