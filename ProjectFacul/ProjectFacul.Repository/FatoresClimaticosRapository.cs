using ProjectFacul.Domain.Entities;
using ProjectFacul.Domain.Repository;
using System;
using System.Collections.Generic;
using Npgsql;

namespace ProjectFacul.Repository
{
    public class FatoresClimaticosRepository : IFatoresClimaticosRepository
    {
        public void Adicionar(FatoresClimaticos fatoresClimaticos)
        {
            string strConnection = "Server=pgsql.jmenzen.com.br;Port=5432;Database=jmenzen2;User Id=jmenzen2;Password=2J2eyWGw;";
            //CRIAR UMA CONEXÃO
            using (NpgsqlConnection con = new NpgsqlConnection(strConnection))
            {
                //ABRIR CONEXÃO COM O BD
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                //CRIAR O COMANDO A SER EXECUTADO
                command.CommandText = "INSERT INTO fatoresclimaticos (id, humidade, temperatura, indicePluviometrico, data) " +
                                      "VALUES(@id, @humidade, @temperatura, @indicePluviometrico, @data); ";
                command.Parameters.AddWithValue("id",fatoresClimaticos.Id);
                command.Parameters.AddWithValue("humidade", fatoresClimaticos.Humidade);
                command.Parameters.AddWithValue("temperatura", fatoresClimaticos.Temperatura);
                command.Parameters.AddWithValue("data", fatoresClimaticos.Data);
                command.Parameters.AddWithValue("indicePluviometrico", fatoresClimaticos.IndicePluviometrico);
                //command.Parameters.AddWithValue("praga", fatoresClimaticos.Praga);

                //EXECUTAMOS O COMANDO
                command.ExecuteNonQuery();
            }
            //FECHAMOS A CONEXAO
        }

        public void Alterar(FatoresClimaticos fatoresClimaticos)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid idFatoresClimaticos)
        {
            throw new NotImplementedException();
        }

        public List<FatoresClimaticos> ListarTodos()
        {
            string strConnection = "Server=pgsql.jmenzen.com.br;Port=5432;Database=jmenzen2;User Id=jmenzen2;Password=2J2eyWGw;";
            List<FatoresClimaticos> fatoresClimaticas = new List<FatoresClimaticos>();

            //CRIAR UMA CONEXÃO
            using (NpgsqlConnection con = new NpgsqlConnection(strConnection))
            {
                //ABRIR CONEXÃO COM O BD
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                //CRIAR O COMANDO A SER EXECUTADO
                command.CommandText = "SELECT id, humidade, temperatura, indicePluviometrico, data FROM fatoresclimaticos;";

                //EXECUTAMOS O COMANDO
                NpgsqlDataReader leitor =  command.ExecuteReader();
                while (leitor.Read())
                {
                    fatoresClimaticas.Add(new FatoresClimaticos()
                    {
                        Id = Guid.Parse(leitor["id"].ToString()),
                        Humidade = Convert.ToInt32(leitor["humidade"]),
                        Temperatura = Convert.ToInt32(leitor["temperatura"]),
                        Data = Convert.ToDateTime(leitor["data"]),
                        IndicePluviometrico = Convert.ToInt32(leitor["indicePluviometrico"]),
                        //Praga
                    });
                }
                return fatoresClimaticas;
            }
            //FECHAMOS A CONEXAO
        }

        public FatoresClimaticos Selecionar(Guid idFatoresClimaticos)
        {
            throw new NotImplementedException();
        }
    }
}
