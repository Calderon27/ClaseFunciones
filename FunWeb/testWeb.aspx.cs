using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FunWeb
{
    public partial class testWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClaseFunciones.ClaFunciones op = new ClaseFunciones.ClaFunciones();
            string num = this.txtNumero1.Text;
            int x = Convert.ToInt32(num);
            string valor1 = op.EsPar(x);
            this.txtR1.Text = valor1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClaseFunciones.ClaFunciones op1 = new ClaseFunciones.ClaFunciones();
            string mes = this.txtNumero2.Text;
            int x2 = Convert.ToInt32(mes);
            string valor2 = op1.nombreMes(x2);
                this.txtR2.Text = valor2;
        }
    }
}