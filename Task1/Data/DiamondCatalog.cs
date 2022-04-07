namespace Data;

public class DiamondCatalog
{
    public Guid Id { get; set; }
    public List<Diamond> Diamonds { get; set; }
    public Event Event { get; set; }

    public delegate void AddDiamondDelegate(Diamond diamond);
    public event AddDiamondDelegate AddDiamondEvent;
    public delegate void RemoveDiamondDelegate(Diamond diamond);
    public event RemoveDiamondDelegate RemoveDiamondEvent;

    //Dictionary <int, Diamond> DiamondList = new Dictionary <int, Diamond>();

    //Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);
    //diamond.Add(1,first);

    public DiamondCatalog()
    {
        Id = Guid.NewGuid();
        Diamonds = new List<Diamond>();
    }

    public void AddDiamond(Diamond diamond)
    {
        if (diamond == null)
            return;
        Diamonds.Add(diamond);
        AddDiamondEvent?.Invoke(diamond);
    }

    public void RemoveDiamond(Diamond diamond)
    {
        if (diamond == null)
            return;
        Diamonds.Remove(diamond);
        RemoveDiamondEvent?.Invoke(diamond);
    }

    // public DiamondCatalog(Dictionary<int, Diamond> diamond)
    // {
    //
    //     diamond.Add(1, first);
    //
    // }


    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (obj is Diamond)
        {
            return false;
        }

        //to do  return ....Comparer.Equals ??
        return true; //not correct
    }

    public override int GetHashCode()
    {
        return base.GetHashCode(); //return Comparer......
    }
}