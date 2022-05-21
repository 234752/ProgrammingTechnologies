using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface IDiamondService
    {
        IDiamondData GetDiamond(int diamondId);
        bool AddDiamond(int diamondId, decimal price, string quality);
        bool UpdateDiamond(int diamondId, decimal price, string quality);
        bool DeleteDiamond(int diamondId);
    }
}
