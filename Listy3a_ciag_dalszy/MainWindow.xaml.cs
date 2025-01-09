using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Listy3a_ciag_dalszy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<GraKomputerowa> GryKomputerowe { get; set; }
        public List<string> gatunki { get; set; } = new List<string>() { "rpg", "fantasy", "zręcznościowa", "fps" };
        public MainWindow()
        {
            InitializeComponent();
           
           KolumnaGatunek.ItemsSource = gatunki;

            wypelnijDane();

            DataContext = this;
        }

        private void wypelnijDane()
        {
            GryKomputerowe = new ObservableCollection<GraKomputerowa>();
            GryKomputerowe.Add(new GraKomputerowa("CS2", "fps", 18, true));
            GryKomputerowe.Add(new GraKomputerowa("Tetris", "zręcznościowa", 6, false));
            GryKomputerowe.Add(new GraKomputerowa("LoL", "fantasy", 13, true));
            GryKomputerowe.Add(new GraKomputerowa("Fortnite", "fps", 12, true));
            GryKomputerowe.Add(new GraKomputerowa("Cyberpunk", "rpg", 18, false));

        }


    }
}
