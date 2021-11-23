
namespace CapaPresentacion
{
    partial class Principal
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
            this.btn_areas = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.pnlMenu.Controls.Add(this.btn_citas);
            this.pnlMenu.Controls.Add(this.btn_doctores);
            this.pnlMenu.Controls.Add(this.btn_areas);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(140, 535);
            this.pnlMenu.TabIndex = 0;
            // 
            // btn_citas
            // 
            this.btn_citas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_citas.FlatAppearance.BorderSize = 0;
            this.btn_citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_citas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_citas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_citas.Image = global::CapaPresentacion.Properties.Resources.icons8_calendario_48;
            this.btn_citas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_citas.Location = new System.Drawing.Point(0, 381);
            this.btn_citas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_citas.Name = "btn_citas";
            this.btn_citas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_citas.Size = new System.Drawing.Size(165, 49);
            this.btn_citas.TabIndex = 3;
            this.btn_citas.Text = "Citas";
            this.btn_citas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_citas.UseVisualStyleBackColor = true;
            this.btn_citas.Click += new System.EventHandler(this.btn_citas_Click);
            // 
            // btn_doctores
            // 
            this.btn_doctores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_doctores.FlatAppearance.BorderSize = 0;
            this.btn_doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_doctores.Image = global::CapaPresentacion.Properties.Resources.icons8_doctor_48;
            this.btn_doctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doctores.Location = new System.Drawing.Point(0, 259);
            this.btn_doctores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doctores.Name = "btn_doctores";
            this.btn_doctores.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_doctores.Size = new System.Drawing.Size(165, 49);
            this.btn_doctores.TabIndex = 2;
            this.btn_doctores.Text = "Doctores";
            this.btn_doctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_doctores.UseVisualStyleBackColor = true;
            this.btn_doctores.Click += new System.EventHandler(this.btn_doctores_Click);
            // 
            // btn_areas
            // 
            this.btn_areas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_areas.FlatAppearance.BorderSize = 0;
            this.btn_areas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_areas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_areas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_areas.Image = global::CapaPresentacion.Properties.Resources.icons8_caduceo_48;
            this.btn_areas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_areas.Location = new System.Drawing.Point(0, 138);
            this.btn_areas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_areas.Name = "btn_areas";
            this.btn_areas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_areas.Size = new System.Drawing.Size(165, 49);
            this.btn_areas.TabIndex = 1;
            this.btn_areas.Text = "Áreas";
            this.btn_areas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_areas.UseVisualStyleBackColor = true;
            this.btn_areas.Click += new System.EventHandler(this.btn_areas_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(140, 60);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.pnlTitulo.Controls.Add(this.lbl_titulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(140, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(871, 60);
            this.pnlTitulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(377, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(77, 27);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "HOME";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(140, 60);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(871, 475);
            this.pnlContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 535);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btn_areas;
        private System.Windows.Forms.Button btn_citas;
        private System.Windows.Forms.Button btn_doctores;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

