using System.Drawing;

namespace ClothesMagazine
{
    public class Cloth
    {
        //You are given a class Cloth with the following properties:
        // Color - string
        // Size - int
        // Type - string
        //The class constructor should receive color, size and type.
        //Override the ToString() method in the following format:
        //"Product: {type} with size {size}, color {color}"
        public Cloth(string color,int size,string type)
        {
            Color = color;
            Size = size;
            Type = type;
        }
        public string Color { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"Product: {Type} with size {Size}, color {Color}";
        }

    }
}
