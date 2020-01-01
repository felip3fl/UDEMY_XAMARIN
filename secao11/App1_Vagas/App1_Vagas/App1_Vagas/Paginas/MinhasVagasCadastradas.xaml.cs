using App1_Vagas.Banco;
using App1_Vagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhasVagasCadastradas : ContentPage
    {
        List<Vaga> Lista { get; set; }
        public MinhasVagasCadastradas()
        {
            InitializeComponent();
            ConsultarVagas();
        }


        public void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new CadastroVaga(vaga));
        }

        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            DataBase database = new DataBase();
            database.Exclusao(vaga);
            ConsultarVagas();
        }

        private void ConsultarVagas()
        {
            DataBase database = new DataBase();
            Lista = database.Consultar();
            ListaVagas.ItemsSource = Lista;

            lblCount.Text = Lista.Count.ToString();
        }

    }
}