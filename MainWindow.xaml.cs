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

namespace Mecanismos_II__RRRR_
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuSalir_click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menuRango_click(object sender, RoutedEventArgs e)
        {


        }

        private void menuAgregar_click(object sender, RoutedEventArgs e)
        {
            wIngresaDatos ventana1 = new wIngresaDatos();
            ventana1.ShowDialog();


        }




        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            wInfo ventanai = new wInfo();
            ventanai.ShowDialog();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TECNM: INSTITUTO TECNOLOGICO DE VERACRUZ. \n Ing. Mecatrónica \n\n CATEDRATICO: Hugo Vega Platas \n INTREGANTES: \n -Osorio Aguilar David Uriel" +
                "\n -Pérez Toral Luis \n -Barradas Sosa Luis Alberto \n -Zamudio Rendon Diego \n -Losano Luigi \n\n VERSION 1.0.0 \n Designed by Davwolf");
        }




        private void menuAnimacion_click(object sender, RoutedEventArgs e)
        {
            wDobleManivela ventanai = new wDobleManivela();
            ventanai.ShowDialog();
        }

        private void animacion2_Click(object sender, RoutedEventArgs e)
        {
            wAnimManiBal ventanai = new wAnimManiBal();
            ventanai.ShowDialog();
        }

        private void animacion3_Click(object sender, RoutedEventArgs e)
        {
            wDobleBalancin ventanai = new wDobleBalancin();
            ventanai.ShowDialog();
        }

        private void animacion4_Click(object sender, RoutedEventArgs e)
        {
            wPuntoCambio ventanai = new wPuntoCambio();
            ventanai.ShowDialog();
        }

        private void animacion5_Click(object sender, RoutedEventArgs e)
        {
            wTripleBalancin ventanai = new wTripleBalancin();
            ventanai.ShowDialog();
        }
    }
}
