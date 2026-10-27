using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24_EF_Core.Models
{
    public class Category
    {

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }
    }
}
