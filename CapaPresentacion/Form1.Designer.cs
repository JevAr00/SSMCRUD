
namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btn_citas = new System.Windows.Forms.Button();
            this.btn_doctores = new System.Windows.Forms.Button();
            this.btn_area = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btn_citas);
            this.pnlMenu.Controls.Add(this.btn_doctores);
            this.pnlMenu.Controls.Add(this.btn_area);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(140, 475);
            this.pnlMenu.TabIndex = 0;
            // 
            // btn_citas
            // 
            this.btn_citas.FlatAppearance.BorderSize = 0;
            this.btn_citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_citas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_citas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_citas.Image = global::CapaPresentacion.Properties.Resources.icons8_calendario_48;
            this.btn_citas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_citas.Location = new System.Drawing.Point(0, 341);
            this.btn_citas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_citas.Name = "btn_citas";
            this.btn_citas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_citas.Size = new System.Drawing.Size(165, 49);
            this.btn_citas.TabIndex = 3;
            this.btn_citas.Text = "Citas";
            this.btn_citas.UseVisualStyleBackColor = true;
            // 
            // btn_doctores
            // 
            this.btn_doctores.FlatAppearance.BorderSize = 0;
            this.btn_doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctores.Image = global::CapaPresentacion.Properties.Resources.icons8_doctor_48;
            this.btn_doctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doctores.Location = new System.Drawing.Point(0, 219);
            this.btn_doctores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doctores.Name = "btn_doctores";
            this.btn_doctores.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_doctores.Size = new System.Drawing.Size(165, 49);
            this.btn_doctores.TabIndex = 2;
            this.btn_doctores.Text = "  Doctores";
            this.btn_doctores.UseVisualStyleBackColor = true;
            // 
            // btn_area
            // 
            this.btn_area.FlatAppearance.BorderSize = 0;
            this.btn_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_area.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_area.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_area.Image = global::CapaPresentacion.Properties.Resources.icons8_caduceo_48;
            this.btn_area.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_area.Location = new System.Drawing.Point(0, 98);
            this.btn_area.Margin = new System.Windows.Forms.Padding(2);
            this.btn_area.Name = "btn_area";
            this.btn_area.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_area.Size = new System.Drawing.Size(165, 49);
            this.btn_area.TabIndex = 1;
            this.btn_area.Text = "Áreas";
            this.btn_area.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(140, 65);
            this.pnlLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 475);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_citas;
        private System.Windows.Forms.Button btn_doctores;
    }
}

