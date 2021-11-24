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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /*Hacer llamado de las ventanas*/
        private void AbrirVentanas(Form childForm, object btnEnviar)
        {
            if (activeForm != null)
            {
                activeForm.Close();
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


        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }


        #region Botones Menu Izquierdo

        private void btn_areas_Click(object sender, EventArgs e)
        {

            AbrirVentanas(new Forms.FormAreas(), sender);

            string color = ThemeColors.Colorlist[0];
            pnlTitulo.BackColor = ColorTranslator.FromHtml(color);
            pnlLogo.BackColor = ThemeColors.ChangeColorBrightness(ColorTranslator.FromHtml(color), -0.3);

        }

        private void btn_doctores_Click(object sender, EventArgs e)
        {
            AbrirVentanas(new Forms.FormDoctores(), sender);

            string color = ThemeColors.Colorlist[1];
            pnlTitulo.BackColor = ColorTranslator.FromHtml(color);
            pnlLogo.BackColor = ThemeColors.ChangeColorBrightness(ColorTranslator.FromHtml(color), -0.3);
        }

        private void btn_citas_Click(object sender, EventArgs e)
        {
            AbrirVentanas(new Forms.FormCitas(), sender);

            string color = ThemeColors.Colorlist[2];
            pnlTitulo.BackColor = ColorTranslator.FromHtml(color);
            pnlLogo.BackColor = ThemeColors.ChangeColorBrightness(ColorTranslator.FromHtml(color), -0.3);

        }

        #endregion


    }
}
