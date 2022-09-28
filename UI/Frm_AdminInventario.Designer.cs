namespace UI
{
    partial class Frm_AdminInventario
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
            this.grp_listaProductos = new System.Windows.Forms.GroupBox();
            this.lst_listaProductos = new System.Windows.Forms.ListBox();
            this.grp_descripcion = new System.Windows.Forms.GroupBox();
            this.lbl_idProducto = new System.Windows.Forms.Label();
            this.lbl_precioProducto = new System.Windows.Forms.Label();
            this.lbl_cantidadProducto = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_cambiarPrecio = new System.Windows.Forms.Button();
            this.grp_listaProductos.SuspendLayout();
            this.grp_descripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_listaProductos
            // 
            this.grp_listaProductos.Controls.Add(this.lst_listaProductos);
            this.grp_listaProductos.Location = new System.Drawing.Point(35, 53);
            this.grp_listaProductos.Name = "grp_listaProductos";
            this.grp_listaProductos.Size = new System.Drawing.Size(236, 324);
            this.grp_listaProductos.TabIndex = 0;
            this.grp_listaProductos.TabStop = false;
            this.grp_listaProductos.Text = "Lista de productos";
            // 
            // lst_listaProductos
            // 
            this.lst_listaProductos.FormattingEnabled = true;
            this.lst_listaProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lst_listaProductos.ItemHeight = 15;
            this.lst_listaProductos.Location = new System.Drawing.Point(20, 22);
            this.lst_listaProductos.Name = "lst_listaProductos";
            this.lst_listaProductos.Size = new System.Drawing.Size(187, 214);
            this.lst_listaProductos.TabIndex = 0;
            this.lst_listaProductos.SelectedIndexChanged += new System.EventHandler(this.lst_listaProductos_SelectedIndexChanged);
            // 
            // grp_descripcion
            // 
            this.grp_descripcion.Controls.Add(this.lbl_idProducto);
            this.grp_descripcion.Controls.Add(this.lbl_precioProducto);
            this.grp_descripcion.Controls.Add(this.lbl_cantidadProducto);
            this.grp_descripcion.Controls.Add(this.lbl_id);
            this.grp_descripcion.Controls.Add(this.lbl_precio);
            this.grp_descripcion.Controls.Add(this.lbl_cantidad);
            this.grp_descripcion.Location = new System.Drawing.Point(314, 53);
            this.grp_descripcion.Name = "grp_descripcion";
            this.grp_descripcion.Size = new System.Drawing.Size(200, 172);
            this.grp_descripcion.TabIndex = 1;
            this.grp_descripcion.TabStop = false;
            this.grp_descripcion.Text = "Descripcion";
            // 
            // lbl_idProducto
            // 
            this.lbl_idProducto.AutoSize = true;
            this.lbl_idProducto.Location = new System.Drawing.Point(96, 102);
            this.lbl_idProducto.Name = "lbl_idProducto";
            this.lbl_idProducto.Size = new System.Drawing.Size(38, 15);
            this.lbl_idProducto.TabIndex = 4;
            this.lbl_idProducto.Text = "label1";
            // 
            // lbl_precioProducto
            // 
            this.lbl_precioProducto.AutoSize = true;
            this.lbl_precioProducto.Location = new System.Drawing.Point(96, 62);
            this.lbl_precioProducto.Name = "lbl_precioProducto";
            this.lbl_precioProducto.Size = new System.Drawing.Size(38, 15);
            this.lbl_precioProducto.TabIndex = 3;
            this.lbl_precioProducto.Text = "label1";
            // 
            // lbl_cantidadProducto
            // 
            this.lbl_cantidadProducto.AutoSize = true;
            this.lbl_cantidadProducto.Location = new System.Drawing.Point(96, 28);
            this.lbl_cantidadProducto.Name = "lbl_cantidadProducto";
            this.lbl_cantidadProducto.Size = new System.Drawing.Size(38, 15);
            this.lbl_cantidadProducto.TabIndex = 2;
            this.lbl_cantidadProducto.Text = "label1";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_id.Location = new System.Drawing.Point(49, 97);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(35, 21);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID: ";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_precio.Location = new System.Drawing.Point(25, 57);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(59, 21);
            this.lbl_precio.TabIndex = 1;
            this.lbl_precio.Text = "Precio:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_cantidad.Location = new System.Drawing.Point(6, 22);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(84, 21);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Cantidad: ";
            // 
            // btn_cambiarPrecio
            // 
            this.btn_cambiarPrecio.Location = new System.Drawing.Point(431, 249);
            this.btn_cambiarPrecio.Name = "btn_cambiarPrecio";
            this.btn_cambiarPrecio.Size = new System.Drawing.Size(83, 50);
            this.btn_cambiarPrecio.TabIndex = 2;
            this.btn_cambiarPrecio.Text = "Cambiar Precio";
            this.btn_cambiarPrecio.UseVisualStyleBackColor = true;
            this.btn_cambiarPrecio.Click += new System.EventHandler(this.btn_cambiarPrecio_Click);
            // 
            // Frm_AdminInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cambiarPrecio);
            this.Controls.Add(this.grp_descripcion);
            this.Controls.Add(this.grp_listaProductos);
            this.Name = "Frm_AdminInventario";
            this.Text = "Frm_AdminInventario";
            this.Load += new System.EventHandler(this.Frm_AdminInventario_Load);
            this.grp_listaProductos.ResumeLayout(false);
            this.grp_descripcion.ResumeLayout(false);
            this.grp_descripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp_listaProductos;
        private ListBox lst_listaProductos;
        private GroupBox grp_descripcion;
        private Label lbl_precio;
        private Label lbl_cantidad;
        private Label lbl_id;
        private Label lbl_idProducto;
        private Label lbl_precioProducto;
        private Label lbl_cantidadProducto;
        private Button btn_cambiarPrecio;
    }
}