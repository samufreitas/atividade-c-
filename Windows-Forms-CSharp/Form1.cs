using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TesteSistema
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            resultado.Text = campo_nome.Text;

        }

        private void botao2_Click(object sender, EventArgs e)
        {


            string Nome = campo_nome.Text;
            int Cod = Convert.ToInt32(campo_cod.Text);
            int Quantidade = Convert.ToInt32(campo_quantidade.Text);
            string Fornecedor = campo_fornecedor.Text;

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database= csharp; " +
            "user id = root; " +
            "password=2212;");

            MySqlCommand cmd = new MySqlCommand("insert into Vendas values ('" + Nome + "','" + Cod + "','" + Quantidade + "','" + Fornecedor + "' ); ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd

            atualizar_ds();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }




        private void btn_desativar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void carregar_Click(object sender, EventArgs e)
        {

            atualizar_ds();


        }
        public void atualizar_ds()
        {
            MySqlConnection con = new MySqlConnection(
          "server = localhost; " +
          "database= csharp; " +
          "user id = root; " +
          "password=2212;");


            MySqlCommand cmd = new MySqlCommand(" select * from vendas ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd
            /*Pronto após o cmd.ExecuteNonQuery(); selecionamos tudo o
            que tinha dentro do banco,
            agora os passos seguintes irão exibir as informações para
            que o usuário possa vê-las
            */
            MySqlDataAdapter da = new MySqlDataAdapter(); /* da, adapta o banco de dados ao nosso projeto */
            DataSet ds = new DataSet();
            da.SelectCommand = cmd; // adapta cmd ao projeto
            da.Fill(ds); // preenche todas as informações dentro do DataSet
            dados.DataSource = ds; //Datagridview recebe ds já preenchido
            dados.DataMember = ds.Tables[0].TableName;
            /*Agora Datagridview exibe o banco de dados*/
        }

        private void dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            campo_nome.Text = dados.CurrentRow.Cells[0].Value.ToString();
            /* ao clicar em uma linha do datagridview, o conteudo é transferido para o texbox */
            campo_cod.Text = dados.CurrentRow.Cells[1].Value.ToString();
            campo_quantidade.Text = dados.CurrentRow.Cells[2].Value.ToString();
            campo_fornecedor.Text = dados.CurrentRow.Cells[3].Value.ToString(); //

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Nome = campo_cod.Text;
            int Cod = Convert.ToInt32(campo_cod.Text);
            int Quantidade = Convert.ToInt32(campo_quantidade.Text);
            string fornecedor = campo_fornecedor.Text;

            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database= csharp; " +
            "user id = root; " +
            "password=admin;");

            MySqlCommand cmd = new MySqlCommand("update  set Nome = '" + Nome + "', Quantidade = '" + Quantidade + "', Fornecedor = '" + fornecedor + "' where Cod = '" + Cod + "' ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd

            atualizar_ds();
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            int Cod = Convert.ToInt32(campo_cod.Text);


            MySqlConnection con = new MySqlConnection(
            "server = localhost; " +
            "database= csharp; " +
            "user id = root; " +
            "password=2212;");

            MySqlCommand cmd = new MySqlCommand("delete from vendas where Cod = '" + Cod + "' ", con);

            con.Open(); // abre a conexão com o banco
            cmd.ExecuteNonQuery(); // executa cmd

            campo_fornecedor.Clear();
            campo_cod.Clear();
            campo_cod.Clear();
            campo_quantidade.Clear();


            atualizar_ds();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void campo_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_Click(object sender, EventArgs e)
        {

        }
    }
}