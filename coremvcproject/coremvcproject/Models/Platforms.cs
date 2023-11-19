using System.ComponentModel.DataAnnotations;

namespace coremvcproject.Models
{
    public class Platforms
    {
        [Key]
        public int PlatformsId { get; set; }
        public string? PlatformName { get; set; }
    }
}
