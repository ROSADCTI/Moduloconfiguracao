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
using System.Security.Cryptography;

namespace WindowsFormsAppPrincipal
{
    public partial class FormTelaprincipal : Form
    {
        public FormTelaprincipal()
        {
            InitializeComponent();
            
        }

        private void FormTelaprincipal_Load(object sender, EventArgs e)
         
        {
            try
            {
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void grupoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void permissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormPermissao frm = new FormPermissao())
            {
                frm.ShowDialog();
            }
        }
    }
}
