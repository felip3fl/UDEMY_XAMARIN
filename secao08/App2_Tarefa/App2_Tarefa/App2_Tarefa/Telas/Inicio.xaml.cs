using App2_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd/MM");
        }

        public void ActionGoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cadastro());
        }

        public void LinhaStackLayout(Tarefa tarefa)
        {
            Label TxtTarefa = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Fill,  Text = tarefa.Nome};

            Image check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.png")};
            if (Device.RuntimePlatform == Device.UWP)
            {
                check.Source = ImageSource.FromFile("Resources/CheckOff.png");
            }

            StackLayout Linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing =15 };

            Linha.Children.Add(check);
        }
    }
}