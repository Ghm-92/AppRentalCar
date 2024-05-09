using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRentalcar
{
    internal class Carro
    {
        public int id {  get; set; }
        public int tipo_id { get; set; }
        public int cor_id { get; set; }
        public int marca_id { get; set; }
        public int ano_id { get; set; }
        public string? acessorios { get; set; }
        public string? cambio { get; set; }
        public string? caminho_imagem { get; set; }
        public string? nome { get; set; }
        public decimal? preco { get; set; }
        public decimal? quilometragem { get; set;}
            public static DataTable GetCarros()
            {
                string sql = "SELECT * FROM carros ORDER BY nome";
                // Cria o objeto que irá conter os dados 
                DataTable dt = new DataTable();


                try
                {
                    // Cria o objeto de conexão
                    MySqlConnection conexao = new MySqlConnection(Connectdb.stringConexao);

                    // Abre a conexão
                    conexao.Open();

                    // Cria o objeto que prepara a instrução SQL 
                    MySqlCommand sqlCommand = new MySqlCommand(sql, conexao);

                    // Cria o objeto DataReader que executará o SQL no banco
                    var dr = sqlCommand.ExecuteReader();

                    // Atribui o DataReader (que contém os dados) ao DataTable
                    dt.Load(dr);

                    // Fecha o DataReader
                    dr.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return dt;
            }

            public void SalvarCarro()
            {
                string sql = "INSERT INTO carros(nome,marca_id,cor_id,ano_id,tipo_id,acessorios,cambio,caminho_imagem,preco,quilometragem)" +
                    "VALUES(@nome,@marca_id,@cor_id,@ano_id,@tipo_id,@acessorios,@cambio,@caminho_imagem,@preco,@quilometragem)";

                try
                {
                    // Cria o objeto de conexão
                    MySqlConnection conexao = new MySqlConnection(Connectdb.stringConexao);

                    // Abre a conexão
                    conexao.Open();

                    // Cria o objeto que prepara a instrução SQL 
                    MySqlCommand sqlCommand = new MySqlCommand(sql, conexao);
                    //sqlCommand.Parameters.AddWithValue("@id", this.id);
                    sqlCommand.Parameters.AddWithValue("@nome", this.nome);
                    sqlCommand.Parameters.AddWithValue("@marca_id", this.marca_id);
                    sqlCommand.Parameters.AddWithValue("@ano_id", this.ano_id);
                    sqlCommand.Parameters.AddWithValue("@cor_id", this.cor_id);
                    sqlCommand.Parameters.AddWithValue("@tipo_id", this.tipo_id);
                    sqlCommand.Parameters.AddWithValue("@preco", this.preco);
                    sqlCommand.Parameters.AddWithValue("@quilometragem", this.quilometragem);
                    sqlCommand.Parameters.AddWithValue("@acessorios", this.acessorios);
                    sqlCommand.Parameters.AddWithValue("@cambio",this.cambio);
                    sqlCommand.Parameters.AddWithValue("@caminho_imagem", this.caminho_imagem);
                    

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        public void DeletarCarro()
        {
            string sql = "DELETE INTO carros(nome,marca_id,cor_id,ano_id,tipo_id,acessorios,cambio,caminho_imagem,preco,quilometragem)" +
                "VALUES(@nome,@marca_id,@cor_id,@ano_id,@tipo_id,@acessorios,@cambio,@caminho_imagem,@preco,@quilometragem)";

            try
            {
                // Cria o objeto de conexão
                MySqlConnection conexao = new MySqlConnection(Connectdb.stringConexao);

                // Abre a conexão
                conexao.Open();

                // Cria o objeto que prepara a instrução SQL 
                MySqlCommand sqlCommand = new MySqlCommand(sql, conexao);
                //sqlCommand.Parameters.AddWithValue("@id", this.id);
                sqlCommand.Parameters.AddWithValue("@nome", this.nome);
                sqlCommand.Parameters.AddWithValue("@marca_id", this.marca_id);
                sqlCommand.Parameters.AddWithValue("@ano_id", this.ano_id);
                sqlCommand.Parameters.AddWithValue("@cor_id", this.cor_id);
                sqlCommand.Parameters.AddWithValue("@tipo_id", this.tipo_id);
                sqlCommand.Parameters.AddWithValue("@preco", this.preco);
                sqlCommand.Parameters.AddWithValue("@quilometragem", this.quilometragem);
                sqlCommand.Parameters.AddWithValue("@acessorios", this.acessorios);
                sqlCommand.Parameters.AddWithValue("@cambio", this.cambio);
                sqlCommand.Parameters.AddWithValue("@caminho_imagem", this.caminho_imagem);


                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }


}
