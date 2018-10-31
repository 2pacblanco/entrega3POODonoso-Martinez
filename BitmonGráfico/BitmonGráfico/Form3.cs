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
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
            List<Bitmon> eq1 = new List<Bitmon>();
            List<Bitmon> eq2 = new List<Bitmon>(); 
            
            foreach (string s in Form2.eq1)
            {
                comboBox1.Items.Add(s);
            }
            foreach (string s in Form2.eq2)
            {
                comboBox2.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre1 = comboBox1.Text;
            string nombre2 = comboBox2.Text;

            Form1.lucha1.AddActivo(nombre1, nombre2);

            MessageBox.Show("Bitmons elegidos, preparaos para la batalla!!!!");
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }
    }
}
