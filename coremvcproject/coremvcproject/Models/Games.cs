using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coremvcproject.Models
{
    public class Games
    {
        [Key]
        public int GamesId { get; set; }
        public string? GameName { get; set; }
        public DateTime ReleaseDate {  get; set; }

    }
}
