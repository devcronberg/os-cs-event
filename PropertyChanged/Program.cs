using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {

            Person1 p1 = new Person1();
            p1.PropertyChanged += (s, e) => Console.WriteLine("Egenskab rettet");
            p1.Id = 1;  // skulle gerne resulterer i "Egenskab rettet" på consol

            Person2 p2 = new Person2();
            p2.PropertyChanged += (s, e) => Console.WriteLine("Egenskab " +
                ((PropertyChangedEventArgs)e).PropertyName + " rettet");
            p2.Id = 1;  // skulle gerne resulterer i "Egenskab Id rettet" på consol

            Person3 p3 = new Person3();
            p3.PropertyChanged += (s, e) => Console.WriteLine("Egenskab " +
                e.PropertyName + " rettet");
            p3.Id = 1;  // skulle gerne resulterer i "Egenskab Id rettet" på consol

            Person4 p4 = new Person4();
            p4.PropertyChanged += (s, e) => Console.WriteLine("Egenskab " +
                e.PropertyName + " rettet");
            p4.Id = 1;  // skulle gerne resulterer i "Egenskab Id rettet" på consol

        }
    }
}
