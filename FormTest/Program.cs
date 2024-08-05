using System;
using System.Windows.Forms;
using System.Drawing;

namespace FormTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var form = new Form { BackColor = System.Drawing.Color.DarkSeaGreen };
            //f.ShowDialog();
            Application.Run(form);
        }
    }
}
