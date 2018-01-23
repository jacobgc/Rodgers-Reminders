using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class User
    {
        public String Name { get; set; }
        public String Password { get; set; }
        public DateTime TimeCreated { get; set; }
        public Boolean EmailVerified { get; set; }
    }
}
