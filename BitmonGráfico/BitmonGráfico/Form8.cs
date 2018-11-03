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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            if (Form1.lucha1.lucha.turno == 1)
            {
                label1.Text = "FELICIDADES "+Form1.nombre1+"\nEres el ganador\nde esta épica batalla!";
            }
            if (Form1.lucha1.lucha.turno == 2)
            {
                label1.Text = "FELICIDADES " + Form1.nombre2 + "\nEres el ganador\nde esta épica batalla!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
