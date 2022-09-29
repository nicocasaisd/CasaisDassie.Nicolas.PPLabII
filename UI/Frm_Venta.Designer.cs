namespace UI
{
    partial class Frm_Venta
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
            this.lst_carrito = new System.Windows.Forms.ListBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_detalle = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.gpb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_carrito
            // 
            this.lst_carrito.FormattingEnabled = true;
            this.lst_carrito.ItemHeight = 15;
            this.lst_carrito.Location = new System.Drawing.Point(34, 163);
            this.lst_carrito.Name = "lst_carrito";
            this.lst_carrito.Size = new System.Drawing.Size(513, 184);
            this.lst_carrito.TabIndex = 0;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(391, 368);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(472, 368);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(111, 369);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(50, 15);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Total    $";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(167, 366);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 23);
            this.txt_total.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(6, 28);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 5;
            this.lbl_codigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad";
            // 
            // gpb_detalle
            // 
            this.gpb_detalle.Controls.Add(this.nud_cantidad);
            this.gpb_detalle.Controls.Add(this.txt_codigo);
            this.gpb_detalle.Controls.Add(this.lbl_codigo);
            this.gpb_detalle.Controls.Add(this.label1);
            this.gpb_detalle.Location = new System.Drawing.Point(34, 57);
            this.gpb_detalle.Name = "gpb_detalle";
            this.gpb_detalle.Size = new System.Drawing.Size(288, 100);
            this.gpb_detalle.TabIndex = 7;
            this.gpb_detalle.TabStop = false;
            this.gpb_detalle.Text = "Detalle";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(77, 25);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 23);
            this.txt_codigo.TabIndex = 7;
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Location = new System.Drawing.Point(77, 63);
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(100, 23);
            this.nud_cantidad.TabIndex = 8;
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.gpb_detalle);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lst_carrito);
            this.Name = "Frm_Venta";
            this.Text = "Frm_Venta";
            this.gpb_detalle.ResumeLayout(false);
            this.gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lst_carrito;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_total;
        private TextBox txt_total;
        private Label lbl_codigo;
        private Label label1;
        private GroupBox gpb_detalle;
        private TextBox txt_codigo;
        private NumericUpDown nud_cantidad;
    }
}