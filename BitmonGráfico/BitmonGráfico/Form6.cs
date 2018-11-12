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
        string atq;
        public Form6()
        {
            InitializeComponent();
            int contATK = 2;
            if (Form1.lucha1.lucha.turno ==1)
            {
                foreach(Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                {
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {
                            listAtaques.Items.Add(p.nombre);                                           
                        }
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
                            listAtaques.Items.Add(p.nombre);
                        }
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
            
            
            if (listAtaques.SelectedItem == null)
            {
                MessageBox.Show("seleccione un ataque");
            }
            else
            {
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
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listStatsAtaques_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelATK1_Click(object sender, EventArgs e)
        {

        }
    }
}
