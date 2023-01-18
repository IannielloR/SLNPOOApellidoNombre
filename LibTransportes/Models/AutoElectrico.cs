using LibTransportes.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class AutoElectrico : Vehiculo
    {
        public AutoElectrico(double kilometros, int cantidadDeRuedas, int prmCantidadPasajeros, int prmNivelDeBateria) : base(kilometros, cantidadDeRuedas)
        {
            this.CantidadPasajeros = prmCantidadPasajeros;
            this.NivelDeBateria = prmNivelDeBateria;
        }
        public int CantidadPasajeros { get; set; }
        public int NivelDeBateria { get; set; }

        public override string Acelerar()
        {
            return "Acelera 4 veces mas rapido que el camion";
        }

        public override string Frenar()
        {
            return "Frena 4 veces mas lento que el camion";
        }
    }
}
