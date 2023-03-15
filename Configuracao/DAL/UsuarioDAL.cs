using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class UsuarioDAL
    {
        public void inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Nome, NomeUsuario, Email,CPF,Senha,Ativo)
                                  VALEUS(@Nome,@NomeUsuario,@Email,@CPF,@Senha,@Ativo )";
                cmd.Parameters.AddWithValue("@Nome",_usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.Cpf);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
             catch(Exception ex)
            {
                throw new Exception("ocorreu um erro na tentativa de inserir um usuário. por favor verifique sua conexão",ex);
            }
            finally
            {
                cn.Close();
            }
            
        }    
        public void Alterar(Usuario _usuario)
        {

        }
        public void Excluir (int _id)
            
        {

        }
        public List<Usuario> BuscarPorTodos()
        {
            throw new NotImplementedException();
        }
        public List<Usuario> BuscarPorNome(string _nome)
        {
            throw new NotImplementedException();
        }
        public List<Usuario> BuscarPorId(int _id)
        {
            throw new NotImplementedException();
        }
    }   
}