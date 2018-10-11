using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BitmonGráfico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ALuchar_Click(object sender, EventArgs e)
        {
            modelo.Jugador jg1 = new modelo.Jugador(null, null, tb_NameP1.Text, 1);
            modelo.Jugador jg2 = new modelo.Jugador(null, null, tb_NameP2.Text, 2);

        }
    }
}
