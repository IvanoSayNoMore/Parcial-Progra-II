namespace UTNFacultad
{
    partial class AltaUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.txb_Contraseña = new System.Windows.Forms.TextBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.btn_concretar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 273);
            this.panel1.TabIndex = 15;
            // 
            // cbx_TipoUsuario
            // 
            this.cbx_TipoUsuario.FormattingEnabled = true;
            this.cbx_TipoUsuario.Location = new System.Drawing.Point(111, 27);
            this.cbx_TipoUsuario.Name = "cbx_TipoUsuario";
            this.cbx_TipoUsuario.Size = new System.Drawing.Size(127, 23);
            this.cbx_TipoUsuario.TabIndex = 29;
            this.cbx_TipoUsuario.Text = "Tipos de usuario";
            // 
            // txb_Contraseña
            // 
            this.txb_Contraseña.BackColor = System.Drawing.Color.Black;
            this.txb_Contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Contraseña.Location = new System.Drawing.Point(253, 146);
            this.txb_Contraseña.Name = "txb_Contraseña";
            this.txb_Contraseña.Size = new System.Drawing.Size(133, 23);
            this.txb_Contraseña.TabIndex = 28;
            this.txb_Contraseña.Text = "CONTRASEÑA";
            this.txb_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Contraseña.Enter += new System.EventHandler(this.txb_Contraseña_Enter);
            this.txb_Contraseña.Leave += new System.EventHandler(this.txb_Contraseña_Leave);
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.BackColor = System.Drawing.Color.Black;
            this.txb_Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Usuario.Location = new System.Drawing.Point(111, 146);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(133, 23);
            this.txb_Usuario.TabIndex = 27;
            this.txb_Usuario.Text = "USUARIO";
            this.txb_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Usuario.Enter += new System.EventHandler(this.txb_Usuario_Enter);
            this.txb_Usuario.Leave += new System.EventHandler(this.txb_Usuario_Leave);
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.BackColor = System.Drawing.Color.Black;
            this.txb_Apellido.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Apellido.Location = new System.Drawing.Point(253, 98);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.Size = new System.Drawing.Size(133, 23);
            this.txb_Apellido.TabIndex = 26;
            this.txb_Apellido.Text = "APELLIDO";
            this.txb_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Apellido.Enter += new System.EventHandler(this.txb_Apellido_Enter);
            this.txb_Apellido.Leave += new System.EventHandler(this.txb_Apellido_Leave);
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.BackColor = System.Drawing.Color.Black;
            this.txb_Nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txb_Nombre.Location = new System.Drawing.Point(111, 98);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(133, 23);
            this.txb_Nombre.TabIndex = 25;
            this.txb_Nombre.Text = "NOMBRE";
            this.txb_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_Nombre.Enter += new System.EventHandler(this.txb_Nombre_Enter);
            this.txb_Nombre.Leave += new System.EventHandler(this.txb_Nombre_Leave);
            // 
            // btn_concretar
            // 
            this.btn_concretar.Location = new System.Drawing.Point(135, 210);
            this.btn_concretar.Name = "btn_concretar";
            this.btn_concretar.Size = new System.Drawing.Size(75, 23);
            this.btn_concretar.TabIndex = 30;
            this.btn_concretar.Text = "Concretar";
            this.btn_concretar.UseVisualStyleBackColor = true;
            this.btn_concretar.Click += new System.EventHandler(this.btn_concretar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(398, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_concretar);
            this.Controls.Add(this.cbx_TipoUsuario);
            this.Controls.Add(this.txb_Contraseña);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaUsuario";
            this.Opacity = 0.95D;
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AltaUsuario_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ComboBox cbx_TipoUsuario;
        private TextBox txb_Contraseña;
        private TextBox txb_Usuario;
        private TextBox txb_Apellido;
        private TextBox txb_Nombre;
        private Button btn_concretar;
        private Button button1;
    }
}