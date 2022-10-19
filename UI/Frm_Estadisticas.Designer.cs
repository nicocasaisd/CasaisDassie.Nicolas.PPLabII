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
            this.gpb_ventasTotales = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ventasTotales = new System.Windows.Forms.TextBox();
            this.gpb_datosCategoria = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_promedioDeGanancia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productoMasVendido = new System.Windows.Forms.TextBox();
            this.gpb_totalGanancia = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalGanancia = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.gpb_ventasTotales.SuspendLayout();
            this.gpb_datosCategoria.SuspendLayout();
            this.gpb_totalGanancia.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant total: ";
            // 
            // txt_ventasTotales
            // 
            this.txt_ventasTotales.Enabled = false;
            this.txt_ventasTotales.Location = new System.Drawing.Point(103, 40);
            this.txt_ventasTotales.Name = "txt_ventasTotales";
            this.txt_ventasTotales.Size = new System.Drawing.Size(149, 23);
            this.txt_ventasTotales.TabIndex = 0;
            // 
            // gpb_datosCategoria
            // 
            this.gpb_datosCategoria.Controls.Add(this.label4);
            this.gpb_datosCategoria.Controls.Add(this.cmb_categoria);
            this.gpb_datosCategoria.Controls.Add(this.label3);
            this.gpb_datosCategoria.Controls.Add(this.txt_promedioDeGanancia);
            this.gpb_datosCategoria.Controls.Add(this.label2);
            this.gpb_datosCategoria.Controls.Add(this.txt_productoMasVendido);
            this.gpb_datosCategoria.Location = new System.Drawing.Point(12, 171);
            this.gpb_datosCategoria.Name = "gpb_datosCategoria";
            this.gpb_datosCategoria.Size = new System.Drawing.Size(357, 162);
            this.gpb_datosCategoria.TabIndex = 6;
            this.gpb_datosCategoria.TabStop = false;
            this.gpb_datosCategoria.Text = "Datos por categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Elija categoría:";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(172, 126);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(149, 23);
            this.cmb_categoria.TabIndex = 4;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promedio de ganancia:";
            // 
            // txt_promedioDeGanancia
            // 
            this.txt_promedioDeGanancia.Enabled = false;
            this.txt_promedioDeGanancia.Location = new System.Drawing.Point(172, 83);
            this.txt_promedioDeGanancia.Name = "txt_promedioDeGanancia";
            this.txt_promedioDeGanancia.Size = new System.Drawing.Size(149, 23);
            this.txt_promedioDeGanancia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto más vendido:";
            // 
            // txt_productoMasVendido
            // 
            this.txt_productoMasVendido.Enabled = false;
            this.txt_productoMasVendido.Location = new System.Drawing.Point(172, 39);
            this.txt_productoMasVendido.Name = "txt_productoMasVendido";
            this.txt_productoMasVendido.Size = new System.Drawing.Size(149, 23);
            this.txt_productoMasVendido.TabIndex = 0;
            // 
            // gpb_totalGanancia
            // 
            this.gpb_totalGanancia.Controls.Add(this.label5);
            this.gpb_totalGanancia.Controls.Add(this.txt_totalGanancia);
            this.gpb_totalGanancia.Location = new System.Drawing.Point(12, 339);
            this.gpb_totalGanancia.Name = "gpb_totalGanancia";
            this.gpb_totalGanancia.Size = new System.Drawing.Size(357, 100);
            this.gpb_totalGanancia.TabIndex = 6;
            this.gpb_totalGanancia.TabStop = false;
            this.gpb_totalGanancia.Text = "Total de Ventas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ganancia total: ";
            // 
            // txt_totalGanancia
            // 
            this.txt_totalGanancia.Enabled = false;
            this.txt_totalGanancia.Location = new System.Drawing.Point(130, 39);
            this.txt_totalGanancia.Name = "txt_totalGanancia";
            this.txt_totalGanancia.Size = new System.Drawing.Size(149, 23);
            this.txt_totalGanancia.TabIndex = 0;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(404, 385);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 7;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.gpb_totalGanancia);
            this.Controls.Add(this.gpb_datosCategoria);
            this.Controls.Add(this.gpb_ventasTotales);
            this.Name = "Frm_Estadisticas";
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.Frm_Estadisticas_Load);
            this.Controls.SetChildIndex(this.gpb_ventasTotales, 0);
            this.Controls.SetChildIndex(this.gpb_datosCategoria, 0);
            this.Controls.SetChildIndex(this.gpb_totalGanancia, 0);
            this.Controls.SetChildIndex(this.btn_calcular, 0);
            this.gpb_ventasTotales.ResumeLayout(false);
            this.gpb_ventasTotales.PerformLayout();
            this.gpb_datosCategoria.ResumeLayout(false);
            this.gpb_datosCategoria.PerformLayout();
            this.gpb_totalGanancia.ResumeLayout(false);
            this.gpb_totalGanancia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gpb_ventasTotales;
        private TextBox txt_ventasTotales;
        private Label label1;
        private GroupBox gpb_datosCategoria;
        private Label label2;
        private TextBox txt_productoMasVendido;
        private Label label3;
        private TextBox txt_promedioDeGanancia;
        private Label label4;
        private ComboBox cmb_categoria;
        private GroupBox gpb_totalGanancia;
        private Label label5;
        private TextBox txt_totalGanancia;
        private Button btn_calcular;
    }
}