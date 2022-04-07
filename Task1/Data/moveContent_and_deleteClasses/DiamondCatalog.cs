namespace Data;

public class DiamondCatalog
{
    public Guid Id { get; set; }
   // public List<Diamond> Diamonds { get; set; }   DIAMOND PROTECTION = DP commented in order  to build Data project

   // public delegate void AddDiamondDelegate(Diamond diamond);          DP
 //   public event AddDiamondDelegate AddDiamondEvent;
   // public delegate void RemoveDiamondDelegate(Diamond diamond);       DP
   // public event RemoveDiamondDelegate RemoveDiamondEvent; 

    public DiamondCatalog()
    {
        Id = Guid.NewGuid();
      // Diamonds = new List<Diamond>();                                DP
    }

   /* public void AddDiamond(Diamond diamond)
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

        //to do czy diamenty sa takie same etc etc
        return true; //not correct
    }*/

}