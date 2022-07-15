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
    /// Lógica de interacción para w
    /// Mecanismo4b.xaml
    /// </summary>
    public partial class wMecanismo4b : Window
    {





        public wMecanismo4b(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4)
        {
            InitializeComponent();

            double[] valores;
            double l, s;
            valores = new double[4] { eslabon1.Longitud, eslabon2.Longitud, eslabon3.Longitud, eslabon4.Longitud };




            l = valores[0];
            s = valores[0];

            for (int i = 0; i < 4; i++)
            {
                if (valores[i] > l)
                {
                    l = valores[i];
                }
                else if (valores[i] < s)
                {
                    s = valores[i];
                }
            }



            double c = eslabon1.Longitud + eslabon2.Longitud + eslabon3.Longitud + eslabon4.Longitud - s - l;

            if (s + l < c)
            {
                if (eslabon2.Longitud == s)
                {
                    txtGrashof.Content = "CATEGORIA:  Manivela - Balancin";
                }
                else if (eslabon3.Longitud == s)
                {
                    txtGrashof.Content = "CATEGORIA:  Doble Balancín";
                }
                else { txtGrashof.Content = "CATEGORIA:  Doble Manivela"; }
            }

            else if (s + l == c)
            {
                txtGrashof.Content = "CATEGORIA:  Punto de Cambio";
            }
            else { txtGrashof.Content = "CATEGORIA: Triple balancín"; }











            //PRUEBA
            DGValores.ItemsSource = Entrada(eslabon1, eslabon2, eslabon3, eslabon4);
            DGValores3.ItemsSource = Entrada3(eslabon1, eslabon2, eslabon3, eslabon4);
            DGValores4.ItemsSource = Entrada4(eslabon1, eslabon2, eslabon3, eslabon4);













        }




        //CONVIERTE LOS RADIANES A GRADOS PARA EL COSENO
        static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }















        //ESLABON 2
        public static List<Eslabon2> Entrada(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4)
        {
            List<Eslabon2> listaAngulos = new List<Eslabon2>();

            for (int i = 0; i<361; i++)
            {
                //Crear variable para despues
                double c = Math.Sqrt(eslabon1.Longitud * eslabon1.Longitud + eslabon2.Longitud * eslabon2.Longitud - 2 * eslabon1.Longitud * eslabon2.Longitud * Math.Cos(DegreesToRadians(i)));


                //VERIFICA QUE SEA POSIBLE CREAR EL MECANISMO

                if (eslabon3.Longitud + eslabon4.Longitud > c)
                {
                    if (eslabon4.Longitud <= c + eslabon3.Longitud && eslabon3.Longitud <= c + eslabon4.Longitud)
                    {
                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                        eslabon22.Velocidad = eslabon2.Velocidad;
                        eslabon22.Aceleracion = eslabon2.Aceleracion;


                        listaAngulos.Add(eslabon22);
                    }
                    else if (eslabon3.Longitud <= c + eslabon4.Longitud && eslabon4.Longitud <= c + eslabon3.Longitud)
                    {
                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                      
                        eslabon22.Aceleracion = eslabon22.Aceleracion;


                        listaAngulos.Add(eslabon22);
                    }
                    else {   }

                }
                else {  }




                
                
            }


            return listaAngulos;
        }




















        //ESLABON 3
        public static List<Eslabon3> Entrada3(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4)
        {
            List<Eslabon3> listaAngulos3 = new List<Eslabon3>();

            for (int i = 0; i < 361; i++)
            {
                //Crear variable para despues
                double c = Math.Sqrt(eslabon1.Longitud * eslabon1.Longitud + eslabon2.Longitud * eslabon2.Longitud - 2 * eslabon1.Longitud * eslabon2.Longitud * Math.Cos(DegreesToRadians(i)));


                //VERIFICA QUE SEA POSIBLE CREAR EL MECANISMO

                if (eslabon3.Longitud + eslabon4.Longitud > c)
                {
                    if (eslabon4.Longitud <= c + eslabon3.Longitud && eslabon3.Longitud <= c + eslabon4.Longitud)
                    {

                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                        eslabon22.Velocidad = eslabon2.Velocidad;
                        eslabon22.Aceleracion = eslabon2.Aceleracion;


                        Eslabon3 eslabon33 = new Eslabon3(0, 0, 0, 0);
                        eslabon33.Longitud = eslabon3.Longitud;
                        eslabon33.Angulo = Mecanismo.Angulo3(eslabon1, eslabon22, eslabon3, eslabon4);

                        eslabon33.Aceleracion = eslabon33.Aceleracion;


                        listaAngulos3.Add(eslabon33);
                    }
                    else if (eslabon3.Longitud <= c + eslabon4.Longitud && eslabon4.Longitud <= c + eslabon3.Longitud)
                    {

                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                        eslabon22.Velocidad = eslabon2.Velocidad;
                        eslabon22.Aceleracion = eslabon2.Aceleracion;

                        Eslabon3 eslabon33 = new Eslabon3(0, 0, 0, 0);
                        eslabon33.Longitud = eslabon33.Longitud;
                        eslabon33.Angulo = Mecanismo.Angulo3(eslabon1, eslabon22, eslabon3, eslabon4);

                        eslabon33.Aceleracion = eslabon33.Aceleracion;


                        listaAngulos3.Add(eslabon33);
                    }
                    else { }

                }
                else { }






            }


            return listaAngulos3;
        }


























        //ESLABON 4
        public static List<Eslabon4> Entrada4(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4)
        {
            List<Eslabon4> listaAngulos4 = new List<Eslabon4>();

            for (int i = 0; i < 361; i++)
            {
                //Crear variable para despues
                double c = Math.Sqrt(eslabon1.Longitud * eslabon1.Longitud + eslabon2.Longitud * eslabon2.Longitud - 2 * eslabon1.Longitud * eslabon2.Longitud * Math.Cos(DegreesToRadians(i)));


                //VERIFICA QUE SEA POSIBLE CREAR EL MECANISMO

                if (eslabon3.Longitud + eslabon4.Longitud > c)
                {
                    if (eslabon4.Longitud <= c + eslabon3.Longitud && eslabon3.Longitud <= c + eslabon4.Longitud)
                    {
                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                        eslabon22.Velocidad = eslabon2.Velocidad;
                        eslabon22.Aceleracion = eslabon2.Aceleracion;


                        Eslabon4 eslabon44 = new Eslabon4(0, 0, 0, 0);
                        eslabon44.Longitud = eslabon4.Longitud;
                        eslabon44.Angulo = Mecanismo.Angulo4(eslabon1, eslabon22, eslabon3, eslabon4);

                        eslabon44.Aceleracion = eslabon44.Aceleracion;


                        listaAngulos4.Add(eslabon44);
                    }
                    else if (eslabon3.Longitud <= c + eslabon4.Longitud && eslabon4.Longitud <= c + eslabon3.Longitud)
                    {

                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                        eslabon22.Velocidad = eslabon2.Velocidad;
                        eslabon22.Aceleracion = eslabon2.Aceleracion;


                        Eslabon4 eslabon44 = new Eslabon4(0, 0, 0, 0);
                        eslabon44.Longitud = eslabon4.Longitud;
                        eslabon44.Angulo = Mecanismo.Angulo4(eslabon1, eslabon22, eslabon3, eslabon4);

                        eslabon44.Aceleracion = eslabon44.Aceleracion;


                        listaAngulos4.Add(eslabon44);
                    }
                    else { }

                }
                else { }






            }


            return listaAngulos4;
        }



















        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
