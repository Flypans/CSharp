using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmsSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datas = { 3, 2, 1, 5, 4 };

            //Sort
            Console.WriteLine("Sort with Array.Sort()");
            Array.Sort(datas);
            datas.ToList().ForEach(x => Console.WriteLine(x));

            //Sort
            Console.WriteLine("Sort with OrderBy");
            var SortOrderBy = datas.OrderBy(x => x);
            SortOrderBy.ToList().ForEach(n => Console.WriteLine(n));

            Console.WriteLine("Sort with OrderByDescending");
            //Sort
            var SortDescending = datas.OrderByDescending(x => x);
            SortDescending.ToList().ForEach(n => Console.WriteLine(n));

            //Algorithms

            //Selection Sort Ascending
            Console.WriteLine("Selection Sort Ascending");
            for (int i = 0; i < datas.Length -1; i++)
            {
                for (int j = i + 1; j < datas.Length; j++)
                {
                    if (datas[i] > datas[j])// > Ascending
                    {
                        int temp = datas[i];
                        datas[i] = datas[j];
                        datas[j] = temp;
                    }
                }
            }
            //datas.ToList().ForEach(n => Console.WriteLine(n));

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }

            //Selection Sort descending
            Console.WriteLine("//Selection Sort descending");
            for (int i = 0; i < datas.Length - 1; i++)
            {
                for (int j = i + 1; j < datas.Length; j++)
                {
                    if (datas[i] < datas[j]) // < descending
                    {
                        int temp = datas[i];
                        datas[i] = datas[j];
                        datas[j] = temp;
                    }
                }
            }
            //datas.ToList().ForEach( x => Console.WriteLine(x));

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
