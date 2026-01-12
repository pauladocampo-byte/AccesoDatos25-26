namespace Actividad6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbFutbolistaEquipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInsertarFutbolista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFutbolista = new System.Windows.Forms.TextBox();
            this.txtCodigoFutbolista = new System.Windows.Forms.TextBox();
            this.futbolDataSet = new Actividad6.FutbolDataSet();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Actividad6.FutbolDataSetTableAdapters.EquiposTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(26, 28);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(2);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(125, 290);
            this.lstProductos.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.cbFutbolistaEquipo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnInsertarFutbolista);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombreFutbolista);
            this.panel1.Controls.Add(this.txtCodigoFutbolista);
            this.panel1.Location = new System.Drawing.Point(247, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 191);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 8;
            // 
            // cbFutbolistaEquipo
            // 
            this.cbFutbolistaEquipo.FormattingEnabled = true;
            this.cbFutbolistaEquipo.Location = new System.Drawing.Point(86, 149);
            this.cbFutbolistaEquipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbFutbolistaEquipo.Name = "cbFutbolistaEquipo";
            this.cbFutbolistaEquipo.Size = new System.Drawing.Size(150, 21);
            this.cbFutbolistaEquipo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fabricante";
            // 
            // btnInsertarFutbolista
            // 
            this.btnInsertarFutbolista.Location = new System.Drawing.Point(409, 89);
            this.btnInsertarFutbolista.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertarFutbolista.Name = "btnInsertarFutbolista";
            this.btnInsertarFutbolista.Size = new System.Drawing.Size(146, 32);
            this.btnInsertarFutbolista.TabIndex = 5;
            this.btnInsertarFutbolista.Text = "INSERTAR";
            this.btnInsertarFutbolista.UseVisualStyleBackColor = true;
            this.btnInsertarFutbolista.Click += new System.EventHandler(this.btnInsertarFutbolista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "INSERTAR PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // txtNombreFutbolista
            // 
            this.txtNombreFutbolista.Location = new System.Drawing.Point(86, 84);
            this.txtNombreFutbolista.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreFutbolista.Name = "txtNombreFutbolista";
            this.txtNombreFutbolista.Size = new System.Drawing.Size(150, 20);
            this.txtNombreFutbolista.TabIndex = 1;
            // 
            // txtCodigoFutbolista
            // 
            this.txtCodigoFutbolista.Location = new System.Drawing.Point(86, 46);
            this.txtCodigoFutbolista.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoFutbolista.Name = "txtCodigoFutbolista";
            this.txtCodigoFutbolista.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoFutbolista.TabIndex = 0;
            // 
            // futbolDataSet
            // 
            this.futbolDataSet.DataSetName = "FutbolDataSet";
            this.futbolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.futbolDataSet;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstProductos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.futbolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertarFutbolista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreFutbolista;
        private System.Windows.Forms.TextBox txtCodigoFutbolista;
        private System.Windows.Forms.Label label7;
        private FutbolDataSet futbolDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private FutbolDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.ComboBox cbFutbolistaEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

