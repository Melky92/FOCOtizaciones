using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FOCOtizaciones.Model
{
    public class Costo:INotifyPropertyChanged
    {
        private int id;
        private string nombre;
        //private bool enable;
        string enable;
        private float precio;

        


        public Costo()
        {
            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                this.id= 1;
                this.nombre = "Test feature";
                //this.enable = true;
                this.enable = "true";
            }
            else
            {
                this.nombre = "";
            }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value;
                OnpropertyChanged("precio");
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value;
                OnpropertyChanged("id");
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnpropertyChanged("nombre");
            }
        }
        //public bool Enable
        public string Enable
        {
            get { return enable; }
            set { enable = value;
                OnpropertyChanged("enable");
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
        public override string ToString()
        {
            return nombre;
        }
    }
}
