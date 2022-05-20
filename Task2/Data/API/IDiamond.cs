using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IDiamond
    {
        int Id { get; set; }
        decimal Price { get; set; }
        string Quality { get; set; }
    }
}
