using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paarcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = comboBox1.SelectedIndex;
            a = comboBox2.SelectedIndex;

            cantidad = double.Parse(textBox1.Text);
            double[] Zona = { 0.09290304, 0.7, 0.84, 1, 438, 7000, 10000 };
            respuesta = Zona[de] / Zona[a] * cantidad;
            lblRespuesta.Text = "Respuesta: " + Math.Round(respuesta, 2);
        }
    }
}
