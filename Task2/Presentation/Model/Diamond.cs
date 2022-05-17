using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Model
{
    internal class Diamond
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Quality { get; set; }
        internal decimal Price { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Quality + " " + Price;
        }
    }
}
