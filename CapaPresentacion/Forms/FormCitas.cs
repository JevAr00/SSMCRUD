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

namespace CapaPresentacion.Forms
{
    public partial class FormCitas : Form
    {
        CitaModel cita = new CitaModel();

        public FormCitas()
        {
            InitializeComponent();
        }

        #region Botones de Funciones
        private void btn_registroCita_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificarCita_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminarCita_Click(object sender, EventArgs e)
        {

        }
        private void btn_buscarCita_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region Métodos Principales

        private async void Refrescar()
        {
            try
            {
                await Task.Run(async () =>
                {
                    var datos = await cita.GetAll();
                    dgv_citas.Invoke(new Action(() =>
                    {
                        dgv_citas.DataSource = datos;
                    }));
                });
            }
            catch
            {

            }
        }

        private async void FormCitas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        #endregion


    }
}
