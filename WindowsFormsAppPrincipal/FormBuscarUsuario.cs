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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.Nome = "Rosilene";
            usuario.NomeUsuario = "Test";
            usuario.Ativo = true;
            usuario.Cpf = "415.485.148.84";
            usuario.Senha = "157861";
            usuario.Email = "contato@gmail.com";
        }
    }
}
