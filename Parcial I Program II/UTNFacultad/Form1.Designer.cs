namespace UTNFacultad
{
    partial class formLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioAlumno = new System.Windows.Forms.RadioButton();
            this.radioProfe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(237, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 30);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "UTN Facultad";
            // 
            // txtUsr
            // 
            this.txtUsr.BackColor = System.Drawing.Color.LightGray;
            this.txtUsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsr.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsr.Location = new System.Drawing.Point(226, 92);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(156, 16);
            this.txtUsr.TabIndex = 1;
            this.txtUsr.Text = "USUARIO";
            this.txtUsr.Enter += new System.EventHandler(this.txtUsr_Enter);
            this.txtUsr.Leave += new System.EventHandler(this.txtUsr_Leave);
            // 
            // txtPas
            // 
            this.txtPas.BackColor = System.Drawing.Color.LightGray;
            this.txtPas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPas.ForeColor = System.Drawing.Color.Gray;
            this.txtPas.Location = new System.Drawing.Point(226, 136);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(156, 16);
            this.txtPas.TabIndex = 2;
            this.txtPas.Text = "CONTRASEÑA";
            this.txtPas.Enter += new System.EventHandler(this.txtPas_Enter);
            this.txtPas.Leave += new System.EventHandler(this.txtPas_Leave);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(226, 184);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "Ingresar";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(307, 184);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 4;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 237);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.BackColor = System.Drawing.Color.LightGray;
            this.radioAdmin.Location = new System.Drawing.Point(428, 91);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(70, 19);
            this.radioAdmin.TabIndex = 6;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin   ";
            this.radioAdmin.UseVisualStyleBackColor = false;
            this.radioAdmin.CheckedChanged += new System.EventHandler(this.radioAdmin_CheckedChanged);
            // 
            // radioAlumno
            // 
            this.radioAlumno.AutoSize = true;
            this.radioAlumno.BackColor = System.Drawing.Color.LightGray;
            this.radioAlumno.Location = new System.Drawing.Point(428, 116);
            this.radioAlumno.Name = "radioAlumno";
            this.radioAlumno.Size = new System.Drawing.Size(71, 19);
            this.radioAlumno.TabIndex = 7;
            this.radioAlumno.TabStop = true;
            this.radioAlumno.Text = "Alumno ";
            this.radioAlumno.UseVisualStyleBackColor = false;
            this.radioAlumno.CheckedChanged += new System.EventHandler(this.radioAlumno_CheckedChanged);
            // 
            // radioProfe
            // 
            this.radioProfe.AutoSize = true;
            this.radioProfe.BackColor = System.Drawing.Color.LightGray;
            this.radioProfe.Location = new System.Drawing.Point(428, 141);
            this.radioProfe.Name = "radioProfe";
            this.radioProfe.Size = new System.Drawing.Size(72, 19);
            this.radioProfe.TabIndex = 8;
            this.radioProfe.TabStop = true;
            this.radioProfe.Text = "Profesor ";
            this.radioProfe.UseVisualStyleBackColor = false;
            this.radioProfe.CheckedChanged += new System.EventHandler(this.radioProfe_CheckedChanged);
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnCanc;
            this.ClientSize = new System.Drawing.Size(545, 237);
            this.Controls.Add(this.radioProfe);
            this.Controls.Add(this.radioAlumno);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogIn";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogIn_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox txtUsr;
        private TextBox txtPas;
        private Button btnIn;
        private Button btnCanc;
        private Panel panel1;
        private RadioButton radioAdmin;
        private RadioButton radioAlumno;
        private RadioButton radioProfe;
    }
}