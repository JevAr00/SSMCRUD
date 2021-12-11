using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Models;
using CapaLogica.ValueObjects;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        Principal principal = new Principal();
        UserModel usuario = new UserModel();

        public Login()
        {
            InitializeComponent();

            Size = new Size(354, 451);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Inicio y Registro label
        private void lbl_registrar_Click(object sender, EventArgs e)
        {
            limpiar();
            Size = new Size(354, 518);
            lbl_registrar.Visible = false;
            lbl_titulo.Visible = false;
            btn_sesion.Visible = false;
            lbl_registro.Visible = true;
            lbl_ini.Visible = true;
            btn_registro.Visible = true;
            txt_confContraseña.Visible = true;
            pnl_login.BackgroundImage = Properties.Resources.light_wave;

        }

        private void lbl_ini_Click(object sender, EventArgs e)
        {
            limpiar();
            Size = new Size(354, 451);
            lbl_registrar.Visible = true;
            lbl_titulo.Visible = true;
            btn_sesion.Visible = true;
            lbl_registro.Visible = false;
            lbl_ini.Visible = false;
            btn_registro.Visible = false;
            txt_confContraseña.Visible = false;
            pnl_login.BackgroundImage = Properties.Resources.wave;

        }
        #endregion

        #region botones inicio sesión y registro
        private void btn_sesion_Click(object sender, EventArgs e)
        {
            
            Inicio_Sesion();

        }

        private async void btn_registro_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.Text == "" || txt_confContraseña.Text == "" || txt_usuario.Text == "")
            {
                MessageBox.Show("Por favor llenar todos los campos");
            }
            else if (txt_contraseña.Text != txt_confContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                MessageBox.Show("Registro en proceso");
                Registro();

            }
        }
        #endregion

        #region métodos de inicio sesión y registro


        public async void Registro()
        {
            await Task.Run(async () =>
           {
               usuario.estadoEntidad = EntityState.Added;
               usuario.Nombre = txt_usuario.Text;
               usuario.Password = usuario.Encrypt(txt_contraseña.Text);

               string mensaje = await usuario.ejecutarAccion();
               MessageBox.Show(mensaje);
           });
            limpiar();
        }

        public void Inicio_Sesion()
        {
            usuario.Nombre = txt_usuario.Text;
            usuario.Password = usuario.Encrypt(txt_contraseña.Text);

            if (txt_usuario.Text == "" || txt_contraseña.Text == "")
            {
                MessageBox.Show("Por favor llenar los campos");
            } else if (usuario.validarUsuario() == false) 
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            else
            {
                this.Hide();
                principal.Show();
            }

        }

        #endregion

        #region Métodos de los txt contraseña
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
        private void txt_confContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txt_confContraseña.PlaceholderText == "Confirmar Contraseña" || txt_confContraseña.Text == "")
            {
                txt_confContraseña.PasswordChar = '\0';

                if (txt_confContraseña.Text != "")
                {
                    txt_confContraseña.PasswordChar = '*';
                }
            }
        }

        public void limpiar()
        {
            txt_usuario.Clear();
            txt_contraseña.Clear();
            txt_confContraseña.Clear();
        }

        #endregion

    }
}
