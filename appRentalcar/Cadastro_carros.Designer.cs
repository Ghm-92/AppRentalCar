namespace appRentalcar
{
    partial class Cadastro_carros
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
            dataGridView1 = new DataGridView();
            tabControl = new TabControl();
            tabConsulta = new TabPage();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            tabCadastro = new TabPage();
            txtQuilometragem = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtPreco = new TextBox();
            txtAcessorios = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            cboTipo = new ComboBox();
            cboMarca = new ComboBox();
            cboCor = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imgCarro = new PictureBox();
            txtNomeCarro = new TextBox();
            cboAno = new ComboBox();
            textBox1 = new TextBox();
            cboCambio = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl.SuspendLayout();
            tabConsulta.SuspendLayout();
            tabCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCarro).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(756, 355);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConsulta);
            tabControl.Controls.Add(tabCadastro);
            tabControl.Location = new Point(12, 59);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 457);
            tabControl.TabIndex = 1;
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(btnNovo);
            tabConsulta.Controls.Add(btnExcluir);
            tabConsulta.Controls.Add(btnEditar);
            tabConsulta.Controls.Add(dataGridView1);
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(768, 429);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.FlatStyle = FlatStyle.Popup;
            btnNovo.Location = new Point(108, 389);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(122, 33);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.IndianRed;
            btnExcluir.FlatStyle = FlatStyle.Popup;
            btnExcluir.ForeColor = Color.Black;
            btnExcluir.Location = new Point(479, 389);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(117, 33);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Deletar";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(286, 389);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(122, 33);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tabCadastro
            // 
            tabCadastro.Controls.Add(cboCambio);
            tabCadastro.Controls.Add(txtQuilometragem);
            tabCadastro.Controls.Add(label10);
            tabCadastro.Controls.Add(label9);
            tabCadastro.Controls.Add(txtPreco);
            tabCadastro.Controls.Add(txtAcessorios);
            tabCadastro.Controls.Add(label8);
            tabCadastro.Controls.Add(label7);
            tabCadastro.Controls.Add(btnSalvar);
            tabCadastro.Controls.Add(btnCancelar);
            tabCadastro.Controls.Add(cboTipo);
            tabCadastro.Controls.Add(cboMarca);
            tabCadastro.Controls.Add(cboCor);
            tabCadastro.Controls.Add(label6);
            tabCadastro.Controls.Add(label5);
            tabCadastro.Controls.Add(label4);
            tabCadastro.Controls.Add(label3);
            tabCadastro.Controls.Add(label2);
            tabCadastro.Controls.Add(label1);
            tabCadastro.Controls.Add(imgCarro);
            tabCadastro.Controls.Add(txtNomeCarro);
            tabCadastro.Controls.Add(cboAno);
            tabCadastro.Controls.Add(textBox1);
            tabCadastro.Location = new Point(4, 24);
            tabCadastro.Name = "tabCadastro";
            tabCadastro.Padding = new Padding(3);
            tabCadastro.Size = new Size(768, 429);
            tabCadastro.TabIndex = 1;
            tabCadastro.Text = "Cadastro";
            tabCadastro.UseVisualStyleBackColor = true;
            // 
            // txtQuilometragem
            // 
            txtQuilometragem.Location = new Point(593, 101);
            txtQuilometragem.Name = "txtQuilometragem";
            txtQuilometragem.Size = new Size(130, 23);
            txtQuilometragem.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(593, 83);
            label10.Name = "label10";
            label10.Size = new Size(120, 15);
            label10.TabIndex = 25;
            label10.Text = "Quilometragem (KM)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(487, 83);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 23;
            label9.Text = "Cambio";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(487, 231);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(236, 23);
            txtPreco.TabIndex = 22;
            // 
            // txtAcessorios
            // 
            txtAcessorios.Location = new Point(487, 169);
            txtAcessorios.Name = "txtAcessorios";
            txtAcessorios.Size = new Size(236, 23);
            txtAcessorios.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 151);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 20;
            label8.Text = "Acessórios";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 213);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 19;
            label7.Text = "Preço";
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(487, 376);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 33);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(630, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 33);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Hatch", "Sedan", "SUV", "Crossover", "Minivan", "Picape" });
            cboTipo.Location = new Point(374, 101);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(85, 23);
            cboTipo.TabIndex = 16;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Items.AddRange(new object[] { "Vw", "Fiat", "Gm", "Hyundai", "Toyota", "Jeep", "Renault", "Honda", "Nissan", "Peugeot", "Citroen" });
            cboMarca.Location = new Point(30, 101);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(113, 23);
            cboMarca.TabIndex = 15;
            // 
            // cboCor
            // 
            cboCor.FormattingEnabled = true;
            cboCor.Items.AddRange(new object[] { "Branco", "Cinza", "Preto", "Azul", "Prata", "Vermelho", "Marrom", "Verde", "Amarelo", "Laranja" });
            cboCor.Location = new Point(165, 101);
            cboCor.Name = "cboCor";
            cboCor.Size = new Size(85, 23);
            cboCor.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 83);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 13;
            label6.Text = "Cor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 83);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "Ano";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 83);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 83);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 24);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Carro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 8;
            label1.Text = "ID";
            // 
            // imgCarro
            // 
            imgCarro.Location = new Point(30, 146);
            imgCarro.Name = "imgCarro";
            imgCarro.Size = new Size(429, 263);
            imgCarro.TabIndex = 7;
            imgCarro.TabStop = false;
            // 
            // txtNomeCarro
            // 
            txtNomeCarro.Location = new Point(165, 42);
            txtNomeCarro.Name = "txtNomeCarro";
            txtNomeCarro.Size = new Size(558, 23);
            txtNomeCarro.TabIndex = 6;
            // 
            // cboAno
            // 
            cboAno.FormattingEnabled = true;
            cboAno.Items.AddRange(new object[] { "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            cboAno.Location = new Point(271, 101);
            cboAno.Name = "cboAno";
            cboAno.Size = new Size(85, 23);
            cboAno.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 42);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // cboCambio
            // 
            cboCambio.FormattingEnabled = true;
            cboCambio.Items.AddRange(new object[] { "Manual", "Automatico" });
            cboCambio.Location = new Point(487, 101);
            cboCambio.Name = "cboCambio";
            cboCambio.Size = new Size(85, 23);
            cboCambio.TabIndex = 27;
            // 
            // Cadastro_carros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(tabControl);
            Name = "Cadastro_carros";
            Text = "Cadastro Carros";
            Load += Cadastro_carros_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl.ResumeLayout(false);
            tabConsulta.ResumeLayout(false);
            tabCadastro.ResumeLayout(false);
            tabCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgCarro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl;
        private TabPage tabConsulta;
        private Button btnExcluir;
        private Button btnEditar;
        private TabPage tabCadastro;
        private TextBox txtNomeCarro;
        private ComboBox cboAno;
        private TextBox textBox1;
        private ComboBox cboTipo;
        private ComboBox cboMarca;
        private ComboBox cboCor;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imgCarro;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnNovo;
        private TextBox txtPreco;
        private TextBox txtAcessorios;
        private Label label8;
        private Label label7;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox2;
        private Label label9;
        private ComboBox cboCambio;
        private TextBox txtQuilometragem;
    }
}