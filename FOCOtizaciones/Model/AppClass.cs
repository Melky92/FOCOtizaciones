using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FOCOtizaciones.Model
{
    class AppClass: INotifyPropertyChanged
    {
        private List<Costo> listaCosto;

        public AppClass()
        {
            //This is just to know if you are in designMode or running
            //This way you can check the binding while coding and when running it will use actual data
            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                listaCosto = new List<Costo>();
            }
            else
            {
                listaCosto = new List<Costo>();
                listaCosto.Add(new Costo()
                {
                    Id = 101,
                    Nombre = "Aplicacion",
                    Precio = 123,
                    //Enable = false,
                    Enable = "true"
                });
            }
            
        }

        public List<Costo> ListaCosto
        {
            get { return listaCosto; }
            set { listaCosto = value;
                OnpropertyChanged("Lista");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //This is just a funcition you create to call the the event PropertyChanged
        //The string propertyName is the an arg that you can send to the event
        private void OnpropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
            //The upper can be simplify and just writing this
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
