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

    public partial class Form1 : Form
    {
        public static ControllerLucha lucha1 = new ControllerLucha();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ALuchar_Click(object sender, EventArgs e)
        {

            lucha1.OnagregarJugardor(tb_NameP1.Text);
            lucha1.OnagregarJugardor(tb_NameP2.Text); 
            MessageBox.Show(tb_NameP1.Text + " y " + tb_NameP2.Text + " \n" + "Ahora se iniciara la elección de bitmon \npara cada jugador");
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
        private void tb_NameP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

