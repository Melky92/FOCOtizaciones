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

namespace FOCOtizaciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        
        private List<Costo> LoadCollectionData()
        {
            List<Costo> authors = new List<Costo>();
            authors.Add(new Costo()
            {
                Id = 101,
                Nombre = "Aplicacion",
                Precio = 123,
                Checked = false,
            });
            return authors;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            dataGridDatos.ItemsSource = LoadCollectionData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridRow dgr = Interfaz.GetRow(dataGridDatos, 0);
            //DataGridCell dgc = Interfaz.GetCell(dataGridDatos, 0, 3);
            DataGridCheckBoxColumn dgc = (DataGridCheckBoxColumn)dataGridDatos.GetColumn(3);
            
            dgr.IsEnabled = false;
        }
    }
}
