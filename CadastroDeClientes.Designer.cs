
namespace CRUD_C_SHARP
{
    partial class Cadastro_de_clientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.CPF_CNPJ = new System.Windows.Forms.Label();
            this.txtCPF_CNPJ = new System.Windows.Forms.TextBox();
            this.dgvFiltrar_Clientes = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrar_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.Control;
            this.Nome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(12, 16);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(41, 16);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(12, 75);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(54, 16);
            this.Telefone.TabIndex = 1;
            this.Telefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(109, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(433, 22);
            this.txtNome.TabIndex = 2;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(691, 46);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(109, 72);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(172, 22);
            this.txtTelefone.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(107, 103);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(200, 103);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 103);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(88, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(691, 75);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 22);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.AutoSize = true;
            this.CPF_CNPJ.Location = new System.Drawing.Point(12, 44);
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.Size = new System.Drawing.Size(70, 16);
            this.CPF_CNPJ.TabIndex = 10;
            this.CPF_CNPJ.Text = "CPF/CNPJ";
            // 
            // txtCPF_CNPJ
            // 
            this.txtCPF_CNPJ.Location = new System.Drawing.Point(109, 41);
            this.txtCPF_CNPJ.Name = "txtCPF_CNPJ";
            this.txtCPF_CNPJ.Size = new System.Drawing.Size(172, 22);
            this.txtCPF_CNPJ.TabIndex = 11;
            // 
            // dgvFiltrar_Clientes
            // 
            this.dgvFiltrar_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrar_Clientes.Location = new System.Drawing.Point(12, 151);
            this.dgvFiltrar_Clientes.Name = "dgvFiltrar_Clientes";
            this.dgvFiltrar_Clientes.RowTemplate.Height = 25;
            this.dgvFiltrar_Clientes.Size = new System.Drawing.Size(776, 321);
            this.dgvFiltrar_Clientes.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(691, 17);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // Cadastro_de_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvFiltrar_Clientes);
            this.Controls.Add(this.txtCPF_CNPJ);
            this.Controls.Add(this.CPF_CNPJ);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpButton = true;
            this.Name = "Cadastro_de_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrar_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label CPF_CNPJ;
        private System.Windows.Forms.TextBox txtCPF_CNPJ;
        private System.Windows.Forms.DataGridView dgvFiltrar_Clientes;
        private System.Windows.Forms.Button btnFiltrar;
    }
}

