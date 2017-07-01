using System.ComponentModel.DataAnnotations;

namespace DbCreator.Model
{
    public class MessageContent
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Message { get; set; }        
    }
}
