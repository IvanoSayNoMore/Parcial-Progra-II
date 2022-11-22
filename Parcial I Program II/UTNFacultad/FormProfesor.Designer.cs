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
            this.TITULO = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_crearExamen = new System.Windows.Forms.Button();
            this.rtb_materiasAsignadas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 234);
            this.panel1.TabIndex = 13;
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
            this.btn_salir.Location = new System.Drawing.Point(160, 179);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_crearExamen
            // 
            this.btn_crearExamen.Location = new System.Drawing.Point(135, 71);
            this.btn_crearExamen.Name = "btn_crearExamen";
            this.btn_crearExamen.Size = new System.Drawing.Size(138, 23);
            this.btn_crearExamen.TabIndex = 19;
            this.btn_crearExamen.Text = "Crear Examen";
            this.btn_crearExamen.UseVisualStyleBackColor = true;
            this.btn_crearExamen.Click += new System.EventHandler(this.btn_crearExamen_Click);
            // 
            // rtb_materiasAsignadas
            // 
            this.rtb_materiasAsignadas.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtb_materiasAsignadas.ForeColor = System.Drawing.Color.DarkGray;
            this.rtb_materiasAsignadas.Location = new System.Drawing.Point(322, 71);
            this.rtb_materiasAsignadas.Name = "rtb_materiasAsignadas";
            this.rtb_materiasAsignadas.Size = new System.Drawing.Size(304, 131);
            this.rtb_materiasAsignadas.TabIndex = 26;
            this.rtb_materiasAsignadas.Text = "";
            this.rtb_materiasAsignadas.Visible = false;
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(679, 234);
            this.Controls.Add(this.rtb_materiasAsignadas);
            this.Controls.Add(this.btn_crearExamen);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.TITULO);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfesor";
            this.Opacity = 0.9D;
            this.Text = "FormProfesor";
            this.Load += new System.EventHandler(this.FormProfesor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProfesor_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label TITULO;
        private Button btn_salir;
        private Button btn_crearExamen;
        private RichTextBox rtb_materiasAsignadas;
    }
}