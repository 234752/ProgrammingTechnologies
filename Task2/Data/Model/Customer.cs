﻿using Data.API;

namespace Data.Model

{
    public class Customer //: ICustomer z interface tu czy bez??
    {
    private int Id { get; set; }
    private string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }


      
        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        //int ICustomer.Id => throw new System.NotImplementedException();

        //string ICustomer.Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public int GetId()
        {
            return Id;
        }
    }
}