using Npgsql;
using ProjectFacul.Domain.Entities;
using ProjectFacul.Domain.Repository;
using System;
using System.Collections.Generic;

namespace ProjectFacul.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string strConexao;

        public UsuarioRepository(string strConexao)
        {
            this.strConexao = strConexao;
        }

        public Usuarios Adicionar(Usuarios Usuario)
        {
            throw new NotImplementedException();
        }

        public Usuarios Alterar(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Usuarios Deletar(Guid idUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Usuarios Selecionar(string usuario)
        {
            Usuarios usu = null;
            using (NpgsqlConnection con = new NpgsqlConnection())
            {
                //ABRIR CONEXÃO COM O BD
                con.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = con;
                //CRIAR O COMANDO A SER EXECUTADO
                command.CommandText = "SELECT usuario, senha FROM public.usuario WHERE usuario=@usuario";
                command.Parameters.AddWithValue("usuario", usuario);
                NpgsqlDataReader leitor = command.ExecuteReader(); 
                while (leitor.Read())
                {
                    usu = new Usuarios()
                    {
                        Usuario = leitor["usuario"].ToString(),
                        Senha = leitor["senha"].ToString()
                    };
                }
                return usu;

                //EXECUTAMOS O COMANDO
                //command.ExecuteNonQuery();
            }
        }
    }
}
