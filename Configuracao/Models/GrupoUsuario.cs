using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GrupoUsuario
    {
        public int IdGupo{ get; set; }
        public string NameGrupo { get; set; }
        public List<Permissao> Permitir { get; set; }
    }
}
