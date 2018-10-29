using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;


namespace BitmonGráfico
{

    public delegate void agregarJugadorDelegate(string nombre);

    public partial class Form1 : Form
    {
        public event agregarJugadorDelegate OnagregarJugador;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ALuchar_Click(object sender, EventArgs e)
        {
            //falta instanciar jugador con los nombres de los textbox

        }

        private void tb_NameP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
