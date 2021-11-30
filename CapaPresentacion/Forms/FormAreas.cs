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
    public partial class FormAreas : Form
    {
        AreaModel area = new AreaModel();

        public FormAreas()
        {
            InitializeComponent();

        }


        #region Botones de Funciones
        private void btn_registroArea_Click(object sender, EventArgs e)
        {
            area.estadoEntidad = EntityState.Added;

            area.Nombre = txt_nombreArea.Text;
            area.Edificio = txt_edificioArea.Text;
            area.Habilitada = cmb_dispArea.Text;

            string mensaje = area.ejecutarAccion();

            MessageBox.Show(mensaje);

            txt_nombreArea.Clear();
            txt_edificioArea.Clear();
            cmb_dispArea.Text = "";
            Refrescar();
        }

        private void btn_modificarArea_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminarArea_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscarArea_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private async void FormAreas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        #region Métodos Adicionales
        private void dgv_areas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(this.dgv_areas.SelectedRows[0].Cells[0].Value);
                string nombre = Convert.ToString(this.dgv_areas.SelectedRows[0].Cells[1].Value);
                string edificio = Convert.ToString(this.dgv_areas.SelectedRows[0].Cells[2].Value);
                string disponibilidad = Convert.ToString(this.dgv_areas.SelectedRows[0].Cells[3].Value);

                txt_nombreArea.Text = nombre;
                txt_edificioArea.Text = edificio;
                cmb_dispArea.Text = disponibilidad;
            }
            catch (Exception)
            {
                return;
            }

        }

        private async void Refrescar()
        {
            await Task.Run(async () =>
            {
                var datos = await area.GetAll();
                dgv_areas.Invoke(new Action(() =>
                {
                    dgv_areas.DataSource = datos;
                }));
            });

        }

        private void txt_nombreArea_TextChanged(object sender, EventArgs e)
        {
            dgv_areas.DataSource = area.Buscar(txt_nombreArea.Text);
        }

        #endregion


    }
}
