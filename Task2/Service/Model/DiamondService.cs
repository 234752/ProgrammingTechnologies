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
    public class DiamondService
    {
        private readonly DataRepository _dataRepository;

        public DiamondService(DataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        private static IDiamondData Transform(IDiamond diamond)
        {
            return diamond == null ? null : new DiamondData(diamond.DiamondId, diamond.Price, diamond.Quality);
        }

        public IDiamondData GetProduct(int diamondId)
        {
            return Transform(_dataRepository.GetDiamond(diamondId));
        }

        public bool AddDiamond(int diamondId, decimal price, string quality)
        {
            return _dataRepository.AddDiamond( diamondId, price, quality);
        }

      

        public bool UpdateProduct(int diamondId, decimal price, string quality)
        {
            return _dataRepository.UpdateDiamond(diamondId, price, quality);
        }

        public bool DeleteProduct(int diamondId)
        {
            return _dataRepository.DeleteDiamond(diamondId);
        }
    }
}
