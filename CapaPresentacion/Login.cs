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
    public partial class Login : Form
    {
        Principal principal = new Principal();

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_registrar_Click(object sender, EventArgs e)
        {

            lbl_registrar.Visible = false;
            lbl_titulo.Visible = false;
            btn_sesion.Visible = false;
            btn_sesion.Enabled = false;
            lbl_registro.Visible = true;
            lbl_ini.Visible = true;
            btn_registro.Visible = true;
            btn_registro.Enabled = true;
            pnl_login.BackgroundImage = Properties.Resources.light_wave;

        }

        private void lbl_ini_Click(object sender, EventArgs e)
        {

            lbl_registrar.Visible = true;
            lbl_titulo.Visible = true;
            btn_sesion.Visible = true;
            btn_sesion.Enabled = true;
            lbl_registro.Visible = false;
            lbl_ini.Visible = false;
            btn_registro.Visible = false;
            btn_registro.Enabled = false;
            pnl_login.BackgroundImage = Properties.Resources.wave;

        }

        private void btn_sesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal.Show();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

            if (txt_contraseña.PlaceholderText == "Contraseña" || txt_contraseña.Text == "")
            {
                txt_contraseña.PasswordChar = '\0';

                if (txt_contraseña.Text != "")
                {
                    txt_contraseña.PasswordChar = '*';
                }
            }

        }

       

    }
}
