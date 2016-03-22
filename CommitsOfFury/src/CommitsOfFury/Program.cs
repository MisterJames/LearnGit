using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommitsOfFury
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var classes = new List<IAmAClass>()
            {
                new Class1(), new Class2(), new Class3(), new Class4(), new Class5()
            };

            foreach (var item in classes)
            {
                Console.WriteLine(item.TheThingToSay());
            }

            Console.ReadLine();
        }
    }
}
