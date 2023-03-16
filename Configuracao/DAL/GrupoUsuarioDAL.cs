using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DAL
{
   public class GrupoUsuarioDAL
    {
        public void inserir(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo)      
                                  VALUE(@NomeGrupo )";
                
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("O correu um erro na tentativa de inserir uma descrissao. por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }
           

        }
        public void Alterar(GrupoUsuario _grupousuario)
        {

        }
        public void Excluir(int _id)
        {

        }
        public List<GrupoUsuario> BuscarPorTodos()
        {
            throw new NotImplementedException();
        }
        public List<GrupoUsuario> BuscarPorNome(string _nome)
        {
            throw new NotImplementedException();
        }
        public List<GrupoUsuario> BuscarPorId(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
