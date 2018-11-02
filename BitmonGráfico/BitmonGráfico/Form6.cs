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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            if (Form1.lucha1.lucha.turno ==1)
            {
                foreach(Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                {
                    foreach(Poder p in b.poderes)
                    {
                        listAtaques.Items.Add("Nombre : " + p.nombre + "   Danio : " + p.danio + "   Costo : " + p.costo + "   Tipo : " + p.tipo);
                    }
                }
            }
            if (Form1.lucha1.lucha.turno ==2)
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[1].equipo)
                {
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {
                            listAtaques.Items.Add("Nombre : " + p.nombre + "   Danio : " + p.danio + "   Costo : " + p.costo + "   Tipo : " + p.tipo);
                        }
                        //listAtaques.DataSource = b.poderes;
                    }
                }
            }
        }

        private void listAtaques_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
