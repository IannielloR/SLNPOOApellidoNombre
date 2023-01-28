using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Remolque
    {
        public bool Ocupado { get; set; }
        public double MaxPeso { get; set; }

        public string Mostrar()
        {
            return ($"Ocupado: {Ocupado} \nPeso maximo: {MaxPeso}");
        }
    }
}
