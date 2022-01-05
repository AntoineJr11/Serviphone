namespace Serviphone
{
    partial class EXISTENCIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXISTENCIA));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridViewExistencia = new System.Windows.Forms.DataGridView();
            this.dataGridViewMov = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalir.Location = new System.Drawing.Point(802, 634);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(159, 53);
            this.buttonSalir.TabIndex = 5;
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
            this.buttonRegresar.Location = new System.Drawing.Point(599, 634);
            this.buttonRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(159, 53);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "REGRESAR";
            this.buttonRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(45, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(367, 36);
            this.label21.TabIndex = 154;
            this.label21.Text = "REPORTE DE EXISTENCIAS";
            // 
            // dataGridViewExistencia
            // 
            this.dataGridViewExistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewExistencia.Location = new System.Drawing.Point(38, 70);
            this.dataGridViewExistencia.Name = "dataGridViewExistencia";
            this.dataGridViewExistencia.RowTemplate.Height = 24;
            this.dataGridViewExistencia.Size = new System.Drawing.Size(874, 521);
            this.dataGridViewExistencia.TabIndex = 155;
            this.dataGridViewExistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewMov
            // 
            this.dataGridViewMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMov.Location = new System.Drawing.Point(38, 614);
            this.dataGridViewMov.Name = "dataGridViewMov";
            this.dataGridViewMov.RowTemplate.Height = 24;
            this.dataGridViewMov.Size = new System.Drawing.Size(197, 53);
            this.dataGridViewMov.TabIndex = 156;
            this.dataGridViewMov.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            // 
            // EXISTENCIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 700);
            this.Controls.Add(this.dataGridViewMov);
            this.Controls.Add(this.dataGridViewExistencia);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonRegresar);
            this.Name = "EXISTENCIA";
            this.Text = "EXISTENCIA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridViewExistencia;
        private System.Windows.Forms.DataGridView dataGridViewMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}