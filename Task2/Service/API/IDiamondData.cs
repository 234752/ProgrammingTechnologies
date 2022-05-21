using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public abstract class IDiamondData
    { 
       public int DiamondId { get; }
       public decimal Price { get; }
       public string Quality { get;}
    }
}
