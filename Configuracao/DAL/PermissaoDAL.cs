using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermissaoDAL
    {
        public void inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Descricao)
                                  VALUE(@Descricao )";
                cmd.Parameters.AddWithValue("@Descricao", _permissao.descricao);
                
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("ocorreu um erro na tentativa de inserir uma descrissao. por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Alterar(Permissao _permissao)
        {

        }
        public void Excluir(int _id)
        {

        }
        public List<Permissao> BuscarPorTodos()
        {
            
           
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            throw new NotImplementedException();
        }
        public List<Permissao> BuscarPorId(int _id)
        {
                
   
        }  
    }
}
