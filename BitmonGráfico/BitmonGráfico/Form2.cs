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
    public partial class Form2 : Form
    {
        public static List<Bitmon> eq1;
        public static List<Bitmon> eq2;
        public List<Bitmon> disponibles;
        int contador1, contador2;
        int contadorSeleccion;

        public Form2()
        {
            InitializeComponent();
            eq1 = new List<Bitmon>();
            eq2 = new List<Bitmon>();
            disponibles = Form1.lucha1.allbitmons;
            contador1 = 1;
            contador2 = 1;
            contadorSeleccion = 1;
            BotonJugador2Agregar.Hide();

            foreach (Bitmon b in disponibles)
            {
                ListaBits.Items.Add(b);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonJugador2Agregar_Click(object sender, EventArgs e)
        {
            if (contadorSeleccion == 2 | contadorSeleccion == 4 | contadorSeleccion == 6)
            {
                BotonJugador1Agregar.Show();
                if (contador2 <= 3)
                {
                    try
                    {
                        Bitmon c = (Bitmon)ListaBits.SelectedItem;
                        eq2.Add(c);
                        MessageBox.Show(c.nombre+ " se ha agregado para el equipo del jugador " + Form1.nombre2);
                        ListaBits.Items.Remove(ListaBits.SelectedItem);
                        contadorSeleccion++;
                        contador2++;
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No eligió ningún Bitmon, reiniciando Form...");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("Ya tiene listo su equipo, no puede elegir mas bitmons");
                }
                BotonJugador2Agregar.Hide();
            }
            else
            {
                MessageBox.Show("No es su turno para elegir bitmon todavia");
            }
            if (contador2 == 4) {   
                Form1.lucha1.AddEquipos(eq1,1);
                Form1.lucha1.AddEquipos(eq2,2);     
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }       
        }


        private void BotonJugador1Agregar_Click(object sender, EventArgs e)
        {
            if (contadorSeleccion == 1 | contadorSeleccion == 3 | contadorSeleccion == 5)
            {
                BotonJugador2Agregar.Show();
                if (contador1 <= 3)
                {
                    try
                    {
                        Bitmon b = (Bitmon)ListaBits.SelectedItem;
                        eq1.Add(b);
                        MessageBox.Show(b.nombre + " se ha agregado para el equipo del jugador " + Form1.nombre2);
                        ListaBits.Items.Remove(ListaBits.SelectedItem);
                        contadorSeleccion++;
                        contador1++;
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No eligió ningún Bitmon, reiniciando form...");
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Ya tiene listo su equipo, no puede elegir mas bitmons");
                }
                BotonJugador1Agregar.Hide();
            }
           
            else
            {
                MessageBox.Show("No es su turno para elegir bitmon todavia");
            }
            
        }
    }
}

