using Npgsql;
using System;
using System.Collections.Generic;

namespace ProjectFacul.ProjetoWeb.Api.Model
{
    public class DadosHumidadeRepository : IDadosHumidadeRepository
    {
        private string conexao;

        public DadosHumidadeRepository(string conexao)
        {
            this.conexao = conexao;
        }
        public List<DadosHumidade> ListarHumidade()
        {
            //-------------------Pra aprimorar passar essa string de conexão para a camada de aplicação. --------------------
            string strConnection = conexao;
            List<DadosHumidade> dadosHumidade = new List<DadosHumidade>();

            //CRIAR UMA CONEXÃO
            using (NpgsqlConnection con = new NpgsqlConnection(strConnection))
            {
                //ABRIR CONEXÃO COM O BD
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                //CRIAR O COMANDO A SER EXECUTADO
                command.CommandText = "SELECT humidade, data FROM fatoresclimaticos;";

                //EXECUTAMOS O COMANDO
                NpgsqlDataReader leitor = command.ExecuteReader();
                while (leitor.Read())
                {
                    dadosHumidade.Add(new DadosHumidade()
                    {
                        Humidade = Convert.ToInt32(leitor["humidade"]),
                        Data = Convert.ToDateTime(leitor["data"]),
                    });
                }
                return dadosHumidade;
            }

        }
}
