using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbCreator.Model
{
    public class MessageDetails
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Type { get; set; }

        public string SourceSystem { get; set; }

        public string TrackingId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Environment { get; set; }

        [Required]
        public virtual ICollection<MessageContent> MessageContents { get; set; }
    }
}
