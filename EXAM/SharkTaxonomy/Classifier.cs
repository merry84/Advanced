using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        //Next, create a class Classifier that has Species (a collection for storing sharks). All entities inside the repository have the same properties.
        //The Classifier class should have the following properties:
        // •	Capacity - int
        // •	Species - List<Shark>
        // •	GetCount – getter => returns the number of all sharks.
        // The class constructor should receive capacity. Also, it should initialise the Species with a new instance of the collection. 
        // Implement the following features:
        // •	Method AddShark(Shark shark) – adds a Shark to the Species collection, if the Capacity allows it. If there is a Shark from the same Kind already added, do not duplicate sharks, just skip the command.
        // •	Method RemoveShark(string kind) – attempts to find a Shark, within the Species collection, with Kind value, matching the given parameter. If no Shark is found, the method returns false. Otherwise, it is removed from the collection and the method returns true.
        // •	Method GetLargestShark()– returns the ToString() value of the largest of all sharks, arranged by length.
        // •	Method GetAverageLength() – returns the average length of the sharks added to the collection.
        // •	Method Report() – returns a string in the following format:
        // o	"{count} sharks classified:
        // {shark1}
        // {shark2}
        // {…}
        // {sharkn}"
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }

        public List<Shark> Species { get; set; }

        public int GetCount => Species.Count;

        
        //Method AddShark(Shark shark) – adds a Shark to the Species collection, if the Capacity allows it.
        //If there is a Shark from the same Kind already added, do not duplicate sharks, just skip the command.
        public void AddShark(Shark s)
        {
            if (Capacity == Species.Count || Species.Any(s => s.Kind == s.Kind))
            {
                return;
            }
            Species.Add(s);

        }
        // Method RemoveShark(string kind) – attempts to find a Shark, within the Species collection, with Kind value, matching the given parameter.
        // If no Shark is found, the method returns false. Otherwise, it is removed from the collection and the method returns true.
        public bool RemoveShark(string kind) => Species.Remove(Species.FirstOrDefault(s => s.Kind == kind));

        

        // public bool RemoveProduct(string name) => Stall.Remove(Stall.FirstOrDefault(n => n.Name == name));

        //Method GetLargestShark()– returns the ToString() value of the largest of all sharks, arranged by length.
        public string GetLargestShark()=>
            Species.OrderByDescending(s => s.Length).FirstOrDefault().ToString();
        //Method GetAverageLength() – returns the average length of the sharks added to the collection.
        public double GetAverageLength() => Species.Average(c => c.Length);
        //Method Report() – returns a string in the following format:
        // // o	"{count} sharks classified:
        // // {shark1}
        // // {shark2}
        // // {…}
        // // {sharkn}"
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (var s in Species)
            {
                sb.AppendLine($"{s.ToString().Trim()}");
            }

            return sb.ToString().TrimEnd();

        }


    }


}
