using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRentalcar
{
    public partial class Cadastro_carros : Form
    {
        Carro carro = new Carro();
        public Cadastro_carros()
        {
            InitializeComponent();
        }

        private void Cadastro_carros_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            // Cria o objeto datatable e recebe outro datatable devolvido
            // pelo GetCarros()
            DataTable dataTable = Carro.GetCarros();

            // Associa o datatable ao dataGridView
            dataGridView1.DataSource = dataTable;

        }

        private void botoes(int tab)
        {

            if (tab == 1)
            {
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnCancelar.Enabled = false;

                txtNomeCarro.Text = string.Empty;
                cboMarca.SelectedIndex = -1;
                cboCor.SelectedIndex = -1;
                cboAno.SelectedIndex = -1;
                cboTipo.SelectedIndex = -1;
                cboCambio.SelectedIndex = -1;
                txtAcessorios.Text = string.Empty;
                txtPreco.Text = string.Empty;
                txtQuilometragem.Text = string.Empty;


            }
            if (tab == 2)
            {
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            botoes(2);
            tabControl.SelectedTab = tabCadastro;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            botoes(1);
            tabControl.SelectedTab = tabConsulta;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var idCarro = dataGridView1.CurrentRow.Cells["id"].Value;
            Uteis.MensagemInfo(" " + idCarro);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCarro.TextLength < 5)
            {
                Uteis.MensagemAviso("O campo \"Nome do Carro\" deve ter pelo menos 5 caracteres");
                txtNomeCarro.Focus();
                return;
            }

            if (cboMarca.SelectedIndex == -1)
            {
                Uteis.MensagemAviso("O campo \"Marca\" dede ser selecionado");
                cboMarca.Focus();
                return;
            }

            if (cboCor.SelectedIndex == -1)
            {
                Uteis.MensagemAviso("O campo \"Cor\" dede ser selecionado");
                cboCor.Focus();
                return;
            }

            if (cboAno.SelectedIndex == -1)
            {
                Uteis.MensagemAviso("O campo \"Ano\" dede ser selecionado");
                cboAno.Focus();
                return;
            }

            if (cboTipo.SelectedIndex == -1)
            {
                Uteis.MensagemAviso("O campo \"Tipo\" dede ser selecionado");
                cboTipo.Focus();
                return;
            }

            carro.nome = txtNomeCarro.Text;
            carro.marca_id = cboMarca.SelectedIndex;
            carro.cor_id = cboCor.SelectedIndex;
            carro.ano_id = cboAno.SelectedIndex;
            carro.tipo_id = cboTipo.SelectedIndex;
            carro.cambio = cboCambio.SelectedText;
            carro.acessorios = txtAcessorios.Text;
            carro.quilometragem = Convert.ToInt32(txtQuilometragem.Text);
            carro.preco = Convert.ToInt32(txtPreco.Text);
            //carro.caminho_imagem = imgCarro.Image //carregamento caminho imagem no picture box


            try
            {
                carro.SalvarCarro();
                LoadGrid();                             // Atualizar o grid
                Uteis.MensagemInfo("Registro gravado com sucesso");
                botoes(1);                              // Habilitar/desabilitar botões
                tabControl.SelectedTab = tabConsulta;     // Voltar para o grid
            }
            catch (Exception ex)
            {
                Uteis.MensagemErro("Houve um problema: " + ex.Message);
            }
        }
    }
}
