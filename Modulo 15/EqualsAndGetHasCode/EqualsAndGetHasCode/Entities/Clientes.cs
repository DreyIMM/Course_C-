using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsAndGetHasCode.Entities
{
    internal class Clientes
    {
        public string Name{ get; set; }
        public string Email { get; set; }


        public override bool Equals(object obj)
        {
            if(!(obj is Clientes))
            {
                return false;
            }
            Clientes other = obj as Clientes;
            return Email.Equals(other.Email);

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }


    }
}
