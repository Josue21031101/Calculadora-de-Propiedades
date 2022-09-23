using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suma s = new Suma();
            s.V1 = double.Parse(n1.Text);
            s.V2 = double.Parse(n2.Text);

            n3.Text = s.sumar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resta s = new Resta();
            s.V1 = double.Parse(n1.Text);
            s.V2 = double.Parse(n2.Text);

            n3.Text = s.Restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicar s = new Multiplicar();
            s.V1 = double.Parse(n1.Text);
            s.V2 = double.Parse(n2.Text);

            n3.Text = s.Multiplica().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dividir s = new Dividir();
            s.V1 = double.Parse(n1.Text);
            s.V2 = double.Parse(n2.Text);

            n3.Text = s.Dividir().ToString();
        }
    }
}
