using System.Collections.Generic;

namespace Data
{
  	class DiamondCatalog : Dictionary<int, Diamond>
    {
        Dictionary <int, Diamond> DiamondList = new Dictionary <int, Diamond>();
       
        Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);
        Diamond second = new Diamond(1F, 3999.99F, QualityValue.Good, ShapeValue.Round);
        Diamond third = new Diamond(2F, 4999.99F, QualityValue.VeryGood, ShapeValue.Pear);
        Diamond fourth = new Diamond(2F, 6999.99F, QualityValue.Excellent, ShapeValue.Cushion);
        Diamond fith = new Diamond(3F, 1999.99F, QualityValue.Good, ShapeValue.Oval);
        Diamond sixth = new Diamond(3F, 5999.99F, QualityValue.Excellent, ShapeValue.Pear);
        DiamondList.Add(1,first);
        DiamondList.Add(2,second);
        DiamondList.Add(3,third);
        DiamondList.Add(4,fourth);
        DiamondList.Add(5,fith);
        DiamondList.Add(6,sixth);

            public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!obj is Diamond)
            {
                return false;
            }
          //to do  return ....Comparer.Equals ??
        }

        override int GetHashCode()
        {
            return base.GetHashCode(); //return Comparer......
        }
    }

}
