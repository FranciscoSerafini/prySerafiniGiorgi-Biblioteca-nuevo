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
        //ZONA DE DECLARACION VARIABLES GLOBALES
        public string[,] baseLibro = new string[20, 5];
        int indiceRecorrido = 0;
        char separador = Convert.ToChar(",");

        public frmConsultaLibros()
        {
            InitializeComponent();
        }

        private void frmConsultaLibros_Load(object sender, EventArgs e)
        {

            int i = 0;

            StreamReader lectorLibro = new StreamReader("./LIBRO.txt");

            while (!lectorLibro.EndOfStream)
            {
                string[] VecLibro = lectorLibro.ReadLine().Split(separador);//separador dentro del vecto

                if (i < 20)
                {
                    //cargamos lo de la matriz al vector libro
                    baseLibro[i, 0] = VecLibro[0];
                    baseLibro[i, 1] = VecLibro[1];
                    baseLibro[i, 2] = VecLibro[2];
                    baseLibro[i, 3] = VecLibro[3];
                    baseLibro[i, 4] = VecLibro[4];
                    //llamamos a los procedimientos que utilizamos
                    BuscarNombreEditorial(i);
                    BuscarNombreDistribuidor(i);
                    i++;

                }
            }
            //mostramos lo que esta en la matriz
            lectorLibro.Close();
            txtCodigoLibro.Text = baseLibro[0, 0];
            txtNombreLibro.Text = baseLibro[0, 1];
            txtCodigoEdito.Text = baseLibro[0, 2];
            txtCodigoAutor.Text = baseLibro[0, 3];
            txtCodigoDistri.Text = baseLibro[0, 4];
            //desabilitamos el boton de retroceso
            cmdRetroceso.Enabled = false;



        }

        private void cmdListarLibros_Click(object sender, EventArgs e)
        {

        }
        
        private void BuscarNombreDistribuidor(int numeroDistribuidorBuscado)
        {
            //leemos el archivo
            StreamReader lectorDistribuidor = new StreamReader("./DISTRIBUIDORA.txt");

            while (!lectorDistribuidor.EndOfStream)
            {
                //comparar el codigo del libro

                string[] vecDistribuidor = lectorDistribuidor.ReadLine().Split(separador);
                //se cambia el codigo por el nombre correspondiente
                if (vecDistribuidor[0] == baseLibro[numeroDistribuidorBuscado,4])
                {
                    
                    baseLibro[numeroDistribuidorBuscado,4] = vecDistribuidor[1];//se sobre escribe el nombre de la distribuidor
                }
            }

            lectorDistribuidor.Close();
        }



        private void BuscarNombreEditorial(int nombreEditorialBuscado)
        {
            StreamReader lectorEditorial = new StreamReader("./EDITORIAL.txt");

            while (!lectorEditorial.EndOfStream)
            {
                //comparar el codigo del libro

                string[] vecEditorial = lectorEditorial.ReadLine().Split(separador);
                //se cambia el codigo por el nombre correspondiente
                if (vecEditorial[0] == baseLibro[nombreEditorialBuscado, 2])
                {
                    //se sobre escribe el nombre de la distribuidor 
                    baseLibro[nombreEditorialBuscado,2] = vecEditorial[1];
                }
            }

            lectorEditorial.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)// no se me cambia el nombre de los botones 
        {
            indiceRecorrido++;

            txtCodigoLibro.Text = baseLibro[indiceRecorrido, 0];
            txtNombreLibro.Text = baseLibro[indiceRecorrido, 1];
            txtCodigoEdito.Text = baseLibro[indiceRecorrido, 2];

            txtCodigoAutor.Text = baseLibro[indiceRecorrido, 3];

            
            txtCodigoDistri.Text = baseLibro[indiceRecorrido, 4];
            cmdRetroceso.Enabled = true;

            if (indiceRecorrido == baseLibro.GetLength(0) - 1)//el -1 es para controlor los espacios de la matriz
            {
                cmdAvanzar1.Enabled = false;
            }

        }
        

        private void button1_Click(object sender, EventArgs e)// no se me cambia el nombre de los botones 
        {
            indiceRecorrido--;//decrementa el indice
            if (indiceRecorrido >= 0) // si es menor o igual decrementa
            {
                //muestra de los datos hacia atras
                txtCodigoLibro.Text = baseLibro[indiceRecorrido, 0];
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
