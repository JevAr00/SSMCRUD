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


        #region Método ComboBox

        private async void comboArea()
        {
            try
            {
                await Task.Run(async () =>
                {
                    //var datAreas = await area.GetNombres();
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

        #endregion


    }
}
