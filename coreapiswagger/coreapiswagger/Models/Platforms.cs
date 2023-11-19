using System.ComponentModel.DataAnnotations;

namespace coreapiswagger.Models
{
    public class Platforms
    {
        [Key]
        public int PlatformsId { get; set; }
        public string? PlatformName { get; set; }
    }
}
