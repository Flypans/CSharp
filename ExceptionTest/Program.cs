using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw (new Exception());
            //throw (new ArgumentNullException());

            //에러 발생 시 비정상 정료
            //int[] arr = new int[2];
            //arr[100] = 101;

            //에러 발생 시 정상 종료
            /*
                        try
                        {
                            int[] arr = new int[2];
                            arr[100] = 101;
                        }
                        catch(Exception ex)
                        {
                            //Console.WriteLine("Error !!!");
                            //Console.WriteLine(ex.Message);// 에러 문장만 출력
                            //Console.WriteLine(ex);// 에러 전체 출력
                            Console.WriteLine(ex.ToString());
                        }
            */
            /*
                        string Pi = "3.14";
                        int number = 0;

                        try
                        {
                            number = Convert.ToInt32(Pi);
                            Console.WriteLine($"Input Value : {number}");
                        }
                        catch(FormatException fe)
                        {
                            Console.WriteLine($"에러 발생: {fe.Message}");
                        }
            */
            //Runtime Error
            for (int i = 0; i < 500; i++)
            {
                try
                {
                    int nowSecond = DateTime.Now.Second;
                    Console.WriteLine($"Now : {nowSecond}s");

                    int result = 2 / (nowSecond % 2);
                    Console.WriteLine("an odd number is OK");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("an even number is Error");
                    Console.WriteLine(ex);
                }
                finally
                {
                    Console.WriteLine("Close Programm");
                }
            }
            
        }
    }
}
