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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inventario
            // 
            this.btn_inventario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.btn_ventas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ventas.Location = new System.Drawing.Point(348, 105);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(154, 120);
            this.btn_ventas.TabIndex = 1;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(12, 23);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(94, 40);
            this.lbl_nombreUsuario.TabIndex = 2;
            this.lbl_nombreUsuario.Text = "label1";
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 298);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_inventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MenuPrincipal";
            this.Text = "Menú principal";
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