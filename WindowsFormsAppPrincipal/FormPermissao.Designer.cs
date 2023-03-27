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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPermissao));
            this.permissaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.permissaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdicional = new System.Windows.Forms.Button();
            this.buttonAdicionalPermissao = new System.Windows.Forms.Button();
            this.buttonEcluirPermissao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingNavigator)).BeginInit();
            this.permissaoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoBindingNavigator
            // 
            this.permissaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.permissaoBindingNavigator.BindingSource = this.permissaoBindingSource;
            this.permissaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.permissaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.permissaoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.permissaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.permissaoBindingNavigatorSaveItem});
            this.permissaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.permissaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.permissaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.permissaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.permissaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.permissaoBindingNavigator.Name = "permissaoBindingNavigator";
            this.permissaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.permissaoBindingNavigator.Size = new System.Drawing.Size(1124, 27);
            this.permissaoBindingNavigator.TabIndex = 0;
            this.permissaoBindingNavigator.Text = "bindingNavigator1";
            this.permissaoBindingNavigator.RefreshItems += new System.EventHandler(this.permissaoBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // permissaoBindingNavigatorSaveItem
            // 
            this.permissaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.permissaoBindingNavigatorSaveItem.Enabled = false;
            this.permissaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("permissaoBindingNavigatorSaveItem.Image")));
            this.permissaoBindingNavigatorSaveItem.Name = "permissaoBindingNavigatorSaveItem";
            this.permissaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.permissaoBindingNavigatorSaveItem.Text = "Save Data";
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
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.permissaoBindingSource;
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
            // buttonAdicionar
            // 
            this.buttonAdicionar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonAdicionar.Location = new System.Drawing.Point(311, 83);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 33);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Buscar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(392, 82);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 33);
            this.buttonAlterar.TabIndex = 4;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(464, 83);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(96, 33);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // idGrupoDataGridViewTextBoxColumn
            // 
            this.idGrupoDataGridViewTextBoxColumn.DataPropertyName = "IdGrupo";
            this.idGrupoDataGridViewTextBoxColumn.HeaderText = "Id Grupo";
            this.idGrupoDataGridViewTextBoxColumn.Name = "idGrupoDataGridViewTextBoxColumn";
            this.idGrupoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // buttonAdicional
            // 
            this.buttonAdicional.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdicional.Location = new System.Drawing.Point(566, 83);
            this.buttonAdicional.Name = "buttonAdicional";
            this.buttonAdicional.Size = new System.Drawing.Size(85, 34);
            this.buttonAdicional.TabIndex = 5;
            this.buttonAdicional.Text = "Adicional";
            this.buttonAdicional.UseVisualStyleBackColor = true;
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
            // FormPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.buttonEcluirPermissao);
            this.Controls.Add(this.buttonAdicionalPermissao);
            this.Controls.Add(this.buttonAdicional);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grupoDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.Controls.Add(this.permissaoBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPermissao";
            this.Text = "Cadastro Permissao";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingNavigator)).EndInit();
            this.permissaoBindingNavigator.ResumeLayout(false);
            this.permissaoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.BindingNavigator permissaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton permissaoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private System.Windows.Forms.DataGridView grupoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdicional;
        private System.Windows.Forms.Button buttonAdicionalPermissao;
        private System.Windows.Forms.Button buttonEcluirPermissao;
    }
}