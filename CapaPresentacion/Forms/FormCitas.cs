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
        DoctorModel doctor = new DoctorModel();
        List<DoctorModel> listaDoctor = new List<DoctorModel>();

        public FormCitas()
        {
            InitializeComponent();
            DataGridSize();
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
            comboDoctor();
        }

        #endregion


        #region Métodos Adicionales

        private async void comboDoctor()

        {
            try
            {
                await Task.Run(async () =>
                {
                    listaDoctor = await doctor.GetNombres();

                    cmb_Doctor.Invoke(new Action(() =>
                    {

                        for (int i = 0; i < listaDoctor.Count; i++)
                        {
                            cmb_Doctor.Items.Add(listaDoctor[i].Nombre);
                        }

                    }));

                });

            }
            catch { }

        }

        private void DataGridSize()
        {
            if (WindowState == FormWindowState.Normal)
            {
                dgv_citas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            }
            else
            {
                dgv_citas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        #endregion


    }
}
