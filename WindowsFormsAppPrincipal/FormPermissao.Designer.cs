namespace WindowsFormsAppPrincipal
{
    partial class FormPermissao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.grupoDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAdicionalPermissao = new System.Windows.Forms.Button();
            this.buttonEcluirPermissao = new System.Windows.Forms.Button();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(55, 121);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(596, 220);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // grupoDataGridView
            // 
            this.grupoDataGridView.AllowUserToAddRows = false;
            this.grupoDataGridView.AllowUserToDeleteRows = false;
            this.grupoDataGridView.AllowUserToOrderColumns = true;
            this.grupoDataGridView.AutoGenerateColumns = false;
            this.grupoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrupoDataGridViewTextBoxColumn,
            this.nomeGrupoDataGridViewTextBoxColumn});
            this.grupoDataGridView.DataSource = this.grupoBindingSource;
            this.grupoDataGridView.Location = new System.Drawing.Point(651, 121);
            this.grupoDataGridView.Name = "grupoDataGridView";
            this.grupoDataGridView.ReadOnly = true;
            this.grupoDataGridView.RowHeadersWidth = 51;
            this.grupoDataGridView.RowTemplate.Height = 24;
            this.grupoDataGridView.Size = new System.Drawing.Size(455, 220);
            this.grupoDataGridView.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonBuscar.Location = new System.Drawing.Point(311, 83);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 33);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(392, 82);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 33);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(464, 83);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(96, 33);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdicionar.Location = new System.Drawing.Point(566, 83);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(85, 34);
            this.buttonAdicionar.TabIndex = 5;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonAdicionalPermissao
            // 
            this.buttonAdicionalPermissao.Location = new System.Drawing.Point(914, 82);
            this.buttonAdicionalPermissao.Name = "buttonAdicionalPermissao";
            this.buttonAdicionalPermissao.Size = new System.Drawing.Size(93, 35);
            this.buttonAdicionalPermissao.TabIndex = 5;
            this.buttonAdicionalPermissao.Text = "Adicional";
            this.buttonAdicionalPermissao.UseVisualStyleBackColor = true;
            // 
            // buttonEcluirPermissao
            // 
            this.buttonEcluirPermissao.Location = new System.Drawing.Point(1013, 82);
            this.buttonEcluirPermissao.Name = "buttonEcluirPermissao";
            this.buttonEcluirPermissao.Size = new System.Drawing.Size(93, 36);
            this.buttonEcluirPermissao.TabIndex = 5;
            this.buttonEcluirPermissao.Text = "Excluir";
            this.buttonEcluirPermissao.UseVisualStyleBackColor = true;
            // 
            // idGrupoDataGridViewTextBoxColumn
            // 
            this.idGrupoDataGridViewTextBoxColumn.DataPropertyName = "IdGrupo";
            this.idGrupoDataGridViewTextBoxColumn.HeaderText = "Id Grupo";
            this.idGrupoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGrupoDataGridViewTextBoxColumn.Name = "idGrupoDataGridViewTextBoxColumn";
            this.idGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGrupoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeGrupoDataGridViewTextBoxColumn
            // 
            this.nomeGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeGrupoDataGridViewTextBoxColumn.DataPropertyName = "NomeGrupo";
            this.nomeGrupoDataGridViewTextBoxColumn.HeaderText = "Nome Grupo";
            this.nomeGrupoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nomeGrupoDataGridViewTextBoxColumn.Name = "nomeGrupoDataGridViewTextBoxColumn";
            this.nomeGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.permissaoBindingSource;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPermissao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id Permissao";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // FormPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.buttonEcluirPermissao);
            this.Controls.Add(this.buttonAdicionalPermissao);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grupoDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPermissao";
            this.Text = "Buscar Permissao";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private System.Windows.Forms.DataGridView grupoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAdicionalPermissao;
        private System.Windows.Forms.Button buttonEcluirPermissao;
    }
}