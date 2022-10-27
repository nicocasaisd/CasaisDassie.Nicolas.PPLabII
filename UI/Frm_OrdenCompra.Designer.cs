namespace UI
{
    partial class Frm_OrdenCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_listaProveedores = new System.Windows.Forms.ComboBox();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_comprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cmb_listaProveedores
            // 
            this.cmb_listaProveedores.FormattingEnabled = true;
            this.cmb_listaProveedores.Location = new System.Drawing.Point(49, 116);
            this.cmb_listaProveedores.Name = "cmb_listaProveedores";
            this.cmb_listaProveedores.Size = new System.Drawing.Size(139, 23);
            this.cmb_listaProveedores.TabIndex = 1;
            this.cmb_listaProveedores.SelectedIndexChanged += new System.EventHandler(this.cmb_listaProveedores_SelectedIndexChanged);
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.AllowUserToAddRows = false;
            this.dgv_listaProductos.AllowUserToDeleteRows = false;
            this.dgv_listaProductos.AllowUserToResizeColumns = false;
            this.dgv_listaProductos.AllowUserToResizeRows = false;
            this.dgv_listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listaProductos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Location = new System.Drawing.Point(49, 171);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.ReadOnly = true;
            this.dgv_listaProductos.RowTemplate.Height = 25;
            this.dgv_listaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listaProductos.Size = new System.Drawing.Size(739, 201);
            this.dgv_listaProductos.TabIndex = 6;
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Location = new System.Drawing.Point(376, 406);
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(120, 23);
            this.nud_cantidad.TabIndex = 7;
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(580, 407);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_comprar.TabIndex = 8;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            // 
            // Frm_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.nud_cantidad);
            this.Controls.Add(this.dgv_listaProductos);
            this.Controls.Add(this.cmb_listaProveedores);
            this.Controls.Add(this.label1);
            this.Name = "Frm_OrdenCompra";
            this.Text = "Frm_OrdenCompra";
            this.Load += new System.EventHandler(this.Frm_OrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmb_listaProveedores;
        private DataGridView dgv_listaProductos;
        private NumericUpDown nud_cantidad;
        private Button btn_comprar;
    }
}