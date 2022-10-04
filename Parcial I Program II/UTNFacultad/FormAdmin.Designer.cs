namespace UTNFacultad
{
    partial class FormAdmin
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
            this.TITULO = new System.Windows.Forms.Label();
            this.btn_AltaUsuario = new System.Windows.Forms.Button();
            this.btn_cambioEstadoAlumno = new System.Windows.Forms.Button();
            this.btn_AltaMateria = new System.Windows.Forms.Button();
            this.btn_AsignarMateria = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.rdb_Alumno = new System.Windows.Forms.RadioButton();
            this.rdb_profesor = new System.Windows.Forms.RadioButton();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.txb_nombreRealUsr = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_ConcretarUsr = new System.Windows.Forms.Button();
            this.rdb_PrimerCuatri = new System.Windows.Forms.RadioButton();
            this.rdb_SegundoCuatri = new System.Windows.Forms.RadioButton();
            this.txb_correlativa = new System.Windows.Forms.TextBox();
            this.txb_NombreMateria = new System.Windows.Forms.TextBox();
            this.btn_ConcretarNuevaMateria = new System.Windows.Forms.Button();
            this.rch_MateriasSinProfesor = new System.Windows.Forms.RichTextBox();
            this.nm_legajoProfesor = new System.Windows.Forms.NumericUpDown();
            this.btn_ConcretarAsignarMateria = new System.Windows.Forms.Button();
            this.rch_ListaProfesores = new System.Windows.Forms.RichTextBox();
            this.lbl_TituloMaterias = new System.Windows.Forms.Label();
            this.lbl_Profesores = new System.Windows.Forms.Label();
            this.lbl_legajo = new System.Windows.Forms.Label();
            this.rdb_Libre = new System.Windows.Forms.RadioButton();
            this.rdb_Regular = new System.Windows.Forms.RadioButton();
            this.btn_CambiarEstado = new System.Windows.Forms.Button();
            this.btn_InscribirAlumno = new System.Windows.Forms.Button();
            this.btn_AsignarMateriaAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_legajoProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 422);
            this.panel1.TabIndex = 14;
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TITULO.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TITULO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TITULO.Location = new System.Drawing.Point(148, 19);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(286, 27);
            this.TITULO.TabIndex = 18;
            this.TITULO.Text = "Menu Del Administrador";
            this.TITULO.Click += new System.EventHandler(this.TITULO_Click);
            // 
            // btn_AltaUsuario
            // 
            this.btn_AltaUsuario.Location = new System.Drawing.Point(148, 86);
            this.btn_AltaUsuario.Name = "btn_AltaUsuario";
            this.btn_AltaUsuario.Size = new System.Drawing.Size(122, 23);
            this.btn_AltaUsuario.TabIndex = 19;
            this.btn_AltaUsuario.Text = "Altas de Usuarios";
            this.btn_AltaUsuario.UseVisualStyleBackColor = true;
            this.btn_AltaUsuario.Click += new System.EventHandler(this.btn_AltaUsuario_Click);
            // 
            // btn_cambioEstadoAlumno
            // 
            this.btn_cambioEstadoAlumno.Location = new System.Drawing.Point(148, 130);
            this.btn_cambioEstadoAlumno.Name = "btn_cambioEstadoAlumno";
            this.btn_cambioEstadoAlumno.Size = new System.Drawing.Size(122, 49);
            this.btn_cambioEstadoAlumno.TabIndex = 20;
            this.btn_cambioEstadoAlumno.Text = "Cambio de estado de materia alumno";
            this.btn_cambioEstadoAlumno.UseVisualStyleBackColor = true;
            this.btn_cambioEstadoAlumno.Click += new System.EventHandler(this.btn_cambioEstadoAlumno_Click);
            // 
            // btn_AltaMateria
            // 
            this.btn_AltaMateria.Location = new System.Drawing.Point(148, 198);
            this.btn_AltaMateria.Name = "btn_AltaMateria";
            this.btn_AltaMateria.Size = new System.Drawing.Size(122, 23);
            this.btn_AltaMateria.TabIndex = 21;
            this.btn_AltaMateria.Text = "Alta de Materia";
            this.btn_AltaMateria.UseVisualStyleBackColor = true;
            this.btn_AltaMateria.Click += new System.EventHandler(this.btn_AltaMateria_Click);
            // 
            // btn_AsignarMateria
            // 
            this.btn_AsignarMateria.Location = new System.Drawing.Point(148, 240);
            this.btn_AsignarMateria.Name = "btn_AsignarMateria";
            this.btn_AsignarMateria.Size = new System.Drawing.Size(122, 23);
            this.btn_AsignarMateria.TabIndex = 22;
            this.btn_AsignarMateria.Text = "Asignar Materia";
            this.btn_AsignarMateria.UseVisualStyleBackColor = true;
            this.btn_AsignarMateria.Click += new System.EventHandler(this.btn_AsignarMateria_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(148, 375);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(122, 23);
            this.btn_Salir.TabIndex = 23;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // rdb_Alumno
            // 
            this.rdb_Alumno.AutoSize = true;
            this.rdb_Alumno.ForeColor = System.Drawing.Color.DarkGray;
            this.rdb_Alumno.Location = new System.Drawing.Point(469, 109);
            this.rdb_Alumno.Name = "rdb_Alumno";
            this.rdb_Alumno.Size = new System.Drawing.Size(76, 19);
            this.rdb_Alumno.TabIndex = 24;
            this.rdb_Alumno.TabStop = true;
            this.rdb_Alumno.Text = "ALUMNO";
            this.rdb_Alumno.UseVisualStyleBackColor = true;
            this.rdb_Alumno.Visible = false;
            this.rdb_Alumno.CheckedChanged += new System.EventHandler(this.rdb_Alumno_CheckedChanged);
            // 
            // rdb_profesor
            // 
            this.rdb_profesor.AutoSize = true;
            this.rdb_profesor.ForeColor = System.Drawing.Color.DarkGray;
            this.rdb_profesor.Location = new System.Drawing.Point(469, 180);
            this.rdb_profesor.Name = "rdb_profesor";
            this.rdb_profesor.Size = new System.Drawing.Size(82, 19);
            this.rdb_profesor.TabIndex = 25;
            this.rdb_profesor.TabStop = true;
            this.rdb_profesor.Text = "PROFESOR";
            this.rdb_profesor.UseVisualStyleBackColor = true;
            this.rdb_profesor.Visible = false;
            this.rdb_profesor.CheckedChanged += new System.EventHandler(this.rdb_profesor_CheckedChanged);
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.ForeColor = System.Drawing.Color.DarkGray;
            this.rdb_Admin.Location = new System.Drawing.Point(469, 244);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(118, 19);
            this.rdb_Admin.TabIndex = 26;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Text = "ADMINISTRADOR";
            this.rdb_Admin.UseVisualStyleBackColor = true;
            this.rdb_Admin.Visible = false;
            this.rdb_Admin.CheckedChanged += new System.EventHandler(this.rdb_Admin_CheckedChanged);
            // 
            // txb_nombreRealUsr
            // 
            this.txb_nombreRealUsr.BackColor = System.Drawing.SystemColors.InfoText;
            this.txb_nombreRealUsr.ForeColor = System.Drawing.Color.LightGray;
            this.txb_nombreRealUsr.Location = new System.Drawing.Point(334, 86);
            this.txb_nombreRealUsr.Name = "txb_nombreRealUsr";
            this.txb_nombreRealUsr.Size = new System.Drawing.Size(100, 23);
            this.txb_nombreRealUsr.TabIndex = 27;
            this.txb_nombreRealUsr.Text = "NOMBRE";
            this.txb_nombreRealUsr.Visible = false;
            this.txb_nombreRealUsr.Enter += new System.EventHandler(this.txb_nombreRealUsr_Enter);
            this.txb_nombreRealUsr.Leave += new System.EventHandler(this.txb_nombreRealUsr_Leave);
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.BackColor = System.Drawing.SystemColors.InfoText;
            this.txb_Apellido.ForeColor = System.Drawing.Color.LightGray;
            this.txb_Apellido.Location = new System.Drawing.Point(334, 130);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txb_Apellido.TabIndex = 28;
            this.txb_Apellido.Text = "APELLIDO";
            this.txb_Apellido.Visible = false;
            this.txb_Apellido.Enter += new System.EventHandler(this.txb_Apellido_Enter);
            this.txb_Apellido.Leave += new System.EventHandler(this.txb_Apellido_Leave);
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.BackColor = System.Drawing.SystemColors.InfoText;
            this.txb_Usuario.ForeColor = System.Drawing.Color.LightGray;
            this.txb_Usuario.Location = new System.Drawing.Point(334, 261);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(100, 23);
            this.txb_Usuario.TabIndex = 29;
            this.txb_Usuario.Text = "USUARIO";
            this.txb_Usuario.Visible = false;
            this.txb_Usuario.Enter += new System.EventHandler(this.txb_Usuario_Enter);
            this.txb_Usuario.Leave += new System.EventHandler(this.txb_Usuario_Leave);
            // 
            // txb_Contraseña
            // 
            this.txb_Contraseña.BackColor = System.Drawing.SystemColors.InfoText;
            this.txb_Contraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.txb_Contraseña.Location = new System.Drawing.Point(334, 302);
            this.txb_Contraseña.Name = "txb_Contraseña";
            this.txb_Contraseña.Size = new System.Drawing.Size(100, 23);
            this.txb_Contraseña.TabIndex = 30;
            this.txb_Contraseña.Text = "CONTRASEÑA";
            this.txb_Contraseña.Visible = false;
            this.txb_Contraseña.Enter += new System.EventHandler(this.txb_Contraseña_Enter);
            this.txb_Contraseña.Leave += new System.EventHandler(this.txb_Contraseña_Leave);
            // 
            // btn_ConcretarUsr
            // 
            this.btn_ConcretarUsr.Location = new System.Drawing.Point(553, 373);
            this.btn_ConcretarUsr.Name = "btn_ConcretarUsr";
            this.btn_ConcretarUsr.Size = new System.Drawing.Size(111, 23);
            this.btn_ConcretarUsr.TabIndex = 31;
            this.btn_ConcretarUsr.Text = "Concretar";
            this.btn_ConcretarUsr.UseVisualStyleBackColor = true;
            this.btn_ConcretarUsr.Visible = false;
            this.btn_ConcretarUsr.Click += new System.EventHandler(this.btn_ConcretarUsr_Click);
            // 
            // rdb_PrimerCuatri
            // 
            this.rdb_PrimerCuatri.AutoSize = true;
            this.rdb_PrimerCuatri.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_PrimerCuatri.Location = new System.Drawing.Point(469, 198);
            this.rdb_PrimerCuatri.Name = "rdb_PrimerCuatri";
            this.rdb_PrimerCuatri.Size = new System.Drawing.Size(125, 19);
            this.rdb_PrimerCuatri.TabIndex = 32;
            this.rdb_PrimerCuatri.TabStop = true;
            this.rdb_PrimerCuatri.Text = "1er CUATRIMESTRE";
            this.rdb_PrimerCuatri.UseVisualStyleBackColor = true;
            this.rdb_PrimerCuatri.Visible = false;
            this.rdb_PrimerCuatri.CheckedChanged += new System.EventHandler(this.rdb_PrimerCuatri_CheckedChanged);
            // 
            // rdb_SegundoCuatri
            // 
            this.rdb_SegundoCuatri.AutoSize = true;
            this.rdb_SegundoCuatri.ForeColor = System.Drawing.Color.LightGray;
            this.rdb_SegundoCuatri.Location = new System.Drawing.Point(469, 218);
            this.rdb_SegundoCuatri.Name = "rdb_SegundoCuatri";
            this.rdb_SegundoCuatri.Size = new System.Drawing.Size(129, 19);
            this.rdb_SegundoCuatri.TabIndex = 33;
            this.rdb_SegundoCuatri.TabStop = true;
            this.rdb_SegundoCuatri.Text = "2do CUATRIMESTRE";
            this.rdb_SegundoCuatri.UseVisualStyleBackColor = true;
            this.rdb_SegundoCuatri.Visible = false;
            this.rdb_SegundoCuatri.CheckedChanged += new System.EventHandler(this.rdb_SegundoCuatri_CheckedChanged);
            // 
            // txb_correlativa
            // 
            this.txb_correlativa.BackColor = System.Drawing.SystemColors.InfoText;
            this.txb_correlativa.ForeColor = System.Drawing.Color.LightGray;
            this.txb_correlativa.Location = new System.Drawing.Point(334, 217);
            this.txb_correlativa.Name = "txb_correlativa";
            this.txb_correlativa.Size = new System.Drawing.Size(100, 23);
            this.txb_correlativa.TabIndex = 34;
            this.txb_correlativa.Text = "CORRELATIVA";
            this.txb_correlativa.Visible = false;
            this.txb_correlativa.Enter += new System.EventHandler(this.txb_correlativa_Enter);
            this.txb_correlativa.Leave += new System.EventHandler(this.txb_correlativa_Leave);
            // 
            // txb_NombreMateria
            // 
            this.txb_NombreMateria.BackColor = System.Drawing.SystemColors.InfoText;
            this.txb_NombreMateria.ForeColor = System.Drawing.Color.LightGray;
            this.txb_NombreMateria.Location = new System.Drawing.Point(334, 176);
            this.txb_NombreMateria.Name = "txb_NombreMateria";
            this.txb_NombreMateria.Size = new System.Drawing.Size(100, 23);
            this.txb_NombreMateria.TabIndex = 35;
            this.txb_NombreMateria.Text = "MATERIA";
            this.txb_NombreMateria.Visible = false;
            this.txb_NombreMateria.Enter += new System.EventHandler(this.txb_NombreMateria_Enter);
            this.txb_NombreMateria.Leave += new System.EventHandler(this.txb_NombreMateria_Leave);
            // 
            // btn_ConcretarNuevaMateria
            // 
            this.btn_ConcretarNuevaMateria.Location = new System.Drawing.Point(553, 280);
            this.btn_ConcretarNuevaMateria.Name = "btn_ConcretarNuevaMateria";
            this.btn_ConcretarNuevaMateria.Size = new System.Drawing.Size(111, 23);
            this.btn_ConcretarNuevaMateria.TabIndex = 36;
            this.btn_ConcretarNuevaMateria.Text = "Concretar";
            this.btn_ConcretarNuevaMateria.UseVisualStyleBackColor = true;
            this.btn_ConcretarNuevaMateria.Visible = false;
            this.btn_ConcretarNuevaMateria.Click += new System.EventHandler(this.btn_ConcretarNuevaMateria_Click);
            // 
            // rch_MateriasSinProfesor
            // 
            this.rch_MateriasSinProfesor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rch_MateriasSinProfesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_MateriasSinProfesor.ForeColor = System.Drawing.Color.LightGray;
            this.rch_MateriasSinProfesor.Location = new System.Drawing.Point(594, 72);
            this.rch_MateriasSinProfesor.Name = "rch_MateriasSinProfesor";
            this.rch_MateriasSinProfesor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rch_MateriasSinProfesor.Size = new System.Drawing.Size(213, 127);
            this.rch_MateriasSinProfesor.TabIndex = 37;
            this.rch_MateriasSinProfesor.Text = "";
            this.rch_MateriasSinProfesor.Visible = false;
            // 
            // nm_legajoProfesor
            // 
            this.nm_legajoProfesor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nm_legajoProfesor.ForeColor = System.Drawing.Color.LightGray;
            this.nm_legajoProfesor.Location = new System.Drawing.Point(334, 235);
            this.nm_legajoProfesor.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nm_legajoProfesor.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nm_legajoProfesor.Name = "nm_legajoProfesor";
            this.nm_legajoProfesor.Size = new System.Drawing.Size(100, 23);
            this.nm_legajoProfesor.TabIndex = 38;
            this.nm_legajoProfesor.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nm_legajoProfesor.Visible = false;
            // 
            // btn_ConcretarAsignarMateria
            // 
            this.btn_ConcretarAsignarMateria.Location = new System.Drawing.Point(440, 353);
            this.btn_ConcretarAsignarMateria.Name = "btn_ConcretarAsignarMateria";
            this.btn_ConcretarAsignarMateria.Size = new System.Drawing.Size(105, 45);
            this.btn_ConcretarAsignarMateria.TabIndex = 39;
            this.btn_ConcretarAsignarMateria.Text = "Concretar asignacion";
            this.btn_ConcretarAsignarMateria.UseVisualStyleBackColor = true;
            this.btn_ConcretarAsignarMateria.Visible = false;
            this.btn_ConcretarAsignarMateria.Click += new System.EventHandler(this.btn_ConcretarAsignarMateria_Click);
            // 
            // rch_ListaProfesores
            // 
            this.rch_ListaProfesores.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rch_ListaProfesores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_ListaProfesores.ForeColor = System.Drawing.Color.LightGray;
            this.rch_ListaProfesores.Location = new System.Drawing.Point(594, 240);
            this.rch_ListaProfesores.Name = "rch_ListaProfesores";
            this.rch_ListaProfesores.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rch_ListaProfesores.Size = new System.Drawing.Size(213, 127);
            this.rch_ListaProfesores.TabIndex = 40;
            this.rch_ListaProfesores.Text = "";
            this.rch_ListaProfesores.Visible = false;
            this.rch_ListaProfesores.WordWrap = false;
            // 
            // lbl_TituloMaterias
            // 
            this.lbl_TituloMaterias.AutoSize = true;
            this.lbl_TituloMaterias.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TituloMaterias.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_TituloMaterias.Location = new System.Drawing.Point(604, 52);
            this.lbl_TituloMaterias.Name = "lbl_TituloMaterias";
            this.lbl_TituloMaterias.Size = new System.Drawing.Size(184, 17);
            this.lbl_TituloMaterias.TabIndex = 41;
            this.lbl_TituloMaterias.Text = "Materias sin profesores ";
            this.lbl_TituloMaterias.Visible = false;
            // 
            // lbl_Profesores
            // 
            this.lbl_Profesores.AutoSize = true;
            this.lbl_Profesores.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Profesores.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Profesores.Location = new System.Drawing.Point(655, 217);
            this.lbl_Profesores.Name = "lbl_Profesores";
            this.lbl_Profesores.Size = new System.Drawing.Size(90, 17);
            this.lbl_Profesores.TabIndex = 42;
            this.lbl_Profesores.Text = "Profesores";
            this.lbl_Profesores.Visible = false;
            // 
            // lbl_legajo
            // 
            this.lbl_legajo.AutoSize = true;
            this.lbl_legajo.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_legajo.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lbl_legajo.Location = new System.Drawing.Point(334, 217);
            this.lbl_legajo.Name = "lbl_legajo";
            this.lbl_legajo.Size = new System.Drawing.Size(45, 15);
            this.lbl_legajo.TabIndex = 43;
            this.lbl_legajo.Text = "Legajo ";
            this.lbl_legajo.Visible = false;
            // 
            // rdb_Libre
            // 
            this.rdb_Libre.AutoSize = true;
            this.rdb_Libre.ForeColor = System.Drawing.Color.DarkGray;
            this.rdb_Libre.Location = new System.Drawing.Point(469, 135);
            this.rdb_Libre.Name = "rdb_Libre";
            this.rdb_Libre.Size = new System.Drawing.Size(54, 19);
            this.rdb_Libre.TabIndex = 44;
            this.rdb_Libre.TabStop = true;
            this.rdb_Libre.Text = "LIBRE";
            this.rdb_Libre.UseVisualStyleBackColor = true;
            this.rdb_Libre.Visible = false;
            this.rdb_Libre.CheckedChanged += new System.EventHandler(this.rdb_Libre_CheckedChanged);
            // 
            // rdb_Regular
            // 
            this.rdb_Regular.AutoSize = true;
            this.rdb_Regular.ForeColor = System.Drawing.Color.DarkGray;
            this.rdb_Regular.Location = new System.Drawing.Point(469, 160);
            this.rdb_Regular.Name = "rdb_Regular";
            this.rdb_Regular.Size = new System.Drawing.Size(75, 19);
            this.rdb_Regular.TabIndex = 45;
            this.rdb_Regular.TabStop = true;
            this.rdb_Regular.Text = "REGULAR";
            this.rdb_Regular.UseVisualStyleBackColor = true;
            this.rdb_Regular.Visible = false;
            this.rdb_Regular.CheckedChanged += new System.EventHandler(this.rdb_Regular_CheckedChanged);
            // 
            // btn_CambiarEstado
            // 
            this.btn_CambiarEstado.Location = new System.Drawing.Point(553, 364);
            this.btn_CambiarEstado.Name = "btn_CambiarEstado";
            this.btn_CambiarEstado.Size = new System.Drawing.Size(113, 23);
            this.btn_CambiarEstado.TabIndex = 46;
            this.btn_CambiarEstado.Text = "Concretar";
            this.btn_CambiarEstado.UseVisualStyleBackColor = true;
            this.btn_CambiarEstado.Click += new System.EventHandler(this.btn_CambiarEstado_Click);
            // 
            // btn_InscribirAlumno
            // 
            this.btn_InscribirAlumno.Location = new System.Drawing.Point(148, 280);
            this.btn_InscribirAlumno.Name = "btn_InscribirAlumno";
            this.btn_InscribirAlumno.Size = new System.Drawing.Size(122, 45);
            this.btn_InscribirAlumno.TabIndex = 47;
            this.btn_InscribirAlumno.Text = "Inscribir Alumno a materia";
            this.btn_InscribirAlumno.UseVisualStyleBackColor = true;
            this.btn_InscribirAlumno.Click += new System.EventHandler(this.btn_InscribirAlumno_Click);
            // 
            // btn_AsignarMateriaAlumno
            // 
            this.btn_AsignarMateriaAlumno.Location = new System.Drawing.Point(553, 364);
            this.btn_AsignarMateriaAlumno.Name = "btn_AsignarMateriaAlumno";
            this.btn_AsignarMateriaAlumno.Size = new System.Drawing.Size(113, 23);
            this.btn_AsignarMateriaAlumno.TabIndex = 48;
            this.btn_AsignarMateriaAlumno.Text = "Asignar";
            this.btn_AsignarMateriaAlumno.UseVisualStyleBackColor = true;
            this.btn_AsignarMateriaAlumno.Visible = false;
            this.btn_AsignarMateriaAlumno.Click += new System.EventHandler(this.btn_AsignarMateriaAlumno_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(837, 422);
            this.Controls.Add(this.btn_AsignarMateriaAlumno);
            this.Controls.Add(this.btn_InscribirAlumno);
            this.Controls.Add(this.btn_CambiarEstado);
            this.Controls.Add(this.rdb_Regular);
            this.Controls.Add(this.rdb_Libre);
            this.Controls.Add(this.lbl_legajo);
            this.Controls.Add(this.lbl_Profesores);
            this.Controls.Add(this.lbl_TituloMaterias);
            this.Controls.Add(this.rch_ListaProfesores);
            this.Controls.Add(this.btn_ConcretarAsignarMateria);
            this.Controls.Add(this.nm_legajoProfesor);
            this.Controls.Add(this.rch_MateriasSinProfesor);
            this.Controls.Add(this.btn_ConcretarNuevaMateria);
            this.Controls.Add(this.txb_NombreMateria);
            this.Controls.Add(this.txb_correlativa);
            this.Controls.Add(this.rdb_SegundoCuatri);
            this.Controls.Add(this.rdb_PrimerCuatri);
            this.Controls.Add(this.btn_ConcretarUsr);
            this.Controls.Add(this.txb_Contraseña);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.txb_nombreRealUsr);
            this.Controls.Add(this.rdb_Admin);
            this.Controls.Add(this.rdb_profesor);
            this.Controls.Add(this.rdb_Alumno);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_AsignarMateria);
            this.Controls.Add(this.btn_AltaMateria);
            this.Controls.Add(this.btn_cambioEstadoAlumno);
            this.Controls.Add(this.btn_AltaUsuario);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAdmin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nm_legajoProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label TITULO;
        private Button btn_AltaUsuario;
        private Button btn_cambioEstadoAlumno;
        private Button btn_AltaMateria;
        private Button btn_AsignarMateria;
        private Button btn_Salir;
        private RadioButton rdb_Alumno;
        private RadioButton rdb_profesor;
        private RadioButton rdb_Admin;
        private TextBox txb_nombreRealUsr;
        private TextBox txb_Apellido;
        private TextBox txb_Usuario;
        private TextBox txb_Contraseña;
        private Button btn_ConcretarUsr;
        private RadioButton rdb_PrimerCuatri;
        private RadioButton rdb_SegundoCuatri;
        private TextBox txb_correlativa;
        private TextBox txb_NombreMateria;
        private Button btn_ConcretarNuevaMateria;
        private RichTextBox rch_MateriasSinProfesor;
        private NumericUpDown nm_legajoProfesor;
        private Button btn_ConcretarAsignarMateria;
        private RichTextBox rch_ListaProfesores;
        private Label lbl_TituloMaterias;
        private Label lbl_Profesores;
        private Label lbl_legajo;
        private RadioButton rdb_Libre;
        private RadioButton rdb_Regular;
        private Button btn_CambiarEstado;
        private Button btn_InscribirAlumno;
        private Button btn_AsignarMateriaAlumno;
    }
}