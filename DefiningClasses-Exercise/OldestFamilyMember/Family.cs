using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DefiningClasses;

namespace OldestFamilyMember
{
    public class Family
    {
       private List<Person> persons;

       public Family()
       {
           persons = new List<Person>();
       }

       public List<Person> Persons
       {
           get { return persons;}
           set { persons = value; }
       }

       public void AddMember(Person member)
       {
           Persons.Add(member);
       }

       public Person GetOldestMember()
       {
           Person oldPerson = Persons.MaxBy(member => member.Age);
           return oldPerson;
       }
    }
}
