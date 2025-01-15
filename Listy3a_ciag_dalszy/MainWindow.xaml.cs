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
        public ObservableCollection<GraKomputerowa> WybraneGryKomputerowe { get; set; } = new ObservableCollection<GraKomputerowa>();
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

        private void Button_Click_DodaJgRE(object sender, RoutedEventArgs e)
        {
            string nazwa = nazwa_gry_textbox.Text;
            string kategoria = gatunki_combo_box.Text;
            int wiek;
            if (int.TryParse(wiek_textbox.Text, out wiek)){
                if(multi_checkbox.IsChecked == true)
                {
                    GryKomputerowe.Add(new GraKomputerowa(nazwa, kategoria, wiek, true));
                }
                else
                {
                    GryKomputerowe.Add(new GraKomputerowa(nazwa, kategoria, wiek, false));
                }
            }
            else
            {
                MessageBox.Show("wiek musi być liczbą");
            }
        }

        private void Button_Click_Wybierz(object sender, RoutedEventArgs e)
        {
            string gatunek = kategoria_comboBox.Text;
            WybraneGryKomputerowe.Clear();
            for(int i = 0; i < GryKomputerowe.Count; i++)
            {
                if (GryKomputerowe[i].Gatunek == gatunek)
                {
                    WybraneGryKomputerowe.Add(GryKomputerowe[i]);
                }
            }
        }

        private void Button_Click_Usun(object sender, RoutedEventArgs e)
        {

        }
    }
}
