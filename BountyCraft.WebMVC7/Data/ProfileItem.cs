using System.ComponentModel.DataAnnotations.Schema;

namespace BountyCraft.WebMVC7.Data
{
    public class ProfileItem
    {
        public int Id { get; set; }

        [ForeignKey("ProfileId")]
        public int ProfileId { get; set; }

        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
    }
}
