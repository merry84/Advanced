using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        //Next, you are given a class VendingMachine that has Drinks (a List that stores Drinks).
        //The VendingMachine class should have the following properties:
        //•	ButtonCapacity - int
        //•	Drinks – List<Drink>
        //•	GetCount  - int - returns the number of drinks, available in the Vending machine.
        //The class constructor should receive buttonCapacity, also it should initialize the Drinks with a new instance of the collection.
        //Implement the following features:
        //•	Method AddDrink(Drink drink) – adds an entity to the collection of Drinks, if the Capacity allows it.
        //•	Method RemoveDrink(string name) – removes a drink by given name, if such exists,
        //and returns boolean (true if it is removed, otherwise – false)
        //•	Method GetLongest() – returns the Drink with the biggest value of Volume property.
        //•	Method GetCheapest() – returns the Drink with the lowest value of Price property.
        //•	Method BuyDrink(string name) - returns a string in the format of the overriden ToString() method.
        //•	Method Report() – returns a string in the following format:
        //o   "Drinks available:
        //{ Drink1}
        //{Drink2
        //    }
        //    (…)"

        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }
        public int ButtonCapacity { get; set; }
        public List<Drink>  Drinks { get; set; }
        ////•	GetCount  - int - returns the number of drinks, available in the Vending machine.
        public int GetCount =>  Drinks.Count();
        //You will always have drinks added before receiving methods, manipulating the drinks in the VendingMachine.
        public void AddDrink(Drink drink)//Method AddDrink(Drink drink) – adds an entity to the collection of Drinks,
                                         //if the Capacity allows it.
        {
            if(ButtonCapacity> Drinks.Count) { Drinks.Add(drink); }
        }
       // Method RemoveDrink(string name) – removes a drink by given name, if such exists,
        //and returns boolean (true if it is removed, otherwise – false)
        public bool RemoveDrink(string name)=> Drinks.Remove(Drinks.FirstOrDefault(n=>n.Name ==  name));
        //Method GetLongest() – returns the Drink with the biggest value of Volume property.
        public Drink GetLongest()
        {
            Drink drink = Drinks.OrderByDescending(p=>p.Volume).FirstOrDefault();
            return drink;
        }
        public Drink GetCheapest()// returns the Drink with the lowest value of Price property.
        {
            Drink drink = Drinks.OrderBy(p=>p.Price).FirstOrDefault();
            return drink;
        }
        //	Method BuyDrink(string name) - returns a string in the format of the overriden ToString() method
        public string BuyDrink(string name)
        {
            Drink drink = Drinks.FirstOrDefault(n => n.Name == name);
            return drink.ToString().TrimEnd();
        }
        public string Report() 
        {
            var sb = new StringBuilder();
            sb.AppendLine("Drinks available:");
            foreach (Drink drink in Drinks)
            {
                sb.AppendLine(drink.ToString());
            }
                return sb.ToString().TrimEnd();
        }
    }
}
