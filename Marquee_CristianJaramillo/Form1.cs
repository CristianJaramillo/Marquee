using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Marquee_CristianJaramillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string cad1, aux, cola;
        Thread Hebra;
        public void Hilo()
        {
            while (true)
            {
                Thread.Sleep(5);
                if (i < 240)
                    i += 10;

                else
                {
                    i = 0;
                    for (i = 0; i < 1; i++)
                    {
                        cad1 = textBox1.Text;
                        cola = cad1.Substring(0, 1);
                        aux = cad1.Substring(1, cad1.Length - 1);
                        textBox1.Text = aux.ToString() + cola.ToString();
                    }
                }
            }
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " Hola soy el número uno";
            Hebra = new Thread(new ThreadStart(Hilo));
            Hebra.Start();
            Iniciar.Enabled = false;
            Pausa.Enabled = true;
            Reanudar.Enabled = false;
        }

        private void Pausa_Click(object sender, EventArgs e)
        {
            Hebra.Suspend();
            Reanudar.Enabled = true;
            Terminar.Enabled = false;
            i = 2;
        }

        private void Reanudar_Click(object sender, EventArgs e)
        {
            Hebra.Resume();
            Reanudar.Enabled = false;
            Terminar.Enabled = true;
            Pausa.Enabled = true;
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            if (i == 0)
                MessageBox.Show("No hay proceso que terminar!!");

            else
                if (Hebra.IsAlive)
                {
                    //// condicion
                    //i = 0;
                    Iniciar.Enabled = true;
                    Pausa.Enabled = false;
                    Reanudar.Enabled = false;
                    Hebra.Abort();
                    textBox1.Text = "";
                }
                else
                    MessageBox.Show("No hay proceso que finalizar");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            if (i == 0)
                Application.Exit();
            else
                if (Hebra.IsAlive && i == 2)
                    MessageBox.Show("Reanude la aplicacion y presione 'Terminar' para que pueda Salir correctamente!");
                else
                    Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}