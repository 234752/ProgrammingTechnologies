﻿namespace Data
{
    public class Customer //maybe internal?
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}