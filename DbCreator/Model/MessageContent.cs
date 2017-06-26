using System.ComponentModel.DataAnnotations;

namespace DbCreator.Model
{
    public class MessageContent
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
