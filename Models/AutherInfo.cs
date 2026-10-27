using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24_EF_Core.Models
{
    public class AutherInfo
    {

        public int Id { get; set; }

        public  string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public string DateOfBirth { get; set; }
    }
}
