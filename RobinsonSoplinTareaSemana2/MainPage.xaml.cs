using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RobinsonSoplinTareaSemana2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
           string Usuario = txtUsuario.Text;
           string Pass = txtPass.Text;

           await Navigation.PushAsync(new Vista_dos ());
        }
    }
}
