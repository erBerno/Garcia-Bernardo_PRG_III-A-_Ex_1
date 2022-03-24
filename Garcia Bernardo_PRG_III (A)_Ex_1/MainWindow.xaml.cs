
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Garcia_Bernardo_PRG_III__A__Ex_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Parque> listaParques;
        Queue<Juego> colaTmp;

        public MainWindow()
        {
            listaParques = new List<Parque>();
            colaTmp = new Queue<Juego>();
            colaTmp.Enqueue(new Juego("Sube y baja", 2));
            colaTmp.Enqueue(new Juego("Tazas Giratorias", 20));
            colaTmp.Enqueue(new Juego("Puntitos", 5));
            listaParques.Add(new Parque("Vial", colaTmp));
            InitializeComponent();
            RellenarCmb();
            ShowData();
        }

        public void ShowData()
        {
            lstShow.Items.Clear();

            foreach (Parque p in listaParques)
            {
                lstShow.Items.Add("Nombre Parque: " + p.nombreParque);
                lstShow.Items.Add("Juegos:");
                foreach (Juego j in p.colaJuegos)
                {
                    lstShow.Items.Add("\t" + j.nombreJuego + " - " + j.capacidadMax);
                }
                lstShow.Items.Add("-----------------------------------------------------");
            }
        }

        public void RellenarCmb()
        {
            cmbParques.Items.Clear();
            foreach (Parque p in listaParques)
            {
                cmbParques.Items.Add(p.nombreParque);
            }
        }

        private void btnAñadirP_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listaParques.Count; i++)
            {
                if (listaParques[i].nombreParque != txbNombreP.Text)
                {
                    string nombreP = txbNombreP.Text;
                    listaParques.Add(new Parque(nombreP));
                    RellenarCmb();
                }
            }
            lstShow.Items.Clear();
            ShowData();
            txbNombreP.Text = "";
        }

        private void btnRegistrarJ_Click(object sender, RoutedEventArgs e)
        {
            int indice = cmbParques.SelectedIndex;
            string nombreJ = txbNombreA.Text;
            int capacidad = int.Parse(txbCapacidad.Text);

            listaParques[indice].AgregarJuego(nombreJ, capacidad);

            lstShow.Items.Clear();
            ShowData();
            txbNombreA.Text = "";
            txbCapacidad.Text = "";
        }

        private void btnEliminarJ_Click(object sender, RoutedEventArgs e)
        {
            int indice = cmbParques.SelectedIndex;
            listaParques[indice].colaJuegos.Dequeue();
            MessageBox.Show("Juego " + txbEliminarJ.Text + " del Parque " + listaParques[indice].nombreParque + ", ELIMINADO.", "ELIMINADO CORRECTAMENTE", MessageBoxButton.OK, MessageBoxImage.Information);

            lstShow.Items.Clear();
            ShowData();

            txbEliminarJ.Text = "";
        }

        public int BuscarParque(string buscado)
        {
            int encontrado = -1;

            for (int i = 0; i < listaParques.Count; i++)
            {
                if (listaParques[i].nombreParque == buscado)
                {
                    encontrado = i;
                }
            }

            return encontrado;
        }

        public int BuscarJuego(string buscado)
        {
            int encontrado = -1;

            for (int i = 0; i < listaParques.Count; i++) 
            {
                foreach (Juego j in listaParques[i].colaJuegos)
                {
                    if (j.nombreJuego == buscado)
                    {
                        encontrado = i;
                    }
                }
            }

            return encontrado;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();

            if (rdParque.IsChecked == true)
            {
                string buscado = txbBusqueda.Text;

                if (BuscarParque(buscado) != -1)
                {
                    int indice = BuscarParque(buscado);
                    lstShow.Items.Add("Nombre Parque: " + listaParques[indice].nombreParque);
                    lstShow.Items.Add("Juegos:");
                    foreach (Juego j in listaParques[indice].colaJuegos)
                    {
                        lstShow.Items.Add("\t" + j.nombreJuego + " - " + j.capacidadMax);
                    }
                    lstShow.Items.Add("-----------------------------------------------------");
                }
            } else if (rdJuego.IsChecked == true)
            {
                string buscado = txbBusqueda.Text;

                if (BuscarJuego(buscado) != -1)
                {
                    int indice = BuscarJuego(buscado);
                    lstShow.Items.Add("El juego se encuentra en el Parque: " + listaParques[indice].nombreParque);
                }
            }

            txbBusqueda.Text = "";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lstShow.Items.Clear();
            ShowData();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
