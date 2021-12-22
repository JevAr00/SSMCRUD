using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Principal : Form
    {

        private Form activeForm;

        public Principal()
        {
            InitializeComponent();
        }


        #region Métodos Adicionales
        /*Hacer llamado de las ventanas*/
        private void AbrirVentanas(Form childForm)
        {

            if (activeForm != null)
            {
                activeForm.Dispose();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(childForm);
            this.pnlContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_titulo.Text = childForm.Text;



        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm tt");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        #endregion


        #region Botones Menu Izquierdo

        private void btn_areas_Click(object sender, EventArgs e)
        {

            try
            {

                AbrirVentanas(new Forms.FormAreas());

                string color = ThemeColors.Colorlist[0];
                pnlTitulo.BackColor = ColorTranslator.FromHtml(color);
                pnlLogo.BackColor = ThemeColors.ChangeColorBrightness(ColorTranslator.FromHtml(color), -0.3);
                btn_closeChild.Enabled = true;
                btn_closeChild.Visible = true;
            }
            catch
            {

            }

        }

        private void btn_doctores_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirVentanas(new Forms.FormDoctores());

                string color = ThemeColors.Colorlist[1];
                pnlTitulo.BackColor = ColorTranslator.FromHtml(color);
                pnlLogo.BackColor = ThemeColors.ChangeColorBrightness(ColorTranslator.FromHtml(color), -0.3);
                btn_closeChild.Enabled = true;
                btn_closeChild.Visible = true;
            }
            catch
            {

            }
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {

            AbrirVentanas(new Forms.FormCitas());

            string color = ThemeColors.Colorlist[2];
            pnlTitulo.BackColor = ColorTranslator.FromHtml(color);
            pnlLogo.BackColor = ThemeColors.ChangeColorBrightness(ColorTranslator.FromHtml(color), -0.3);
            btn_closeChild.Enabled = true;
            btn_closeChild.Visible = true;

        }

        #endregion


        #region Botones Barra superior
        private void btn_closeChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Dispose();
            Reset();
        }

        private void Reset()
        {
            btn_closeChild.Visible = false;

            lbl_titulo.Text = "INICIO";
            pnlTitulo.BackColor = Color.FromArgb(65, 90, 119);
            pnlLogo.BackColor = Color.FromArgb(13, 27, 42);
        }

        private void btn_cerrarPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizarPrincipal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizarPrincipal_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        #endregion


    }
}
