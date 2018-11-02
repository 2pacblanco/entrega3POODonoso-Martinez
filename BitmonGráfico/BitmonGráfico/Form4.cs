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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label4.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            Random rnd = new Random();

            int random = rnd.Next(0, 10);

            if(random < 5)
            {
                Form1.lucha1.lucha.turno = 1;
                label4.Text= "Felicidades ,la moneda dio cara " + Form1.nombre1 + "\nserás el primero en atacar en esta batalla!";
            }
            else
            {
                Form1.lucha1.lucha.turno = 2;
                label4.Text = "Felicidades ,la moneda dio sello " + Form1.nombre2 + "\nserás el primero en atacar en esta batalla!!";
            }
            label4.Show();
            MessageBox.Show("A luchar!!");
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
