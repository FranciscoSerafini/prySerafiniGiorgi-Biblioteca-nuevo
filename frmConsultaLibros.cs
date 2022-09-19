using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySerafiniGiorgi_Biblioteca_nuevo
{
    public partial class frmConsultaLibros : Form
    {
        string[] baseLibro = new string[30];
        public frmConsultaLibros()
        {
            InitializeComponent();
        }

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {
            StreamReader lectorLibros = new StreamReader("./LIBRO.txt");
            int indice = 0;

            while (!lectorLibros.EndOfStream)
            {
                baseLibro[indice] = lectorLibros.ReadLine();
                indice++;
            }
            lectorLibros.Close();
        }

        private void cmdListarLibros_Click(object sender, EventArgs e)
        {

        }

        int indiceRecorrido = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (indiceRecorrido < baseLibro.Length && baseLibro[indiceRecorrido] != null)
            {
                txtCodigo.Text = baseLibro[indiceRecorrido];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
