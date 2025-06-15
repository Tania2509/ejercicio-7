using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double dinero, conersion;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtConversion.Clear();
            txtCantidad.Clear();
            lblError.Text = "Error:";
            txtCantidad.ReadOnly = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCantidad.Text, out dinero))
            {

                if (dinero >= 0)
                {
                    conersion = dinero * 18;
                    txtConversion.Text = conersion.ToString("N2");
                }

                else
                {
                    lblError.Text = "Ingrese numeros positivos";
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    lblError.Text = "Existe un campo vacio";
                }

                else
                {
                    lblError.Text = "Ingresa numeros y no letras";
                }
            }

            txtCantidad.ReadOnly = true;
        }
    }
}
