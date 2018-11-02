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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            if (Form1.lucha1.lucha.turno == 1)
            {
                foreach(Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                {
                    if (b.estadolucha != "activo" && b.estadolucha!= "muerto" )
                    {
                        xcb1.Items.Add(b.nombre);
                    }
                }
            }
            if(Form1.lucha1.lucha.turno == 2)
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[1].equipo)
                {
                    if (b.estadolucha != "activo" && b.estadolucha!= "muerto" )
                    {
                        xcb1.Items.Add(b.nombre);
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.lucha1.lucha.turno == 1)
            {
                Form1.lucha1.Cambiar(Form1.nombre1, xcb1.Text);
                Form1.lucha1.lucha.turno = 2;

            }
            if (Form1.lucha1.lucha.turno == 2)
            {
                Form1.lucha1.Cambiar(Form1.nombre2, xcb1.Text);
                Form1.lucha1.lucha.turno = 1;
            }

            MessageBox.Show("Bitmon cambiado con éxito!!");
            Form5 form555 = new Form5();
            this.Hide();
            form555.Show();

        }

        private void xcb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
