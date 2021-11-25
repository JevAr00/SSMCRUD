
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.PrincipalDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_minimizarPrincipal = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_maximizarPrincipal = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_cerrarPrincipal = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_closeChild = new System.Windows.Forms.Button();
            this.btn_citas = new System.Windows.Forms.Button();
            this.btn_doctores = new System.Windows.Forms.Button();
            this.btn_areas = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.pnlMenu.Size = new System.Drawing.Size(140, 580);
            this.pnlMenu.TabIndex = 0;
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
            this.pnlTitulo.Controls.Add(this.btn_minimizarPrincipal);
            this.pnlTitulo.Controls.Add(this.btn_maximizarPrincipal);
            this.pnlTitulo.Controls.Add(this.btn_cerrarPrincipal);
            this.pnlTitulo.Controls.Add(this.btn_closeChild);
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
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(140, 60);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(871, 520);
            this.pnlContenedor.TabIndex = 2;
            // 
            // PrincipalDragControl
            // 
            this.PrincipalDragControl.Fixed = true;
            this.PrincipalDragControl.Horizontal = true;
            this.PrincipalDragControl.TargetControl = this.pnlTitulo;
            this.PrincipalDragControl.Vertical = true;
            // 
            // btn_minimizarPrincipal
            // 
            this.btn_minimizarPrincipal.ActiveImage = null;
            this.btn_minimizarPrincipal.AllowAnimations = true;
            this.btn_minimizarPrincipal.AllowBuffering = false;
            this.btn_minimizarPrincipal.AllowToggling = false;
            this.btn_minimizarPrincipal.AllowZooming = false;
            this.btn_minimizarPrincipal.AllowZoomingOnFocus = false;
            this.btn_minimizarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizarPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizarPrincipal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_minimizarPrincipal.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_minimizarPrincipal.ErrorImage")));
            this.btn_minimizarPrincipal.FadeWhenInactive = false;
            this.btn_minimizarPrincipal.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_minimizarPrincipal.Image = global::CapaPresentacion.Properties.Resources.Minimizar;
            this.btn_minimizarPrincipal.ImageActive = null;
            this.btn_minimizarPrincipal.ImageLocation = null;
            this.btn_minimizarPrincipal.ImageMargin = 20;
            this.btn_minimizarPrincipal.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_minimizarPrincipal.ImageZoomSize = new System.Drawing.Size(44, 44);
            this.btn_minimizarPrincipal.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_minimizarPrincipal.InitialImage")));
            this.btn_minimizarPrincipal.Location = new System.Drawing.Point(749, 0);
            this.btn_minimizarPrincipal.Name = "btn_minimizarPrincipal";
            this.btn_minimizarPrincipal.Rotation = 0;
            this.btn_minimizarPrincipal.ShowActiveImage = true;
            this.btn_minimizarPrincipal.ShowCursorChanges = true;
            this.btn_minimizarPrincipal.ShowImageBorders = true;
            this.btn_minimizarPrincipal.ShowSizeMarkers = false;
            this.btn_minimizarPrincipal.Size = new System.Drawing.Size(44, 44);
            this.btn_minimizarPrincipal.TabIndex = 4;
            this.btn_minimizarPrincipal.ToolTipText = "";
            this.btn_minimizarPrincipal.WaitOnLoad = false;
            this.btn_minimizarPrincipal.Zoom = 20;
            this.btn_minimizarPrincipal.ZoomSpeed = 10;
            this.btn_minimizarPrincipal.Click += new System.EventHandler(this.btn_minimizarPrincipal_Click);
            // 
            // btn_maximizarPrincipal
            // 
            this.btn_maximizarPrincipal.ActiveImage = null;
            this.btn_maximizarPrincipal.AllowAnimations = true;
            this.btn_maximizarPrincipal.AllowBuffering = false;
            this.btn_maximizarPrincipal.AllowToggling = false;
            this.btn_maximizarPrincipal.AllowZooming = false;
            this.btn_maximizarPrincipal.AllowZoomingOnFocus = false;
            this.btn_maximizarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizarPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximizarPrincipal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_maximizarPrincipal.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_maximizarPrincipal.ErrorImage")));
            this.btn_maximizarPrincipal.FadeWhenInactive = false;
            this.btn_maximizarPrincipal.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_maximizarPrincipal.Image = global::CapaPresentacion.Properties.Resources.Maximizar;
            this.btn_maximizarPrincipal.ImageActive = null;
            this.btn_maximizarPrincipal.ImageLocation = null;
            this.btn_maximizarPrincipal.ImageMargin = 20;
            this.btn_maximizarPrincipal.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_maximizarPrincipal.ImageZoomSize = new System.Drawing.Size(44, 44);
            this.btn_maximizarPrincipal.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_maximizarPrincipal.InitialImage")));
            this.btn_maximizarPrincipal.Location = new System.Drawing.Point(788, 0);
            this.btn_maximizarPrincipal.Name = "btn_maximizarPrincipal";
            this.btn_maximizarPrincipal.Rotation = 0;
            this.btn_maximizarPrincipal.ShowActiveImage = true;
            this.btn_maximizarPrincipal.ShowCursorChanges = true;
            this.btn_maximizarPrincipal.ShowImageBorders = true;
            this.btn_maximizarPrincipal.ShowSizeMarkers = false;
            this.btn_maximizarPrincipal.Size = new System.Drawing.Size(44, 44);
            this.btn_maximizarPrincipal.TabIndex = 3;
            this.btn_maximizarPrincipal.ToolTipText = "";
            this.btn_maximizarPrincipal.WaitOnLoad = false;
            this.btn_maximizarPrincipal.Zoom = 20;
            this.btn_maximizarPrincipal.ZoomSpeed = 10;
            this.btn_maximizarPrincipal.Click += new System.EventHandler(this.btn_maximizarPrincipal_Click);
            // 
            // btn_cerrarPrincipal
            // 
            this.btn_cerrarPrincipal.ActiveImage = null;
            this.btn_cerrarPrincipal.AllowAnimations = true;
            this.btn_cerrarPrincipal.AllowBuffering = false;
            this.btn_cerrarPrincipal.AllowToggling = false;
            this.btn_cerrarPrincipal.AllowZooming = false;
            this.btn_cerrarPrincipal.AllowZoomingOnFocus = false;
            this.btn_cerrarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrarPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarPrincipal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_cerrarPrincipal.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrarPrincipal.ErrorImage")));
            this.btn_cerrarPrincipal.FadeWhenInactive = false;
            this.btn_cerrarPrincipal.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_cerrarPrincipal.Image = global::CapaPresentacion.Properties.Resources.Cerrar;
            this.btn_cerrarPrincipal.ImageActive = null;
            this.btn_cerrarPrincipal.ImageLocation = null;
            this.btn_cerrarPrincipal.ImageMargin = 20;
            this.btn_cerrarPrincipal.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_cerrarPrincipal.ImageZoomSize = new System.Drawing.Size(44, 44);
            this.btn_cerrarPrincipal.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrarPrincipal.InitialImage")));
            this.btn_cerrarPrincipal.Location = new System.Drawing.Point(827, 0);
            this.btn_cerrarPrincipal.Name = "btn_cerrarPrincipal";
            this.btn_cerrarPrincipal.Rotation = 0;
            this.btn_cerrarPrincipal.ShowActiveImage = true;
            this.btn_cerrarPrincipal.ShowCursorChanges = true;
            this.btn_cerrarPrincipal.ShowImageBorders = true;
            this.btn_cerrarPrincipal.ShowSizeMarkers = false;
            this.btn_cerrarPrincipal.Size = new System.Drawing.Size(44, 44);
            this.btn_cerrarPrincipal.TabIndex = 2;
            this.btn_cerrarPrincipal.ToolTipText = "";
            this.btn_cerrarPrincipal.WaitOnLoad = false;
            this.btn_cerrarPrincipal.Zoom = 20;
            this.btn_cerrarPrincipal.ZoomSpeed = 10;
            this.btn_cerrarPrincipal.Click += new System.EventHandler(this.btn_cerrarPrincipal_Click);
            // 
            // btn_closeChild
            // 
            this.btn_closeChild.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_closeChild.Enabled = false;
            this.btn_closeChild.FlatAppearance.BorderSize = 0;
            this.btn_closeChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeChild.Image = global::CapaPresentacion.Properties.Resources.Cerrar_Child;
            this.btn_closeChild.Location = new System.Drawing.Point(0, 0);
            this.btn_closeChild.Name = "btn_closeChild";
            this.btn_closeChild.Size = new System.Drawing.Size(29, 60);
            this.btn_closeChild.TabIndex = 1;
            this.btn_closeChild.UseVisualStyleBackColor = true;
            this.btn_closeChild.Visible = false;
            this.btn_closeChild.Click += new System.EventHandler(this.btn_closeChild_Click);
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
            this.btn_citas.Location = new System.Drawing.Point(0, 404);
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
            this.btn_doctores.Location = new System.Drawing.Point(0, 282);
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
            this.btn_areas.Location = new System.Drawing.Point(0, 161);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 580);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btn_closeChild;
        private Bunifu.Framework.UI.BunifuDragControl PrincipalDragControl;
        private Bunifu.UI.WinForms.BunifuImageButton btn_minimizarPrincipal;
        private Bunifu.UI.WinForms.BunifuImageButton btn_maximizarPrincipal;
        private Bunifu.UI.WinForms.BunifuImageButton btn_cerrarPrincipal;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

