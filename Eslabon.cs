using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mecanismos_II__RRRR_
{
    public class Eslabon
    {
        private double longitud;
        public double Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }

        private double angulo;
        public double Angulo
        {
            get { return angulo; }
            set { angulo = value; }
        }

        private double velocidad;
        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        private double aceleracion;
        public double Aceleracion
        {
            get { return aceleracion; }
            set { aceleracion = value; }
        }

        //CONSTRUCTOR
        public Eslabon(double longitud, double angulo, double velocidad = 0, double aceleracion = 0)
        {
            this.longitud = longitud;
            this.angulo = angulo;
            this.velocidad = velocidad;
            this.aceleracion = aceleracion;
        }

        
    }
}
