using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Travel_Entities
{
    public class About
    {
        [Key]
        public int ID { get; set; }

        public string PhotoURL { get; set; }

        public string AboutDescription { get; set; }

    }
}
