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
            if (OnagregarJugador != null)
            {
                OnagregarJugador.Invoke(tb_NameP1.Text);
                OnagregarJugador.Invoke(tb_NameP2.Text);
                
            }
            MessageBox.Show(tb_NameP1.Text + " y " + tb_NameP2.Text + "ahora se iniciara la eleccion de bitmon para cada equipo");
            Form2 form2 = new Form2();
            form2.Show();


        }       private void tb_NameP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

