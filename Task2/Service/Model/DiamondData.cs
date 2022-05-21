using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Service.Model
{
    internal class DiamondData :IDiamondData
    {
        public int DiamondId { get; }
        public decimal Price { get; }
        public string Quality { get; }
        public DiamondData(int id, decimal price, string quality)
        {
            DiamondId = id;
            Price = price;
            Quality = quality;
        }
    }

}
