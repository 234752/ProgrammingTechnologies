using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.API;
using Data.Model;
using Service;
using Service.API;

namespace Service.Model
{
    public class DiamondService : IDiamondService
    {
        private readonly AbstractDataAPI _dataRepository;

        public DiamondService(AbstractDataAPI dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public DiamondService()
        {
            _dataRepository = AbstractDataAPI.CreateLayer();
        }

        private static IDiamondData Transform(IDiamond diamond)
        {
            return diamond == null ? null : new DiamondData(diamond.DiamondId, diamond.Price, diamond.Quality, diamond.Name);
        }

        public IDiamondData GetProduct(int diamondId)
        {
            return Transform(_dataRepository.GetDiamond(diamondId)); //czemu inaccessible??
        }

        public bool AddDiamond(int diamondId, decimal price, string quality, string name)
        {
            return _dataRepository.AddDiamond( diamondId, price, quality, name);
        }

      

        public bool UpdateProduct(int diamondId, decimal price, string quality, string name)
        {
            return _dataRepository.UpdateDiamond(diamondId, price, quality, name);
        }

        public bool DeleteProduct(int diamondId)
        {
            return _dataRepository.DeleteDiamond(diamondId);
        }
    }
}
