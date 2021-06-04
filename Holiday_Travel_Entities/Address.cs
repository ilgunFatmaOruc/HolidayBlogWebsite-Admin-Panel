using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Travel_Entities
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        public string AddressTitle { get; set; }

        public string AddressDescription { get; set; }

        public string AddressInformation { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Location { get; set; }
    }
}
