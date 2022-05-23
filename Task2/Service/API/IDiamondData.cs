using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface IDiamondData
    { 
        int DiamondId { get; }
        decimal Price { get; }
        string Quality { get;}
        string Name { get; }
    }
}
