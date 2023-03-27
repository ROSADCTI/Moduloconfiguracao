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
    public partial class FormPermissao : Form
    {
        public FormPermissao()
        {
            InitializeComponent();
        }

        private void permissaoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorTodos();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Permissao)permissaoBindingSource.Current).IdPermissao;
            using (FormCadastroPermissao frm = new FormCadastroPermissao(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (permissaoBindingSource .Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Permissao)permissaoBindingSource.Current).IdPermissao;
            new GrupoUsuarioBLL().Excluir(id);
            permissaoBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormPermissao frm = new FormPermissao())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
    }
}
