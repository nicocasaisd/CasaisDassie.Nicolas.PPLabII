namespace UI
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_AutoCompletarDuenio = new System.Windows.Forms.Button();
            this.btn_AutoCompletarVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(167, 176);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(97, 35);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(167, 65);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "Ingrese su contraseña";
            this.txt_password.Size = new System.Drawing.Size(129, 23);
            this.txt_password.TabIndex = 1;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(167, 25);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "Ingrese su email";
            this.txt_usuario.Size = new System.Drawing.Size(129, 23);
            this.txt_usuario.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(111, 33);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(50, 15);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(91, 68);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(70, 15);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Contraseña:";
            // 
            // btn_AutoCompletarDuenio
            // 
            this.btn_AutoCompletarDuenio.Location = new System.Drawing.Point(126, 112);
            this.btn_AutoCompletarDuenio.Name = "btn_AutoCompletarDuenio";
            this.btn_AutoCompletarDuenio.Size = new System.Drawing.Size(75, 45);
            this.btn_AutoCompletarDuenio.TabIndex = 5;
            this.btn_AutoCompletarDuenio.Text = "Completar Dueño";
            this.btn_AutoCompletarDuenio.UseVisualStyleBackColor = true;
            this.btn_AutoCompletarDuenio.Click += new System.EventHandler(this.btn_AutoCompletarDuenio_Click);
            // 
            // btn_AutoCompletarVendedor
            // 
            this.btn_AutoCompletarVendedor.Location = new System.Drawing.Point(221, 112);
            this.btn_AutoCompletarVendedor.Name = "btn_AutoCompletarVendedor";
            this.btn_AutoCompletarVendedor.Size = new System.Drawing.Size(75, 47);
            this.btn_AutoCompletarVendedor.TabIndex = 6;
            this.btn_AutoCompletarVendedor.Text = "Completar Vendedor";
            this.btn_AutoCompletarVendedor.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 251);
            this.Controls.Add(this.btn_AutoCompletarVendedor);
            this.Controls.Add(this.btn_AutoCompletarDuenio);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_ingresar);
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ingresar;
        private TextBox txt_password;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private Label lbl_password;
        private Button btn_AutoCompletarDuenio;
        private Button btn_AutoCompletarVendedor;
    }
}