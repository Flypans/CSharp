using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTest
{
    class Program
    {
        static (int, int) TupleReturn()
        {
            var re = (2, 3);
            return re;
        }

        static (int Sum, int Count) TupleReturnName()
        {
            var returnWithName = (20, 5);
            return returnWithName;
        }

        static (string Name, bool IsStudent, int OrderPrice) StudendOrder()
        {
            var Bestellung = ("Müller", true, 10 );
            return Bestellung;
        }

        static (int, int) TupleDefult() => default;

        static(int Sum, int Count) Tally()
        {
            var r = (s: 100, c: 10);
            Console.WriteLine($"{r.s}, {r.c}");
            return r;
        }
        
        static void Main(string[] args)
        {
            var TagDerUnabhaengigkeit = (15, 08, 1945);
            Console.WriteLine($"Tag der Unabhaengigkeit {TagDerUnabhaengigkeit.Item1}.{TagDerUnabhaengigkeit.Item2}.{TagDerUnabhaengigkeit.Item3}");
            //Default name Item1, Item2...

            var UHD = (Width: 3840, Height: 2160);
            Console.WriteLine($"UHD Width {UHD.Width} x Height {UHD.Height}");
            Console.WriteLine(UHD.GetType());

            (int Width, int Height) FHD = (1920, 1080);
            Console.WriteLine($"FHD Width {FHD.Width} x Height {FHD.Height}");
            Console.WriteLine(FHD.GetType());

            (string Hersteller, string LandDerHerstellung) MadeIn = ("GE", "USA");
            Console.WriteLine($"{MadeIn.Hersteller}, Made in {MadeIn.LandDerHerstellung}");
            Console.WriteLine(MadeIn.GetType());

            Console.WriteLine($"Tuple Return : {TupleReturn()}");

            var retName = TupleReturnName();
            Console.WriteLine($"Tuple Return with Name : {TupleReturnName()}");
            Console.WriteLine(retName.Sum);
            Console.WriteLine(retName.Count);

            var Auftragsbestaetigung = StudendOrder();
            Console.WriteLine(StudendOrder());
            Console.WriteLine(Auftragsbestaetigung);

            Console.WriteLine($"{Auftragsbestaetigung.Name}       :{Auftragsbestaetigung.Name.GetType()} ");
            Console.WriteLine($"{Auftragsbestaetigung.IsStudent}  :{Auftragsbestaetigung.IsStudent.GetType()} ");
            Console.WriteLine($"{Auftragsbestaetigung.OrderPrice} :{Auftragsbestaetigung.OrderPrice.GetType()}");

            var tDefault = TupleDefult();
            Console.WriteLine($"{tDefault.Item1}");
            Console.WriteLine($"{tDefault.Item2}");

            var ta = Tally();
            Console.WriteLine(ta.Sum);
            Console.WriteLine(ta.Count);

            var (sum, count) = Tally();
            Console.WriteLine(sum);
            Console.WriteLine(count);

        }
    }
}
