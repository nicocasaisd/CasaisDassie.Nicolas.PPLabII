namespace UI
{
    partial class Frm_HistorialDeFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HistorialDeFacturas));
            this.dgv_historialDeFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historialDeFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_historialDeFacturas
            // 
            this.dgv_historialDeFacturas.AllowUserToAddRows = false;
            this.dgv_historialDeFacturas.AllowUserToDeleteRows = false;
            this.dgv_historialDeFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_historialDeFacturas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_historialDeFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historialDeFacturas.Location = new System.Drawing.Point(12, 40);
            this.dgv_historialDeFacturas.Name = "dgv_historialDeFacturas";
            this.dgv_historialDeFacturas.ReadOnly = true;
            this.dgv_historialDeFacturas.RowTemplate.Height = 25;
            this.dgv_historialDeFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historialDeFacturas.Size = new System.Drawing.Size(739, 150);
            this.dgv_historialDeFacturas.TabIndex = 0;
            // 
            // Frm_HistorialDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.dgv_historialDeFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_HistorialDeFacturas";
            this.Text = "Historial de Facturas";
            this.Load += new System.EventHandler(this.Frm_HistorialDeFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historialDeFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_historialDeFacturas;
    }
}