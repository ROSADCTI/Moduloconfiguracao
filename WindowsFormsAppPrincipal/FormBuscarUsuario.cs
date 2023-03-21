﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()

        {
            InitializeComponent();
        }
            
        private void buttonBuscar_Click(object sender, EventArgs e)

        {
            
            usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
        }
        private void buttonExcluirusauario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL(). Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluído com sucesso!");
        }

       

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não há registro selecionar para ser alterado.");
                return;
            }
            else
            {
                int id = ((Usuario)usuarioBindingSource.Current).Id;

                using (FormCadastrodeUsuario frm = new FormCadastrodeUsuario(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);

            }

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastrodeUsuario frm = new FormCadastrodeUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }
    }
}
