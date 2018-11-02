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
    public partial class Form5 : Form
    {
        int turno;
        public Form5()
        {
            InitializeComponent();
            if (Form1.lucha1.lucha.turno == 1)
            {
                label1.Text = "Turno de " + Form1.nombre1;
                turno = Form1.lucha1.lucha.turno;
            }
            if(Form1.lucha1.lucha.turno == 2)
            {
                label1.Text = "Turno de " + Form1.nombre2;
                turno = Form1.lucha1.lucha.turno;
            }

            Bitmon act1 = Form1.lucha1.GetActivo(Form1.nombre1);
            Bitmon act2 = Form1.lucha1.GetActivo(Form1.nombre2);

            label2.Text = "Bitmon de " + Form1.nombre1 + ":    Nombre: " + act1.nombre + "    Vida: " + Convert.ToString(act1.vida) + "    Stamina:" + Convert.ToString(act1.stamina) + "    Tipo: " + act1.tipo;
            label3.Text = "Bitmon de " + Form1.nombre2 + ":    Nombre: " + act2.nombre + "    Vida: " + Convert.ToString(act2.vida) + "    Stamina:" + Convert.ToString(act2.stamina) + "    Tipo: " + act2.tipo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Descansar")
            {
                button2.Text = "De verdad quiere que descanse?";
            }

            if (button2.Text == "De verdad quiere que descanse?")
            {
                if (turno == 1)
                {
                    Form1.lucha1.Descansar(Form1.nombre1);
                    Form1.lucha1.lucha.turno = 2;

                }
                if (turno == 2)
                {
                    Form1.lucha1.Descansar(Form1.nombre2);
                    Form1.lucha1.lucha.turno = 1;

                }

                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turno ==1)
            {
                
            }
            if (turno ==2)
            {

            }
            this.Hide();
                
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
