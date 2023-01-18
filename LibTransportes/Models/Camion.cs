using LibTransportes.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Camion : Vehiculo
    {
        public Camion(double kilometros, int cantidadDeRuedas) : base(kilometros, cantidadDeRuedas)
        {
        }
        public int Capacidad { get; set; }
        public string DescripcionDeCarga { get; set; }

        public Remolque Remolque { get; set; }

        public override string Acelerar()
        {
            return "Acelera 4 veces mas lento que el auto electrico";
        }

        public override string Frenar()
        {
            return "Frena 4 veces mas rapido que el auto electrico";
        }

        public void QuitarRemolque()
        {
            Remolque = null;
        }
    }
}
