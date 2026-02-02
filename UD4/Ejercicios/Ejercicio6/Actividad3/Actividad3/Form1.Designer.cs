namespace Actividad3
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
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstFabricantes = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFabricanteSeleccionado = new System.Windows.Forms.ComboBox();
            this.lblInsertarActualizarProductos = new System.Windows.Forms.Label();
            this.btnInsertarActualizarProducto = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInsertarActualizarFabricantes = new System.Windows.Forms.Label();
            this.btnInsertarActualizarFabricante = new System.Windows.Forms.Button();
            this.txtNombreFabricante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoFabricante = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEditarFabricante = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnBorrarFabricante = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 16;
            this.lstProductos.Location = new System.Drawing.Point(27, 165);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(214, 132);
            this.lstProductos.TabIndex = 1;
            this.lstProductos.DoubleClick += new System.EventHandler(this.lstProductos_DoubleClick);
            // 
            // lstFabricantes
            // 
            this.lstFabricantes.FormattingEnabled = true;
            this.lstFabricantes.ItemHeight = 16;
            this.lstFabricantes.Location = new System.Drawing.Point(276, 165);
            this.lstFabricantes.Name = "lstFabricantes";
            this.lstFabricantes.Size = new System.Drawing.Size(204, 132);
            this.lstFabricantes.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbFabricanteSeleccionado);
            this.panel1.Controls.Add(this.lblInsertarActualizarProductos);
            this.panel1.Controls.Add(this.btnInsertarActualizarProducto);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(532, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 357);
            this.panel1.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Fabricante";
            // 
            // cbFabricanteSeleccionado
            // 
            this.cbFabricanteSeleccionado.FormattingEnabled = true;
            this.cbFabricanteSeleccionado.Location = new System.Drawing.Point(121, 303);
            this.cbFabricanteSeleccionado.Name = "cbFabricanteSeleccionado";
            this.cbFabricanteSeleccionado.Size = new System.Drawing.Size(145, 24);
            this.cbFabricanteSeleccionado.TabIndex = 10;
            // 
            // lblInsertarActualizarProductos
            // 
            this.lblInsertarActualizarProductos.AutoSize = true;
            this.lblInsertarActualizarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertarActualizarProductos.Location = new System.Drawing.Point(75, 15);
            this.lblInsertarActualizarProductos.Name = "lblInsertarActualizarProductos";
            this.lblInsertarActualizarProductos.Size = new System.Drawing.Size(280, 38);
            this.lblInsertarActualizarProductos.TabIndex = 4;
            this.lblInsertarActualizarProductos.Text = "Insertar productos";
            // 
            // btnInsertarActualizarProducto
            // 
            this.btnInsertarActualizarProducto.Location = new System.Drawing.Point(286, 213);
            this.btnInsertarActualizarProducto.Name = "btnInsertarActualizarProducto";
            this.btnInsertarActualizarProducto.Size = new System.Drawing.Size(114, 47);
            this.btnInsertarActualizarProducto.TabIndex = 4;
            this.btnInsertarActualizarProducto.Text = "Insertar producto";
            this.btnInsertarActualizarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarActualizarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(92, 225);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(174, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 149);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 84);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInsertarActualizarFabricantes);
            this.panel2.Controls.Add(this.btnInsertarActualizarFabricante);
            this.panel2.Controls.Add(this.txtNombreFabricante);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCodigoFabricante);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(984, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 357);
            this.panel2.TabIndex = 4;
            // 
            // lblInsertarActualizarFabricantes
            // 
            this.lblInsertarActualizarFabricantes.AutoSize = true;
            this.lblInsertarActualizarFabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertarActualizarFabricantes.Location = new System.Drawing.Point(75, 15);
            this.lblInsertarActualizarFabricantes.Name = "lblInsertarActualizarFabricantes";
            this.lblInsertarActualizarFabricantes.Size = new System.Drawing.Size(296, 38);
            this.lblInsertarActualizarFabricantes.TabIndex = 4;
            this.lblInsertarActualizarFabricantes.Text = "Insertar fabricantes";
            // 
            // btnInsertarActualizarFabricante
            // 
            this.btnInsertarActualizarFabricante.Location = new System.Drawing.Point(229, 198);
            this.btnInsertarActualizarFabricante.Name = "btnInsertarActualizarFabricante";
            this.btnInsertarActualizarFabricante.Size = new System.Drawing.Size(154, 77);
            this.btnInsertarActualizarFabricante.TabIndex = 4;
            this.btnInsertarActualizarFabricante.Text = "Insertar fabricante";
            this.btnInsertarActualizarFabricante.UseVisualStyleBackColor = true;
            this.btnInsertarActualizarFabricante.Click += new System.EventHandler(this.btnInsertarFabricante_Click);
            // 
            // txtNombreFabricante
            // 
            this.txtNombreFabricante.Location = new System.Drawing.Point(106, 254);
            this.txtNombreFabricante.Name = "txtNombreFabricante";
            this.txtNombreFabricante.Size = new System.Drawing.Size(100, 22);
            this.txtNombreFabricante.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nombre";
            // 
            // txtCodigoFabricante
            // 
            this.txtCodigoFabricante.Location = new System.Drawing.Point(106, 189);
            this.txtCodigoFabricante.Name = "txtCodigoFabricante";
            this.txtCodigoFabricante.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoFabricante.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Codigo";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(64, 302);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(109, 60);
            this.btnEditarProducto.TabIndex = 5;
            this.btnEditarProducto.Text = "Seleccionar producto a editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEditarFabricante
            // 
            this.btnEditarFabricante.Location = new System.Drawing.Point(315, 303);
            this.btnEditarFabricante.Name = "btnEditarFabricante";
            this.btnEditarFabricante.Size = new System.Drawing.Size(109, 58);
            this.btnEditarFabricante.TabIndex = 6;
            this.btnEditarFabricante.Text = "Seleccionar fabricante a editar";
            this.btnEditarFabricante.UseVisualStyleBackColor = true;
            this.btnEditarFabricante.Click += new System.EventHandler(this.btnEditarFabricante_Click);
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(64, 391);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(109, 60);
            this.btnBorrarProducto.TabIndex = 7;
            this.btnBorrarProducto.Text = "Borrar producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // btnBorrarFabricante
            // 
            this.btnBorrarFabricante.Location = new System.Drawing.Point(315, 391);
            this.btnBorrarFabricante.Name = "btnBorrarFabricante";
            this.btnBorrarFabricante.Size = new System.Drawing.Size(109, 60);
            this.btnBorrarFabricante.TabIndex = 8;
            this.btnBorrarFabricante.Text = "Borrar fabricante";
            this.btnBorrarFabricante.UseVisualStyleBackColor = true;
            this.btnBorrarFabricante.Click += new System.EventHandler(this.btnBorrarFabricante_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 710);
            this.Controls.Add(this.btnBorrarFabricante);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnEditarFabricante);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstFabricantes);
            this.Controls.Add(this.lstProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.ListBox lstFabricantes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertarActualizarProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInsertarActualizarProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInsertarActualizarFabricantes;
        private System.Windows.Forms.Button btnInsertarActualizarFabricante;
        private System.Windows.Forms.TextBox txtNombreFabricante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoFabricante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbFabricanteSeleccionado;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEditarFabricante;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnBorrarFabricante;
    }
}

