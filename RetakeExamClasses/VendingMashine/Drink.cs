using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace VendingSystem
{
    public class Drink
    {
        //You are given a class Drink with the following properties:
        //•	Name – string
        //•	Price - decimal
        //•	Volume - int
        //The class constructor should receive name, price and volume.
        //Override the ToString() method in the following format:
        //"Name: {Name}, Price: ${Price}, Volume: {Volume} ml"
        public Drink(string name,decimal price,int volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }
        public string  Name { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, Price: ${Price}, Volume: {Volume} ml";
        }
    }
}
