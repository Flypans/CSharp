using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest2
{
    class Person
    {
        public string Name { get; set; }
        /*
                public override string ToString()
                {
                    return ($"Name: {Name}");
                }
        */
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Cup<T>
    {
        public T Content { get; set; }
    }

    public class Kunden
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Pair<T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }

        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }
    }
    
    public struct ArticleSet<T, V>
    {
        //public IEnumerable<T> Items { get; set; }
        public List<T> Items { get; set; }


        public V TotalCount { get; set; }

        //public ArticleSet(IEnumerable<T> items, V totalCount)
        public ArticleSet(List<T> items, V totalCount)

        {
            Items = items;
            TotalCount = totalCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>() { "Rot", "Blau" };
            //Console.WriteLine(colors);
            foreach (var coler in colors)
            {
                Console.WriteLine(coler);
            }

            List<Person> person = new List<Person>
            {
                new Person { Name = "Müller" },
                new Person { Name = "Neuer" },
                new Person { Name = "Kroos" }
            };

            foreach (var man in person)
            {
                Console.WriteLine(man.Name);
            }

            var categories = new List<Category>()
            {
                new Category(){ CategoryId = 1, CategoryName = "Erste" },
                new Category(){ CategoryId = 2, CategoryName = "Bundes Liga"},
                new Category(){ CategoryId = 3, CategoryName = "Manschaft"}
            };

            foreach (var category in categories)
            {
                Console.WriteLine($"ID: {category.CategoryId} - NAME: { category.CategoryName}");
            }

            var text = new Cup<string>();
            //text.Content = 1234;
            text.Content = "Hallo";
            Console.WriteLine(text.Content);

            var number = new Cup<int>();
            number.Content = 247;
            Console.WriteLine(number.Content);

            var people = new Cup<Kunden>();
            people.Content = new Kunden { Name = "Steiger", Age = 40 };

            Console.WriteLine($"Name:{people.Content.Name} Age:{people.Content.Age}");

            var pair = new Pair<string, bool>("Ich war anwesend :", true);
            Console.WriteLine($"{pair.First}{pair.Second}");

            var tuple = new Pair<int, double>(3141592, 3.14);
            Console.WriteLine($"{tuple.First}: {tuple.Second}");

            var articles = new List<string> { "Article 1", "Article 2", "Article 3" };
            var articleSet = new ArticleSet<string, int>(articles, articles.Count);

            Console.WriteLine($"Total Count:{articleSet.TotalCount}");

            foreach (var item in articleSet.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
