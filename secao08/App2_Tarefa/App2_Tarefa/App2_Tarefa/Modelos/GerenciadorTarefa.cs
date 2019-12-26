using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace App2_Tarefa.Modelos
{
    public class GerenciadorTarefa
    {
        public List<Tarefa> Lista { get; set; }

        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);
            
            SalvarNoProperties(Lista);
        }

        public void Finalizar(int Index, Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(Index);
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }

        public void Deletar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Remove(tarefa);
            SalvarNoProperties(Lista);
        }

        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                String JsonVal = (String)App.Current.Properties["Tarefas"];

                List<Tarefa> Lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);
                return Lista;

                //return (List<Tarefa>)App.Current.Properties["Tarefas"];
            }

            return new List<Tarefa>();
        }

        private void SalvarNoProperties(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            JsonConvert.SerializeObject(Lista);

            App.Current.Properties.Add("Tarefas", Lista);
        }

    }
}
