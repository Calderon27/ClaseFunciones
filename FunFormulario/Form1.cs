using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            ClaseFunciones.ClaFunciones op = new ClaseFunciones.ClaFunciones();
            string num = this.txtNumero1.Text;
            int x = Convert.ToInt32(num);
            string valor1 = op.EsPar(x);
            this.txtR1.Text = valor1;
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            ClaseFunciones.ClaFunciones op1 = new ClaseFunciones.ClaFunciones();
            string mes = this.txtNumero2.Text;
            int x2 = Convert.ToInt32(mes);
            string valor2 = op1.nombreMes(x2);
            this.txtR2.Text = valor2;
        }
    }
}
