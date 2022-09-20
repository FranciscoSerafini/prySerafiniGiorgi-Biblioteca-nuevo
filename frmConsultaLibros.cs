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
       public string[,] baseLibro = new string[20,5];
       int indiceRecorrido = 0;


        public frmConsultaLibros()
        {
            InitializeComponent();
        }

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {
            char separador = Convert.ToChar(",");
            int i = 0;

            StreamReader lectorLibro = new StreamReader("./LIBRO.txt");

            while (!lectorLibro.EndOfStream)
            {
                string[] VecLibro = lectorLibro.ReadLine().Split(separador);

                if (i < 20)
                {
                    baseLibro[i, 0] = VecLibro[0];
                    baseLibro[i, 1] = VecLibro[1];
                    baseLibro[i, 2] = VecLibro[2];
                    baseLibro[i, 3] = VecLibro[3];
                    baseLibro[i, 4] = VecLibro[4];
                    i++;
                    
                }
            }
            lectorLibro.Close();
            txtCodigo.Text = baseLibro[0, 0];
            txtNombreLibro.Text = baseLibro[0, 1];
            txtCodigoEdito.Text = baseLibro[0, 2];
            txtCodigoAutor.Text = baseLibro[0, 3];
            txtCodigoDistri.Text = baseLibro[0, 4];
            
           
            
        }

        private void cmdListarLibros_Click(object sender, EventArgs e)
        {

        }

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            indiceRecorrido++;

            txtCodigo.Text = baseLibro[indiceRecorrido, 0];
            txtNombreLibro.Text = baseLibro[indiceRecorrido, 1];
            txtCodigoEdito.Text = baseLibro[indiceRecorrido, 2];
            txtCodigoAutor.Text = baseLibro[indiceRecorrido, 3];
            txtCodigoDistri.Text = baseLibro[indiceRecorrido, 4];
            cmdRetroceso.Enabled = true;

            if (indiceRecorrido == baseLibro.GetLength(0) - 1)
            {
                cmdAvanzar.Enabled = false;
            }







        }

        private void button1_Click(object sender, EventArgs e)
        {
            indiceRecorrido--;
            if (indiceRecorrido >= 0)
            {
                txtCodigo.Text = baseLibro[indiceRecorrido, 0];
                txtNombreLibro.Text = baseLibro[indiceRecorrido, 1];
                txtCodigoEdito.Text = baseLibro[indiceRecorrido, 2];
                txtCodigoAutor.Text = baseLibro[indiceRecorrido, 3];
                txtCodigoDistri.Text = baseLibro[indiceRecorrido, 4];

                if (indiceRecorrido == 0)
                {
                    cmdRetroceso.Enabled = false;
                }

            }
            else
            {
                cmdRetroceso.Enabled = false;
            }
        }
    }
}
