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
            
        }
        public void Alterar(GrupoUsuario _grupousuario)
        {

        }
        public void Deletar(int _id)
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
