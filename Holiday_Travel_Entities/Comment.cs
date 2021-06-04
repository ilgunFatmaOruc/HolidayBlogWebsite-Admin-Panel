using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday_Travel_Entities
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Mail { get; set; }

        public string CommentDescription { get; set; }

        public int BlogID { get; set; }

        public Blog Blog { get; set; }
    }
}
