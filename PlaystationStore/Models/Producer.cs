using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PlaystationStore.Models
{
    public class Producer
    {
        public int producerId { get; set; }
        [Required()]
        [StringLength(100,MinimumLength = 2)]
        public string producerName { get; set; }
        public string producerType { get; set; }

        public virtual List<Game> games { get; set; }
    }
}