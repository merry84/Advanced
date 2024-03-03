using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        //Next, you are given a class Magazine that has Clothes (a List that stores the entity Cloth).
        //All entities inside the repository have the same properties.
        //The Magazine class should have the following properties:
        // Type - string
        // Capacity – int
        // Clothes – List<Cloth>
        //The class constructor should receive type and capacity, also it should initialize the Clothes with a new instance
        //of the collection.Implement the following features:
        // Method AddCloth(Cloth cloth) – adds an entity to the collection if there is room for it
        // Method RemoveCloth(string color) – removes a cloth by given color, if such exists, and returns
        //boolean (true if it is removed, otherwise – false)

        // Method GetSmallestCloth() – returns the Cloth with the smallest Size
        // Method GetCloth(string color) – returns the Cloth with the given color
        // Method GetClothCount() – returns the number of clothes
        // 
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }
        //Method AddCloth(Cloth cloth) – adds an entity to the collection if there is room for it
        public void AddCloth(Cloth cloth)
        {
            if (Clothes.Count < Capacity)
            {
                Clothes.Add(cloth);
            }
        }
        //Method RemoveCloth(string color) – removes a cloth by given color, if such exists, and returns
        public bool RemoveCloth(string color)
        {
            Cloth cloth = Clothes.FirstOrDefault(c => c.Color == color);
            if (cloth != null)
            {
                Clothes.Remove(cloth);
                return true;
            }
            else return false;
        }
        //Method GetSmallestCloth() – returns the Cloth with the smallest Size
        public Cloth GetSmallestCloth()=> Clothes.OrderBy(c => c.Size).FirstOrDefault();
        // Method GetCloth(string color) – returns the Cloth with the given color
        public Cloth GetCloth(string color) => Clothes.FirstOrDefault(c => c.Color == color);

        //Method GetClothCount() – returns the number of clothes
        public int GetClothCount() => Clothes.Count;
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");

            foreach (var cloth in Clothes.OrderBy(c => c.Size))
            {
                sb.AppendLine(cloth.ToString());
            }

            return sb.ToString().TrimEnd();
        }
        

    }
}

