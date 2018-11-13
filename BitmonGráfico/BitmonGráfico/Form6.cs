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
<<<<<<< HEAD
                    if(b.estadolucha == "activo")
                    {
                        label2.Text = "Poderes disponibles de " + b.nombre;
                        foreach (Poder p in b.poderes)
                        {
                            listAtaques.Items.Add(p);
=======
                    if (b.estadolucha == "activo")
                    {
                        foreach (Poder p in b.poderes)
                        {
                            listAtaques.Items.Add(p.nombre);                                           
>>>>>>> 99c22d6130ae31191cd5e42fbae082ad13fd1aa9
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
                        label2.Text = "Poderes disponibles de " + b.nombre;
                        foreach (Poder p in b.poderes)
                        {
<<<<<<< HEAD
                            listAtaques.Items.Add(p);
=======
                            listAtaques.Items.Add(p.nombre);
>>>>>>> 99c22d6130ae31191cd5e42fbae082ad13fd1aa9
                        }
                    }
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            Poder pi = (Poder)listAtaques.SelectedItem;
            atq = listAtaques.GetItemText(pi.nombre);

            if (Form1.lucha1.lucha.turno == 1)
=======
            
            
            if (listAtaques.SelectedItem == null)
            {
                MessageBox.Show("seleccione un ataque");
            }
            else
>>>>>>> 99c22d6130ae31191cd5e42fbae082ad13fd1aa9
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
