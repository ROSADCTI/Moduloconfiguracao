using BLL;
using Models;
using System;
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

            if (id == 0)
                usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current);
            else
                usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current);
                           
            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
