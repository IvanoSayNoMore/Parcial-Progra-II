namespace UTNFacultad
{
    partial class FormProfesor
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
            this.chk_SegundoCuatrimestre = new System.Windows.Forms.CheckBox();
            this.chk_PrimerCuatr = new System.Windows.Forms.CheckBox();
            this.TITULO = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_crearExamen = new System.Windows.Forms.Button();
            this.rdb_pParcial = new System.Windows.Forms.RadioButton();
            this.rdb_Sparcial = new System.Windows.Forms.RadioButton();
            this.btn_Concretar = new System.Windows.Forms.Button();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.rtb_materiasAsignadas = new System.Windows.Forms.RichTextBox();
            this.txb_materia = new System.Windows.Forms.TextBox();
            this.nm_Nota = new System.Windows.Forms.NumericUpDown();
            this.nm_legajoAlumno = new System.Windows.Forms.NumericUpDown();
            this.NOTA = new System.Windows.Forms.Label();
            this.LEGAJO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nm_Nota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_legajoAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 370);
            this.panel1.TabIndex = 13;
            // 
            // chk_SegundoCuatrimestre
            // 
            this.chk_SegundoCuatrimestre.AutoSize = true;
            this.chk_SegundoCuatrimestre.ForeColor = System.Drawing.Color.LightGray;
            this.chk_SegundoCuatrimestre.Location = new System.Drawing.Point(521, 287);
            this.chk_SegundoCuatrimestre.Name = "chk_SegundoCuatrimestre";
            this.chk_SegundoCuatrimestre.Size = new System.Drawing.Size(117, 19);
            this.chk_SegundoCuatrimestre.TabIndex = 1;
            this.chk_SegundoCuatrimestre.Text = "2do Cuatrimestre";
            this.chk_SegundoCuatrimestre.UseVisualStyleBackColor = true;
            this.chk_SegundoCuatrimestre.Visible = false;
            this.chk_SegundoCuatrimestre.CheckedChanged += new System.EventHandler(this.chk_SegundoCuatrimestre_CheckedChanged);
            // 
            // chk_PrimerCuatr
            // 
            this.chk_PrimerCuatr.AutoSize = true;
            this.chk_PrimerCuatr.ForeColor = System.Drawing.Color.LightGray;
            this.chk_PrimerCuatr.Location = new System.Drawing.Point(521, 262);
            this.chk_PrimerCuatr.Name = "chk_PrimerCuatr";
            this.chk_PrimerCuatr.Size = new System.Drawing.Size(113, 19);
            this.chk_PrimerCuatr.TabIndex = 0;
            this.chk_PrimerCuatr.Text = "1er Cuatrimestre";
            this.chk_PrimerCuatr.UseVisualStyleBackColor = true;
            this.chk_PrimerCuatr.Visible = false;
            this.chk_PrimerCuatr.CheckedChanged += new System.EventHandler(this.chk_PrimerCuatr_CheckedChanged);
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TITULO.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TITULO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TITULO.Location = new System.Drawing.Point(135, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(181, 27);
            this.TITULO.TabIndex = 17;
            this.TITULO.Text = "Menu Profesor";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(173, 310);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_crearExamen
            // 
            this.btn_crearExamen.Location = new System.Drawing.Point(135, 87);
            this.btn_crearExamen.Name = "btn_crearExamen";
            this.btn_crearExamen.Size = new System.Drawing.Size(138, 23);
            this.btn_crearExamen.TabIndex = 19;
            this.btn_crearExamen.Text = "Crear Examen";
            this.btn_crearExamen.UseVisualStyleBackColor = true;
            this.btn_crearExamen.Click += new System.EventHandler(this.btn_crearExamen_Click);
            // 
            // rdb_pParcial
            // 
            this.rdb_pParcial.AutoSize = true;
            this.rdb_pParcial.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_pParcial.Location = new System.Drawing.Point(364, 186);
            this.rdb_pParcial.Name = "rdb_pParcial";
            this.rdb_pParcial.Size = new System.Drawing.Size(98, 19);
            this.rdb_pParcial.TabIndex = 21;
            this.rdb_pParcial.TabStop = true;
            this.rdb_pParcial.Text = "Primer Parcial";
            this.rdb_pParcial.UseVisualStyleBackColor = true;
            this.rdb_pParcial.Visible = false;
            this.rdb_pParcial.CheckedChanged += new System.EventHandler(this.rdb_pParcial_CheckedChanged);
            // 
            // rdb_Sparcial
            // 
            this.rdb_Sparcial.AutoSize = true;
            this.rdb_Sparcial.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_Sparcial.Location = new System.Drawing.Point(521, 186);
            this.rdb_Sparcial.Name = "rdb_Sparcial";
            this.rdb_Sparcial.Size = new System.Drawing.Size(110, 19);
            this.rdb_Sparcial.TabIndex = 22;
            this.rdb_Sparcial.TabStop = true;
            this.rdb_Sparcial.Text = "Segundo Parcial";
            this.rdb_Sparcial.UseVisualStyleBackColor = true;
            this.rdb_Sparcial.Visible = false;
            this.rdb_Sparcial.CheckedChanged += new System.EventHandler(this.rdb_Sparcial_CheckedChanged);
            // 
            // btn_Concretar
            // 
            this.btn_Concretar.Location = new System.Drawing.Point(566, 310);
            this.btn_Concretar.Name = "btn_Concretar";
            this.btn_Concretar.Size = new System.Drawing.Size(75, 23);
            this.btn_Concretar.TabIndex = 24;
            this.btn_Concretar.Text = "Concretar";
            this.btn_Concretar.UseVisualStyleBackColor = true;
            this.btn_Concretar.Visible = false;
            this.btn_Concretar.Click += new System.EventHandler(this.btn_Concretar_Click);
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.LightGray;
            this.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fecha.ForeColor = System.Drawing.Color.DimGray;
            this.txt_fecha.Location = new System.Drawing.Point(364, 310);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(127, 16);
            this.txt_fecha.TabIndex = 25;
            this.txt_fecha.Text = "FECHA";
            this.txt_fecha.Visible = false;
            this.txt_fecha.Enter += new System.EventHandler(this.txt_fecha_Enter);
            this.txt_fecha.Leave += new System.EventHandler(this.txt_fecha_Leave);
            // 
            // rtb_materiasAsignadas
            // 
            this.rtb_materiasAsignadas.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtb_materiasAsignadas.ForeColor = System.Drawing.Color.DarkGray;
            this.rtb_materiasAsignadas.Location = new System.Drawing.Point(364, 36);
            this.rtb_materiasAsignadas.Name = "rtb_materiasAsignadas";
            this.rtb_materiasAsignadas.Size = new System.Drawing.Size(277, 131);
            this.rtb_materiasAsignadas.TabIndex = 26;
            this.rtb_materiasAsignadas.Text = "";
            this.rtb_materiasAsignadas.Visible = false;
            // 
            // txb_materia
            // 
            this.txb_materia.BackColor = System.Drawing.Color.LightGray;
            this.txb_materia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_materia.ForeColor = System.Drawing.Color.DimGray;
            this.txb_materia.Location = new System.Drawing.Point(364, 278);
            this.txb_materia.Name = "txb_materia";
            this.txb_materia.Size = new System.Drawing.Size(127, 16);
            this.txb_materia.TabIndex = 27;
            this.txb_materia.Text = "MATERIA";
            this.txb_materia.Visible = false;
            this.txb_materia.Enter += new System.EventHandler(this.txb_materia_Enter);
            this.txb_materia.Leave += new System.EventHandler(this.txb_materia_Leave);
            // 
            // nm_Nota
            // 
            this.nm_Nota.Location = new System.Drawing.Point(364, 233);
            this.nm_Nota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nm_Nota.Name = "nm_Nota";
            this.nm_Nota.Size = new System.Drawing.Size(55, 23);
            this.nm_Nota.TabIndex = 28;
            this.nm_Nota.Visible = false;
            // 
            // nm_legajoAlumno
            // 
            this.nm_legajoAlumno.Location = new System.Drawing.Point(521, 233);
            this.nm_legajoAlumno.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_legajoAlumno.Name = "nm_legajoAlumno";
            this.nm_legajoAlumno.Size = new System.Drawing.Size(120, 23);
            this.nm_legajoAlumno.TabIndex = 29;
            this.nm_legajoAlumno.Visible = false;
            // 
            // NOTA
            // 
            this.NOTA.AutoSize = true;
            this.NOTA.ForeColor = System.Drawing.Color.LightGray;
            this.NOTA.Location = new System.Drawing.Point(364, 215);
            this.NOTA.Name = "NOTA";
            this.NOTA.Size = new System.Drawing.Size(37, 15);
            this.NOTA.TabIndex = 30;
            this.NOTA.Text = "NOTA";
            this.NOTA.Visible = false;
            // 
            // LEGAJO
            // 
            this.LEGAJO.AutoSize = true;
            this.LEGAJO.ForeColor = System.Drawing.Color.DarkGray;
            this.LEGAJO.Location = new System.Drawing.Point(521, 215);
            this.LEGAJO.Name = "LEGAJO";
            this.LEGAJO.Size = new System.Drawing.Size(88, 15);
            this.LEGAJO.TabIndex = 31;
            this.LEGAJO.Text = "Legajo Alumno";
            this.LEGAJO.Visible = false;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(732, 370);
            this.Controls.Add(this.chk_SegundoCuatrimestre);
            this.Controls.Add(this.LEGAJO);
            this.Controls.Add(this.chk_PrimerCuatr);
            this.Controls.Add(this.NOTA);
            this.Controls.Add(this.nm_legajoAlumno);
            this.Controls.Add(this.nm_Nota);
            this.Controls.Add(this.txb_materia);
            this.Controls.Add(this.rtb_materiasAsignadas);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.btn_Concretar);
            this.Controls.Add(this.rdb_Sparcial);
            this.Controls.Add(this.rdb_pParcial);
            this.Controls.Add(this.btn_crearExamen);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfesor";
            this.Opacity = 0.9D;
            this.Text = "FormProfesor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProfesor_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nm_Nota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_legajoAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label TITULO;
        private Button btn_salir;
        private Button btn_crearExamen;
        private RadioButton rdb_pParcial;
        private RadioButton rdb_Sparcial;
        private Button btn_Concretar;
        private TextBox txt_fecha;
        private RichTextBox rtb_materiasAsignadas;
        private TextBox txb_materia;
        private NumericUpDown nm_Nota;
        private NumericUpDown nm_legajoAlumno;
        private Label NOTA;
        private Label LEGAJO;
        private CheckBox chk_SegundoCuatrimestre;
        private CheckBox chk_PrimerCuatr;
    }
}