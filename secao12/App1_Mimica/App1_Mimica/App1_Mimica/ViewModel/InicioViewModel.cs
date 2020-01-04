using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using App1_Mimica.Model;
using Xamarin.Forms;

namespace App1_Mimica.ViewModel
{
    public class InicioViewModel : INotifyPropertyChanged
    {
        public Jogo jogo { get; set; }
        public Command IniciarCommand { get; set; }

        public InicioViewModel()
        {
            IniciarCommand = new Command(IniciarJogo);
            jogo = new Jogo();
            jogo.Grupo1 = new Grupo();
            jogo.Grupo2 = new Grupo();
        }

        private void IniciarJogo()
        {
            Armazenamento.Armazenamento.Jogo = this.jogo;
            Armazenamento.Armazenamento.RodadaAtual = 1;
            App.Current.MainPage = new View.Jogo();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string NameProperty)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }

    }
}
