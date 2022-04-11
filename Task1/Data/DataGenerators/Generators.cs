
namespace Data.DataGenerators
{
    internal interface IGenerator
    {
        internal void GenerateData(DataContext context);
    }

    internal class EmptyGenerator : IGenerator
    {
        void IGenerator.GenerateData(DataContext context)
        {
            context.Customers = new List<Customer>();
            context.StorageState = new List<StorageEntry>();
            context.Events = new List<Event>();
            context.Catalog = new Dictionary<int, Diamond>();
        }
    }
    internal class CatalogGenerator : IGenerator
    {
        void IGenerator.GenerateData(DataContext context)
        {
            context.Customers = new List<Customer>();
            context.StorageState = new List<StorageEntry>();
            context.Events = new List<Event>();
            context.Catalog = new Dictionary<int, Diamond>();

            Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond second = new Diamond(1F, 3999.99F, QualityValue.Good, ShapeValue.Round);
            Diamond third = new Diamond(2F, 4999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond fourth = new Diamond(2F, 6999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            Diamond fifth = new Diamond(3F, 1999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond sixth = new Diamond(3F, 5999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond seventh = new Diamond(4F, 7999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            context.Catalog.Add(0, first);
            context.Catalog.Add(1, second);
            context.Catalog.Add(2, third);
            context.Catalog.Add(3, fourth);
            context.Catalog.Add(4, fifth);
            context.Catalog.Add(5, sixth);
            context.Catalog.Add(6, seventh);
        }
    }

    internal class CatalogAndCustomersGenerator : IGenerator
    {
        void IGenerator.GenerateData(DataContext context)
        {
            context.Customers = new List<Customer>();
            context.StorageState = new List<StorageEntry>();
            context.Events = new List<Event>();
            context.Catalog = new Dictionary<int, Diamond>();

            Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond second = new Diamond(1F, 3999.99F, QualityValue.Good, ShapeValue.Round);
            Diamond third = new Diamond(2F, 4999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond fourth = new Diamond(2F, 6999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            Diamond fifth = new Diamond(3F, 1999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond sixth = new Diamond(3F, 5999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond seventh = new Diamond(4F, 7999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            context.Catalog.Add(0, first);
            context.Catalog.Add(1, second);
            context.Catalog.Add(2, third);
            context.Catalog.Add(3, fourth);
            context.Catalog.Add(4, fifth);
            context.Catalog.Add(5, sixth);
            context.Catalog.Add(6, seventh);

            context.Customers.Add(new Customer(0, "Bob"));
            context.Customers.Add(new Customer(1, "Paul"));
            context.Customers.Add(new Customer(2, "Daniel"));
        }
    }
}
