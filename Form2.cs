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

        public Form2()
        {
            InitializeComponent();
            eq1 = new List<string>();
            eq2 = new List<string>();
            disponibles = new List<string>();

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
    }
}
