using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormGrupoUsualrio : Form
    {
        public FormGrupoUsualrio()
        {
            InitializeComponent();
        }

        private void FormGrupoUsualrio_Load(object sender, EventArgs e)
        {
            grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorTodos();
        } 
    }
}
