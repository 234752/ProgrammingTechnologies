using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models.ModelsAPI;

namespace TestPresentation
{
    public class MockCustomer : ICustomerModel
    {
        public int Id { get { return 102; } set { Id = value; } }
        public string FirstName { get { return "FirstName"; } set { FirstName = value; } }
        public string LastName { get { return "LastName"; } set { LastName = value; } }
        public override string ToString()
        {
            return "Customer Mock";
        }
    }

    public class MockDiamond : IDiamondModel
    {
        public int Id { get { return 102; } set { Id = value; } }
        public string Name { get { return "Name"; } set { Name = value; } }
        public string Quality { get { return "Quality"; } set { Quality = value; } }
        public decimal Price { get { return 10.2M; } set { Price = value; } }

        public override string ToString()
        {
            return "Diamond Mock";
        }
    }

    public class MockEvent : IEventModel
    {
        public int Id { get { return 102; } set { Id = value; } }
        public string Date { get { return "01/01/2000"; } set { Date = value; } }
        public bool IsDelivery { get { return true; } set { IsDelivery = value; } }
        public int CatalogId { get { return 102; } set { CatalogId = value; } }
        public override string ToString()
        {
            return "Event Mock";
        }
    }

    public class MockData
    {
        public static void GenerateDataMethod1(IDataModel dataModel)
        {
            dataModel.Customers.Add(new MockCustomer());
            dataModel.Diamonds.Add(new MockDiamond());
            dataModel.Events.Add(new MockEvent());
        }
    }

    public class MockDataModel : IDataModel
    {

        public IList<ICustomerModel> Customers
        {
            get { return Customers; }
            set { Customers = value; }
        }

        public IList<IDiamondModel> Diamonds
        {
            get { return Diamonds; }
            set { Diamonds = value; }
        }

        public IList<IEventModel> Events
        {
            get { return Events; }
            set { Events = value; }
        }
    }
}

