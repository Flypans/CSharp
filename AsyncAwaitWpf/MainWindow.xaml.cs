using AsyncAwaitTest3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncAwaitWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnMakeEssen_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            //DateTime start = DateTime.Now;
            stopwatch.Start();

            Steak steak = await (new Steak()).MakeSteakAsync();
            lblDisplay.Content = $"Steak {steak.GetHashCode()}";
            
            Soup soup = await(new Soup()).MakeSoupAsync();
            lblDisplay.Content = $"Soup {soup.GetHashCode()}";

            Egg egg = await(new Egg()).MakeEggAsync();
            lblDisplay.Content = $"Egg {egg.GetHashCode()}";

            stopwatch.Stop();
            lblDisplay.Content = $"Time: {stopwatch.ElapsedMilliseconds} ms";

        }

        private void btnBeerDrinking_Click(object sender, RoutedEventArgs e)
        {
            lblDisplay.Content = "Beer drinking....Good!" + DateTime.Now.Millisecond.ToString();
        }
    }
}
