namespace CargaArchivo
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtarchivos = new System.Windows.Forms.ListBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtarchivos
            // 
            this.txtarchivos.FormattingEnabled = true;
            this.txtarchivos.Items.AddRange(new object[] {
            ""});
            this.txtarchivos.Location = new System.Drawing.Point(31, 43);
            this.txtarchivos.Name = "txtarchivos";
            this.txtarchivos.Size = new System.Drawing.Size(240, 212);
            this.txtarchivos.TabIndex = 2;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(313, 129);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(192, 86);
            this.btncargar.TabIndex = 3;
            this.btncargar.Text = "Cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(313, 67);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(192, 20);
            this.txtdireccion.TabIndex = 4;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(412, 93);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(93, 30);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(430, 232);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 289);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.txtarchivos);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox txtarchivos;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

