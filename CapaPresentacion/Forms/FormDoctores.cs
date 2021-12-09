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
    public partial class FormDoctores : Form
    {
        DoctorModel doctor = new DoctorModel();

        AreaModel area = new AreaModel();

        List<AreaModel> listaArea = new List<AreaModel>();

        public FormDoctores()
        {
            InitializeComponent();
        }

        #region Botones de Funciones
        private void btn_registroDoctor_Click(object sender, EventArgs e)
        {
            if ((ckb_lunes.Checked || ckb_martes.Checked || ckb_miercoles.Checked || ckb_jueves.Checked || ckb_viernes.Checked) == true)
            {

                doctor.estadoEntidad = EntityState.Added;
                doctor.Cedula = txt_identificacionD.Text;
                doctor.Nombre = txt_nombreD.Text;
                doctor.Apellidos = txt_apellidoD.Text;
                doctor.Telefono = txt_telefonoD.Text;
                doctor.Disponibilidad = cmb_dispDoctor.Text;
                doctor.Activo = cmb_estadoDoctor.Text;
                doctor.DiasLaborales = DiaLaboral();
                doctor.IdArea = area.GetID(listaArea, cmb_areaDoctor.SelectedItem.ToString());

                string mensaje = doctor.ejecutarAccion();

                MessageBox.Show(mensaje);

                Limpiar();
                Refrescar();

            }
            else
            {
                MessageBox.Show("Seleccionar día laboral");
            }


        }

        private void btn_modificarDoctor_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminarDoctor_Click(object sender, EventArgs e)
        {

        }
        private void btn_buscarDoctor_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Métodos adicionales

        private async void Refrescar()
        {
            try
            {
                await Task.Run(async () =>
                {
                    var datos = await doctor.GetAll();
                    dgv_doctores.Invoke(new Action(() =>
                    {
                        dgv_doctores.DataSource = datos;
                    }));
                });
            }
            catch
            {

            }
        }

        private void FormDoctores_Load(object sender, EventArgs e)
        {
            Refrescar();
            comboArea();
        }

        private async void comboArea()
        {
            try
            {
                await Task.Run(async () =>
                {

                    listaArea = await area.GetNombres();

                    cmb_areaDoctor.Invoke(new Action(() =>
                    {

                        for (int i = 0; i < listaArea.Count; i++)
                        {
                            cmb_areaDoctor.Items.Add(listaArea[i].Nombre);
                        }

                    }));

                });

            }
            catch { }

        }


        private string DiaLaboral()
        {
            String dia = "";

            if (ckb_lunes.Checked)
                dia += "L ";
            if (ckb_martes.Checked)
                dia += "K ";
            if (ckb_miercoles.Checked)
                dia += "M ";
            if (ckb_jueves.Checked)
                dia += "J ";
            if (ckb_viernes.Checked)
                dia += "V ";
            return dia;

        }

        private void Limpiar()
        {
            txt_identificacionD.Clear();
            txt_nombreD.Clear();
            txt_apellidoD.Clear();
            txt_telefonoD.Clear();
            cmb_dispDoctor.ResetText();
            cmb_estadoDoctor.ResetText();
            cmb_areaDoctor.ResetText();
            ckb_lunes.Checked = false;
            ckb_martes.Checked = false;
            ckb_miercoles.Checked = false;
            ckb_jueves.Checked = false;
            ckb_viernes.Checked = false;
        }


        private void dgv_doctores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

            int ID = Convert.ToInt32(this.dgv_doctores.SelectedRows[0].Cells[0].Value);
            string area = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[1].Value);
            string dias = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[2].Value);
            string disponibilidad = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[3].Value);
            string estado = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[4].Value);
            string cedula = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[5].Value);
            string nombre = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[6].Value);
            string apellido = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[7].Value);
            string telefono = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[8].Value);

            txt_identificacionD.Text = cedula;
            txt_nombreD.Text = nombre;
            txt_apellidoD.Text = apellido;
            txt_telefonoD.Text = telefono;
            cmb_areaDoctor.Text = area;
            cmb_dispDoctor.Text = disponibilidad;
            cmb_estadoDoctor.Text = estado;

            List<string> list = new List<string>();
            list = dias.Split(' ').ToList();

            foreach (var i in list)
            {

                if (i == "L")
                    ckb_lunes.Checked = true;
                if (i == "K")
                    ckb_martes.Checked = true;
                if (i == "M")
                    ckb_miercoles.Checked = true;
                if (i == "J")
                    ckb_jueves.Checked = true;
                if (i == "V")
                    ckb_viernes.Checked = true;
            }
        }

        #endregion


    }
}
