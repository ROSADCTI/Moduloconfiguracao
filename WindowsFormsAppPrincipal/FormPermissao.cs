using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPermissao : Form
    {
        public int Id;
        public FormPermissao()

        {
            InitializeComponent();
        }
        

        private void permissaoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorDescricao(TextBoxBuscarpermissao.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissaoBindingSource.Count > 0)
                {
                    Id = ((Permissao)permissaoBindingSource.Current).IdPermissao;
                    Close();
                }
                else
                    MessageBox.Show("Não Existe Registro para se Selecionado.");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
             

    }
}
