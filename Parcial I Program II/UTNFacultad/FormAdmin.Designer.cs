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
            this.btn_AltaClase = new System.Windows.Forms.Button();
            this.btn_AltaAula = new System.Windows.Forms.Button();
            this.btn_CreaExamen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_altaPeriodo = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 257);
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
            // 
            // btn_AltaUsuario
            // 
            this.btn_AltaUsuario.Location = new System.Drawing.Point(148, 71);
            this.btn_AltaUsuario.Name = "btn_AltaUsuario";
            this.btn_AltaUsuario.Size = new System.Drawing.Size(119, 23);
            this.btn_AltaUsuario.TabIndex = 19;
            this.btn_AltaUsuario.Text = "Alta de usuario";
            this.btn_AltaUsuario.UseVisualStyleBackColor = true;
            this.btn_AltaUsuario.Click += new System.EventHandler(this.btn_AltaUsuario_Click);
            // 
            // btn_AltaClase
            // 
            this.btn_AltaClase.Location = new System.Drawing.Point(148, 111);
            this.btn_AltaClase.Name = "btn_AltaClase";
            this.btn_AltaClase.Size = new System.Drawing.Size(119, 23);
            this.btn_AltaClase.TabIndex = 20;
            this.btn_AltaClase.Text = "Alta Clase";
            this.btn_AltaClase.UseVisualStyleBackColor = true;
            this.btn_AltaClase.Click += new System.EventHandler(this.btn_AltaClase_Click);
            // 
            // btn_AltaAula
            // 
            this.btn_AltaAula.Location = new System.Drawing.Point(315, 71);
            this.btn_AltaAula.Name = "btn_AltaAula";
            this.btn_AltaAula.Size = new System.Drawing.Size(119, 23);
            this.btn_AltaAula.TabIndex = 21;
            this.btn_AltaAula.Text = "Alta Aula";
            this.btn_AltaAula.UseVisualStyleBackColor = true;
            this.btn_AltaAula.Click += new System.EventHandler(this.btn_AltaAula_Click);
            // 
            // btn_CreaExamen
            // 
            this.btn_CreaExamen.Location = new System.Drawing.Point(315, 100);
            this.btn_CreaExamen.Name = "btn_CreaExamen";
            this.btn_CreaExamen.Size = new System.Drawing.Size(119, 23);
            this.btn_CreaExamen.TabIndex = 22;
            this.btn_CreaExamen.Text = "Crear Examen";
            this.btn_CreaExamen.UseVisualStyleBackColor = true;
            this.btn_CreaExamen.Click += new System.EventHandler(this.btn_CreaExamen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_altaPeriodo
            // 
            this.btn_altaPeriodo.Location = new System.Drawing.Point(148, 151);
            this.btn_altaPeriodo.Name = "btn_altaPeriodo";
            this.btn_altaPeriodo.Size = new System.Drawing.Size(119, 23);
            this.btn_altaPeriodo.TabIndex = 24;
            this.btn_altaPeriodo.Text = "Alta Periodo";
            this.btn_altaPeriodo.UseVisualStyleBackColor = true;
            this.btn_altaPeriodo.Click += new System.EventHandler(this.btn_altaPeriodo_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Location = new System.Drawing.Point(315, 129);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(119, 45);
            this.btn_exp.TabIndex = 25;
            this.btn_exp.Text = "Exportar Alumnos en materias";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.btn_exp_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(518, 257);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_altaPeriodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_CreaExamen);
            this.Controls.Add(this.btn_AltaAula);
            this.Controls.Add(this.btn_AltaClase);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label TITULO;
        private Button btn_AltaUsuario;
        private Button btn_AltaClase;
        private Button btn_AltaAula;
        private Button btn_CreaExamen;
        private Button button1;
        private Button btn_altaPeriodo;
        private Button btn_exp;
    }
}