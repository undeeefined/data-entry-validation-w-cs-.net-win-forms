using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validacion_datos_U2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtEMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@' || e.KeyChar == '.' || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }

            else if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || (e.KeyChar
           == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnValidar_Click(object sender, EventArgs e)
        {
            //validando formato de email
            if (!Validadores.validaEmail(txtEmail.Text))
             {
                MessageBox.Show("El formato de correo no es válido", "Advertencia",
               MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else MessageBox.Show("Correo Electronico Valido");
        }

        private void txtLetras_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }




    }
}
