using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace Practica02_03
{
    public partial class frmOperaciones : Form
    {
        Operacion obj;
        Resta resta;
        Multiplicacion multi;
        Division div;
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            obj = new Operacion();
            obj.V1 = int.Parse(txtValorA.Text);
            obj.V2 = int.Parse(txtValorB.Text);

            lblResultado.Text = "Resultado: " + obj.Calcular().ToString(); ;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            resta = new Resta();
            resta.R1 = int.Parse(txtValorA.Text);
            resta.R2 = int.Parse(txtValorB.Text);

            lblResultado.Text = "Resultado: " + resta.Restar().ToString(); ;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            multi = new Multiplicacion();
            multi.M1 = int.Parse(txtValorA.Text);
            multi.M2 = int.Parse(txtValorB.Text);

            lblResultado.Text = "Resultado: " + multi.Multiplicar().ToString(); ;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            div = new Division();
            div.D1 = int.Parse(txtValorA.Text);
            div.D2 = int.Parse(txtValorB.Text);

            lblResultado.Text = "Resultado: " + div.Dividir().ToString(); ;
        }
    }
}
