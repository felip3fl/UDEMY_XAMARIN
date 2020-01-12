using System;
using System.Collections.Generic;
using System.Text;
using App1_NossoChat.Model;
using App1_NossoChat.Service;
using Xamarin.Forms;
using System.ComponentModel;

namespace App1_NossoChat.ViewModel
{
    public class MensagemViewModel : INotifyPropertyChanged
    {
        public MensagemViewModel(Chat chat)
        {
            //TODO PESQUI SA E APRESENTACAO
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnProPertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
