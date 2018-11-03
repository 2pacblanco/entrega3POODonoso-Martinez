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
<<<<<<< HEAD
        string atq;

        public Form6()
        {
            InitializeComponent();
            if (Form1.lucha1.lucha.turno == 1)
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                {
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {
                            listAtaques.Items.Add(p.nombre);
                            listStatsAtaques.Items.Add("   Danio : " + p.danio + "   Costo : " + p.costo + "   Tipo : " + p.tipo);
                        }
                    }
                }
            }
            if (Form1.lucha1.lucha.turno == 2)
=======
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
>>>>>>> 9b00b7dd190965630f52895381a750cb9bdea7e6
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[1].equipo)
                {
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {
<<<<<<< HEAD
                            listAtaques.Items.Add(p.nombre);
                            listStatsAtaques.Items.Add("   Danio : " + p.danio + "   Costo : " + p.costo + "   Tipo : " + p.tipo);
                        }

=======
                            listAtaques.Items.Add("Nombre : " + p.nombre + "   Danio : " + p.danio + "   Costo : " + p.costo + "   Tipo : " + p.tipo);
                        }
                        //listAtaques.DataSource = b.poderes;
>>>>>>> 9b00b7dd190965630f52895381a750cb9bdea7e6
                    }
                }
            }
        }

        private void listAtaques_SelectedIndexChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            
>>>>>>> 9b00b7dd190965630f52895381a750cb9bdea7e6
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            atq = listAtaques.GetItemText(listAtaques.SelectedItem);

            if (Form1.lucha1.lucha.turno == 1)
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                {
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {

                            if (atq == p.nombre)
                            {
                                Form1.lucha1.GetActivo(Form1.nombre2);
                                Form1.lucha1.Ataca(Form1.lucha1.GetActivo(Form1.nombre2), p, Form1.nombre1);
                                Form1.lucha1.lucha.turno = 2;
                                if (Form1.lucha1.Verify(Form1.lucha1.lucha.turno) == true)
                                {
                                    this.Hide();
                                    Form5 form5 = new Form5();
                                    form5.Show();
                                }

                                if (Form1.lucha1.Verify(Form1.lucha1.lucha.turno) == false)
                                {
                                    this.Hide();
                                    Form8 form8 = new Form8();
                                    form8.Show();
                                }
                            }
                        }
                    }
                }
            }
            if (Form1.lucha1.lucha.turno == 2)
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[1].equipo)
                {
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {

                            if (atq == p.nombre)
                            {
                                Form1.lucha1.GetActivo(Form1.nombre1);
                                Form1.lucha1.Ataca(Form1.lucha1.GetActivo(Form1.nombre1), p, Form1.nombre2);
                                
                                Form1.lucha1.lucha.turno = 1;
                                

                                if (Form1.lucha1.Verify(Form1.lucha1.lucha.turno) == true)
                                {
                                    this.Hide();
                                    Form5 form5 = new Form5();
                                    form5.Show();
                                }

                                if (Form1.lucha1.Verify(Form1.lucha1.lucha.turno) == false)
                                {
                                    this.Hide();
                                    Form8 form8 = new Form8();
                                    form8.Show();
                                }
                            }
                        }
                    }
                }
            }
=======
            
>>>>>>> 9b00b7dd190965630f52895381a750cb9bdea7e6
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
