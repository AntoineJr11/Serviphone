namespace Serviphone
{
    partial class CLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLIENTES));
            this.buttonNUEVO = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonMODIFICAR = new System.Windows.Forms.Button();
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNIT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDPI = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxCorreo = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNUEVO
            // 
            this.buttonNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("buttonNUEVO.Image")));
            this.buttonNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNUEVO.Location = new System.Drawing.Point(18, 621);
            this.buttonNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNUEVO.Name = "buttonNUEVO";
            this.buttonNUEVO.Size = new System.Drawing.Size(186, 43);
            this.buttonNUEVO.TabIndex = 8;
            this.buttonNUEVO.Text = "NUEVO";
            this.buttonNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNUEVO.UseVisualStyleBackColor = true;
            this.buttonNUEVO.Click += new System.EventHandler(this.buttonNUEVO_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.Image")));
            this.buttonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar.Location = new System.Drawing.Point(689, 620);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(185, 43);
            this.buttonBorrar.TabIndex = 11;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonMODIFICAR
            // 
            this.buttonMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonMODIFICAR.Image")));
            this.buttonMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMODIFICAR.Location = new System.Drawing.Point(471, 621);
            this.buttonMODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMODIFICAR.Name = "buttonMODIFICAR";
            this.buttonMODIFICAR.Size = new System.Drawing.Size(185, 43);
            this.buttonMODIFICAR.TabIndex = 10;
            this.buttonMODIFICAR.Text = "ACTUALIZAR";
            this.buttonMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMODIFICAR.UseVisualStyleBackColor = true;
            this.buttonMODIFICAR.Click += new System.EventHandler(this.buttonMODIFICAR_Click);
            // 
            // dataGridProd
            // 
            this.dataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProd.Location = new System.Drawing.Point(18, 241);
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.RowTemplate.Height = 24;
            this.dataGridProd.Size = new System.Drawing.Size(856, 341);
            this.dataGridProd.TabIndex = 162;
            this.dataGridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellContentClick);
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Location = new System.Drawing.Point(264, 183);
            this.txtBoxApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(263, 22);
            this.txtBoxApellido.TabIndex = 4;
            this.txtBoxApellido.TextChanged += new System.EventHandler(this.txtBoxPrecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 158;
            this.label3.Text = "APELLIDO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBoxNIT
            // 
            this.txtBoxNIT.Location = new System.Drawing.Point(264, 106);
            this.txtBoxNIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNIT.Name = "txtBoxNIT";
            this.txtBoxNIT.Size = new System.Drawing.Size(263, 22);
            this.txtBoxNIT.TabIndex = 2;
            this.txtBoxNIT.TextChanged += new System.EventHandler(this.txtBoxCantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 156;
            this.label2.Text = "NUMERO FISCAL (NIT):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(264, 144);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(263, 22);
            this.txtBoxNombre.TabIndex = 3;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 154;
            this.label1.Text = "NOMBRE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxDPI
            // 
            this.txtBoxDPI.Location = new System.Drawing.Point(264, 66);
            this.txtBoxDPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDPI.Name = "txtBoxDPI";
            this.txtBoxDPI.Size = new System.Drawing.Size(263, 22);
            this.txtBoxDPI.TabIndex = 1;
            this.txtBoxDPI.TextChanged += new System.EventHandler(this.txtBoxDPI_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(-74, 83);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 19);
            this.label20.TabIndex = 152;
            this.label20.Text = "ID:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(12, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(335, 36);
            this.label21.TabIndex = 151;
            this.label21.Text = "REGISTRO DE CLIENTES";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(902, 529);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(159, 53);
            this.buttonSalir.TabIndex = 13;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRegresar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresar.Image")));
            this.buttonRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegresar.Location = new System.Drawing.Point(902, 443);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(159, 53);
            this.buttonRegresar.TabIndex = 12;
            this.buttonRegresar.Text = "REGRESAR";
            this.buttonRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(254, 621);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(185, 43);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 19);
            this.label5.TabIndex = 166;
            this.label5.Text = "NUMERO IDENTIFICACION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 160;
            this.label4.Text = "DIRECCION:";
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(752, 66);
            this.txtBoxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(263, 22);
            this.txtBoxDireccion.TabIndex = 5;
            this.txtBoxDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 168;
            this.label6.Text = "CORREO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 169;
            this.label7.Text = "TELEFONO:";
            // 
            // txtBoxCorreo
            // 
            this.txtBoxCorreo.Location = new System.Drawing.Point(752, 109);
            this.txtBoxCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCorreo.Name = "txtBoxCorreo";
            this.txtBoxCorreo.Size = new System.Drawing.Size(263, 22);
            this.txtBoxCorreo.TabIndex = 6;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(752, 147);
            this.txtBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(263, 22);
            this.txtBoxTelefono.TabIndex = 7;
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 713);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNUEVO);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonMODIFICAR);
            this.Controls.Add(this.dataGridProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxDPI);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "CLIENTES";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNUEVO;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonMODIFICAR;
        private System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDPI;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxCorreo;
        private System.Windows.Forms.TextBox txtBoxTelefono;
    }
}