using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IDiamond
    {
        int DiamondId { get; set; }
        decimal Price { get; set; }
        string Quality { get; set; }
        string Name { get; set; }
    }
}
