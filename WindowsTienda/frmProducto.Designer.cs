namespace WindowsTienda
{
    partial class frmProducto
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtEstacion = new System.Windows.Forms.TextBox();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCaracteristica = new System.Windows.Forms.TextBox();
            this.txtCantidadInicial = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPrecioEfectivo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCaracteristica = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblEstacion = new System.Windows.Forms.Label();
            this.lblCantidadEnStock = new System.Windows.Forms.Label();
            this.lblCantidadInicial = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblPrecioEfectivo = new System.Windows.Forms.Label();
            this.lblTalle = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPrecioLista = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblPrecioLista = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(139, 61);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(142, 20);
            this.txtTipo.TabIndex = 1;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(139, 87);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(142, 20);
            this.txtSexo.TabIndex = 2;
            // 
            // txtEstacion
            // 
            this.txtEstacion.Location = new System.Drawing.Point(139, 113);
            this.txtEstacion.Name = "txtEstacion";
            this.txtEstacion.Size = new System.Drawing.Size(142, 20);
            this.txtEstacion.TabIndex = 3;
            // 
            // txtTalle
            // 
            this.txtTalle.Location = new System.Drawing.Point(139, 139);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.Size = new System.Drawing.Size(142, 20);
            this.txtTalle.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(139, 165);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(142, 20);
            this.txtCategoria.TabIndex = 5;
            // 
            // txtCaracteristica
            // 
            this.txtCaracteristica.Location = new System.Drawing.Point(139, 191);
            this.txtCaracteristica.Name = "txtCaracteristica";
            this.txtCaracteristica.Size = new System.Drawing.Size(142, 20);
            this.txtCaracteristica.TabIndex = 6;
            // 
            // txtCantidadInicial
            // 
            this.txtCantidadInicial.Location = new System.Drawing.Point(139, 217);
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.Size = new System.Drawing.Size(142, 20);
            this.txtCantidadInicial.TabIndex = 7;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Location = new System.Drawing.Point(139, 243);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(142, 20);
            this.txtCantidadStock.TabIndex = 8;
            this.txtCantidadStock.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(139, 269);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(142, 20);
            this.txtPrecioCosto.TabIndex = 9;
            // 
            // txtPrecioEfectivo
            // 
            this.txtPrecioEfectivo.Location = new System.Drawing.Point(139, 295);
            this.txtPrecioEfectivo.Name = "txtPrecioEfectivo";
            this.txtPrecioEfectivo.Size = new System.Drawing.Size(142, 20);
            this.txtPrecioEfectivo.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(38, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCaracteristica
            // 
            this.lblCaracteristica.AutoSize = true;
            this.lblCaracteristica.Location = new System.Drawing.Point(38, 191);
            this.lblCaracteristica.Name = "lblCaracteristica";
            this.lblCaracteristica.Size = new System.Drawing.Size(73, 13);
            this.lblCaracteristica.TabIndex = 12;
            this.lblCaracteristica.Text = "Característica";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(38, 165);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblIdCategoria.TabIndex = 13;
            this.lblIdCategoria.Text = "Categorìa";
            // 
            // lblEstacion
            // 
            this.lblEstacion.AutoSize = true;
            this.lblEstacion.Location = new System.Drawing.Point(38, 116);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(48, 13);
            this.lblEstacion.TabIndex = 14;
            this.lblEstacion.Text = "Estación";
            // 
            // lblCantidadEnStock
            // 
            this.lblCantidadEnStock.AutoSize = true;
            this.lblCantidadEnStock.Location = new System.Drawing.Point(38, 246);
            this.lblCantidadEnStock.Name = "lblCantidadEnStock";
            this.lblCantidadEnStock.Size = new System.Drawing.Size(95, 13);
            this.lblCantidadEnStock.TabIndex = 15;
            this.lblCantidadEnStock.Text = "Cantidad en Stock";
            // 
            // lblCantidadInicial
            // 
            this.lblCantidadInicial.AutoSize = true;
            this.lblCantidadInicial.Location = new System.Drawing.Point(38, 217);
            this.lblCantidadInicial.Name = "lblCantidadInicial";
            this.lblCantidadInicial.Size = new System.Drawing.Size(79, 13);
            this.lblCantidadInicial.TabIndex = 16;
            this.lblCantidadInicial.Text = "Cantidad Inicial";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(38, 272);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(67, 13);
            this.lblPrecioCosto.TabIndex = 18;
            this.lblPrecioCosto.Text = "Precio Costo";
            // 
            // lblPrecioEfectivo
            // 
            this.lblPrecioEfectivo.AutoSize = true;
            this.lblPrecioEfectivo.Location = new System.Drawing.Point(38, 298);
            this.lblPrecioEfectivo.Name = "lblPrecioEfectivo";
            this.lblPrecioEfectivo.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioEfectivo.TabIndex = 19;
            this.lblPrecioEfectivo.Text = "Precio Efectivo";
            // 
            // lblTalle
            // 
            this.lblTalle.AutoSize = true;
            this.lblTalle.Location = new System.Drawing.Point(38, 142);
            this.lblTalle.Name = "lblTalle";
            this.lblTalle.Size = new System.Drawing.Size(30, 13);
            this.lblTalle.TabIndex = 20;
            this.lblTalle.Text = "Talle";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(38, 90);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 21;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(38, 61);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo";
            // 
            // txtPrecioLista
            // 
            this.txtPrecioLista.Location = new System.Drawing.Point(139, 321);
            this.txtPrecioLista.Name = "txtPrecioLista";
            this.txtPrecioLista.Size = new System.Drawing.Size(142, 20);
            this.txtPrecioLista.TabIndex = 23;
            this.txtPrecioLista.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(139, 347);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(142, 20);
            this.txtNotas.TabIndex = 24;
            // 
            // lblPrecioLista
            // 
            this.lblPrecioLista.AutoSize = true;
            this.lblPrecioLista.Location = new System.Drawing.Point(38, 324);
            this.lblPrecioLista.Name = "lblPrecioLista";
            this.lblPrecioLista.Size = new System.Drawing.Size(62, 13);
            this.lblPrecioLista.TabIndex = 25;
            this.lblPrecioLista.Text = "Precio Lista";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(38, 350);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(35, 13);
            this.lblNotas.TabIndex = 26;
            this.lblNotas.Text = "Notas";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(41, 390);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 446);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblPrecioLista);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.txtPrecioLista);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTalle);
            this.Controls.Add(this.lblPrecioEfectivo);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.lblCantidadInicial);
            this.Controls.Add(this.lblCantidadEnStock);
            this.Controls.Add(this.lblEstacion);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.lblCaracteristica);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtPrecioEfectivo);
            this.Controls.Add(this.txtPrecioCosto);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtCantidadInicial);
            this.Controls.Add(this.txtCaracteristica);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtTalle);
            this.Controls.Add(this.txtEstacion);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmProducto";
            this.Text = "Form Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtEstacion;
        private System.Windows.Forms.TextBox txtTalle;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCaracteristica;
        private System.Windows.Forms.TextBox txtCantidadInicial;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtPrecioEfectivo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCaracteristica;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblEstacion;
        private System.Windows.Forms.Label lblCantidadEnStock;
        private System.Windows.Forms.Label lblCantidadInicial;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblPrecioEfectivo;
        private System.Windows.Forms.Label lblTalle;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPrecioLista;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblPrecioLista;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}