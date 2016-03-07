using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        string dato;
        string vivo;
        delegate void Delegado();
        private void Escribir()
        {
            richTextBox1.Text = dato;
        }

        private void conectaServidor() {
            try
            {
                client = new TcpClient("127.0.0.1", 2000);
                ns = client.GetStream();
                sr = new StreamReader(ns);
                sw = new StreamWriter(ns);

                dato = sr.ReadLine();
                Delegado delegado = new Delegado(Escribir);
                Invoke(delegado);

            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectaServidor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sw.WriteLine("A");
            sw.Flush();
            dato = sr.ReadLine();
            vivo = sr.ReadLine();
            if (vivo == "muerto")
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }

            Delegado delegado = new Delegado(Escribir);
            Invoke(delegado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sw.WriteLine("B");
            sw.Flush();
            dato = sr.ReadLine();
            vivo = sr.ReadLine();
            if (vivo == "muerto")
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }

            Delegado delegado = new Delegado(Escribir);
            Invoke(delegado);
        }
    }
}
