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
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "https://c-sf.smule.com/sf/s78/arr/5f/2a/74c74fc9-ee12-4398-af7b-047ae5e62d05.jpg", Nome = "José", Cargo = "Presidente da Empresa" });
            Lista.Add(new Funcionario() { Foto = "https://cidadewap.mobi/img/p/90223/1553255702.jpg", Nome = "Maria", Cargo = "Gerente" });
            Lista.Add(new Funcionario() { Foto = "https://i.pinimg.com/originals/65/06/6b/65066bd52464e7a76007e7b9236ce957.jpg", Nome = "Pamella", Cargo = "Vendendor" });
            Lista.Add(new Funcionario() { Foto = "https://lh6.googleusercontent.com/-_HnTfAULi_s/AAAAAAAAAAI/AAAAAAAAAA0/HLxBbHiDylo/photo.jpg", Nome = "Joana", Cargo = "RH" });
            Lista.Add(new Funcionario() { Foto = "https://i.pinimg.com/originals/5d/5b/c6/5d5bc6662aa5143e92dd6be53ef76c30.jpg", Nome = "Felipe", Cargo = "Coodernador" });

            ListaFuncionario.ItemsSource = Lista;

        }
    }
}