using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEFcore.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        public string PublisherName { get; set; }
    }
}
