using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
                                  VALUES(@NomeGrupo )";

                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um grupo de usuário no banco de dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public void Alterar(GrupoUsuario _grupousuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "update GrupoUsuario set NomeGrupo = @nomegrupo WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _grupousuario.IdGrupo);
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("O correu um erro ao tentarde alterar um grupo de usuário no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;
            using (SqlConnection cn = new SqlConnection(Conexao.stringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM GrupoUsuario WHERE Id = @Id", cn)) ;
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _idGrupoUsuario);

                        if (_transaction != null)
                        {
                            cn.Open();
                            transaction.Rollback();

                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = cn;

                        RemoverGrupoPermissao(_idGrupoUsuario, transaction);
                        RemoverTodoUsuario(_idGrupoUsuario, transaction);
                        cmd.ExecuteNonQuery();

                        if (_transaction != null);



                    }
                    catch (Exception ex)
                    {
                        throw new Exception("O correu um erro na tentativa de exluir um usuário.por favor verifique sua conexão", ex);
                    }
                    transaction.Commit();
                  

                }

            }
            private RemoverGrupoPermissao(int _idGrupoUsuario, SqlTransaction _transaction = null)
            {
                SqlTransaction transaction
            }


        }

        public List<GrupoUsuario> BuscarPorTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            List<GrupoUsuario> grupousuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.IdGrupo = Convert.ToInt32(rd["Id"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupousuarios.Add(grupousuario);
                    }
                }
                return grupousuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuários no banco de dados. Por favor verifique sua conexao", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorNome(string _nomegrupo)
        {

            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            List<GrupoUsuario> grupousuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario = new GrupoUsuario();


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,NomeGrupo FROM GrupoUsuario WHERE Nomegrupo LIKE @Nomegrupo";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nomegrupo", "%" + _nomegrupo + "%");
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())

                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.IdGrupo = Convert.ToInt32(rd["Id"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupousuarios.Add(grupousuario);
                    }
                }

                return grupousuarios;
            }

            catch (Exception ex)
            {
                throw new Exception("O correu um erro ao tentar buscar grupo de usuário por nome no grupo no banco de dados . Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<GrupoUsuario> BuscarPorId(int _id)

        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            List<GrupoUsuario> grupousuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario = new GrupoUsuario();
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id,NomeGrupo FROM GrupoUsuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())


                {
                    while (rd.Read())
                    {

                        grupousuario.IdGrupo = Convert.ToInt32(rd["Id"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo "].ToString();
                        grupousuarios.Add(grupousuario);
                    }
                }

                return grupousuarios;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar grupo usuario por Id no banco de dados. verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorIdUsuario(int _idUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            List<GrupoUsuario> grupousuarios = new List<GrupoUsuario>();
            GrupoUsuario grupousuario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GrupoUsuario.Id, GrupoUsuario.NomeGrupo FROM GrupoUsuario
                    INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.Id = UsuarioGrupoUsuario.IdGrupoUsuario
                    WHERE UsuarioGrupoUsuario.IdUsuario = @Idusuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Idusuario", _idUsuario);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupousuario = new GrupoUsuario();
                        grupousuario.IdGrupo = Convert.ToInt32(rd["Id"]);
                        grupousuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupousuarios.Add(grupousuario);

                    }
                }
                return grupousuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar grupos de usuário Id do usuário do banco de dado. ");
            }
            finally
            {
                cn.Close();
            }
        }

        public void RemoverPermissao(int _idPermissao, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM PermissaoGrupoUsuario 
                                    WHERE IdPermissao = @IdPermissao AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar remover uma permissao de um grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool PermissaoPertenceAoGrupo(int idGrupoUsuario, int idPermissao)
        {
            throw new NotImplementedException();
        }
        public bool UsuarioPertenceAoGrupo(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM UsuarioGrupoUsuario
                                    WHERE IdUsuario = @IdUsuario AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar existência de grupo vinculado a um usuário no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarPermissao(int idGrupoUsuario, int idPermissao)
        {
            throw new NotImplementedException();
        }
        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.stringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO UsuarioGrupoUsuario(IdUsuario, IdGrupoUsuario) 
                                        VALUES(@IdUsuario, @IdGrupoUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular um grupo a um usuário no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}   