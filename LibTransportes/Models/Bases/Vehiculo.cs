using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models.Bases
{
    public abstract class Vehiculo
    {
        protected Vehiculo(double kilometros, int cantidadDeRuedas)
        {
            this.Kilometros = kilometros;
            this.CantidadDeRuedas = cantidadDeRuedas;
        }

        public double Kilometros { get; set; }
        public int CantidadDeRuedas { get; set; }

        public abstract string Acelerar();

        public abstract string Frenar();

        public abstract string Mostrar();

    }
}
