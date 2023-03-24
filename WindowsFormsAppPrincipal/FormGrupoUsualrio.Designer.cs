namespace WindowsFormsAppPrincipal
{
    partial class FormGrupoUsualrio
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
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.permitirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permitirDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonExcluirGrupoUsuario = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonAdicionorGrupoUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permitirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permitirDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            this.grupoUsuarioDataGridView.AllowUserToAddRows = false;
            this.grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuarioDataGridView.AutoGenerateColumns = false;
            this.grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuarioDataGridView.DataSource = this.grupoUsuarioBindingSource;
            this.grupoUsuarioDataGridView.Location = new System.Drawing.Point(13, 114);
            this.grupoUsuarioDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            this.grupoUsuarioDataGridView.ReadOnly = true;
            this.grupoUsuarioDataGridView.RowHeadersWidth = 51;
            this.grupoUsuarioDataGridView.RowTemplate.Height = 24;
            this.grupoUsuarioDataGridView.Size = new System.Drawing.Size(792, 275);
            this.grupoUsuarioDataGridView.TabIndex = 0;
            // 
            // permitirBindingSource
            // 
            this.permitirBindingSource.DataMember = "Permitir";
            this.permitirBindingSource.DataSource = this.grupoUsuarioBindingSource;
            // 
            // permitirDataGridView
            // 
            this.permitirDataGridView.AllowUserToAddRows = false;
            this.permitirDataGridView.AllowUserToDeleteRows = false;
            this.permitirDataGridView.AllowUserToOrderColumns = true;
            this.permitirDataGridView.AutoGenerateColumns = false;
            this.permitirDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permitirDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.permitirDataGridView.DataSource = this.permitirBindingSource;
            this.permitirDataGridView.Location = new System.Drawing.Point(812, 114);
            this.permitirDataGridView.Name = "permitirDataGridView";
            this.permitirDataGridView.ReadOnly = true;
            this.permitirDataGridView.RowHeadersWidth = 51;
            this.permitirDataGridView.RowTemplate.Height = 24;
            this.permitirDataGridView.Size = new System.Drawing.Size(358, 275);
            this.permitirDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id Grupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id do Grupo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Grupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdPermissao";
            this.dataGridViewTextBoxColumn3.FillWeight = 106.9519F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id Permissao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn4.FillWeight = 93.04813F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 27);
            this.textBox1.TabIndex = 2;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(343, 82);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(85, 29);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(674, 82);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(85, 29);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdicionar.Location = new System.Drawing.Point(557, 80);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(101, 32);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluirGrupoUsuario
            // 
            this.buttonExcluirGrupoUsuario.Location = new System.Drawing.Point(1058, 80);
            this.buttonExcluirGrupoUsuario.Name = "buttonExcluirGrupoUsuario";
            this.buttonExcluirGrupoUsuario.Size = new System.Drawing.Size(102, 34);
            this.buttonExcluirGrupoUsuario.TabIndex = 3;
            this.buttonExcluirGrupoUsuario.Text = "Excluir";
            this.buttonExcluirGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(449, 83);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(91, 31);
            this.buttonAlterar.TabIndex = 3;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionorGrupoUsuario
            // 
            this.buttonAdicionorGrupoUsuario.Location = new System.Drawing.Point(950, 79);
            this.buttonAdicionorGrupoUsuario.Name = "buttonAdicionorGrupoUsuario";
            this.buttonAdicionorGrupoUsuario.Size = new System.Drawing.Size(93, 34);
            this.buttonAdicionorGrupoUsuario.TabIndex = 3;
            this.buttonAdicionorGrupoUsuario.Text = "Adicionar";
            this.buttonAdicionorGrupoUsuario.UseVisualStyleBackColor = true;
            // 
            // FormGrupoUsualrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 581);
            this.Controls.Add(this.buttonAdicionorGrupoUsuario);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonExcluirGrupoUsuario);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.permitirDataGridView);
            this.Controls.Add(this.grupoUsuarioDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGrupoUsualrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupo Usuario";
            this.Load += new System.EventHandler(this.FormGrupoUsualrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permitirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permitirDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource permitirBindingSource;
        private System.Windows.Forms.DataGridView permitirDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonExcluirGrupoUsuario;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonAdicionorGrupoUsuario;
    }
}