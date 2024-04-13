namespace Proyecto_AFD_Fase_II
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
            this.AFD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VerificaciónLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Automata = new System.Windows.Forms.TextBox();
            this.Recorrido = new System.Windows.Forms.TextBox();
            this.Cadena = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AFD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AFD
            // 
            this.AFD.Controls.Add(this.tabPage1);
            this.AFD.Location = new System.Drawing.Point(12, 12);
            this.AFD.Name = "AFD";
            this.AFD.SelectedIndex = 0;
            this.AFD.Size = new System.Drawing.Size(798, 294);
            this.AFD.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VerificaciónLabel);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Automata);
            this.tabPage1.Controls.Add(this.Recorrido);
            this.tabPage1.Controls.Add(this.Cadena);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Autómatas AFD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // VerificaciónLabel
            // 
            this.VerificaciónLabel.AutoSize = true;
            this.VerificaciónLabel.Location = new System.Drawing.Point(85, 121);
            this.VerificaciónLabel.Name = "VerificaciónLabel";
            this.VerificaciónLabel.Size = new System.Drawing.Size(10, 13);
            this.VerificaciónLabel.TabIndex = 29;
            this.VerificaciónLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ingrese Un Archivo De Texto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ingresar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Recorrido Autómata";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Archivo De Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Verificar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ingrese Una Cadena De Texto:";
            // 
            // Automata
            // 
            this.Automata.Location = new System.Drawing.Point(233, 42);
            this.Automata.Multiline = true;
            this.Automata.Name = "Automata";
            this.Automata.Size = new System.Drawing.Size(237, 195);
            this.Automata.TabIndex = 22;
            // 
            // Recorrido
            // 
            this.Recorrido.Location = new System.Drawing.Point(486, 41);
            this.Recorrido.Multiline = true;
            this.Recorrido.Name = "Recorrido";
            this.Recorrido.ReadOnly = true;
            this.Recorrido.Size = new System.Drawing.Size(254, 196);
            this.Recorrido.TabIndex = 21;
            // 
            // Cadena
            // 
            this.Cadena.Location = new System.Drawing.Point(23, 48);
            this.Cadena.Name = "Cadena";
            this.Cadena.Size = new System.Drawing.Size(128, 20);
            this.Cadena.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ingresar Cadena";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 321);
            this.Controls.Add(this.AFD);
            this.Name = "Form1";
            this.Text = "Proyecto 1";
            this.AFD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AFD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label VerificaciónLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Automata;
        private System.Windows.Forms.TextBox Recorrido;
        private System.Windows.Forms.TextBox Cadena;
        private System.Windows.Forms.Button button2;
    }
}

