using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Filter
    {
        public int MaxCount { get; set; }

        public string Type { get; set; }

        public string SourceSystem { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Endpoint { get; set; }
    }
}