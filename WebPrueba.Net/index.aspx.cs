using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPrueba.Net
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            PruebaServicioWCF.IPruebaServicio prueba = new PruebaServicioWCF.PruebaServicioClient();
            int primerNum = 0;
            int segundoNum = 0;
            bool primNumVal = Int32.TryParse(txtmonto1.Text, out primerNum);
            bool segNumVal = Int32.TryParse(txtmonto2.Text, out segundoNum);

            if (txtmonto1.Text != string.Empty && txtmonto2.Text != string.Empty)
            {
                int resultado = prueba.Modulo(primerNum, segundoNum);
                if (resultado == -1)
                {
                    Response.Write("<script>alert('El divisor no puede ser cero.')</script>");
                    lblResultado.Text = "";
                }
                else
                {
                    lblResultado.Text = string.Format("El módulo de sus dos números es: {0}", resultado.ToString());
                }
            }
            else
            {
               
                lblResultado.Text = "Aun no a ingresado valores";
            }

        }
    }
}