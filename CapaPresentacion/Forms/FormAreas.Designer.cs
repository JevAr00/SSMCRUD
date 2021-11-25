
namespace CapaPresentacion.Forms
{
    partial class FormAreas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAreas));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminarArea = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_modificarArea = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_buscarArea = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_registroArea = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgv_areas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmb_dispArea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_edificioArea = new System.Windows.Forms.TextBox();
            this.txt_nombreArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_areas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_eliminarArea);
            this.panel1.Controls.Add(this.btn_modificarArea);
            this.panel1.Controls.Add(this.btn_buscarArea);
            this.panel1.Controls.Add(this.btn_registroArea);
            this.panel1.Controls.Add(this.dgv_areas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(239, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 481);
            this.panel1.TabIndex = 46;
            // 
            // btn_eliminarArea
            // 
            this.btn_eliminarArea.AllowAnimations = true;
            this.btn_eliminarArea.AllowMouseEffects = true;
            this.btn_eliminarArea.AllowToggling = false;
            this.btn_eliminarArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminarArea.AnimationSpeed = 200;
            this.btn_eliminarArea.AutoGenerateColors = false;
            this.btn_eliminarArea.AutoRoundBorders = true;
            this.btn_eliminarArea.AutoSizeLeftIcon = true;
            this.btn_eliminarArea.AutoSizeRightIcon = true;
            this.btn_eliminarArea.BackColor = System.Drawing.Color.Transparent;
            this.btn_eliminarArea.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_eliminarArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminarArea.BackgroundImage")));
            this.btn_eliminarArea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_eliminarArea.ButtonText = "Eliminar";
            this.btn_eliminarArea.ButtonTextMarginLeft = 0;
            this.btn_eliminarArea.ColorContrastOnClick = 45;
            this.btn_eliminarArea.ColorContrastOnHover = 45;
            this.btn_eliminarArea.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_eliminarArea.CustomizableEdges = borderEdges1;
            this.btn_eliminarArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_eliminarArea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_eliminarArea.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_eliminarArea.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_eliminarArea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btn_eliminarArea.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.btn_eliminarArea.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarArea.IconLeft = null;
            this.btn_eliminarArea.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminarArea.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_eliminarArea.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_eliminarArea.IconMarginLeft = 11;
            this.btn_eliminarArea.IconPadding = 10;
            this.btn_eliminarArea.IconRight = null;
            this.btn_eliminarArea.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminarArea.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_eliminarArea.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_eliminarArea.IconSize = 25;
            this.btn_eliminarArea.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_eliminarArea.IdleBorderRadius = 0;
            this.btn_eliminarArea.IdleBorderThickness = 0;
            this.btn_eliminarArea.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_eliminarArea.IdleIconLeftImage = null;
            this.btn_eliminarArea.IdleIconRightImage = null;
            this.btn_eliminarArea.IndicateFocus = false;
            this.btn_eliminarArea.Location = new System.Drawing.Point(312, 374);
            this.btn_eliminarArea.Name = "btn_eliminarArea";
            this.btn_eliminarArea.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_eliminarArea.OnDisabledState.BorderRadius = 39;
            this.btn_eliminarArea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_eliminarArea.OnDisabledState.BorderThickness = 1;
            this.btn_eliminarArea.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_eliminarArea.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_eliminarArea.OnDisabledState.IconLeftImage = null;
            this.btn_eliminarArea.OnDisabledState.IconRightImage = null;
            this.btn_eliminarArea.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_eliminarArea.onHoverState.BorderRadius = 39;
            this.btn_eliminarArea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_eliminarArea.onHoverState.BorderThickness = 1;
            this.btn_eliminarArea.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_eliminarArea.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarArea.onHoverState.IconLeftImage = null;
            this.btn_eliminarArea.onHoverState.IconRightImage = null;
            this.btn_eliminarArea.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_eliminarArea.OnIdleState.BorderRadius = 39;
            this.btn_eliminarArea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_eliminarArea.OnIdleState.BorderThickness = 1;
            this.btn_eliminarArea.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_eliminarArea.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarArea.OnIdleState.IconLeftImage = null;
            this.btn_eliminarArea.OnIdleState.IconRightImage = null;
            this.btn_eliminarArea.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_eliminarArea.OnPressedState.BorderRadius = 39;
            this.btn_eliminarArea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_eliminarArea.OnPressedState.BorderThickness = 1;
            this.btn_eliminarArea.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_eliminarArea.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_eliminarArea.OnPressedState.IconLeftImage = null;
            this.btn_eliminarArea.OnPressedState.IconRightImage = null;
            this.btn_eliminarArea.Size = new System.Drawing.Size(91, 39);
            this.btn_eliminarArea.TabIndex = 35;
            this.btn_eliminarArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_eliminarArea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_eliminarArea.TextMarginLeft = 0;
            this.btn_eliminarArea.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_eliminarArea.UseDefaultRadiusAndThickness = true;
            // 
            // btn_modificarArea
            // 
            this.btn_modificarArea.AllowAnimations = true;
            this.btn_modificarArea.AllowMouseEffects = true;
            this.btn_modificarArea.AllowToggling = false;
            this.btn_modificarArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificarArea.AnimationSpeed = 200;
            this.btn_modificarArea.AutoGenerateColors = false;
            this.btn_modificarArea.AutoRoundBorders = true;
            this.btn_modificarArea.AutoSizeLeftIcon = true;
            this.btn_modificarArea.AutoSizeRightIcon = true;
            this.btn_modificarArea.BackColor = System.Drawing.Color.Transparent;
            this.btn_modificarArea.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_modificarArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_modificarArea.BackgroundImage")));
            this.btn_modificarArea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modificarArea.ButtonText = "Modificar";
            this.btn_modificarArea.ButtonTextMarginLeft = 0;
            this.btn_modificarArea.ColorContrastOnClick = 45;
            this.btn_modificarArea.ColorContrastOnHover = 45;
            this.btn_modificarArea.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_modificarArea.CustomizableEdges = borderEdges2;
            this.btn_modificarArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_modificarArea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_modificarArea.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_modificarArea.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_modificarArea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btn_modificarArea.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.btn_modificarArea.ForeColor = System.Drawing.Color.White;
            this.btn_modificarArea.IconLeft = null;
            this.btn_modificarArea.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modificarArea.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_modificarArea.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_modificarArea.IconMarginLeft = 11;
            this.btn_modificarArea.IconPadding = 10;
            this.btn_modificarArea.IconRight = null;
            this.btn_modificarArea.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modificarArea.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_modificarArea.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_modificarArea.IconSize = 25;
            this.btn_modificarArea.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_modificarArea.IdleBorderRadius = 0;
            this.btn_modificarArea.IdleBorderThickness = 0;
            this.btn_modificarArea.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_modificarArea.IdleIconLeftImage = null;
            this.btn_modificarArea.IdleIconRightImage = null;
            this.btn_modificarArea.IndicateFocus = false;
            this.btn_modificarArea.Location = new System.Drawing.Point(215, 374);
            this.btn_modificarArea.Name = "btn_modificarArea";
            this.btn_modificarArea.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_modificarArea.OnDisabledState.BorderRadius = 39;
            this.btn_modificarArea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modificarArea.OnDisabledState.BorderThickness = 1;
            this.btn_modificarArea.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_modificarArea.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_modificarArea.OnDisabledState.IconLeftImage = null;
            this.btn_modificarArea.OnDisabledState.IconRightImage = null;
            this.btn_modificarArea.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modificarArea.onHoverState.BorderRadius = 39;
            this.btn_modificarArea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modificarArea.onHoverState.BorderThickness = 1;
            this.btn_modificarArea.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modificarArea.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_modificarArea.onHoverState.IconLeftImage = null;
            this.btn_modificarArea.onHoverState.IconRightImage = null;
            this.btn_modificarArea.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modificarArea.OnIdleState.BorderRadius = 39;
            this.btn_modificarArea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modificarArea.OnIdleState.BorderThickness = 1;
            this.btn_modificarArea.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modificarArea.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_modificarArea.OnIdleState.IconLeftImage = null;
            this.btn_modificarArea.OnIdleState.IconRightImage = null;
            this.btn_modificarArea.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modificarArea.OnPressedState.BorderRadius = 39;
            this.btn_modificarArea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_modificarArea.OnPressedState.BorderThickness = 1;
            this.btn_modificarArea.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_modificarArea.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_modificarArea.OnPressedState.IconLeftImage = null;
            this.btn_modificarArea.OnPressedState.IconRightImage = null;
            this.btn_modificarArea.Size = new System.Drawing.Size(91, 39);
            this.btn_modificarArea.TabIndex = 34;
            this.btn_modificarArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modificarArea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_modificarArea.TextMarginLeft = 0;
            this.btn_modificarArea.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_modificarArea.UseDefaultRadiusAndThickness = true;
            // 
            // btn_buscarArea
            // 
            this.btn_buscarArea.AllowAnimations = true;
            this.btn_buscarArea.AllowMouseEffects = true;
            this.btn_buscarArea.AllowToggling = false;
            this.btn_buscarArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscarArea.AnimationSpeed = 200;
            this.btn_buscarArea.AutoGenerateColors = false;
            this.btn_buscarArea.AutoRoundBorders = true;
            this.btn_buscarArea.AutoSizeLeftIcon = true;
            this.btn_buscarArea.AutoSizeRightIcon = true;
            this.btn_buscarArea.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscarArea.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_buscarArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarArea.BackgroundImage")));
            this.btn_buscarArea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_buscarArea.ButtonText = "Buscar";
            this.btn_buscarArea.ButtonTextMarginLeft = 0;
            this.btn_buscarArea.ColorContrastOnClick = 45;
            this.btn_buscarArea.ColorContrastOnHover = 45;
            this.btn_buscarArea.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_buscarArea.CustomizableEdges = borderEdges3;
            this.btn_buscarArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_buscarArea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_buscarArea.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_buscarArea.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_buscarArea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btn_buscarArea.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.btn_buscarArea.ForeColor = System.Drawing.Color.White;
            this.btn_buscarArea.IconLeft = null;
            this.btn_buscarArea.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscarArea.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_buscarArea.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_buscarArea.IconMarginLeft = 11;
            this.btn_buscarArea.IconPadding = 10;
            this.btn_buscarArea.IconRight = null;
            this.btn_buscarArea.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscarArea.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_buscarArea.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_buscarArea.IconSize = 25;
            this.btn_buscarArea.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_buscarArea.IdleBorderRadius = 0;
            this.btn_buscarArea.IdleBorderThickness = 0;
            this.btn_buscarArea.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_buscarArea.IdleIconLeftImage = null;
            this.btn_buscarArea.IdleIconRightImage = null;
            this.btn_buscarArea.IndicateFocus = false;
            this.btn_buscarArea.Location = new System.Drawing.Point(118, 374);
            this.btn_buscarArea.Name = "btn_buscarArea";
            this.btn_buscarArea.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_buscarArea.OnDisabledState.BorderRadius = 39;
            this.btn_buscarArea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_buscarArea.OnDisabledState.BorderThickness = 1;
            this.btn_buscarArea.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_buscarArea.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_buscarArea.OnDisabledState.IconLeftImage = null;
            this.btn_buscarArea.OnDisabledState.IconRightImage = null;
            this.btn_buscarArea.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_buscarArea.onHoverState.BorderRadius = 39;
            this.btn_buscarArea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_buscarArea.onHoverState.BorderThickness = 1;
            this.btn_buscarArea.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_buscarArea.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_buscarArea.onHoverState.IconLeftImage = null;
            this.btn_buscarArea.onHoverState.IconRightImage = null;
            this.btn_buscarArea.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_buscarArea.OnIdleState.BorderRadius = 39;
            this.btn_buscarArea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_buscarArea.OnIdleState.BorderThickness = 1;
            this.btn_buscarArea.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_buscarArea.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_buscarArea.OnIdleState.IconLeftImage = null;
            this.btn_buscarArea.OnIdleState.IconRightImage = null;
            this.btn_buscarArea.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_buscarArea.OnPressedState.BorderRadius = 39;
            this.btn_buscarArea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_buscarArea.OnPressedState.BorderThickness = 1;
            this.btn_buscarArea.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_buscarArea.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_buscarArea.OnPressedState.IconLeftImage = null;
            this.btn_buscarArea.OnPressedState.IconRightImage = null;
            this.btn_buscarArea.Size = new System.Drawing.Size(91, 39);
            this.btn_buscarArea.TabIndex = 33;
            this.btn_buscarArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_buscarArea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_buscarArea.TextMarginLeft = 0;
            this.btn_buscarArea.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_buscarArea.UseDefaultRadiusAndThickness = true;
            // 
            // btn_registroArea
            // 
            this.btn_registroArea.AllowAnimations = true;
            this.btn_registroArea.AllowMouseEffects = true;
            this.btn_registroArea.AllowToggling = false;
            this.btn_registroArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registroArea.AnimationSpeed = 200;
            this.btn_registroArea.AutoGenerateColors = false;
            this.btn_registroArea.AutoRoundBorders = true;
            this.btn_registroArea.AutoSizeLeftIcon = true;
            this.btn_registroArea.AutoSizeRightIcon = true;
            this.btn_registroArea.BackColor = System.Drawing.Color.Transparent;
            this.btn_registroArea.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_registroArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registroArea.BackgroundImage")));
            this.btn_registroArea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_registroArea.ButtonText = "Registrar";
            this.btn_registroArea.ButtonTextMarginLeft = 0;
            this.btn_registroArea.ColorContrastOnClick = 45;
            this.btn_registroArea.ColorContrastOnHover = 45;
            this.btn_registroArea.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_registroArea.CustomizableEdges = borderEdges4;
            this.btn_registroArea.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_registroArea.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_registroArea.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_registroArea.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_registroArea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Disabled;
            this.btn_registroArea.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Bold);
            this.btn_registroArea.ForeColor = System.Drawing.Color.White;
            this.btn_registroArea.IconLeft = null;
            this.btn_registroArea.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registroArea.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_registroArea.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_registroArea.IconMarginLeft = 11;
            this.btn_registroArea.IconPadding = 10;
            this.btn_registroArea.IconRight = null;
            this.btn_registroArea.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_registroArea.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_registroArea.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_registroArea.IconSize = 25;
            this.btn_registroArea.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_registroArea.IdleBorderRadius = 0;
            this.btn_registroArea.IdleBorderThickness = 0;
            this.btn_registroArea.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_registroArea.IdleIconLeftImage = null;
            this.btn_registroArea.IdleIconRightImage = null;
            this.btn_registroArea.IndicateFocus = false;
            this.btn_registroArea.Location = new System.Drawing.Point(21, 374);
            this.btn_registroArea.Name = "btn_registroArea";
            this.btn_registroArea.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_registroArea.OnDisabledState.BorderRadius = 39;
            this.btn_registroArea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_registroArea.OnDisabledState.BorderThickness = 1;
            this.btn_registroArea.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_registroArea.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_registroArea.OnDisabledState.IconLeftImage = null;
            this.btn_registroArea.OnDisabledState.IconRightImage = null;
            this.btn_registroArea.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_registroArea.onHoverState.BorderRadius = 39;
            this.btn_registroArea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_registroArea.onHoverState.BorderThickness = 1;
            this.btn_registroArea.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_registroArea.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_registroArea.onHoverState.IconLeftImage = null;
            this.btn_registroArea.onHoverState.IconRightImage = null;
            this.btn_registroArea.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_registroArea.OnIdleState.BorderRadius = 39;
            this.btn_registroArea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_registroArea.OnIdleState.BorderThickness = 1;
            this.btn_registroArea.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_registroArea.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_registroArea.OnIdleState.IconLeftImage = null;
            this.btn_registroArea.OnIdleState.IconRightImage = null;
            this.btn_registroArea.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_registroArea.OnPressedState.BorderRadius = 39;
            this.btn_registroArea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_registroArea.OnPressedState.BorderThickness = 1;
            this.btn_registroArea.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_registroArea.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_registroArea.OnPressedState.IconLeftImage = null;
            this.btn_registroArea.OnPressedState.IconRightImage = null;
            this.btn_registroArea.Size = new System.Drawing.Size(91, 39);
            this.btn_registroArea.TabIndex = 32;
            this.btn_registroArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_registroArea.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_registroArea.TextMarginLeft = 0;
            this.btn_registroArea.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_registroArea.UseDefaultRadiusAndThickness = true;
            // 
            // dgv_areas
            // 
            this.dgv_areas.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_areas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_areas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_areas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_areas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_areas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_areas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_areas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_areas.ColumnHeadersHeight = 40;
            this.dgv_areas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_areas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_areas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_areas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_areas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_areas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_areas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_areas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_areas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_areas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_areas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_areas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_areas.CurrentTheme.Name = null;
            this.dgv_areas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_areas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_areas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_areas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_areas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_areas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_areas.EnableHeadersVisualStyles = false;
            this.dgv_areas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_areas.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_areas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_areas.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_areas.Location = new System.Drawing.Point(58, 67);
            this.dgv_areas.Name = "dgv_areas";
            this.dgv_areas.RowHeadersVisible = false;
            this.dgv_areas.RowTemplate.Height = 40;
            this.dgv_areas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_areas.Size = new System.Drawing.Size(325, 271);
            this.dgv_areas.TabIndex = 31;
            this.dgv_areas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // cmb_dispArea
            // 
            this.cmb_dispArea.FormattingEnabled = true;
            this.cmb_dispArea.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cmb_dispArea.Location = new System.Drawing.Point(16, 314);
            this.cmb_dispArea.Name = "cmb_dispArea";
            this.cmb_dispArea.Size = new System.Drawing.Size(121, 21);
            this.cmb_dispArea.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label7.Location = new System.Drawing.Point(16, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Disponibilidad";
            // 
            // txt_edificioArea
            // 
            this.txt_edificioArea.Location = new System.Drawing.Point(16, 243);
            this.txt_edificioArea.Name = "txt_edificioArea";
            this.txt_edificioArea.Size = new System.Drawing.Size(177, 20);
            this.txt_edificioArea.TabIndex = 33;
            // 
            // txt_nombreArea
            // 
            this.txt_nombreArea.Location = new System.Drawing.Point(16, 177);
            this.txt_nombreArea.Name = "txt_nombreArea";
            this.txt_nombreArea.Size = new System.Drawing.Size(177, 20);
            this.txt_nombreArea.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Edificio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre";
            // 
            // FormAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(676, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_dispArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_edificioArea);
            this.Controls.Add(this.txt_nombreArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAreas";
            this.Text = "Áreas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_areas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_eliminarArea;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_modificarArea;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_buscarArea;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_registroArea;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_areas;
        private System.Windows.Forms.ComboBox cmb_dispArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_edificioArea;
        private System.Windows.Forms.TextBox txt_nombreArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}