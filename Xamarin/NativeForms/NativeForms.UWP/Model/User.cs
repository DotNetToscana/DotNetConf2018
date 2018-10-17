using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeForms.Shared.Model
{
    public class User
    {
        public User()
        {

        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
