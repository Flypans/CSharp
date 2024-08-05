using System;
//using System.Collections.Generic;
using System.Collections;


namespace IndexerUndIterator
{
    class Car
    {
        private string[] names;
        public Car(int length)
        {
            names = new string[length];
        }

        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        //foreach statement cannot operate on variables of type 'Car'
        //because 'Car' does not contain a public instance or extension definition for 'GetEnumerator'
        public IEnumerator GetEnumerator()// 공식
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car cars = new Car(3);
            //Indexer
            cars[0] = "BMW3S";
            cars[1] = "BMW5S";
            cars[2] = "BMW7S";

            //Iterator
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
