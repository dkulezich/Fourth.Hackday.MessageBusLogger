using System.ComponentModel.DataAnnotations;

namespace DbCreator.Model
{
    public class MessageContent
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Message { get; set; }
        
        public long MessageDetailsId { get; set; }

        [Required]
        public virtual MessageDetails MessageDetails { get; set; }
    }
}
