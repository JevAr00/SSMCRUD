using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Models;
using System.Windows.Forms;

namespace CapaPresentacion.Forms
{
    public partial class FormAreas : Form
    {
        AreaModel area = new AreaModel();

        public FormAreas()
        {
            InitializeComponent();
            dgv_areas.DataSource = area.GetAll();
        }

        #region Botones de Funciones
        private void btn_registroArea_Click(object sender, EventArgs e)
        {

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


    }




}
