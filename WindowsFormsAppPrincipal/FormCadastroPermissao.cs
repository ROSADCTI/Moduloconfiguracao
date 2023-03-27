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
    public partial class FormCadastroPermissao : Form
    {
        int id;
        public FormCadastroPermissao(int id = 0)
        {
            InitializeComponent(); 
            this.id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            permissaoBindingSource.EndEdit();

            if (id == 0)
                permissaoBLL.Inserir((Permissao)permissaoBindingSource.Current);
            else
                permissaoBLL.Alterar((Permissao)permissaoBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso");
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
