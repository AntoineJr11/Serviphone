namespace Serviphone
{
    partial class COMPRAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COMPRAS));
            this.label21 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.buttonMOSTRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(463, 36);
            this.label21.TabIndex = 153;
            this.label21.Text = "REPORTE DE PEDIDO DE COMPRAS";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(748, 620);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(159, 53);
            this.buttonSalir.TabIndex = 3;
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
            this.buttonRegresar.Location = new System.Drawing.Point(569, 620);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(159, 53);
            this.buttonRegresar.TabIndex = 2;
            this.buttonRegresar.Text = "REGRESAR";
            this.buttonRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(29, 70);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(878, 509);
            this.dgvCompras.TabIndex = 182;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentClick);
            // 
            // buttonMOSTRAR
            // 
            this.buttonMOSTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMOSTRAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonMOSTRAR.Image")));
            this.buttonMOSTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMOSTRAR.Location = new System.Drawing.Point(137, 620);
            this.buttonMOSTRAR.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMOSTRAR.Name = "buttonMOSTRAR";
            this.buttonMOSTRAR.Size = new System.Drawing.Size(246, 53);
            this.buttonMOSTRAR.TabIndex = 1;
            this.buttonMOSTRAR.Text = "GENERAR REPORTE";
            this.buttonMOSTRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMOSTRAR.UseVisualStyleBackColor = true;
            this.buttonMOSTRAR.Click += new System.EventHandler(this.buttonMOSTRAR_Click);
            // 
            // COMPRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 687);
            this.Controls.Add(this.buttonMOSTRAR);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.label21);
            this.Name = "COMPRAS";
            this.Text = "COMPRAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button buttonMOSTRAR;
    }
}