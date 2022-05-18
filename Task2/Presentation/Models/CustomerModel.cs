using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    internal class CustomerModel
    {
        internal int Id { get; set; }
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        public override string ToString()
        {
            return Id + "  " + FirstName + "  " + LastName;
        }
    }
}
