using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Pagina
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewCellPage : ContentPage
    {
        public ViewCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Nome = "Pamella", Cargo = "Vendendor" });
            Lista.Add(new Funcionario() { Nome = "Joana", Cargo = "RH" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Coodernador" });

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}