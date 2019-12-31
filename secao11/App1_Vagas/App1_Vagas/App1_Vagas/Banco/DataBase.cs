using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1_Vagas.Modelos;
using Xamarin.Forms;

namespace App1_Vagas.Banco
{
    public class DataBase
    {
        private SQLiteConnection _conexao;

        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqllite");

            _conexao = new SQLiteConnection(caminho);
        }

        public void Cadastro(Vaga vaga)
        {
            
        }

        public List<Vaga> Consultar()
        {
            return null;
        }

        public Vaga ObterVagaPorId(int id)
        {
            return null;
        }

        public void Atualizacao(Vaga vaga)
        {

        }

        public void Exclusao(int id)
        {

        }



    }
}
