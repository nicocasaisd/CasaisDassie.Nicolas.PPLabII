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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ModificarProducto));
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cantidadStock = new System.Windows.Forms.Label();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.nud_precio = new System.Windows.Forms.NumericUpDown();
            this.nud_cantidadStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(615, 153);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 0;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(27, 85);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(55, 23);
            this.txt_id.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(88, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 2;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(36, 55);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 15);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "ID";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(106, 55);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(201, 55);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(58, 15);
            this.lbl_categoria.TabIndex = 3;
            this.lbl_categoria.Text = "Categoría";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(309, 55);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(30, 15);
            this.lbl_tipo.TabIndex = 3;
            this.lbl_tipo.Text = "Tipo";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(438, 55);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 15);
            this.lbl_marca.TabIndex = 3;
            this.lbl_marca.Text = "Marca";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(514, 55);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(40, 15);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_cantidadStock
            // 
            this.lbl_cantidadStock.AutoSize = true;
            this.lbl_cantidadStock.Location = new System.Drawing.Point(636, 55);
            this.lbl_cantidadStock.Name = "lbl_cantidadStock";
            this.lbl_cantidadStock.Size = new System.Drawing.Size(36, 15);
            this.lbl_cantidadStock.TabIndex = 3;
            this.lbl_cantidadStock.Text = "Stock";
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(194, 85);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(92, 23);
            this.cmb_categoria.TabIndex = 4;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(292, 85);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(92, 23);
            this.cmb_tipo.TabIndex = 4;
            // 
            // cmb_marca
            // 
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(390, 85);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(92, 23);
            this.cmb_marca.TabIndex = 4;
            // 
            // nud_precio
            // 
            this.nud_precio.Location = new System.Drawing.Point(488, 86);
            this.nud_precio.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_precio.Name = "nud_precio";
            this.nud_precio.Size = new System.Drawing.Size(98, 23);
            this.nud_precio.TabIndex = 5;
            // 
            // nud_cantidadStock
            // 
            this.nud_cantidadStock.Location = new System.Drawing.Point(592, 86);
            this.nud_cantidadStock.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_cantidadStock.Name = "nud_cantidadStock";
            this.nud_cantidadStock.Size = new System.Drawing.Size(98, 23);
            this.nud_cantidadStock.TabIndex = 5;
            // 
            // Frm_ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 195);
            this.Controls.Add(this.nud_cantidadStock);
            this.Controls.Add(this.nud_precio);
            this.Controls.Add(this.cmb_marca);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.lbl_cantidadStock);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ModificarProducto";
            this.Load += new System.EventHandler(this.Frm_ModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidadStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_aceptar;
        private TextBox txt_id;
        private TextBox txt_nombre;
        private Label lbl_id;
        private Label lbl_nombre;
        private Label lbl_categoria;
        private Label lbl_tipo;
        private Label lbl_marca;
        private Label lbl_precio;
        private Label lbl_cantidadStock;
        private ComboBox cmb_categoria;
        private ComboBox cmb_tipo;
        private ComboBox cmb_marca;
        private NumericUpDown nud_precio;
        private NumericUpDown nud_cantidadStock;
    }
}