using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RobinsonSoplinTareaSemana2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string usuario, string contraseña) // Datos a Recibir
        {
            InitializeComponent();
           //DisplayAlert("Datos enviados", "El usuario es" + usuario + "La clave es" + contraseña, "cerrar");
           lbNombre.Text ="El usuario es"+ usuario;
            lbContraseña.Text = "La contraseña es"+ contraseña;
        }
    }
}