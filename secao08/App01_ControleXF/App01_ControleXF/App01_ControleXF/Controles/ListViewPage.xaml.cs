using App01_ControleXF.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "José", Idade = "67" });
            lista.Add(new Pessoa { Nome = "Felipe", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Maria", Idade = "35" });
            lista.Add(new Pessoa { Nome = "Jão", Idade = "40" });
            lista.Add(new Pessoa { Nome = "Paulo", Idade = "45" });
            lista.Add(new Pessoa { Nome = "Pamella", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Paula", Idade = "45" });

            ListaPessoas.ItemsSource = lista;

        }
    }
}