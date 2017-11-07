using ClienteAPIXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClienteAPIXamarin
{
    public partial class MainPage : ContentPage
    {
        ServicioDeDatos servicioDeDatos;
        List<Ciclo> ciclos;

        public MainPage()
        {
            InitializeComponent();
            servicioDeDatos = new ServicioDeDatos();
            RefreshData();
            boton.Clicked += Boton_Clicked;
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
            RefreshData();
        }

        async void RefreshData()
        {
            ciclos = await servicioDeDatos.GetCiclosAsync();

            string datosCiclos = "";
            for (int i = 0; i < ciclos.Count; i++)
            {
                datosCiclos += ciclos[i].Abreviatura + ", ";
            }

            datos.Text = datosCiclos;
        }
    }
}
