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
            this.grp_descripcion = new System.Windows.Forms.GroupBox();
            this.lbl_idProducto = new System.Windows.Forms.Label();
            this.lbl_precioProducto = new System.Windows.Forms.Label();
            this.lbl_cantidadProducto = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_SeleccionarProducto = new System.Windows.Forms.Button();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.btn_ModificarProducto = new System.Windows.Forms.Button();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.grp_descripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_descripcion
            // 
            this.grp_descripcion.Controls.Add(this.lbl_idProducto);
            this.grp_descripcion.Controls.Add(this.lbl_precioProducto);
            this.grp_descripcion.Controls.Add(this.lbl_cantidadProducto);
            this.grp_descripcion.Controls.Add(this.lbl_id);
            this.grp_descripcion.Controls.Add(this.lbl_precio);
            this.grp_descripcion.Controls.Add(this.lbl_cantidad);
            this.grp_descripcion.Location = new System.Drawing.Point(821, 373);
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
            // btn_SeleccionarProducto
            // 
            this.btn_SeleccionarProducto.Location = new System.Drawing.Point(603, 296);
            this.btn_SeleccionarProducto.Name = "btn_SeleccionarProducto";
            this.btn_SeleccionarProducto.Size = new System.Drawing.Size(149, 33);
            this.btn_SeleccionarProducto.TabIndex = 4;
            this.btn_SeleccionarProducto.Text = "Seleccionar producto";
            this.btn_SeleccionarProducto.UseVisualStyleBackColor = true;
            this.btn_SeleccionarProducto.Click += new System.EventHandler(this.btn_SeleccionarProducto_Click);
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.AllowUserToAddRows = false;
            this.dgv_listaProductos.AllowUserToDeleteRows = false;
            this.dgv_listaProductos.AllowUserToResizeColumns = false;
            this.dgv_listaProductos.AllowUserToResizeRows = false;
            this.dgv_listaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_listaProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Location = new System.Drawing.Point(12, 89);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.RowTemplate.Height = 25;
            this.dgv_listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaProductos.Size = new System.Drawing.Size(739, 201);
            this.dgv_listaProductos.TabIndex = 5;
            this.dgv_listaProductos.SelectionChanged += new System.EventHandler(this.dgv_listaProductos_SelectionChanged);
            // 
            // btn_ModificarProducto
            // 
            this.btn_ModificarProducto.Location = new System.Drawing.Point(307, 296);
            this.btn_ModificarProducto.Name = "btn_ModificarProducto";
            this.btn_ModificarProducto.Size = new System.Drawing.Size(142, 33);
            this.btn_ModificarProducto.TabIndex = 6;
            this.btn_ModificarProducto.Text = "Modificar producto";
            this.btn_ModificarProducto.UseVisualStyleBackColor = true;
            this.btn_ModificarProducto.Click += new System.EventHandler(this.btn_ModificarProducto_Click);
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(455, 296);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(142, 33);
            this.btn_AgregarProducto.TabIndex = 6;
            this.btn_AgregarProducto.Text = "Agregar producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // Frm_AdminInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 601);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.btn_ModificarProducto);
            this.Controls.Add(this.dgv_listaProductos);
            this.Controls.Add(this.btn_SeleccionarProducto);
            this.Controls.Add(this.grp_descripcion);
            this.Name = "Frm_AdminInventario";
            this.Text = "Frm_AdminInventario";
            this.Load += new System.EventHandler(this.Frm_AdminInventario_Load);
            this.grp_descripcion.ResumeLayout(false);
            this.grp_descripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox grp_descripcion;
        private Label lbl_precio;
        private Label lbl_cantidad;
        private Label lbl_id;
        private Label lbl_idProducto;
        private Label lbl_precioProducto;
        private Label lbl_cantidadProducto;
        private Button btn_SeleccionarProducto;
        private DataGridView dgv_listaProductos;
        private Button btn_ModificarProducto;
        private Button btn_AgregarProducto;
    }
}