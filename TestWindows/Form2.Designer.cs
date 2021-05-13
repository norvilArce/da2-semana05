
namespace TestWindows
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.Num_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_ven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFF = new System.Windows.Forms.DateTimePicker();
            this.dtpFI = new System.Windows.Forms.DateTimePicker();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRUC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_fac,
            this.Fec_fac,
            this.Fec_can,
            this.Nom_ven,
            this.Ape_ven,
            this.Total,
            this.Estado});
            this.dtgDatos.Location = new System.Drawing.Point(12, 151);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(1184, 258);
            this.dtgDatos.TabIndex = 14;
            // 
            // Num_fac
            // 
            this.Num_fac.DataPropertyName = "Num_fac";
            this.Num_fac.HeaderText = "Nro. Factura";
            this.Num_fac.Name = "Num_fac";
            this.Num_fac.ReadOnly = true;
            // 
            // Fec_fac
            // 
            this.Fec_fac.DataPropertyName = "Fec_fac";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Fec_fac.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fec_fac.HeaderText = "Fec. factura";
            this.Fec_fac.Name = "Fec_fac";
            this.Fec_fac.ReadOnly = true;
            // 
            // Fec_can
            // 
            this.Fec_can.DataPropertyName = "Fec_can";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "d";
            this.Fec_can.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fec_can.HeaderText = "Fec. Cancelacion";
            this.Fec_can.Name = "Fec_can";
            this.Fec_can.ReadOnly = true;
            // 
            // Nom_ven
            // 
            this.Nom_ven.DataPropertyName = "Nom_Ven";
            this.Nom_ven.HeaderText = "Nombre vend.";
            this.Nom_ven.Name = "Nom_ven";
            this.Nom_ven.ReadOnly = true;
            // 
            // Ape_ven
            // 
            this.Ape_ven.DataPropertyName = "Ape_ven";
            this.Ape_ven.HeaderText = "Apellido vend.";
            this.Ape_ven.Name = "Ape_ven";
            this.Ape_ven.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total (S/.)";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(764, 27);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFF
            // 
            this.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFF.Location = new System.Drawing.Point(571, 26);
            this.dtpFF.Name = "dtpFF";
            this.dtpFF.Size = new System.Drawing.Size(109, 20);
            this.dtpFF.TabIndex = 11;
            // 
            // dtpFI
            // 
            this.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFI.Location = new System.Drawing.Point(346, 27);
            this.dtpFI.Name = "dtpFI";
            this.dtpFI.Size = new System.Drawing.Size(109, 20);
            this.dtpFI.TabIndex = 12;
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(1143, 422);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(53, 19);
            this.lblRegistros.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1083, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "F. Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "F. Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese codigo cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Razon social:";
            // 
            // lblRS
            // 
            this.lblRS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRS.Location = new System.Drawing.Point(93, 63);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(278, 19);
            this.lblRS.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "RUC:";
            // 
            // lblRUC
            // 
            this.lblRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRUC.Location = new System.Drawing.Point(431, 66);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(145, 19);
            this.lblRUC.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Direccion";
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDir.Location = new System.Drawing.Point(673, 68);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(295, 19);
            this.lblDir.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(163, 26);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Departamento:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepartamento.Location = new System.Drawing.Point(93, 94);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(278, 19);
            this.lblDepartamento.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(391, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Provincia:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProvincia.Location = new System.Drawing.Point(468, 94);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(278, 19);
            this.lblProvincia.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(793, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Distrito:";
            // 
            // lblDistrito
            // 
            this.lblDistrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistrito.Location = new System.Drawing.Point(838, 93);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(278, 19);
            this.lblDistrito.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Deuda:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuda.Location = new System.Drawing.Point(93, 124);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(145, 19);
            this.lblDeuda.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFF);
            this.Controls.Add(this.dtpFI);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRUC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Test de facturacion de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFF;
        private System.Windows.Forms.DateTimePicker dtpFI;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_can;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_ven;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDeuda;
    }
}