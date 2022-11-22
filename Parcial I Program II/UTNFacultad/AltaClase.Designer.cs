namespace UTNFacultad
{
    partial class AltaClase
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
            this.cbx_Profesores = new System.Windows.Forms.ComboBox();
            this.cb_Aulas = new System.Windows.Forms.ComboBox();
            this.cb_Periodos = new System.Windows.Forms.ComboBox();
            this.cb_Materias = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 247);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // cbx_Profesores
            // 
            this.cbx_Profesores.FormattingEnabled = true;
            this.cbx_Profesores.Location = new System.Drawing.Point(112, 55);
            this.cbx_Profesores.Name = "cbx_Profesores";
            this.cbx_Profesores.Size = new System.Drawing.Size(121, 23);
            this.cbx_Profesores.TabIndex = 14;
            // 
            // cb_Aulas
            // 
            this.cb_Aulas.FormattingEnabled = true;
            this.cb_Aulas.Location = new System.Drawing.Point(296, 55);
            this.cb_Aulas.Name = "cb_Aulas";
            this.cb_Aulas.Size = new System.Drawing.Size(121, 23);
            this.cb_Aulas.TabIndex = 15;
            // 
            // cb_Periodos
            // 
            this.cb_Periodos.FormattingEnabled = true;
            this.cb_Periodos.Location = new System.Drawing.Point(112, 126);
            this.cb_Periodos.Name = "cb_Periodos";
            this.cb_Periodos.Size = new System.Drawing.Size(121, 23);
            this.cb_Periodos.TabIndex = 16;
            // 
            // cb_Materias
            // 
            this.cb_Materias.FormattingEnabled = true;
            this.cb_Materias.Location = new System.Drawing.Point(296, 126);
            this.cb_Materias.Name = "cb_Materias";
            this.cb_Materias.Size = new System.Drawing.Size(121, 23);
            this.cb_Materias.TabIndex = 17;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(115, 181);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 18;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(300, 181);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(128, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "PROFESORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(314, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "MATERIAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(314, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "AULAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(128, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "PERIODOS";
            // 
            // AltaClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(493, 247);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.cb_Materias);
            this.Controls.Add(this.cb_Periodos);
            this.Controls.Add(this.cb_Aulas);
            this.Controls.Add(this.cbx_Profesores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaClase";
            this.Opacity = 0.9D;
            this.Text = "AltaClase";
            this.Load += new System.EventHandler(this.AltaClase_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AltaClase_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ComboBox cbx_Profesores;
        private ComboBox cb_Aulas;
        private ComboBox cb_Periodos;
        private ComboBox cb_Materias;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}