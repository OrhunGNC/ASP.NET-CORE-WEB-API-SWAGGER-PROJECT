using System.ComponentModel.DataAnnotations;

namespace coreapiswagger.Models
{
    public class Publishers
    {
        [Key]
        public int PublishersId { get; set; }
        public string? PublisherName { get; set; }
        public DateTime FoundationDate { get; set; }
        public decimal PublisherValue { get; set; }
    }
}
