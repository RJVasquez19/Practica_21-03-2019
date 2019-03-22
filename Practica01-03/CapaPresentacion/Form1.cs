using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            txtValor1.Text = "0";
            txtValor2.Text = "0";
            lblCalculo.Text = "0";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(txtValor1.Text);
            b = int.Parse(txtValor2.Text);
            r = a + b;

            lblCalculo.Text = r.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            lblCalculo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(txtValor1.Text);
            b = int.Parse(txtValor2.Text);
            r = a - b;

            lblCalculo.Text = r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(txtValor1.Text);
            b = int.Parse(txtValor2.Text);
            r = a * b;

            lblCalculo.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, r;
            a = int.Parse(txtValor1.Text);
            b = int.Parse(txtValor2.Text);
            r = a / b;

            lblCalculo.Text = r.ToString();
        }
    }
}
