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
        int ID;

        public FormCitas()
        {
            InitializeComponent();
            DataGridSize();
        }

        #region Botones de Funciones
        private void btn_registroCita_Click(object sender, EventArgs e)
        {
            Registrar();

            string mensaje = cita.ejecutarAccion();
            MessageBox.Show(mensaje);

            //Limpiar();
            Refrescar();
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

        private void Limpiar()
        {
            txt_identCliente.Clear();
            txt_nombreCliente.Clear();
            txt_correoCliente.Clear();
            txt_telefonoCliente.Clear();
            cmb_Doctor.ResetText();
            txt_descCita.Clear();
            dtp_fechaCita.ResetText();
            dtp_horaCita.ResetText();
        }

        private async void FormCitas_Load(object sender, EventArgs e)
        {
            Refrescar();
            comboDoctor();
        }

        private void Registrar()
        {
            cita.estadoEntidad = EntityState.Added;
            cita.Cedula = txt_identCliente.Text;
            cita.Nombre = txt_nombreCliente.Text;
            cita.Correo = txt_correoCliente.Text;
            cita.Telefono = txt_telefonoCliente.Text;
            cita.Doctor = cmb_Doctor.Text;
            cita.Descripcion = txt_descCita.Text;
            cita.Fecha = dtp_fechaCita.Value.ToString("MM/dd/yyyy");
            cita.Hora = dtp_horaCita.Value.ToString("hh:mm tt");
        }

        private void Modificar()
        {

        }

        private void Eliminar()
        {

        }

        #endregion


        #region Métodos números y letras textbox
        private void txt_identCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Ingresar Únicamente Números");
                e.Handled = true;
            }
        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
            {
                MessageBox.Show("Ingresar Únicamente Letras");
                e.Handled = true;
            }
        }

        private void txt_telefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Ingresar Únicamente Números");
                e.Handled = true;
            }
        }

        #endregion

        private void dgv_citas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                asignacionDGV();

            }
            catch (Exception)
            {
                return;
            }
        }

        private void asignacionDGV()
        {
            ID = Convert.ToInt32(this.dgv_citas.SelectedRows[0].Cells[0].Value);

        }

    }
}
