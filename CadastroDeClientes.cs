using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CRUD_C_SHARP
{
    
    public partial class Cadastro_de_clientes : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string connectionString;
        public Cadastro_de_clientes()
        {
            InitializeComponent();
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection("Server=localhost;Database=CRUD;User Id=sa;Password=sa123456;");

                connectionString = "INSERT INTO TB_CLIENTES (NOME, TELEFONE, CPF_CNPJ) VALUES (@NOME, @TELEFONE, @CPF_CNPJ)";

                comando = new SqlCommand(connectionString, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@CPF_CNPJ", txtCPF_CNPJ.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=localhost;Database=CRUD;User Id=sa;Password=sa123456;");

                connectionString = "SELECT * FROM TB_CLIENTES";
                
                DataSet ds = new DataSet();

                da = new SqlDataAdapter(connectionString, conexao);
                
                conexao.Open();

                da.Fill(ds);

                dgvFiltrar_Clientes.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=localhost;Database=CRUD;User Id=sa;Password=sa123456;");

                connectionString = "UPDATE TB_CLIENTES SET NOME = @NOME, " +
                    "TELEFONE = @TELEFONE, " +
                    "CPF_CNPJ = @CPF_CNPJ " +
                    "WHERE NOME = @NOME";

                comando = new SqlCommand(connectionString, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@CPF_CNPJ", txtCPF_CNPJ.Text);

                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];
                    txtTelefone.Text = Convert.ToString(dr["telefone"]);
                    txtCPF_CNPJ.Text = Convert.ToString(dr["CPF_CNPJ"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=localhost;Database=CRUD;User Id=sa;Password=sa123456;");

                connectionString = "DELETE TB_CLIENTES WHERE NOME = @NOME";

                comando = new SqlCommand(connectionString, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Server=localhost;Database=CRUD;User Id=sa;Password=sa123456;");

                connectionString = "SELECT * FROM TB_CLIENTES " +
                    "WHERE NOME = @NOME " +
                    "OR TELEFONE = @TELEFONE " +
                    "OR CPF_CNPJ = @CPF_CNPJ";

                comando = new SqlCommand(connectionString, conexao);

                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@CPF_CNPJ", txtCPF_CNPJ.Text);


                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["nome"];
                    txtTelefone.Text = Convert.ToString(dr["telefone"]);
                    txtCPF_CNPJ.Text = Convert.ToString(dr["CPF_CNPJ"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
