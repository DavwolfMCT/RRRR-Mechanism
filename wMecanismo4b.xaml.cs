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
        Eslabon eslabona;
        Eslabon2 eslabonb;
        Eslabon3 eslabonc;
        Eslabon4 eslabond;
        int tip;
        int ini;
        int fin;





        public wMecanismo4b(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo, int inicio, int final)
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
                tipo = 3;
            }
            else { txtGrashof.Content = "CATEGORIA: Triple balancín"; }


            if(tipo == 0)
            {
                txtConfig.Content = "CONFIGURACION: Abierta";
            }
            else if (tipo == 1)
            {
                txtConfig.Content = "CONFIGURACION: Cruzada";
            }


            txtDatos.Content = "L1: " + eslabon1.Longitud.ToString() +"   L2: " + eslabon2.Longitud.ToString() +"   L3: " + eslabon3.Longitud.ToString() + "   L4: " + eslabon4.Longitud.ToString()
                              + "   ω2: " + eslabon2.Velocidad.ToString() + "   α2: " + eslabon2.Aceleracion.ToString();





            check2.IsChecked = true;
            check3.IsChecked = true;
            check4.IsChecked = true;






            //PRUEBA
            DGValores.ItemsSource = Entrada(eslabon1, eslabon2, eslabon3, eslabon4, tipo, inicio, final);
            DGValores3.ItemsSource = Entrada3(eslabon1, eslabon2, eslabon3, eslabon4, tipo, inicio, final);
            DGValores4.ItemsSource = Entrada4(eslabon1, eslabon2, eslabon3, eslabon4, tipo, inicio ,final);


            eslabona = eslabon1;
            eslabonb = eslabon2;
            eslabonc = eslabon3;
            eslabond = eslabon4;
            tip = tipo;
            ini = inicio;
            fin = final;















        }













        //CONVIERTE LOS RADIANES A GRADOS PARA EL COSENO
        static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }


        public static void Eslabones()
        {

        }














        //ESLABON 2
        public static List<Eslabon2> Entrada(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo, int inicio, int final)
        {
            List<Eslabon2> listaAngulos = new List<Eslabon2>();

            for (int i = inicio; i<(final + 1); i++)
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
        public static List<Eslabon3> Entrada3(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo, int inicio, int final)
        {
            List<Eslabon3> listaAngulos3 = new List<Eslabon3>();

            for (int i = inicio; i < (final + 1); i++)
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
                        eslabon44.Angulo = Mecanismo.Angulo4(eslabon1, eslabon22, eslabon3, eslabon4, tipo);

                        if (tipo == 3)
                        {
                            eslabon44.Angulo = eslabon22.Angulo;
                        }
                        eslabon44.Aceleracion = eslabon44.Aceleracion;


                        Eslabon3 eslabon33 = new Eslabon3(0, 0, 0, 0);
                        eslabon33.Longitud = eslabon3.Longitud;
                        eslabon33.Angulo = Mecanismo.Angulo3(eslabon1, eslabon22, eslabon3, eslabon4, tipo);

                        if (tipo == 3)
                        {
                            eslabon33.Angulo = 0;
                        }
                        eslabon33.Velocidad = Mecanismo.Velocidad3(eslabon1, eslabon22, eslabon33, eslabon44, tipo);
                        eslabon33.Aceleracion = Mecanismo.Aceleracion3(eslabon1, eslabon22, eslabon33, eslabon44, tipo);



                        


                        listaAngulos3.Add(eslabon33);
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
                        eslabon44.Angulo = Mecanismo.Angulo4(eslabon1, eslabon22, eslabon3, eslabon4, tipo);
                        if (tipo == 3)
                        {
                            eslabon44.Angulo = eslabon22.Angulo;
                        }
                        eslabon44.Aceleracion = eslabon44.Aceleracion;

                        Eslabon3 eslabon33 = new Eslabon3(0, 0, 0, 0);
                        eslabon33.Longitud = eslabon3.Longitud;
                        eslabon33.Angulo = Mecanismo.Angulo3(eslabon1, eslabon22, eslabon3, eslabon4, tipo);

                        if (tipo == 3)
                        {
                            eslabon33.Angulo = 0;
                        }
                        eslabon33.Velocidad = Mecanismo.Velocidad3(eslabon1, eslabon22, eslabon33, eslabon44, tipo);
                        eslabon33.Aceleracion = Mecanismo.Aceleracion3(eslabon1, eslabon22, eslabon33, eslabon44, tipo);



                        listaAngulos3.Add(eslabon33);
                    }
                    else { }

                }
                else { }






            }


            return listaAngulos3;
        }


























        //ESLABON 4
        public static List<Eslabon4> Entrada4(Eslabon eslabon1, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo, int inicio, int final)
        {
            List<Eslabon4> listaAngulos4 = new List<Eslabon4>();

            for (int i = inicio; i < (final + 1); i++)
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
                        eslabon33.Angulo = Mecanismo.Angulo3(eslabon1, eslabon22, eslabon3, eslabon4, tipo);

                        if (tipo == 3)
                        {
                            eslabon33.Angulo = 0;
                        }
                        eslabon33.Aceleracion = eslabon33.Aceleracion;




                        Eslabon4 eslabon44 = new Eslabon4(0, 0, 0, 0);
                        eslabon44.Longitud = eslabon4.Longitud;
                        eslabon44.Angulo = Mecanismo.Angulo4(eslabon1, eslabon22, eslabon3, eslabon4, tipo);
                        if (tipo == 3)
                        {
                            eslabon44.Angulo = eslabon22.Angulo;
                        }
                        eslabon44.Velocidad = Mecanismo.Velocidad4(eslabon1, eslabon22, eslabon33, eslabon44, tipo);
                        eslabon44.Aceleracion = Mecanismo.Aceleracion4(eslabon1, eslabon22, eslabon33, eslabon44, tipo);


                        listaAngulos4.Add(eslabon44);
                    }
                    else if (eslabon3.Longitud <= c + eslabon4.Longitud && eslabon4.Longitud <= c + eslabon3.Longitud)
                    {

                        Eslabon2 eslabon22 = new Eslabon2(0, 0, 0, 0);
                        eslabon22.Longitud = eslabon2.Longitud;
                        eslabon22.Angulo = i;
                        eslabon22.Velocidad = eslabon2.Velocidad;
                        eslabon22.Aceleracion = eslabon2.Aceleracion;


                        Eslabon3 eslabon33 = new Eslabon3(0, 0, 0, 0);
                        eslabon33.Longitud = eslabon3.Longitud;
                        eslabon33.Angulo = Mecanismo.Angulo3(eslabon1, eslabon22, eslabon3, eslabon4, tipo);

                        if (tipo == 3)
                        {
                            eslabon33.Angulo = 0;
                        }
                        eslabon33.Aceleracion = eslabon33.Aceleracion;




                        Eslabon4 eslabon44 = new Eslabon4(0, 0, 0, 0);
                        eslabon44.Longitud = eslabon4.Longitud;
                        eslabon44.Angulo = Mecanismo.Angulo4(eslabon1, eslabon22, eslabon3, eslabon4, tipo);
                        if (tipo == 3)
                        {
                            eslabon44.Angulo = eslabon22.Angulo;
                        }
                        eslabon44.Velocidad = Mecanismo.Velocidad4(eslabon1, eslabon22, eslabon33, eslabon44, tipo);
                        eslabon44.Aceleracion = Mecanismo.Aceleracion4(eslabon1, eslabon22, eslabon33, eslabon44, tipo);


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

        private void meca4b_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                if(check2.IsChecked == true)
                {
                    DGValores.ItemsSource = Entrada(eslabona, eslabonb, eslabonc, eslabond, tip, ini, fin);
                }
                else
                {
                    DGValores.ItemsSource = null;
                }

                if (check3.IsChecked == true)
                {
                    DGValores3.ItemsSource = Entrada3(eslabona, eslabonb, eslabonc, eslabond, tip, ini, fin);
                }
                else
                {
                    DGValores3.ItemsSource = null;
                }

                if (check4.IsChecked == true)
                {
                    DGValores4.ItemsSource = Entrada4(eslabona, eslabonb, eslabonc, eslabond, tip, ini, fin);
                }
                else
                {
                    DGValores4.ItemsSource = null;
                }

            }
        }
    }
}
