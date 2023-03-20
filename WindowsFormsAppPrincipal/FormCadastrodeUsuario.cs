using BLL;
using Models;
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
    public partial class FormCadastrodeUsuario : Form
    {
        
        public int id;
        public FormCadastrodeUsuario( int _id = 0)
         {
            InitializeComponent();
            id = _id;
        }

       

        private void CadastrodeUsuario_Load(object sender, EventArgs e)
        {
            if(id == 0)
            usuarioBindingSource.AddNew();
            else
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(id);

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.EndEdit();
            usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current);
            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
