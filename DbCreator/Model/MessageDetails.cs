using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbCreator.Model
{
    public class MessageDetails
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        [Index]
        public string Type { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        [Index]
        public string SourceSystem { get; set; }

        public string TrackingId { get; set; }

        [Required]
        [Index]
        public DateTime Date { get; set; }
        
        public string Environment { get; set; }

        [Required]
        [StringLength(400)]
        [Index]
        public string MessageBusEndpoint { get; set; }

        [Required]
        public virtual MessageContent MessageContent { get; set; }
    }
}
