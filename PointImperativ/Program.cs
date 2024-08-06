using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointImperativ
{
    class Point
    {
        public int x;
        public int y;
        public int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point MoveBy(int dx, int dy, int dz)
        {
            x += dx;
            y += dy;
            z += dz; 
            Console.WriteLine($"Go {x}, {y}, {z}");
            return new Point(x, y, z);
        }

    }


    class Program
    {
        static async Task Main(string[] args)
        {
            Point point = new Point(0, 0, 0);
            int count = 0;
            while(count <= 10)
            {
                count++;
                point.MoveBy(count + 1, count + 2, count + 0);
                await Task.Delay(1000);// 1 Sec
            }

            Console.WriteLine($"x: {point.x}, y: {point.y}, z: {point.z}");

            var methodChaining = new Point(0, 0, 0).MoveBy(100, 200, 300).MoveBy(10, 20, 30);
            Console.WriteLine($"x: {methodChaining.x}, Y: {methodChaining.y}, Z:{methodChaining.z}");
        }
    }
}
