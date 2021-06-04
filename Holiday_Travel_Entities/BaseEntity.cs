using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Travel_Entities
{
    public class BaseEntity
    {
        
        public int Id { get; set; }

        public bool IsActivated { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? OnModifiedTime { get; set; }

    }
}
