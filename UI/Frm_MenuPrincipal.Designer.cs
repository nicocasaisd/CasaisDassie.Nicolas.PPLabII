namespace UI
{
    partial class Frm_MenuPrincipal
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
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(106, 105);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(155, 120);
            this.btn_inventario.TabIndex = 0;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(394, 105);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(184, 120);
            this.btn_ventas.TabIndex = 1;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(62, 24);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(94, 40);
            this.lbl_nombreUsuario.TabIndex = 2;
            this.lbl_nombreUsuario.Text = "label1";
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_inventario);
            this.Name = "Frm_MenuPrincipal";
            this.Text = "Frm_MenuPrincipal";
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_inventario;
        private Button btn_ventas;
        private Label lbl_nombreUsuario;
    }
}