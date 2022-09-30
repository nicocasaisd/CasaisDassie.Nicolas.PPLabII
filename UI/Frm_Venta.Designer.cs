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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_detalle = new System.Windows.Forms.GroupBox();
            this.llb_AgregarProducto = new System.Windows.Forms.LinkLabel();
            this.nud_cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.gpb_total = new System.Windows.Forms.GroupBox();
            this.lbl_medioDePago = new System.Windows.Forms.Label();
            this.cmb_medioDePago = new System.Windows.Forms.ComboBox();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.btn_RemoverProducto = new System.Windows.Forms.Button();
            this.gpb_datosFacturacion = new System.Windows.Forms.GroupBox();
            this.cmb_puntoDeVenta = new System.Windows.Forms.ComboBox();
            this.lbl_puntoDeVenta = new System.Windows.Forms.Label();
            this.txt_nroDeFactura = new System.Windows.Forms.TextBox();
            this.lbl_nroDeFactura = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.gpb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).BeginInit();
            this.gpb_total.SuspendLayout();
            this.gpb_datosFacturacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_carrito
            // 
            this.lst_carrito.FormattingEnabled = true;
            this.lst_carrito.ItemHeight = 15;
            this.lst_carrito.Location = new System.Drawing.Point(22, 229);
            this.lst_carrito.Name = "lst_carrito";
            this.lst_carrito.Size = new System.Drawing.Size(513, 184);
            this.lst_carrito.TabIndex = 0;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(453, 438);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(534, 438);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(269, 22);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(44, 15);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Total  $";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(319, 19);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 23);
            this.txt_total.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(6, 28);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(46, 15);
            this.lbl_codigo.TabIndex = 5;
            this.lbl_codigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad";
            // 
            // gpb_detalle
            // 
            this.gpb_detalle.Controls.Add(this.llb_AgregarProducto);
            this.gpb_detalle.Controls.Add(this.nud_cantidad);
            this.gpb_detalle.Controls.Add(this.txt_codigo);
            this.gpb_detalle.Controls.Add(this.lbl_codigo);
            this.gpb_detalle.Controls.Add(this.label1);
            this.gpb_detalle.Location = new System.Drawing.Point(22, 123);
            this.gpb_detalle.Name = "gpb_detalle";
            this.gpb_detalle.Size = new System.Drawing.Size(307, 100);
            this.gpb_detalle.TabIndex = 7;
            this.gpb_detalle.TabStop = false;
            this.gpb_detalle.Text = "Detalle";
            // 
            // llb_AgregarProducto
            // 
            this.llb_AgregarProducto.AutoSize = true;
            this.llb_AgregarProducto.Location = new System.Drawing.Point(182, 28);
            this.llb_AgregarProducto.Name = "llb_AgregarProducto";
            this.llb_AgregarProducto.Size = new System.Drawing.Size(119, 15);
            this.llb_AgregarProducto.TabIndex = 9;
            this.llb_AgregarProducto.TabStop = true;
            this.llb_AgregarProducto.Text = "Seleccionar producto";
            this.llb_AgregarProducto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_AgregarProducto_LinkClicked);
            // 
            // nud_cantidad
            // 
            this.nud_cantidad.Location = new System.Drawing.Point(77, 63);
            this.nud_cantidad.Name = "nud_cantidad";
            this.nud_cantidad.Size = new System.Drawing.Size(100, 23);
            this.nud_cantidad.TabIndex = 8;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(77, 25);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 23);
            this.txt_codigo.TabIndex = 7;
            // 
            // gpb_total
            // 
            this.gpb_total.Controls.Add(this.lbl_medioDePago);
            this.gpb_total.Controls.Add(this.cmb_medioDePago);
            this.gpb_total.Controls.Add(this.lbl_total);
            this.gpb_total.Controls.Add(this.txt_total);
            this.gpb_total.Location = new System.Drawing.Point(22, 419);
            this.gpb_total.Name = "gpb_total";
            this.gpb_total.Size = new System.Drawing.Size(425, 60);
            this.gpb_total.TabIndex = 8;
            this.gpb_total.TabStop = false;
            this.gpb_total.Text = "Total";
            // 
            // lbl_medioDePago
            // 
            this.lbl_medioDePago.AutoSize = true;
            this.lbl_medioDePago.Location = new System.Drawing.Point(30, 23);
            this.lbl_medioDePago.Name = "lbl_medioDePago";
            this.lbl_medioDePago.Size = new System.Drawing.Size(87, 15);
            this.lbl_medioDePago.TabIndex = 6;
            this.lbl_medioDePago.Text = "Medio de pago";
            // 
            // cmb_medioDePago
            // 
            this.cmb_medioDePago.FormattingEnabled = true;
            this.cmb_medioDePago.Location = new System.Drawing.Point(123, 20);
            this.cmb_medioDePago.Name = "cmb_medioDePago";
            this.cmb_medioDePago.Size = new System.Drawing.Size(109, 23);
            this.cmb_medioDePago.TabIndex = 5;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(341, 143);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_AgregarProducto.TabIndex = 9;
            this.btn_AgregarProducto.Text = "Agregar";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btn_RemoverProducto
            // 
            this.btn_RemoverProducto.Location = new System.Drawing.Point(341, 181);
            this.btn_RemoverProducto.Name = "btn_RemoverProducto";
            this.btn_RemoverProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoverProducto.TabIndex = 10;
            this.btn_RemoverProducto.Text = "Quitar";
            this.btn_RemoverProducto.UseVisualStyleBackColor = true;
            // 
            // gpb_datosFacturacion
            // 
            this.gpb_datosFacturacion.Controls.Add(this.cmb_puntoDeVenta);
            this.gpb_datosFacturacion.Controls.Add(this.lbl_puntoDeVenta);
            this.gpb_datosFacturacion.Controls.Add(this.txt_nroDeFactura);
            this.gpb_datosFacturacion.Controls.Add(this.lbl_nroDeFactura);
            this.gpb_datosFacturacion.Controls.Add(this.dtp_fecha);
            this.gpb_datosFacturacion.Controls.Add(this.lbl_fecha);
            this.gpb_datosFacturacion.Controls.Add(this.lbl_nombreCliente);
            this.gpb_datosFacturacion.Controls.Add(this.txt_nombreCliente);
            this.gpb_datosFacturacion.Location = new System.Drawing.Point(27, 12);
            this.gpb_datosFacturacion.Name = "gpb_datosFacturacion";
            this.gpb_datosFacturacion.Size = new System.Drawing.Size(508, 92);
            this.gpb_datosFacturacion.TabIndex = 11;
            this.gpb_datosFacturacion.TabStop = false;
            this.gpb_datosFacturacion.Text = "Datos de facturación";
            // 
            // cmb_puntoDeVenta
            // 
            this.cmb_puntoDeVenta.FormattingEnabled = true;
            this.cmb_puntoDeVenta.Items.AddRange(new object[] {
            "Alem 723"});
            this.cmb_puntoDeVenta.Location = new System.Drawing.Point(332, 17);
            this.cmb_puntoDeVenta.Name = "cmb_puntoDeVenta";
            this.cmb_puntoDeVenta.Size = new System.Drawing.Size(158, 23);
            this.cmb_puntoDeVenta.TabIndex = 7;
            // 
            // lbl_puntoDeVenta
            // 
            this.lbl_puntoDeVenta.AutoSize = true;
            this.lbl_puntoDeVenta.Location = new System.Drawing.Point(218, 25);
            this.lbl_puntoDeVenta.Name = "lbl_puntoDeVenta";
            this.lbl_puntoDeVenta.Size = new System.Drawing.Size(87, 15);
            this.lbl_puntoDeVenta.TabIndex = 6;
            this.lbl_puntoDeVenta.Text = "Punto de venta";
            // 
            // txt_nroDeFactura
            // 
            this.txt_nroDeFactura.Enabled = false;
            this.txt_nroDeFactura.Location = new System.Drawing.Point(332, 53);
            this.txt_nroDeFactura.Name = "txt_nroDeFactura";
            this.txt_nroDeFactura.Size = new System.Drawing.Size(156, 23);
            this.txt_nroDeFactura.TabIndex = 5;
            // 
            // lbl_nroDeFactura
            // 
            this.lbl_nroDeFactura.AutoSize = true;
            this.lbl_nroDeFactura.Location = new System.Drawing.Point(219, 56);
            this.lbl_nroDeFactura.Name = "lbl_nroDeFactura";
            this.lbl_nroDeFactura.Size = new System.Drawing.Size(107, 15);
            this.lbl_nroDeFactura.TabIndex = 4;
            this.lbl_nroDeFactura.Text = "Número de factura";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(72, 56);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(100, 23);
            this.dtp_fecha.TabIndex = 3;
            this.dtp_fecha.Value = new System.DateTime(2022, 9, 30, 10, 20, 10, 0);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(18, 62);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(38, 15);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(18, 25);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(44, 15);
            this.lbl_nombreCliente.TabIndex = 1;
            this.lbl_nombreCliente.Text = "Cliente";
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(72, 22);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(114, 23);
            this.txt_nombreCliente.TabIndex = 0;
            this.txt_nombreCliente.Text = "Consumidor Final";
            // 
            // Frm_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 495);
            this.Controls.Add(this.gpb_datosFacturacion);
            this.Controls.Add(this.btn_RemoverProducto);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.gpb_total);
            this.Controls.Add(this.gpb_detalle);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lst_carrito);
            this.Name = "Frm_Venta";
            this.Text = "Frm_Venta";
            this.Load += new System.EventHandler(this.Frm_Venta_Load);
            this.gpb_detalle.ResumeLayout(false);
            this.gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantidad)).EndInit();
            this.gpb_total.ResumeLayout(false);
            this.gpb_total.PerformLayout();
            this.gpb_datosFacturacion.ResumeLayout(false);
            this.gpb_datosFacturacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lst_carrito;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_total;
        private TextBox txt_total;
        private Label lbl_codigo;
        private Label label1;
        private GroupBox gpb_detalle;
        private TextBox txt_codigo;
        private NumericUpDown nud_cantidad;
        private LinkLabel llb_AgregarProducto;
        private GroupBox gpb_total;
        private ComboBox cmb_medioDePago;
        private Label lbl_medioDePago;
        private Button btn_AgregarProducto;
        private Button btn_RemoverProducto;
        private GroupBox gpb_datosFacturacion;
        private Label lbl_nombreCliente;
        private TextBox txt_nombreCliente;
        private Label lbl_fecha;
        private DateTimePicker dtp_fecha;
        private TextBox txt_nroDeFactura;
        private Label lbl_nroDeFactura;
        private Label lbl_puntoDeVenta;
        private ComboBox cmb_puntoDeVenta;
    }
}