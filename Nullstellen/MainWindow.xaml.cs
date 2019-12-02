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

namespace Nullstellen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Berechnen_quad();
        }

        private void Berechnen_quad()
        {
            double a = Convert.ToDouble(a1.Text);
            double b = Convert.ToDouble(a2.Text);
            double c = Convert.ToDouble(a3.Text);
            if (a == 0.0)
            {
                MessageBox.Show("a muss verschieben von Null sein!");

            }
            else
            {
                double p, q, D;
                double x1, x2;
                p = b / a;
                q = c / a;
                D = Math.Pow(p / 2, 2) - q;
                if(D>0)
                {
                    x1 = -p / 2 + Math.Sqrt(D);
                    x2 = -p / 2 - Math.Sqrt(D);
                    ergebnis.Text = "Es gibt zwei einfache reelle Nullstellen x_1=" + x1 + " und x_2=" + x2 + " .";

                }
                else if ( D == 0.0)
                {
                    x1 = - p / 2;
                    ergebnis.Text = "Es gibt eine doppelte reelle Nullstellen x_1=" + x1 + " .";
                }
                else
                {
                    ergebnis.Text = "Es gibt keine reelle Nullstelle.";
                }


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
