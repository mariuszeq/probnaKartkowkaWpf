using System.Security.Cryptography.X509Certificates;
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

namespace probnaKartkowkaWpf
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

        private void Button_Click_Wywolaj_Funkcje(object sender, RoutedEventArgs e)
        {
            int liczba = 0;

            if (int.TryParse(liczba_Text_Box.Text, out liczba))
            {


                if (silnia.IsChecked == true)
                {
                    
                    MessageBox.Show("silnia wynosi: " + metodaSilnia(liczba));

                }
                if (czypierwsza.IsChecked == true)
                {
                    MessageBox.Show("Parzysta dla true wynik: " + metodaCzyPierwsza(liczba));
                }
                if (sumacyfr.IsChecked == true)
                {
                    MessageBox.Show("Suma cyfr wynosi: " + metodaSumaCyfr(liczba));
                }

            }
            else
            {
                MessageBox.Show("wpisz poprawna liczbe");
            }


        }

        public static int metodaSilnia(int liczba)
        {
            int wynik = 1;

            for (int i = 1; i <= liczba; i++)
            {
                wynik = wynik * i;
               
            }


            return wynik;
        }

        public static int metodaSumaCyfr(int liczba)
        {
            int wynik = 0;

            while (liczba > 0)
            {
                wynik = wynik + liczba % 10;
                liczba /= 10;
            }


            return wynik;
        }

        public static bool metodaCzyPierwsza(int liczba)
        {
           
            if(liczba == 1)
            {
                return false;
            }

            for (int i = 2; i <= liczba; i++)
            {
                if(liczba %2  == 0)
                {
                    return true;
                }

            }

            return false;
        }

        private void Button_Click_ComboBox(object sender, RoutedEventArgs e)
        {

            int liczba = 0;

            if (int.TryParse(liczba_Text_Box.Text, out liczba))
            {


                if (comboBoxXName.Text == "silnia")
                {

                    MessageBox.Show("silnia wynosi: " + metodaSilnia(liczba));

                }
                if (comboBoxXName.Text == "czy pierwsza")
                {
                    MessageBox.Show("Parzysta dla true wynik: " + metodaCzyPierwsza(liczba));
                }
                if (comboBoxXName.Text == "suma cyfr")
                {
                    MessageBox.Show("Suma cyfr wynosi: " + metodaSumaCyfr(liczba));
                }

            }
            else
            {
                MessageBox.Show("wpisz poprawna liczbe");
            }


        }
    }
}