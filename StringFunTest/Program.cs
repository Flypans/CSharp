using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";

            Console.WriteLine(message.ToUpper());
            Console.WriteLine(message.ToLower());

            Console.WriteLine(message.Replace("Hello", "Hallo").Replace("World", "Welt"));

            String s1 = "Hello";
            string s2 = "World";
            Console.WriteLine($"{s1} {s2}");

            string s3 = "Hallo" + " Walt";
            string s4 = String.Concat("안녕", "하세요");
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine($"{s3.Length} {s4.Length}");

            char[] ch = message.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }

            foreach (var item in ch)
            {
                Console.WriteLine(item);
            }

            var oldStringFormat = "";
            var firstName = "John";
            var lastName = "Müller";
            oldStringFormat = string.Format("Name: {0} {1}", firstName, lastName);
            Console.WriteLine(oldStringFormat);

            string userName = "RedStar";
            string userNameInput = "redstar";

            if (userName.ToLower() == userNameInput)
            {
                Console.WriteLine("Same");
            }

            // 사이즈 크면 비교 시 빠르다
            if (string.Equals(userName, userNameInput,
                StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Same");
            }

            // 파일 경로, URL, 프로토콜 등 시스템과 관련된 문자열 비교, 문자열 비교 시 성능이 중요한 경우
            if (userName.Equals(userNameInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Same");
            }
        }

    }
}
