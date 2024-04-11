using Proyecto_AFD_Fase_II;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CargaArchivo
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtarchivos.SelectedIndex != -1)
            {
                //C:\Users\David\Downloads\Archivos

                String Automata = txtarchivos.SelectedItem.ToString();
                form1.lblautoselect.Visible = true;
                form1.lblautoselect.Text = Automata;

                String RutaAutomata = ruta + "\\" + Automata;

                try
                {
                    // Verificar si el archivo existe
                    if (File.Exists(RutaAutomata))
                    {
                        // Leer todo el texto del archivo
                        string text = File.ReadAllText(RutaAutomata);

                        // Mostrar el contenido del archivo en el TextBox
                        form1.txtlistaarchivos.Text = text;
                        this.Hide();
                    }
                    else
                    {
                        form1.txtlistaarchivos.Text = "El archivo no existe.";
                    }

                }

                catch (Exception ex)
                {
                    form1.txtlistaarchivos.Text = "Error al leer el archivo: " + ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Error, Por favor seleccione 1 de los archivos .txt");
            }
            
        }

        public string ruta;
        private void button2_Click(object sender, EventArgs e)
        {
            ruta = txtdireccion.Text;

            // Obtener la lista de archivos en el directorio
            string[] files = Directory.GetFiles(ruta);

            // Agregar los nombres de los archivos al ListBox
            foreach (string file in files)
            {
                txtarchivos.Items.Add(Path.GetFileName(file));
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
