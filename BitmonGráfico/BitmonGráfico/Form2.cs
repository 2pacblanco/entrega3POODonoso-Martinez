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
    public partial class Form2 : Form
    {

        List<string> eq1;
        List<string> eq2;
        List<string> disponibles;
        int contador1, contador2;
        int contadorSeleccion;

        public Form2()
        {
            InitializeComponent();
            eq1 = new List<string>();
            eq2 = new List<string>();
            disponibles = new List<string>();
            contador1 = 1;
            contador2 = 1;
            contadorSeleccion = 1;

            disponibles.Add("Charmon");
            disponibles.Add("Bitmeleon");
            disponibles.Add("Pikamon");
            disponibles.Add("Qwertymon");
            disponibles.Add("Squimon");
            disponibles.Add("Worbito");
            disponibles.Add("Icemon");
            disponibles.Add("Dragonice");
            disponibles.Add("Tirimon");
            disponibles.Add("Naidormon");

            foreach (var bits in disponibles)
            {
                ListaBits.Items.Add(bits);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonJugador2Agregar_Click(object sender, EventArgs e)
        {
            if (contadorSeleccion == 2 | contadorSeleccion == 4 | contadorSeleccion == 6)
            {
                if (contador2 <= 3)
                {
                    eq2.Add(ListaBits.SelectedItem.ToString());
                    MessageBox.Show(ListaBits.SelectedItem.ToString() + " se ha agregado para el equipo del jugador 2");
                    ListaBits.Items.Remove(ListaBits.SelectedItem.ToString());
                    contadorSeleccion += 1;
                }
                else
                {
                    MessageBox.Show("Ya tiene listo su equipo, no puede elegir mas bitmons");
                }
            }
            else
            {
                MessageBox.Show("No es su turno para elegir bitmon todavia");
            }
        }


        private void BotonJugador1Agregar_Click(object sender, EventArgs e)
        {
            if (contadorSeleccion == 1 | contadorSeleccion == 3 | contadorSeleccion == 5)
            {
                if (contador2 <= 3)
                {
                    eq1.Add(ListaBits.SelectedItem.ToString());
                    MessageBox.Show(ListaBits.SelectedItem.ToString() + " se ha agregado para el equipo del jugador 1");
                    ListaBits.Items.Remove(ListaBits.SelectedItem.ToString());
                    contadorSeleccion += 1;
                }
                else
                {
                    MessageBox.Show("Ya tiene listo su equipo, no puede elegir mas bitmons");
                }
            }
            else
            {
                MessageBox.Show("No es su turno para elegir bitmon todavia");
            }
        }
    }
}

