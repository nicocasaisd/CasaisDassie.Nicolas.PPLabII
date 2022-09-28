namespace UI
{
    partial class Frm_ModificarProducto
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_nuevoPrecio = new System.Windows.Forms.TextBox();
            this.lbl_nuevoPrecio = new System.Windows.Forms.Label();
            this.lbl_precioAnterior = new System.Windows.Forms.Label();
            this.lbl_precioAnteriorContenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(157, 145);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_nuevoPrecio
            // 
            this.txt_nuevoPrecio.Location = new System.Drawing.Point(132, 85);
            this.txt_nuevoPrecio.Name = "txt_nuevoPrecio";
            this.txt_nuevoPrecio.Size = new System.Drawing.Size(100, 23);
            this.txt_nuevoPrecio.TabIndex = 2;
            // 
            // lbl_nuevoPrecio
            // 
            this.lbl_nuevoPrecio.AutoSize = true;
            this.lbl_nuevoPrecio.Location = new System.Drawing.Point(30, 88);
            this.lbl_nuevoPrecio.Name = "lbl_nuevoPrecio";
            this.lbl_nuevoPrecio.Size = new System.Drawing.Size(84, 15);
            this.lbl_nuevoPrecio.TabIndex = 3;
            this.lbl_nuevoPrecio.Text = "Nuevo precio: ";
            // 
            // lbl_precioAnterior
            // 
            this.lbl_precioAnterior.AutoSize = true;
            this.lbl_precioAnterior.Location = new System.Drawing.Point(31, 45);
            this.lbl_precioAnterior.Name = "lbl_precioAnterior";
            this.lbl_precioAnterior.Size = new System.Drawing.Size(90, 15);
            this.lbl_precioAnterior.TabIndex = 4;
            this.lbl_precioAnterior.Text = "Precio anterior: ";
            // 
            // lbl_precioAnteriorContenido
            // 
            this.lbl_precioAnteriorContenido.AutoSize = true;
            this.lbl_precioAnteriorContenido.Location = new System.Drawing.Point(142, 49);
            this.lbl_precioAnteriorContenido.Name = "lbl_precioAnteriorContenido";
            this.lbl_precioAnteriorContenido.Size = new System.Drawing.Size(38, 15);
            this.lbl_precioAnteriorContenido.TabIndex = 5;
            this.lbl_precioAnteriorContenido.Text = "label1";
            // 
            // Frm_ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 216);
            this.Controls.Add(this.lbl_precioAnteriorContenido);
            this.Controls.Add(this.lbl_precioAnterior);
            this.Controls.Add(this.lbl_nuevoPrecio);
            this.Controls.Add(this.txt_nuevoPrecio);
            this.Controls.Add(this.btn_aceptar);
            this.Name = "Frm_ModificarProducto";
            this.Text = "Frm_ModificarProducto";
            this.Load += new System.EventHandler(this.Frm_ModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_aceptar;
        private TextBox txt_nuevoPrecio;
        private Label lbl_nuevoPrecio;
        private Label lbl_precioAnterior;
        private Label lbl_precioAnteriorContenido;
    }
}