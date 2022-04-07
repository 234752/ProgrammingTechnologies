internal class DiamondCatalog : Dictionary<int, Diamond>
    {
      
       
        Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);

       DiamondCatalog(Dictionary<int, Diamond> diamond) { 

        diamond.Add(1,first);
            
        }


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
}