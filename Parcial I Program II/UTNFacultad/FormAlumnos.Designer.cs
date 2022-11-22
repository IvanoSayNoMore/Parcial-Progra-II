namespace UTNFacultad
{
    partial class FormAlumnos
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
            this.dtaGV_materias = new System.Windows.Forms.DataGridView();
            this.dtaGV_asistencias = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_MostrarMateriasCursadas = new System.Windows.Forms.Button();
            this.rch_datosMaterias = new System.Windows.Forms.RichTextBox();
            this.tbx_NombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Inscripciones = new System.Windows.Forms.Button();
            this.btn_Asistencia = new System.Windows.Forms.Button();
            this.TITULO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_asistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGV_materias
            // 
            this.dtaGV_materias.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtaGV_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGV_materias.EnableHeadersVisualStyles = false;
            this.dtaGV_materias.Location = new System.Drawing.Point(310, 86);
            this.dtaGV_materias.Name = "dtaGV_materias";
            this.dtaGV_materias.RowTemplate.Height = 25;
            this.dtaGV_materias.Size = new System.Drawing.Size(394, 213);
            this.dtaGV_materias.TabIndex = 17;
            this.dtaGV_materias.Visible = false;
            this.dtaGV_materias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGV_materias_CellClick);
            // 
            // dtaGV_asistencias
            // 
            this.dtaGV_asistencias.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtaGV_asistencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtaGV_asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGV_asistencias.EnableHeadersVisualStyles = false;
            this.dtaGV_asistencias.Location = new System.Drawing.Point(310, 86);
            this.dtaGV_asistencias.Name = "dtaGV_asistencias";
            this.dtaGV_asistencias.RowTemplate.Height = 25;
            this.dtaGV_asistencias.Size = new System.Drawing.Size(394, 213);
            this.dtaGV_asistencias.TabIndex = 18;
            this.dtaGV_asistencias.Visible = false;
            this.dtaGV_asistencias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGV_asistencias_CellClick);
            // 
            // btn_MostrarMateriasCursadas
            // 
            this.btn_MostrarMateriasCursadas.Location = new System.Drawing.Point(136, 119);
            this.btn_MostrarMateriasCursadas.Name = "btn_MostrarMateriasCursadas";
            this.btn_MostrarMateriasCursadas.Size = new System.Drawing.Size(144, 23);
            this.btn_MostrarMateriasCursadas.TabIndex = 5;
            this.btn_MostrarMateriasCursadas.Text = "Tus materias y datos";
            this.btn_MostrarMateriasCursadas.UseVisualStyleBackColor = true;
            this.btn_MostrarMateriasCursadas.Click += new System.EventHandler(this.btn_MostrarMateriasCursadas_Click);
            // 
            // rch_datosMaterias
            // 
            this.rch_datosMaterias.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rch_datosMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_datosMaterias.ForeColor = System.Drawing.Color.LightGray;
            this.rch_datosMaterias.Location = new System.Drawing.Point(419, 86);
            this.rch_datosMaterias.Name = "rch_datosMaterias";
            this.rch_datosMaterias.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rch_datosMaterias.Size = new System.Drawing.Size(221, 197);
            this.rch_datosMaterias.TabIndex = 9;
            this.rch_datosMaterias.Text = "";
            this.rch_datosMaterias.Visible = false;
            // 
            // tbx_NombreUsuario
            // 
            this.tbx_NombreUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbx_NombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_NombreUsuario.Enabled = false;
            this.tbx_NombreUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.tbx_NombreUsuario.Location = new System.Drawing.Point(136, 57);
            this.tbx_NombreUsuario.Name = "tbx_NombreUsuario";
            this.tbx_NombreUsuario.Size = new System.Drawing.Size(144, 16);
            this.tbx_NombreUsuario.TabIndex = 10;
            this.tbx_NombreUsuario.TextChanged += new System.EventHandler(this.tbx_NombreUsuario_TextChanged);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_usuario.Location = new System.Drawing.Point(136, 86);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(52, 15);
            this.lbl_usuario.TabIndex = 11;
            this.lbl_usuario.Text = "Ususario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 361);
            this.panel1.TabIndex = 12;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(172, 309);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Inscripciones
            // 
            this.btn_Inscripciones.Location = new System.Drawing.Point(136, 170);
            this.btn_Inscripciones.Name = "btn_Inscripciones";
            this.btn_Inscripciones.Size = new System.Drawing.Size(144, 23);
            this.btn_Inscripciones.TabIndex = 14;
            this.btn_Inscripciones.Text = "Inscripciones";
            this.btn_Inscripciones.UseVisualStyleBackColor = true;
            this.btn_Inscripciones.Click += new System.EventHandler(this.btn_Inscripciones_Click);
            // 
            // btn_Asistencia
            // 
            this.btn_Asistencia.Location = new System.Drawing.Point(136, 225);
            this.btn_Asistencia.Name = "btn_Asistencia";
            this.btn_Asistencia.Size = new System.Drawing.Size(144, 23);
            this.btn_Asistencia.TabIndex = 15;
            this.btn_Asistencia.Text = "Asistencias";
            this.btn_Asistencia.UseVisualStyleBackColor = true;
            this.btn_Asistencia.Click += new System.EventHandler(this.btn_Asistencia_Click);
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TITULO.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TITULO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TITULO.Location = new System.Drawing.Point(136, 9);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(161, 27);
            this.TITULO.TabIndex = 16;
            this.TITULO.Text = "Menu Alumno";
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(716, 361);
            this.Controls.Add(this.dtaGV_asistencias);
            this.Controls.Add(this.dtaGV_materias);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.btn_Asistencia);
            this.Controls.Add(this.btn_Inscripciones);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.tbx_NombreUsuario);
            this.Controls.Add(this.rch_datosMaterias);
            this.Controls.Add(this.btn_MostrarMateriasCursadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumnos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlumnos";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAlumnos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGV_asistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btn_MostrarMateriasCursadas;
        private RichTextBox rch_datosMaterias;
        public TextBox tbx_NombreUsuario;
        public Label lbl_usuario;
        private Panel panel1;
        private Button btn_salir;
        private Button btn_Inscripciones;
        private Button btn_Asistencia;
        private Label TITULO;
        private DataGridView dtaGV_materias;
        private DataGridView dtaGV_asistencias;
    }
}