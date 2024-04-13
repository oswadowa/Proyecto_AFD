using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Proyecto_AFD_Fase_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string FullText = Automata.Text;
            string Texto = Cadena.Text;
            int Líneas = Regex.Matches(FullText, Environment.NewLine).Count;
            string[] Jumps = new string[Líneas + 1];
            Jumps = FullText.Split('\n');

            //Determinación de estados finales//
            string[] Finales = Jumps[2].Split(',');
            //Determinación de estados finales//

            //Separación de valores//
            string[] EstActual = new string[Líneas - 2];
            string[] Escribir = new string[Líneas - 2];
            string[] EstSalt = new string[Líneas - 2];
            int[] Final = new int[Finales.Length];
            int Llenado = 0;
            for (int i = 3; i <= Líneas; i++)
            {
                string[] Separated = Jumps[i].Split(',');
                EstActual[Llenado] = Separated[0];
                Escribir[Llenado] = Separated[1];
                EstSalt[Llenado] = Separated[2];
                Llenado++;
            }
            //Separación de valores//

            //Limpiar strings//
            for (int i = 0; i < Líneas - 2; i++)
            {
                string[] EliminarNewLines = EstSalt[i].Split('\r');
                EstSalt[i] = EliminarNewLines[0];
            }

            //Limpiar strings//

            //Limpiar strings finales//
            for (int i = 0; i < Finales.Length; i++)
            {
                string[] TempFinalesClean = Finales[i].Split('\r');
                Finales[i] = TempFinalesClean[0];
            }
            //Limpiar strings finales//


            //Establecer saltos//
            int[,] Saltos = new int[Líneas - 2, 10];
            for (int i = 0; i < Líneas - 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Saltos[i, j] = -1;
                }
            }
            string[] finales = new string[Líneas - 2];
            for (int i = 0; i < Líneas - 2; i++)
            {
                string ActualComp = EstSalt[i];
                Llenado = 0;
                for (int j = 0; j < Líneas - 2; j++)
                {
                    if (ActualComp == EstActual[j])
                    {
                        Saltos[i, Llenado] = j;
                        Llenado++;
                    }
                }
            }
            //Establecer saltos//

            //Establecer Estado incicial//
            string EstInicial = Jumps[1];
            string[] Iniciales = EstInicial.Split(',');
            string[] InicialFinal = Iniciales[Iniciales.Length - 1].Split('\r');
            Iniciales[Iniciales.Length - 1] = InicialFinal[0];
            int CantIniciales = 0;
            for (int i = 0; i < Líneas - 2; i++)
            {
                for (int j = 0; j < Iniciales.Length; j++)
                {
                    if (Iniciales[j] == EstActual[i])
                    {
                        CantIniciales++;
                    }
                }
            }
            int[] posIniciales = new int[CantIniciales];
            for (int i = 0; i < Líneas - 2; i++)
            {
                for (int j = 0; j < Iniciales.Length; j++)
                {
                    if (Iniciales[j] == EstActual[i])
                    {
                        posIniciales[i] = i;
                    }
                }
            }
            //Establecer Estado inicial//

            string RegistroSaltos = "";

            //Camino//
            string[] letras = new string[Texto.Length];
            bool Válido = true;

            //Se separan individualmente las letras//
            for (int i = 0; i < Texto.Length; i++)
            {
                letras[i] = Texto.Substring(i, 1);
            }
            //Se separan individualmente las letras//

            string currentCharacter = "";
            int current = 0;
            int[] nextPos = new int[10];
            int[] VefPos = new int[10];
            string Vef = "";
            bool ConfFinal = false;
            for (int i = 0; i < Texto.Length; i++)
            {
                currentCharacter = letras[i];
                if (i == 0) //Si viene de entrada, utilizar siguiente comandos//
                {
                    for (int j = 0; j < CantIniciales; j++)
                    {
                        if (currentCharacter == Escribir[posIniciales[j]])
                        {
                            RegistroSaltos = "(" + EstActual[j] + "," + Escribir[j] + ")," + EstSalt[j] + Environment.NewLine;
                            Vef = Vef + Escribir[posIniciales[j]];
                            for (int k = 0; k < 10; k++)
                            {
                                nextPos[k] = Saltos[j, k];
                                VefPos[k] = Saltos[j, k];
                            }
                            j = CantIniciales;
                        }
                    }
                }

                else //Si se está evaluando una letra posterior a la primera se usa este código//
                {
                    for (int j = 0; j < nextPos.Length - 1; j++)
                    {
                        if (VefPos[j] >= 0)
                        {
                            if (currentCharacter == Escribir[VefPos[j]])
                            {
                                RegistroSaltos = RegistroSaltos + "(" + EstActual[VefPos[j]] + "," + Escribir[VefPos[j]] + ")," + EstSalt[VefPos[j]] + Environment.NewLine;
                                Vef = Vef + Escribir[VefPos[j]];
                                for (int k = 0; k < 10; k++)
                                {
                                    nextPos[k] = Saltos[VefPos[j], k];
                                }
                                if (i == Texto.Length - 1)
                                {
                                    for (int k = 0; k < Finales.Length; k++)
                                    {
                                        if (Finales[k] == EstSalt[VefPos[j]])
                                        {
                                            ConfFinal = true;
                                        }
                                    }
                                }
                                j = 15;
                            }
                        }

                    }
                }
                for (int k = 0; k < 10; k++)
                {
                    VefPos[k] = nextPos[k];
                }
            }
            //Camino//

            if (Vef == Texto && ConfFinal == true)
            {
                VerificaciónLabel.Text = "Aceptada";
            }
            else
            {
                RegistroSaltos = RegistroSaltos + "FIN";
                VerificaciónLabel.Text = "Rechazada";
            }
            Recorrido.Text = RegistroSaltos;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Crea un cuadro de diálogo para seleccionar el archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Muestra el cuadro de diálogo y comprueba si se ha seleccionado un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lee el contenido del archivo seleccionado
                string contenidoArchivo = File.ReadAllText(openFileDialog.FileName);

                // Muestra el contenido del archivo en el TextBox
                Automata.Text = contenidoArchivo;

            }
        }
    }
}
