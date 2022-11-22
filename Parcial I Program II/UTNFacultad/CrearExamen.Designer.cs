namespace UTNFacultad
{
    partial class CrearExamen
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
            this.MateriaComision = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoParcial = new System.Windows.Forms.ComboBox();
            this.PERIODO = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.LEGAJO = new System.Windows.Forms.Label();
            this.NOTA = new System.Windows.Forms.Label();
            this.nm_Nota = new System.Windows.Forms.NumericUpDown();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.btn_Concretar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Nota)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 302);
            this.panel1.TabIndex = 15;
            // 
            // MateriaComision
            // 
            this.MateriaComision.AutoSize = true;
            this.MateriaComision.ForeColor = System.Drawing.Color.LightGray;
            this.MateriaComision.Location = new System.Drawing.Point(167, 133);
            this.MateriaComision.Name = "MateriaComision";
            this.MateriaComision.Size = new System.Drawing.Size(101, 15);
            this.MateriaComision.TabIndex = 53;
            this.MateriaComision.Text = "Materia Comision";
            this.MateriaComision.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(360, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo de Parcial";
            this.label1.Visible = false;
            // 
            // cbTipoParcial
            // 
            this.cbTipoParcial.FormattingEnabled = true;
            this.cbTipoParcial.Location = new System.Drawing.Point(360, 59);
            this.cbTipoParcial.Name = "cbTipoParcial";
            this.cbTipoParcial.Size = new System.Drawing.Size(133, 23);
            this.cbTipoParcial.TabIndex = 51;
            // 
            // PERIODO
            // 
            this.PERIODO.AutoSize = true;
            this.PERIODO.ForeColor = System.Drawing.Color.LightGray;
            this.PERIODO.Location = new System.Drawing.Point(167, 41);
            this.PERIODO.Name = "PERIODO";
            this.PERIODO.Size = new System.Drawing.Size(48, 15);
            this.PERIODO.TabIndex = 50;
            this.PERIODO.Text = "Periodo";
            this.PERIODO.Visible = false;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(167, 59);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(157, 23);
            this.cbPeriodo.TabIndex = 49;
            // 
            // cbMaterias
            // 
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(167, 151);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(240, 23);
            this.cbMaterias.TabIndex = 48;
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(360, 102);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(136, 23);
            this.cbAlumnos.TabIndex = 47;
            // 
            // LEGAJO
            // 
            this.LEGAJO.AutoSize = true;
            this.LEGAJO.ForeColor = System.Drawing.Color.DarkGray;
            this.LEGAJO.Location = new System.Drawing.Point(357, 85);
            this.LEGAJO.Name = "LEGAJO";
            this.LEGAJO.Size = new System.Drawing.Size(50, 15);
            this.LEGAJO.TabIndex = 46;
            this.LEGAJO.Text = "Alumno";
            this.LEGAJO.Visible = false;
            // 
            // NOTA
            // 
            this.NOTA.AutoSize = true;
            this.NOTA.ForeColor = System.Drawing.Color.LightGray;
            this.NOTA.Location = new System.Drawing.Point(167, 84);
            this.NOTA.Name = "NOTA";
            this.NOTA.Size = new System.Drawing.Size(37, 15);
            this.NOTA.TabIndex = 45;
            this.NOTA.Text = "NOTA";
            this.NOTA.Visible = false;
            // 
            // nm_Nota
            // 
            this.nm_Nota.Location = new System.Drawing.Point(167, 102);
            this.nm_Nota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nm_Nota.Name = "nm_Nota";
            this.nm_Nota.Size = new System.Drawing.Size(67, 23);
            this.nm_Nota.TabIndex = 44;
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.LightGray;
            this.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fecha.ForeColor = System.Drawing.Color.DimGray;
            this.txt_fecha.Location = new System.Drawing.Point(167, 189);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(127, 16);
            this.txt_fecha.TabIndex = 42;
            this.txt_fecha.Text = "FECHA";
            // 
            // btn_Concretar
            // 
            this.btn_Concretar.Location = new System.Drawing.Point(357, 231);
            this.btn_Concretar.Name = "btn_Concretar";
            this.btn_Concretar.Size = new System.Drawing.Size(75, 23);
            this.btn_Concretar.TabIndex = 41;
            this.btn_Concretar.Text = "Concretar";
            this.btn_Concretar.UseVisualStyleBackColor = true;
            this.btn_Concretar.Click += new System.EventHandler(this.btn_Concretar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(167, 231);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 39;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // CrearExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(557, 302);
            this.Controls.Add(this.MateriaComision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoParcial);
            this.Controls.Add(this.PERIODO);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.cbAlumnos);
            this.Controls.Add(this.LEGAJO);
            this.Controls.Add(this.NOTA);
            this.Controls.Add(this.nm_Nota);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_Concretar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearExamen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearExamen";
            this.Load += new System.EventHandler(this.CrearExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_Nota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label MateriaComision;
        private Label label1;
        private ComboBox cbTipoParcial;
        private Label PERIODO;
        private ComboBox cbPeriodo;
        private ComboBox cbMaterias;
        private ComboBox cbAlumnos;
        private Label LEGAJO;
        private Label NOTA;
        private NumericUpDown nm_Nota;
        private TextBox txt_fecha;
        private Button btn_Concretar;
        private Button btn_salir;
    }
}