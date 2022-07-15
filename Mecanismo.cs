using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanismos_II__RRRR_
{
    class Mecanismo
    {



        //METODO
        public static double Angulo3(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo)
        {
            double a = eslabon2.Longitud;
            double b = eslabon3.Longitud;
            double c = eslabon4.Longitud;
            double d = eslabon.Longitud;

            double A;
            double B;
            double C;
            double D;
            double T3;
            double T;
            double ang2 = eslabon2.Angulo;

            int x = 0;

            if(tipo == 0)
            {
                x = 1;
            }
            else if(tipo == 1)
            {
                x = -1;
            }

            if (ang2 == 0 || ang2 == 360)
            {
                ang2 = 0.0001;
            }





            A = (d * Math.Cos(0 * Math.PI / 180)) - (a * Math.Cos(ang2 * Math.PI / 180));

            B = d * Math.Sin(0 * Math.PI / 180) - (a * Math.Sin(ang2 * Math.PI / 180));

            C = ((A * A) + (B * B) + (b * b) - (c * c)) / (2 * b);

            D = (-(A * A) - (B * B) + (b * b) - (c * c)) / (2 * c);



            T = 2 * (Math.Atan((2 * B + x*Math.Sqrt(4 * B * B - 4 * (C * C - A * A))) / (2 * (C + A))) * 180 / Math.PI);

            if (T < 0)
            {
                T3 = T + 360;
            }
            else { T3 = T; }



            return T3;
        }










        public static double Angulo4(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo)
        {
            double a = eslabon2.Longitud;
            double b = eslabon3.Longitud;
            double c = eslabon4.Longitud;
            double d = eslabon.Longitud;

            double A;
            double B;
            double C;
            double D;
            double T;
            double T4;
            double ang2 = eslabon2.Angulo;

            int x = 0;

            if (tipo == 0)
            {
                x = 1;
            }
            else if (tipo == 1)
            {
                x = -1;
            }

            if (ang2 == 0 || ang2 == 360)
            {
                ang2 = 0.0001;
            }





            /* double S;
             double P;
             double Q;
             double R;
             double By1;
             double By2;
             double Bx1;
             double Bx2;
             double Ax;
             double Ay;




              Ax = a * Math.Cos(eslabon2.Angulo * Math.PI / 180);
             Ay = a * Math.Sin(eslabon2.Angulo * Math.PI / 180);

             S = ((a * a) - (b * b) + (c * c) - (d * d)) / (2 * (Ax - d));

             P = (Ay * Ay) / ((Ax - d) * (Ax - d)) + 1;

             Q = (2 * Ay * (d - S)) / (Ax - d);

             R = (d - S) * (d - S) - (c * c);


             By1 = (-Q + Math.Sqrt((Q * Q) - 4 * P * R)) / (2 * P);

             By2 = (-Q - Math.Sqrt((Q * Q) - 4 * P * R)) / (2 * P);

             Bx1 = S - ((2 * Ay * By1) / (2 * (Ax - d)));

             Bx2 = S - ((2 * Ay * By2) / (2 * (Ax - d)));


             T4 =180 - Math.Abs((Math.Atan(((By1) / (Bx1 - d))) * 180 / Math.PI));

             T3 = eslabon2.Angulo;  */



            A = (d * Math.Cos(0 * Math.PI / 180)) - (a * Math.Cos(ang2 * Math.PI / 180));

            B = d * Math.Sin(0 * Math.PI / 180) - (a * Math.Sin(ang2 * Math.PI / 180));

            C = ((A * A) + (B * B) + (b * b) - (c * c)) / (2 * b);

            D = (-(A * A) - (B * B) + (b * b) - (c * c)) / (2 * c);



            T = 2 * (Math.Atan((2 * B  + x*Math.Sqrt(4*B*B - 4*(D*D - A*A))   )   / (2*(D+A))            )                    * 180 / Math.PI);

            if(T<0)
            {
                T4 = T + 360;
            }
            else { T4 = T; }





            



            return T4;
        }




        public static double Velocidad3(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo)
        {
            double a = eslabon2.Longitud;
            double b = eslabon3.Longitud;
            double c = eslabon4.Longitud;
            double d = eslabon.Longitud;

            double ang2 = eslabon2.Angulo;
            double ang3 = eslabon3.Angulo;
            double ang4 = eslabon4.Angulo;

            double w2 = eslabon2.Velocidad;

            double w3;

            if (ang2 == 0)
            {
                ang2 = 0.0001;
            }


            w3 = ((a * w2) * (Math.Sin((ang4 - ang2) * Math.PI / 180))) / ((b) * (Math.Sin((ang3 - ang4) * Math.PI / 180)));






            return w3;
        }




        public static double Velocidad4(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo)
        {
            double a = eslabon2.Longitud;
            double b = eslabon3.Longitud;
            double c = eslabon4.Longitud;
            double d = eslabon.Longitud;

            double ang2 = eslabon2.Angulo;
            double ang3 = eslabon3.Angulo;
            double ang4 = eslabon4.Angulo;

            double w2 = eslabon2.Velocidad;

            double w4;

            if (ang2 == 0 || ang2 == 360)
            {
                ang2 = 0.0001;
            }




            w4 = ((a * w2) * (Math.Sin((ang2 - ang3) * Math.PI / 180))) / ((c) * (Math.Sin((ang4 - ang3) * Math.PI / 180)));






            return w4;
        }










        public static double Aceleracion3(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo)
        {
            double a = eslabon2.Longitud;
            double b = eslabon3.Longitud;
            double c = eslabon4.Longitud;
            double d = eslabon.Longitud;

            double ang2 = eslabon2.Angulo;
            double ang3 = eslabon3.Angulo;
            double ang4 = eslabon4.Angulo;

            double w2 = eslabon2.Velocidad;
            double w3;
            double w4;

            double A;
            double B;
            double C;
            double D;
            double E;
            double F;

            double Acc2 = eslabon2.Aceleracion;

            double Acc3;

            if (ang2 == 0 || ang2 == 360)
            {
                ang2 = 1;
            }

            w3 = ((a * w2) * (Math.Sin((ang4 - ang2) * Math.PI / 180))) / ((b) * (Math.Sin((ang3 - ang4) * Math.PI / 180)));
            w4 = ((a * w2) * (Math.Sin((ang2 - ang3) * Math.PI / 180))) / ((c) * (Math.Sin((ang4 - ang3) * Math.PI / 180)));


            A = c * Math.Sin(ang4 * Math.PI / 180);
            B = b * Math.Sin(ang3 * Math.PI / 180);
            C = a * Acc2 * Math.Sin(ang2 * Math.PI / 180) + a * w2 * w2 * Math.Cos(ang2 * Math.PI / 180) + b * w3 * w3 * Math.Cos(ang3 * Math.PI / 180) - c * w4 * w4 * Math.Cos(ang4 * Math.PI / 180);
            D = c * Math.Cos(ang4 * Math.PI / 180);
            E = b * Math.Cos(ang3 * Math.PI / 180);
            F = a * Acc2 * Math.Cos(ang2 * Math.PI / 180) - a * w2 * w2 * Math.Sin(ang2 * Math.PI / 180) - b * w3 * w3 * Math.Sin(ang3 * Math.PI / 180) + c * w4 * w4 * Math.Sin(ang4 * Math.PI / 180);


            Acc3 = (C * D - A * F) / (A * E - B * D);



            return Acc3;
        }





        public static double Aceleracion4(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4, int tipo)
        {
            double a = eslabon2.Longitud;
            double b = eslabon3.Longitud;
            double c = eslabon4.Longitud;
            double d = eslabon.Longitud;

            double ang2 = eslabon2.Angulo;
            double ang3 = eslabon3.Angulo;
            double ang4 = eslabon4.Angulo;

            double w2 = eslabon2.Velocidad;
            double w3;
            double w4;

            double A;
            double B;
            double C;
            double D;
            double E;
            double F;

            double Acc2 = eslabon2.Aceleracion;

            double Acc3;

            if (ang2 == 0 || ang2 == 360)
            {
                ang2 = 1;
            }

            w3 = ((a * w2) * (Math.Sin((ang4 - ang2) * Math.PI / 180))) / ((b) * (Math.Sin((ang3 - ang4) * Math.PI / 180)));
            w4 = ((a * w2) * (Math.Sin((ang2 - ang3) * Math.PI / 180))) / ((c) * (Math.Sin((ang4 - ang3) * Math.PI / 180)));


            A = c * Math.Sin(ang4 * Math.PI / 180);
            B = b * Math.Sin(ang3 * Math.PI / 180);
            C = a * Acc2 * Math.Sin(ang2 * Math.PI / 180) + a * w2 * w2 * Math.Cos(ang2 * Math.PI / 180) + b * w3 * w3 * Math.Cos(ang3 * Math.PI / 180) - c * w4 * w4 * Math.Cos(ang4 * Math.PI / 180);
            D = c * Math.Cos(ang4 * Math.PI / 180);
            E = b * Math.Cos(ang3 * Math.PI / 180);
            F = a * Acc2 * Math.Cos(ang2 * Math.PI / 180) - a * w2 * w2 * Math.Sin(ang2 * Math.PI / 180) - b * w3 * w3 * Math.Sin(ang3 * Math.PI / 180) + c * w4 * w4 * Math.Sin(ang4 * Math.PI / 180);


            Acc3 = (C * E - B * F) / (A * E - B * D);



            return Acc3;
        }

    }
}
