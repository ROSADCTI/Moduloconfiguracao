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
using BLL;

namespace WindowsFormsAppPrincipal
{
    public partial class FormTelaprincipal : Form
    {
        public FormTelaprincipal()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Rosilene";
            usuario.Nome = "Rosa";
            usuario.Email = "Clementerosa@gmail.com";
            usuario.Cpf = "456.556.015.91";
            usuario.Senha = "R12356c";
            usuario.Ativo = true;
            
            new UsuarioBLL(). Inserir(usuario);
        }

        private void FormTelaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
