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
        public static double Angulo3(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4)
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







            A = (d * Math.Cos(0 * Math.PI / 180)) - (a * Math.Cos(eslabon2.Angulo * Math.PI / 180));

            B = d * Math.Sin(0 * Math.PI / 180) - (a * Math.Sin(eslabon2.Angulo * Math.PI / 180));

            C = ((A * A) + (B * B) + (b * b) - (c * c)) / (2 * b);

            D = (-(A * A) - (B * B) + (b * b) - (c * c)) / (2 * c);



            T = 2 * (Math.Atan((2 * B + Math.Sqrt(4 * B * B - 4 * (C * C - A * A))) / (2 * (C + A))) * 180 / Math.PI);

            if (T < 0)
            {
                T3 = T + 360;
            }
            else { T3 = T; }



            return T3;
        }










        public static double Angulo4(Eslabon eslabon, Eslabon2 eslabon2, Eslabon3 eslabon3, Eslabon4 eslabon4)
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



            A = (d * Math.Cos(0 * Math.PI / 180)) - (a * Math.Cos(eslabon2.Angulo * Math.PI / 180));

            B = d * Math.Sin(0 * Math.PI / 180) - (a * Math.Sin(eslabon2.Angulo * Math.PI / 180));

            C = ((A * A) + (B * B) + (b * b) - (c * c)) / (2 * b);

            D = (-(A * A) - (B * B) + (b * b) - (c * c)) / (2 * c);



            T = 2 * (Math.Atan((2 * B  + Math.Sqrt(4*B*B - 4*(D*D - A*A))   )   / (2*(D+A))            )                    * 180 / Math.PI); 

            if(T<0)
            {
                T4 = T + 360;
            }
            else { T4 = T; }





            



            return T4;
        }

    }
}
