using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App1_Vagas.Modelos;

namespace App1_Vagas.Banco
{
    public class DataBase
    {
        private SQLiteConnection _conexao;

        public DataBase()
        {
            _conexao = new SQLiteConnection();
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
