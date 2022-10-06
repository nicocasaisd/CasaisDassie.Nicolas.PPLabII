namespace UI
{
    partial class Frm_Estadisticas
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gpb_ventasTotales = new System.Windows.Forms.GroupBox();
            this.txt_ventasTotales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpb_ventasTotales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Salir.Location = new System.Drawing.Point(475, 21);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(54, 24);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // gpb_ventasTotales
            // 
            this.gpb_ventasTotales.Controls.Add(this.label1);
            this.gpb_ventasTotales.Controls.Add(this.txt_ventasTotales);
            this.gpb_ventasTotales.Location = new System.Drawing.Point(12, 65);
            this.gpb_ventasTotales.Name = "gpb_ventasTotales";
            this.gpb_ventasTotales.Size = new System.Drawing.Size(357, 100);
            this.gpb_ventasTotales.TabIndex = 5;
            this.gpb_ventasTotales.TabStop = false;
            this.gpb_ventasTotales.Text = "Total de Ventas";
            // 
            // txt_ventasTotales
            // 
            this.txt_ventasTotales.Enabled = false;
            this.txt_ventasTotales.Location = new System.Drawing.Point(103, 40);
            this.txt_ventasTotales.Name = "txt_ventasTotales";
            this.txt_ventasTotales.Size = new System.Drawing.Size(149, 23);
            this.txt_ventasTotales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant total: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cant total: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(103, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb_ventasTotales);
            this.Controls.Add(this.btn_Salir);
            this.Name = "Frm_Estadisticas";
            this.Text = "Frm_Estadisticas";
            this.gpb_ventasTotales.ResumeLayout(false);
            this.gpb_ventasTotales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Salir;
        private GroupBox gpb_ventasTotales;
        private TextBox txt_ventasTotales;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
    }
}