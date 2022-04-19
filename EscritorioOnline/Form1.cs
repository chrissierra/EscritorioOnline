using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones objetoDeEvaluacion = new Operaciones();
            string texto = Numero.Text;
            int numero = Convert.ToInt32(texto);
            Console.WriteLine(texto);
            label2.Text = objetoDeEvaluacion.entregarResultado(numero);
        }
    }
}
