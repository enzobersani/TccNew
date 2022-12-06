using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TccRestaurante { 


    public partial class Caixa : Form
    {


    public static Double Resultado = 0;

        public Caixa()
        {
            InitializeComponent();
        }

        MySqlConnection sqlCon = null;
        private string strCon = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";
        private string strSql = string.Empty;

        private MySqlConnection Conexao;
        private string data_source = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigoFuncionario.Text == "" || txtProduto1.Text == "" || txtValor1.Text == "" || txtQt1.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios sem conteúdo!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                strSql = "insert into venda (idFuncionario, idProduto1, Produto1, idProduto2, Produto2," +
                    "idProduto3, Produto3, idProduto4, Produto4, idProduto5, Produto5, idProduto6, Produto6," +
                    "valor1, valor2, valor3, valor4, valor5, valor6, valorTotal, Qt1, Qt2, Qt3, Qt4, Qt5, Qt6, nomeFuncionario) " +
                    "values ('" + txtCodigoFuncionario.Text + "', '" + txtProduto1.Text + "', '" + txtDesc1.Text + "'," +
                    " '" + txtProduto2.Text + "','" + txtDesc2.Text + "', '" +txtProduto3.Text+ "', '" +txtDesc3.Text+"'" +
                    ", '" +txtProduto4.Text+ "', '" +txtDesc4.Text+ "', '" +txtProduto5.Text+ "', '" +txtDesc5.Text+"'" +
                    ", '" +txtProduto6.Text+ "', '" +txtDesc6.Text+ "', '" +txtValor1.Text+ "', '" +txtValor2.Text+ "'" +
                    ", '" +txtValor2.Text+ "', '" +txtValor3.Text+ "', '" +txtValor4.Text+ "', '" +txtValor5.Text+ "', '" +txtValor6.Text+ "'" +
                    ", '" +txtQtTotal.Text+ "', '" +txtQt1.Text+ "', '" +txtQt2.Text+ "', '" +txtQt3.Text+ "', '" +txtQt5.Text+ "', '" +txtQt6.Text+ "'" +
                    ", '" +txtDescricaoFuncionario.Text+ "')";
                sqlCon = new MySqlConnection(strCon);
                MySqlCommand comando = new MySqlCommand(strSql, sqlCon);

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Venda realizada com sucesso!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Código de produto ja existente!");
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }

        private void txtCodigoFuncionario_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoFuncionario.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM funcionario " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDescricaoFuncionario.Text = reader.GetString(1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto1_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto1.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc1.Text = reader.GetString(1);
                    txtValor1.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto2_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto2.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc2.Text = reader.GetString(1);
                    txtValor2.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto3_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto3.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc3.Text = reader.GetString(1);
                    txtValor3.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto4_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto4.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc4.Text = reader.GetString(1);
                    txtValor4.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto5_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto5.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc5.Text = reader.GetString(1);
                    txtValor5.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void txtProduto6_Leave(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtProduto6.Text;

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                            "FROM produto " +
                            "WHERE id=" + codigo;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    txtDesc6.Text = reader.GetString(1);
                    txtValor6.Text = reader.GetString(3);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Informe o código!");
            }
            finally
            {
                Conexao.Close();
            }
        }

        

        private void txtQtTotal_TextChanged(object sender, EventArgs e)

        {
     
            //txtQtTotal.Text = Resultado.ToString();
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Remove1(object sender, EventArgs e)
        {
         

        }
        public void Remove2(object sender, EventArgs e)
        {
           
        }
        public void Remove3(object sender, EventArgs e)
        {
        
        }
        public void Remove4(object sender, EventArgs e)
        {
     
        }
        public void Remove5(object sender, EventArgs e)
        {
       
        }
     

        public void Remove7(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {
            if(txtDesc1.Text != null)
            {
                Remove.Visible = true;
            } 
        }

        private void txtDesc2_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc2.Text != null)
            {
                RemoveTwo.Visible = true;
            }
        }

        private void txtDesc3_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc3.Text != null)
            {
                RemoveThree.Visible = true;
            }
        }

        private void txtDesc4_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc4.Text != null)
            {
                RemoveFour.Visible = true;
            }
        }

        private void txtDesc5_TextChanged(object sender, EventArgs e)
        {
            if (txtDesc5.Text != null)
            {
                RemoveFive.Visible = true;
            }
        }
        private void txtDesc6_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDesc6.Text != null)
            {
                RemoveSix.Visible = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

    

          private void txtProduto1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtProduto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto4_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtProduto5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProduto7_TextChanged(object sender, EventArgs e)
        {

        }
        private void Remove_click(object sender, EventArgs e)
        {
            txtProduto1.Clear();
            txtDesc1.Clear();
            txtValor1.Clear();
            txtQt1.Clear();
            Remove.Visible = false;
        }
        private void RemoveTwo_Click(object sender, EventArgs e)
        {
            txtProduto2.Clear();
            txtDesc2.Clear();
            txtValor2.Clear();
            txtQt2.Clear();
            RemoveTwo.Visible = false;
        }
        private void RemoveThree_Click(object sender, EventArgs e)
        {
            txtProduto3.Clear();
            txtDesc3.Clear();
            txtValor3.Clear();
            txtQt3.Clear();
            RemoveThree.Visible = false;
        }
        private void RemoveFour_Click(object sender, EventArgs e)
        {
            txtProduto4.Clear();
            txtDesc4.Clear();
            txtValor4.Clear();
            txtQt4.Clear();
            RemoveFour.Visible = false;
        }
        private void RemoveFive_Click(object sender, EventArgs e)
        {
            txtProduto5.Clear();
            txtDesc5.Clear();
            txtValor5.Clear();
            txtQt5.Clear();
            RemoveFive.Visible = false;
        }

        private void RemoveSix_Click(object sender, EventArgs e)
        {
            txtProduto6.Clear();
            txtDesc6.Clear();
            txtValor6.Clear();
            txtQt6.Clear();
            RemoveSix.Visible = false;
        }

        private void txtValor4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQt7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtQt1.Text != null)
            {
                Double ? valor1, valor2, valor3, valor4, valor5, valor6, resultado;
                int ? qt1, qt2, qt3, qt4, qt5, qt6;

                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);
                valor3 = Convert.ToDouble(txtValor3.Text);
                valor4 = Convert.ToDouble(txtValor4.Text);
                valor5 = Convert.ToDouble(txtValor5.Text);
                valor6 = Convert.ToDouble(txtValor6.Text);

                qt1 = Convert.ToInt32(txtQt1.Text);
                qt2 = Convert.ToInt32(txtQt2.Text);
                qt3 = Convert.ToInt32(txtQt3.Text);
                qt4 = Convert.ToInt32(txtQt4.Text);
                qt5 = Convert.ToInt32(txtQt5.Text);
                qt6 = Convert.ToInt32(txtQt6.Text);

                if(valor2 == null && qt2 == null)
                {
                    resultado = (valor1 * qt1);
                }

                else if (valor3 == null && qt3 == null)
                {
                    resultado = (valor1 * qt1) + (valor2 * qt2);
                }

                else if (valor4 == null && qt4 == null)
                {
                    resultado = (valor1 * qt1) + (valor2 * qt2) + (valor3 * qt3);
                }

                else if (valor5 == null && qt5 == null)
                {
                    resultado = (valor1 * qt1) + (valor2 * qt2) + (valor3 * qt3) + (valor4 * qt4);
                }

                else if (valor6 == null && qt6 == null)
                {
                    resultado = (valor1 * qt1) + (valor2 * qt2) + (valor3 * qt3) + (valor4 * qt4) + (valor5 * qt5);
                }

                else
                {
                    resultado = (valor1 * qt1) + (valor2 * qt2) + (valor3 * qt3) + (valor4 * qt4) + (valor5 * qt5) + (valor6 * qt6);
                }

                txtQtTotal.Text = resultado.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtCodigoFuncionario.Text = "";
            txtDescricaoFuncionario.Text = "";

            txtProduto1.Text = "";
            txtProduto2.Text = "";
            txtProduto2.Text = "";
            txtProduto3.Text = "";
            txtProduto4.Text = "";
            txtProduto5.Text = "";
            txtProduto6.Text = "";

            txtDesc1.Text = "";
            txtDesc2.Text = "";
            txtDesc3.Text = "";
            txtDesc4.Text = "";
            txtDesc5.Text = "";
            txtDesc6.Text = "";

            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            txtValor4.Text = "";
            txtValor5.Text = "";
            txtValor6.Text = "";

            txtQt1.Text = "";
            txtQt2.Text = "";
            txtQt3.Text = "";
            txtQt4.Text = "";
            txtQt5.Text = "";
            txtQt6.Text = "";
            txtCodigoFuncionario.Focus();
        }
    }
}
