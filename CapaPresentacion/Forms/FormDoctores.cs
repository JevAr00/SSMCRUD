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

        int ID;

        public FormDoctores()
        {
            InitializeComponent();
        }

        #region Botones de Funciones
        private void btn_registroDoctor_Click(object sender, EventArgs e)
        {
            if ((ckb_lunes.Checked || ckb_martes.Checked || ckb_miercoles.Checked || ckb_jueves.Checked || ckb_viernes.Checked) == true)
            {

                Registrar();

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
            if ((ckb_lunes.Checked || ckb_martes.Checked || ckb_miercoles.Checked || ckb_jueves.Checked || ckb_viernes.Checked) == true)
            {

                Modificar();

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

        private void btn_eliminarDoctor_Click(object sender, EventArgs e)
        {
            if (ID != null)
            {
                Eliminar();

                string mensaje = doctor.ejecutarAccion();
                MessageBox.Show(mensaje);

                Limpiar();
                Refrescar();
            }
        }
        private void btn_buscarDoctor_Click(object sender, EventArgs e)
        {
            if (txt_searchD.Visible == false)
            {
                txt_searchD.Visible = true;
                txt_searchD.Clear();
            }
            else
            {
                txt_searchD.Visible = false;
                txt_searchD.Clear();
            }
        }

        #endregion

        #region Métodos Principales

        private void Registrar()
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

        }

        private void Modificar()
        {
            doctor.estadoEntidad = EntityState.Modified;

            doctor.IdDoctor = ID;
            doctor.Cedula = txt_identificacionD.Text;
            doctor.Nombre = txt_nombreD.Text;
            doctor.Apellidos = txt_apellidoD.Text;
            doctor.Telefono = txt_telefonoD.Text;
            doctor.Disponibilidad = cmb_dispDoctor.Text;
            doctor.Activo = cmb_estadoDoctor.Text;
            doctor.DiasLaborales = DiaLaboral();
            doctor.IdArea = area.GetID(listaArea, cmb_areaDoctor.SelectedItem.ToString());
        }

        private void Eliminar()
        {
            doctor.estadoEntidad = EntityState.Deleted;

            doctor.IdDoctor = ID;
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
            comboArea();
            Refrescar();
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

            ID = Convert.ToInt32(this.dgv_doctores.SelectedRows[0].Cells[0].Value);
            string IDarea = Convert.ToString(this.dgv_doctores.SelectedRows[0].Cells[1].Value);
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
            cmb_areaDoctor.Text = area.GetNameByID(listaArea, Int32.Parse(IDarea));
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

        private void txt_searchD_TextChanged(object sender, EventArgs e)
        {
            dgv_doctores.DataSource = doctor.Buscar(txt_searchD.Text);
        }

        #endregion

        #region Métodos números y letras textbox
        private void txt_identificacionD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Ingresar Únicamente Números");
                e.Handled = true;
            }
        }

        private void txt_nombreD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
            {
                MessageBox.Show("Ingresar Únicamente Letras");
                e.Handled = true;
            }
        }

        private void txt_apellidoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
            {
                MessageBox.Show("Ingresar Únicamente Letras");
                e.Handled = true;
            }
        }

        private void txt_telefonoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Ingresar Únicamente Números");
                e.Handled = true;
            }
        }
        #endregion
    }
}
