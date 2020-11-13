using System;
using System.Collections.Generic;
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
using System.Text.RegularExpressions;

namespace Validation
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex vards = new Regex(@"^[A-Z][a-z]{2,15}$", RegexOptions.Compiled);
            Match sakrita = vards.Match(ie.Text);
            int skaitit = 0;
           
            if (sakrita.Success)
            {
                
                skaitit++;
                ie.Background = Brushes.PaleGreen;
            }
            else
            {
                ie.Background = Brushes.Red;
            }
        }

        private void viens_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex dzimene = new Regex(@"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$", RegexOptions.Compiled);
            Match sakrita = dzimene.Match(viens.Text);

            if (sakrita.Success)
            {
                viens.Background = Brushes.PaleGreen;
            }
            else
            {
                viens.Background = Brushes.Red;
            }
        }

        private void divi_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex numurs = new Regex(@"^([0|\+[0-9]{4})?([0-9]{8}$)", RegexOptions.Compiled);
            Match sakrita = numurs.Match(divi.Text);

            if (sakrita.Success)
            {
                divi.Background = Brushes.PaleGreen;
            }
            else
            {
                divi.Background = Brushes.Red;
            }
        }
        private void tris_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex majaslapa = new Regex(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,3}?$", RegexOptions.Compiled);
            Match sakrita = majaslapa.Match(tris.Text);

            if (sakrita.Success)
            {
                tris.Background = Brushes.PaleGreen;
            }
            else
            {
                tris.Background = Brushes.Red;
            }
        }

        private void cetri_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex epasts = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", RegexOptions.Compiled);
            Match sakrita = epasts.Match(cetri.Text);

            if (sakrita.Success)
            {
                cetri.Background = Brushes.PaleGreen;
            }
            else
            {
                cetri.Background = Brushes.Red;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (viens.Background==Brushes.PaleGreen&& divi.Background == Brushes.PaleGreen && tris.Background == Brushes.PaleGreen && cetri.Background == Brushes.PaleGreen && ie.Background == Brushes.PaleGreen)
            {
                MessageBox.Show("Visi dati ir pareizi", "Viss čikiniekā", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Aizpildi pareizi!", "Mēģini vēlreiz", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
