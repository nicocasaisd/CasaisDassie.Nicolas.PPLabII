﻿namespace UI
{
    partial class Frm_Factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_importeTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_medioDePago = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_nroDeFactura = new System.Windows.Forms.TextBox();
            this.txt_puntoDeVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe total:";
            // 
            // txt_importeTotal
            // 
            this.txt_importeTotal.Enabled = false;
            this.txt_importeTotal.Location = new System.Drawing.Point(704, 48);
            this.txt_importeTotal.Name = "txt_importeTotal";
            this.txt_importeTotal.Size = new System.Drawing.Size(100, 23);
            this.txt_importeTotal.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_importeTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 107);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_medioDePago);
            this.panel3.Controls.Add(this.txt_cliente);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(12, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 171);
            this.panel3.TabIndex = 3;
            // 
            // txt_medioDePago
            // 
            this.txt_medioDePago.Enabled = false;
            this.txt_medioDePago.Location = new System.Drawing.Point(136, 103);
            this.txt_medioDePago.Name = "txt_medioDePago";
            this.txt_medioDePago.Size = new System.Drawing.Size(226, 23);
            this.txt_medioDePago.TabIndex = 1;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(136, 19);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(226, 23);
            this.txt_cliente.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Medio de pago: ";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_fecha);
            this.panel4.Controls.Add(this.txt_nroDeFactura);
            this.panel4.Controls.Add(this.txt_puntoDeVenta);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(408, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(429, 171);
            this.panel4.TabIndex = 3;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(157, 106);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(232, 23);
            this.txt_fecha.TabIndex = 1;
            // 
            // txt_nroDeFactura
            // 
            this.txt_nroDeFactura.Enabled = false;
            this.txt_nroDeFactura.Location = new System.Drawing.Point(157, 66);
            this.txt_nroDeFactura.Name = "txt_nroDeFactura";
            this.txt_nroDeFactura.Size = new System.Drawing.Size(232, 23);
            this.txt_nroDeFactura.TabIndex = 1;
            // 
            // txt_puntoDeVenta
            // 
            this.txt_puntoDeVenta.Enabled = false;
            this.txt_puntoDeVenta.Location = new System.Drawing.Point(157, 24);
            this.txt_puntoDeVenta.Name = "txt_puntoDeVenta";
            this.txt_puntoDeVenta.Size = new System.Drawing.Size(232, 23);
            this.txt_puntoDeVenta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Factura nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de venta:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(213, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 58);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(83, -9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 65);
            this.label7.TabIndex = 0;
            this.label7.Text = "FACTURA";
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Factura";
            this.Load += new System.EventHandler(this.Frm_Factura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txt_importeTotal;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private TextBox txt_medioDePago;
        private TextBox txt_cliente;
        private TextBox txt_fecha;
        private TextBox txt_nroDeFactura;
        private TextBox txt_puntoDeVenta;
        private Panel panel2;
        private Label label7;
    }
}