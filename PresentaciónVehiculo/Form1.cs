using LibTransportes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculo
{
    public partial class frmTransporetes : Form
    {
        public frmTransporetes()
        {
            InitializeComponent();
        }

        private void frmTransporetes_Load(object sender, EventArgs e)
        {
            Camion camion = new Camion(2000, 4);
            Remolque remolque = new Remolque();

            camion.Capacidad = 1000;
            camion.DescripcionDeCarga = "Bebidas";
            camion.Remolque = remolque;

            remolque.Ocupado = true;
            remolque.MaxPeso = 5.5;

            MessageBox.Show("Camion\nCapacidad: " + camion.Capacidad + "\nCarga: " + camion.DescripcionDeCarga+"\nRemolque: "+ camion.Remolque + "\nKilometros: "+ camion.Kilometros +"\nCantidad de ruedas: "+ camion.CantidadDeRuedas);

            MessageBox.Show("Remolque\nOcupado: " + remolque.Ocupado + "\nPeso maximo: " + remolque.MaxPeso);

        }
    }
}
