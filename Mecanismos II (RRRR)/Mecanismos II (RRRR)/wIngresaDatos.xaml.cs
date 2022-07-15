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
using System.Windows.Shapes;

namespace Mecanismos_II__RRRR_
{
    /// <summary>
    /// Lógica de interacción para wIngresaDatos.xaml
    /// </summary>
    public partial class wIngresaDatos : Window
    {
        Eslabon eslabon1;
        Eslabon2 eslabon2;
        Eslabon3 eslabon3;
        Eslabon4 eslabon4;

        public wIngresaDatos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //AGREGA ESLABON1
            eslabon1 = new Eslabon(0, 0, 0, 0);

            eslabon1.Longitud = Convert.ToDouble(txtEslabon1.Text);
            eslabon1.Angulo = 0;

            //AGREGA ESLABON2
            eslabon2 = new Eslabon2(0, 0, 0, 0);

            eslabon2.Longitud = Convert.ToDouble((txtEslabon2.Text));
            eslabon2.Angulo = 0;
            eslabon2.Velocidad = Convert.ToDouble((txtVelocidad2.Text));
            eslabon2.Aceleracion = Convert.ToDouble((txtAceleracion2.Text));

            //AGREGA ESLABON3
            eslabon3 = new Eslabon3(0, 0, 0, 0);

            eslabon3.Longitud = Convert.ToDouble((txtEslabon3.Text));

            //AGREGA ESLABON4
            eslabon4 = new Eslabon4(0, 0, 0, 0);

            eslabon4.Longitud = Convert.ToDouble(txtEslabon4.Text);
            Armar();


            if (Armar() == 1)
            {
                wMecanismo4b ventana = new wMecanismo4b(eslabon1, eslabon2, eslabon3, eslabon4);
                ventana.ShowDialog();
            }
            else if(Armar() == 2)
            {
                MessageBox.Show("No es posible crear mecanismo con esos datos. \n Compruebe los valores e ingrese un valor coherente pedazo de **** 111111111");
            }
            else
            {
                MessageBox.Show("No es posible crear mecanismo con esos datos. \n Compruebe los valores e ingrese un valor coherente pedazo de **** 2222222222");
            }

        }

        //CONVIERTE LOS RADIANES A GRADOS PARA EL COSENO
        double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }


        //FUNCION PARA VERIFICAR QUE SEA POSIBLE CREAR EL MECANISMO
        public int Armar()
        {





            //p verificará si es posible crear el mecanismo en almenos un grado de theta 2.
            int p = 0;
            for (int i = 0; i < 361; i++)
            {
                //Crear variable para despues
                double c = Math.Sqrt((eslabon1.Longitud * eslabon1.Longitud) + (eslabon2.Longitud * eslabon2.Longitud) - (2 * eslabon1.Longitud * eslabon2.Longitud * Math.Cos(DegreesToRadians(i))));


                //VERIFICA QUE SEA POSIBLE CREAR EL MECANISMO

                if (eslabon3.Longitud + eslabon4.Longitud > c)
                {
                    if (eslabon4.Longitud <= c + eslabon3.Longitud && eslabon3.Longitud <= c + eslabon4.Longitud)
                    {
                        p = 1;
                        break;
                    }
                    else if (eslabon3.Longitud <= c + eslabon4.Longitud && eslabon4.Longitud <= c + eslabon3.Longitud)
                    {
                        p = 1;
                        break;
                    }
                    else { p = 2; }

                }
                else { p = 3; }
                prueba.Content = c.ToString();
            }
            
            return p;
        }




        








            //PRUEBAS
            

        
    }
}
