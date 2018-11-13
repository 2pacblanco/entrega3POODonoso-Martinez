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
        string nombre_jugador;
        public Form5()
        {
            InitializeComponent();

            if (Form1.lucha1.lucha.turno == 1)
            {
                label1.Text = "Turno de " + Form1.nombre1;
                turno = Form1.lucha1.lucha.turno;
                nombre_jugador = Form1.nombre1;
            }
            if(Form1.lucha1.lucha.turno == 2)
            {
                label1.Text = "Turno de " + Form1.nombre2;
                turno = Form1.lucha1.lucha.turno;
                nombre_jugador = Form1.nombre2;
            }

            Bitmon act1 = Form1.lucha1.GetActivo(Form1.nombre1);
            Bitmon act2 = Form1.lucha1.GetActivo(Form1.nombre2);

            string ruta1 = "C:\\Users\\usuario\\Desktop\\entrega3POODonoso-Martinez\\Imagenes\\"+act1.nombre+".PNG";
            string ruta2 = "C:\\Users\\usuario\\Desktop\\entrega3POODonoso-Martinez\\Imagenes\\" + act2.nombre + ".PNG";

            pictureBox1.Image = Image.FromFile(ruta1);
            pictureBox2.Image = Image.FromFile(ruta2);

            if (turno == 1)
            {
                if (act1.vida == 0)
                {
                    button1.Hide();
                    button2.Hide();
                    MessageBox.Show("Debido a los stats de su Bitmon, usted sólo tiene las siguientes opciones, Descansar o Rendirse");
                }
                if (act1.stamina <= 0)
                {
                    button1.Hide();
                    MessageBox.Show("Debido a su baja stamina, usted solo puede hacer las siguientes opciones");
                }
                if (act1.estadosalud == "Paralisis" || act1.estadosalud == "Sueño")
                {
                    MessageBox.Show("Pierde turno por efectos en su Bitmon");
                    foreach (Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                    {
                        if (b == act1)
                        {
                            b.estadosalud = null;
                        }
                    }
                    turno = 1;
                }
            }

            if (turno == 2)
            {
                if (act2.vida == 0)
                {
                    button1.Hide();
                    button2.Hide();
                    MessageBox.Show("Debido a los stats de su Bitmon, usted sólo tiene las siguientes opciones, Descansar o Rendirse");
                }
                if (act2.stamina <= 0)
                {
                    button1.Hide();
                    MessageBox.Show("Debido a su baja stamina, usted solo puede hacer las siguientes opciones");
                }
                if (act2.estadosalud == "Paralisis" || act2.estadosalud == "Sueño")
                {
                    MessageBox.Show("Pierde turno por efectos en su Bitmon");
                    foreach (Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                    {
                        if (b == act2)
                        {
                            b.estadosalud = null;
                        }
                    }
                    turno = 2;
                }
            }
           

            label2.Text = "Bitmon de " + Form1.nombre1 + ":    Nombre: " + act1.nombre + "    Vida: " + Convert.ToString(act1.vida) + "    Stamina:" + Convert.ToString(act1.stamina) + "    Tipo: " + act1.tipo;
            label3.Text = "Bitmon de " + Form1.nombre2 + ":    Nombre: " + act2.nombre + "    Vida: " + Convert.ToString(act2.vida) + "    Stamina:" + Convert.ToString(act2.stamina) + "    Tipo: " + act2.tipo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Descansar")
            {
                button2.Text = "De verdad quiere que descanse?\n(Presione para confirmar!!)";
            }

            if (button2.Text == "De verdad quiere que descanse?\n(Presione para confirmar!!)")
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
            }
            MessageBox.Show("Estadisticas mejoradas");
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text == "Rendirse")
            {
                button4.Text = "Está seguro que quiere rendirse?\nPresione para confirmar!!";
            }

            if(button4.Text == "Está seguro que quiere rendirse?\nPresione para confirmar!!")
            {
                if (Form1.lucha1.lucha.turno == 1) 
                {
                    Form1.lucha1.Rendirse(Form1.nombre1);

                }
                if (Form1.lucha1.lucha.turno == 2)
                {
                    Form1.lucha1.Rendirse(Form1.nombre2);
                } 
            }

            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
