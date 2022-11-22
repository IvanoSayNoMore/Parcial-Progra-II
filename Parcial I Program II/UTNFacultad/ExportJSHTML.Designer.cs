namespace UTNFacultad
{
    partial class ExportJSHTML
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
            this.cb_Materias = new System.Windows.Forms.ComboBox();
            this.rdb_json = new System.Windows.Forms.RadioButton();
            this.rdb_csv = new System.Windows.Forms.RadioButton();
            this.btn_concretar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 231);
            this.panel1.TabIndex = 15;
            // 
            // cb_Materias
            // 
            this.cb_Materias.FormattingEnabled = true;
            this.cb_Materias.Location = new System.Drawing.Point(122, 41);
            this.cb_Materias.Name = "cb_Materias";
            this.cb_Materias.Size = new System.Drawing.Size(121, 23);
            this.cb_Materias.TabIndex = 18;
            // 
            // rdb_json
            // 
            this.rdb_json.AutoSize = true;
            this.rdb_json.ForeColor = System.Drawing.Color.DimGray;
            this.rdb_json.Location = new System.Drawing.Point(122, 115);
            this.rdb_json.Name = "rdb_json";
            this.rdb_json.Size = new System.Drawing.Size(53, 19);
            this.rdb_json.TabIndex = 19;
            this.rdb_json.TabStop = true;
            this.rdb_json.Text = "JSON";
            this.rdb_json.UseVisualStyleBackColor = true;
            // 
            // rdb_csv
            // 
            this.rdb_csv.AutoSize = true;
            this.rdb_csv.ForeColor = System.Drawing.Color.DimGray;
            this.rdb_csv.Location = new System.Drawing.Point(197, 115);
            this.rdb_csv.Name = "rdb_csv";
            this.rdb_csv.Size = new System.Drawing.Size(46, 19);
            this.rdb_csv.TabIndex = 20;
            this.rdb_csv.TabStop = true;
            this.rdb_csv.Text = "CSV";
            this.rdb_csv.UseVisualStyleBackColor = true;
            // 
            // btn_concretar
            // 
            this.btn_concretar.Location = new System.Drawing.Point(122, 140);
            this.btn_concretar.Name = "btn_concretar";
            this.btn_concretar.Size = new System.Drawing.Size(121, 23);
            this.btn_concretar.TabIndex = 21;
            this.btn_concretar.Text = "Concretar";
            this.btn_concretar.UseVisualStyleBackColor = true;
            this.btn_concretar.Click += new System.EventHandler(this.btn_concretar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(122, 180);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(121, 23);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // ExportJSHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(282, 231);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_concretar);
            this.Controls.Add(this.rdb_csv);
            this.Controls.Add(this.rdb_json);
            this.Controls.Add(this.cb_Materias);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportJSHTML";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportJSHTML";
            this.Load += new System.EventHandler(this.ExportJSHTML_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ComboBox cb_Materias;
        private RadioButton rdb_json;
        private RadioButton rdb_csv;
        private Button btn_concretar;
        private Button btn_cancelar;
    }
}