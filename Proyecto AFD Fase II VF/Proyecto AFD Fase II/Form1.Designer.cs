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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.VerificacionLabelAFN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AutomataFN = new System.Windows.Forms.TextBox();
            this.CadenaFN = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.AFD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AFD
            // 
            this.AFD.Controls.Add(this.tabPage1);
            this.AFD.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.VerificacionLabelAFN);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.AutomataFN);
            this.tabPage2.Controls.Add(this.CadenaFN);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autómatas AFN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // VerificacionLabelAFN
            // 
            this.VerificacionLabelAFN.AutoSize = true;
            this.VerificacionLabelAFN.Location = new System.Drawing.Point(100, 124);
            this.VerificacionLabelAFN.Name = "VerificacionLabelAFN";
            this.VerificacionLabelAFN.Size = new System.Drawing.Size(10, 13);
            this.VerificacionLabelAFN.TabIndex = 40;
            this.VerificacionLabelAFN.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ingrese Un Archivo De Texto:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 38;
            this.button3.Text = "Ingresar Archivo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Archivo De Texto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Verificar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Ingrese Una Cadena De Texto:";
            // 
            // AutomataFN
            // 
            this.AutomataFN.Location = new System.Drawing.Point(248, 45);
            this.AutomataFN.Multiline = true;
            this.AutomataFN.Name = "AutomataFN";
            this.AutomataFN.Size = new System.Drawing.Size(237, 195);
            this.AutomataFN.TabIndex = 33;
            // 
            // CadenaFN
            // 
            this.CadenaFN.Location = new System.Drawing.Point(38, 51);
            this.CadenaFN.Name = "CadenaFN";
            this.CadenaFN.Size = new System.Drawing.Size(128, 20);
            this.CadenaFN.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Ingresar Cadena";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 321);
            this.Controls.Add(this.AFD);
            this.Name = "Form1";
            this.Text = "Proyecto AFD - AFN";
            this.AFD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label VerificacionLabelAFN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AutomataFN;
        private System.Windows.Forms.TextBox CadenaFN;
        private System.Windows.Forms.Button button4;
    }
}

