using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FOCOtizaciones.Model;
using System.Diagnostics;

namespace FOCOtizaciones.ViewModel
{
    public class ViewModelBase : ObservableCollection<Costo>
    {
        //Create an object of SimpleCommand type, you need to add using CommandsExample.ViewModel.Commands for this
        public SimpleCommand SimpleCommand { get; set; }

        public ParameterCommand ParameterCommand { get; set; }

        public ViewModelBase()
        {
            //On the constructor you send this to the SimpleCommand contrusctor
           this.SimpleCommand = new SimpleCommand(this);
           this.ParameterCommand = new ParameterCommand(this);

            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                for (int i = 0; i < 10; i++)
                {
                    Random a = new Random();
                    String val = "true";
                    //if (a.Next(0, 2)==1)
                    if(i%2==0)
                    {
                        val = "false";
                    }
                    Add(new Model.Costo()
                    {
                        Id = i,
                        Nombre = "Test" + i.ToString(),
                        Precio = 123,
                        //Enable = false
                        Enable = val

                    });
                }
            }
        }
        public void SimpleMethod()
        {
            Debug.WriteLine("Hello");
        }

        public void ParameterMethod(Costo costo)
        {
            Costo p = new Costo();
            p.Id = costo.Id;
            p.Nombre = costo.Nombre;
            p.Precio = costo.Precio;
            p.Enable = costo.Enable;
            Add(p);
        }


    }
}
