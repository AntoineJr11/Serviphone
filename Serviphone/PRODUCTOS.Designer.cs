namespace Serviphone
{
    partial class PRODUCTOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PRODUCTOS));
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridProd = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonMODIFICAR = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonNUEVO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(255, 615);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(185, 43);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonRegresar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegresar.Image")));
            this.buttonRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRegresar.Location = new System.Drawing.Point(903, 437);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(159, 53);
            this.buttonRegresar.TabIndex = 10;
            this.buttonRegresar.Text = "REGRESAR";
            this.buttonRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(903, 523);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(159, 53);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(351, 36);
            this.label21.TabIndex = 133;
            this.label21.Text = "REGISTRO DE PRODUCTOS";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(177, 57);
            this.txtBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(263, 22);
            this.txtBoxId.TabIndex = 1;
            this.txtBoxId.TextChanged += new System.EventHandler(this.txtBoxId_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 60);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 19);
            this.label20.TabIndex = 134;
            this.label20.Text = "ID:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(612, 59);
            this.txtBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(263, 22);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 136;
            this.label1.Text = "NOMBRE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(177, 111);
            this.txtBoxMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(263, 22);
            this.txtBoxMarca.TabIndex = 3;
            this.txtBoxMarca.TextChanged += new System.EventHandler(this.txtBoxCantidad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 138;
            this.label2.Text = "MARCA:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(612, 114);
            this.txtBoxPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(263, 22);
            this.txtBoxPrecio.TabIndex = 4;
            this.txtBoxPrecio.TextChanged += new System.EventHandler(this.txtBoxPrecio_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 140;
            this.label3.Text = "PRECIO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridProd
            // 
            this.dataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProd.Location = new System.Drawing.Point(19, 226);
            this.dataGridProd.Name = "dataGridProd";
            this.dataGridProd.RowTemplate.Height = 24;
            this.dataGridProd.Size = new System.Drawing.Size(856, 350);
            this.dataGridProd.TabIndex = 144;
            this.dataGridProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProd_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 142;
            this.label4.Text = "ESTATUS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.comboBoxStatus.Location = new System.Drawing.Point(177, 163);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(263, 24);
            this.comboBoxStatus.TabIndex = 5;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // buttonMODIFICAR
            // 
            this.buttonMODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonMODIFICAR.Image")));
            this.buttonMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMODIFICAR.Location = new System.Drawing.Point(472, 615);
            this.buttonMODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMODIFICAR.Name = "buttonMODIFICAR";
            this.buttonMODIFICAR.Size = new System.Drawing.Size(185, 43);
            this.buttonMODIFICAR.TabIndex = 8;
            this.buttonMODIFICAR.Text = "ACTUALIZAR";
            this.buttonMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMODIFICAR.UseVisualStyleBackColor = true;
            this.buttonMODIFICAR.Click += new System.EventHandler(this.buttonMODIFICAR_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.Image")));
            this.buttonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar.Location = new System.Drawing.Point(690, 614);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(185, 43);
            this.buttonBorrar.TabIndex = 9;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonNUEVO
            // 
            this.buttonNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("buttonNUEVO.Image")));
            this.buttonNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNUEVO.Location = new System.Drawing.Point(19, 615);
            this.buttonNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNUEVO.Name = "buttonNUEVO";
            this.buttonNUEVO.Size = new System.Drawing.Size(185, 43);
            this.buttonNUEVO.TabIndex = 6;
            this.buttonNUEVO.Text = "NUEVO";
            this.buttonNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNUEVO.UseVisualStyleBackColor = true;
            this.buttonNUEVO.Click += new System.EventHandler(this.buttonNUEVO_Click);
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1075, 691);
            this.Controls.Add(this.buttonNUEVO);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonMODIFICAR);
            this.Controls.Add(this.dataGridProd);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.buttonGuardar);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.PRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonMODIFICAR;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonNUEVO;
    }
}