using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Travel_Entities
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }

        public string BlogTitle { get; set; }

        public DateTime BlogDate { get; set; }

        public string BlogDescription { get; set; }

        public string BlogImage { get; set; }

        public ICollection<Comment> Comment { get; set; }

    }
}
