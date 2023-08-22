using BountyCraft;
using System.ComponentModel.DataAnnotations.Schema;

namespace BountyCraft.WebMVC7.Data
{
    public class Profile
    {
        public int ID { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string ProfileName { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
