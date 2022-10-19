namespace UI
{
    partial class Frm_Base
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
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(8, 8);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(92, 24);
            this.btn_CerrarSesion.TabIndex = 4;
            this.btn_CerrarSesion.Text = "Cerrar sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            this.btn_CerrarSesion.Visible = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // Frm_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Name = "Frm_Base";
            this.Text = "Frm_Base";
            this.Load += new System.EventHandler(this.Frm_Base_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_CerrarSesion;
    }
}