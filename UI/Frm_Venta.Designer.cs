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
            this.SuspendLayout();
            // 
            // lst_carrito
            // 
            this.lst_carrito.FormattingEnabled = true;
            this.lst_carrito.ItemHeight = 15;
            this.lst_carrito.Location = new System.Drawing.Point(34, 163);
            this.lst_carrito.Name = "lst_carrito";
            this.lst_carrito.Size = new System.Drawing.Size(421, 184);
            this.lst_carrito.TabIndex = 0;
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.lst_carrito);
            this.Name = "Frm_Venta";
            this.Text = "Frm_Venta";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lst_carrito;
    }
}