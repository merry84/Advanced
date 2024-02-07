using System.Collections.Specialized;
using System.Data;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main()
        {
            Box<int> box = new Box<int>();
            
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

        }
    }

}