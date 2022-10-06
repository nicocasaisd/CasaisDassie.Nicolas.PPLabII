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
            this.btn_SeleccionarProducto = new System.Windows.Forms.Button();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.btn_ModificarProducto = new System.Windows.Forms.Button();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            this.SuspendLayout();
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
            this.ClientSize = new System.Drawing.Size(761, 337);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.btn_ModificarProducto);
            this.Controls.Add(this.dgv_listaProductos);
            this.Controls.Add(this.btn_SeleccionarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_AdminInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdminInventario";
            this.Load += new System.EventHandler(this.Frm_AdminInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_SeleccionarProducto;
        private DataGridView dgv_listaProductos;
        private Button btn_ModificarProducto;
        private Button btn_AgregarProducto;
    }
}