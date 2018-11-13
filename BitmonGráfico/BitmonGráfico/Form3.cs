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
            
            foreach (Bitmon s in Form2.eq1)
            {
                comboBox1.Items.Add(s);
            }
            foreach (Bitmon s in Form2.eq2)
            {
                comboBox2.Items.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmon nombre_b1 = (Bitmon)comboBox1.SelectedItem;
            Bitmon nombre_b2 = (Bitmon)comboBox2.SelectedItem;

            if(nombre_b1 == null || nombre_b2 == null)
            {
                MessageBox.Show("Opción inválida, reiniciando Form!!");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                Form1.lucha1.AddActivo(nombre_b1.nombre, nombre_b2.nombre);
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();
            }

            
        }
    }
}
