using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace szallitas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Szallitas> szallitasok = new List<Szallitas>();
        public MainWindow()
        {
            InitializeComponent();
            string[] adatok = File.ReadAllLines("szallit.txt");
            for (int i = 1; i < adatok.Length; i++)
            {
              string[] sor = adatok[i].Split(" ");
              szallitasok.Add(new Szallitas(Int32.Parse(sor[0]),
                  Int32.Parse(sor[1]), Int32.Parse(sor[2]), Int32.Parse(sor[3])));

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sors = Int32.Parse(sorszam.Text)-1;
            feladat2.Text ="innen "+szallitasok[sors].honnan +" ide "+ szallitasok[sors].hova;


        }
    }
}