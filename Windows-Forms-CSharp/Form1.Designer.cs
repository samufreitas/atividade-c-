namespace TesteSistema
{
    partial class TelaPrincipal
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
            components = new System.ComponentModel.Container();
            resultado = new Label();
            salvar = new Button();
            campo_nome = new TextBox();
            campo_cod = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            campo_quantidade = new TextBox();
            label5 = new Label();
            campo_fornecedor = new TextBox();
            dados = new DataGridView();
            conexaoBindingSource = new BindingSource(components);
            carregar = new Button();
            Deletar = new Button();
            atualizar_registro = new Button();
            ((System.ComponentModel.ISupportInitialize)dados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resultado.Location = new Point(609, 15);
            resultado.Name = "resultado";
            resultado.Size = new Size(90, 32);
            resultado.TabIndex = 1;
            resultado.Text = "Vendas";
            resultado.Click += resultado_Click;
            // 
            // salvar
            // 
            salvar.BackColor = Color.FromArgb(0, 192, 0);
            salvar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            salvar.Location = new Point(141, 237);
            salvar.Margin = new Padding(3, 2, 3, 2);
            salvar.Name = "salvar";
            salvar.Size = new Size(194, 43);
            salvar.TabIndex = 2;
            salvar.Text = "Cadastrar";
            salvar.UseVisualStyleBackColor = false;
            salvar.Click += botao2_Click;
            // 
            // campo_nome
            // 
            campo_nome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_nome.Location = new Point(141, 28);
            campo_nome.Margin = new Padding(3, 2, 3, 2);
            campo_nome.Name = "campo_nome";
            campo_nome.Size = new Size(195, 39);
            campo_nome.TabIndex = 3;
            campo_nome.TextChanged += campo_nome_TextChanged;
            // 
            // campo_cod
            // 
            campo_cod.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_cod.Location = new Point(141, 83);
            campo_cod.Margin = new Padding(3, 2, 3, 2);
            campo_cod.Name = "campo_cod";
            campo_cod.Size = new Size(195, 39);
            campo_cod.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome da peça:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Código:";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 144);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 13;
            label4.Text = "Quantidade:";
            label4.Click += label4_Click_1;
            // 
            // campo_quantidade
            // 
            campo_quantidade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_quantidade.Location = new Point(141, 136);
            campo_quantidade.Margin = new Padding(3, 2, 3, 2);
            campo_quantidade.Name = "campo_quantidade";
            campo_quantidade.Size = new Size(195, 39);
            campo_quantidade.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 190);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 15;
            label5.Text = "Fornecedor:";
            // 
            // campo_fornecedor
            // 
            campo_fornecedor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            campo_fornecedor.Location = new Point(141, 183);
            campo_fornecedor.Margin = new Padding(3, 2, 3, 2);
            campo_fornecedor.Name = "campo_fornecedor";
            campo_fornecedor.Size = new Size(195, 39);
            campo_fornecedor.TabIndex = 14;
            // 
            // dados
            // 
            dados.BackgroundColor = Color.White;
            dados.BorderStyle = BorderStyle.None;
            dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dados.Location = new Point(390, 49);
            dados.Margin = new Padding(3, 2, 3, 2);
            dados.Name = "dados";
            dados.RowHeadersWidth = 51;
            dados.RowTemplate.Height = 18;
            dados.RowTemplate.ReadOnly = true;
            dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dados.Size = new Size(470, 231);
            dados.TabIndex = 16;
            dados.CellClick += dados_CellClick;
            dados.CellContentClick += dados_CellContentClick;
            // 
            // carregar
            // 
            carregar.BackColor = Color.Lime;
            carregar.Location = new Point(705, 23);
            carregar.Margin = new Padding(3, 2, 3, 2);
            carregar.Name = "carregar";
            carregar.Size = new Size(155, 22);
            carregar.TabIndex = 17;
            carregar.Text = "Atualizar tabela";
            carregar.UseVisualStyleBackColor = false;
            carregar.Click += carregar_Click;
            // 
            // Deletar
            // 
            Deletar.BackColor = Color.Red;
            Deletar.ForeColor = Color.Black;
            Deletar.Location = new Point(656, 284);
            Deletar.Margin = new Padding(3, 2, 3, 2);
            Deletar.Name = "Deletar";
            Deletar.Size = new Size(204, 43);
            Deletar.TabIndex = 18;
            Deletar.Text = "Deletar";
            Deletar.UseVisualStyleBackColor = false;
            Deletar.Click += Deletar_Click;
            // 
            // atualizar_registro
            // 
            atualizar_registro.BackColor = Color.RoyalBlue;
            atualizar_registro.Location = new Point(390, 284);
            atualizar_registro.Margin = new Padding(3, 2, 3, 2);
            atualizar_registro.Name = "atualizar_registro";
            atualizar_registro.Size = new Size(194, 43);
            atualizar_registro.TabIndex = 19;
            atualizar_registro.Text = "Atualizar Registro";
            atualizar_registro.UseVisualStyleBackColor = false;
            atualizar_registro.Click += button1_Click_1;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(942, 367);
            Controls.Add(atualizar_registro);
            Controls.Add(Deletar);
            Controls.Add(carregar);
            Controls.Add(dados);
            Controls.Add(label5);
            Controls.Add(campo_fornecedor);
            Controls.Add(label4);
            Controls.Add(campo_quantidade);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(campo_cod);
            Controls.Add(campo_nome);
            Controls.Add(salvar);
            Controls.Add(resultado);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dados).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label resultado;
        private Button salvar;
        private TextBox campo_nome;
        private TextBox campo_cod;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox campo_quantidade;
        private Label label5;
        private TextBox campo_fornecedor;
        private DataGridView dados;
        private BindingSource conexaoBindingSource;
        private Button carregar;
        private Button Deletar;
        private Button atualizar_registro;
    }
}