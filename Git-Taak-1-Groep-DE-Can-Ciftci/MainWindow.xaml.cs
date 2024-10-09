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

namespace Git_Taak_1_Groep_DE_Can_Ciftci
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

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && e.ChangedButton == MouseButton.Left)
            {
                txtFilm.Text = "Dune: Part Two\r\nPaul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.";
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && e.ChangedButton == MouseButton.Left)
            {
                txtFilm.Text = "Furiosa: A Mad Max Saga\r\nThe origin story of renegade warrior Furiosa before her encounter and teamup with Mad Max.";
            }
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && e.ChangedButton == MouseButton.Left)
            {
                txtFilm.Text = "The Substance\r\nA fading celebrity decides to use a black-market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.";
            }
        }
    }
}