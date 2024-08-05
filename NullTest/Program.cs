using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            int i = 0;
            Console.WriteLine($"Value Type: {i}, {i.GetType()}");

            //Empty Value
            string empty = "";
            Console.WriteLine($"empty Value: {empty}, {empty.GetType()}");

            //Reference Type
            //string nullValue = null;
            //int nullValue = null;// non-nullable value type

            int? nullValue = null;
            try
            {
                //Console.WriteLine($"Reference Type:{nullValue}, {nullValue.GetType()}");
                Console.WriteLine($"Reference Type:{nullValue}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           

            //Nullable<T>
            Nullable<bool> bln = null;
            Console.WriteLine(bln.HasValue);
            
            bln = true;
            Console.WriteLine(bln.HasValue);

            Nullable<int> ii = null;
            Console.WriteLine(ii);

            double? iii = null;
            Console.WriteLine(iii);

            string message = "";

            if(nullValue == null)
            {
                message = "Initialize null with a new value";
                Console.WriteLine(message);
            }

            //message = nullValue ?? "Please Initialize null with a new value";
            message = nullValue?.ToString() ?? "Please Initialize null with a new value";
            Console.WriteLine(message);

            int? value = null;

            int defauValue = value ?? -1;
            Console.WriteLine(defauValue);

            int? x = null;
            //int y = x ?? default(int);// int default 0
            int y = x ?? default;// int default 0

            Console.WriteLine($"{x}, {y}");

            double? d = null;
            Console.WriteLine(d?.ToString()); // ?.

            double? e = 1.0;
            Console.WriteLine(e?.ToString()); ;
            Console.WriteLine(e?.ToString("#.00")); ;

            int? len;
            string smessage;

            //smessage = null;
            smessage = "1234567890";

            len = smessage?.Length;
            Console.WriteLine(len);

            List<string>  list = new List<string>();
            int? numberofList;

            list.Add("Hallo");
            list.Add("Walt");

            numberofList = list?.Count;

            Console.WriteLine(numberofList);

            List<string> list2;
            list2 = null;
            int num;

            num = list2?.Count ?? default;
            Console.WriteLine(num);

        }
    }
}
