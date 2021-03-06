﻿using System;
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
    public partial class Form7 : Form
    {
        int turno;
        public Form7()
        {
            InitializeComponent();
            xcb1.Hide();
            comboBox1.Hide();
            if (Form1.lucha1.lucha.turno == 1)
            {
                foreach(Bitmon b in Form1.lucha1.lucha.participantes[0].equipo)
                {
                    if (b.estadolucha != "activo" && b.estadolucha!= "muerto" )
                    {
                        xcb1.Items.Add(b);
                    }
                }
                turno = Form1.lucha1.lucha.turno;
                xcb1.Show();
            }
            if(Form1.lucha1.lucha.turno == 2)
            {
                foreach (Bitmon b in Form1.lucha1.lucha.participantes[1].equipo)
                {
                    if (b.estadolucha != "activo" && b.estadolucha!= "muerto" )
                    {
                        comboBox1.Items.Add(b);
                    }
                }
                turno = Form1.lucha1.lucha.turno;
                comboBox1.Show();
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turno == 1)
            {
                if(xcb1.SelectedItem == null)
                {
                    MessageBox.Show("Opción inválida, ingrésela nuevamente porfavor!!");
                    this.Hide();
                    Form7 form77 = new Form7();
                    form77.Show();
                }
                else
                {
                    Form1.lucha1.Neutro1();
                    Bitmon ca = (Bitmon)xcb1.SelectedItem;
                    Form1.lucha1.Cambiar1(ca.nombre);
                    Form1.lucha1.lucha.turno = 2;
                    MessageBox.Show("Bitmon cambiado con éxito!!");
                    Form5 form51 = new Form5();
                    this.Hide();
                    form51.Show();
                }
                           
            }
            if (turno == 2)
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Opción inválida, ingrésela nuevamente porfavor!!");
                    this.Hide();
                    Form7 form77 = new Form7();
                    form77.Show();
                }
                else
                {
                    Form1.lucha1.Neutro2();
                    Bitmon co = (Bitmon)comboBox1.SelectedItem;
                    Form1.lucha1.Cambiar2(co.nombre);
                    MessageBox.Show("Bitmon cambiado con éxito!!");
                    Form5 form51 = new Form5();
                    this.Hide();
                    form51.Show();
                }
                
            }
            
        }

        private void xcb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
