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

namespace TccRestaurante
{
    public partial class ListaFornecedor : Form
    {
        public ListaFornecedor()
        {
            InitializeComponent();
        }

        MySqlConnection Conexao = null;
        private string strCon = "Server = localhost; Database=restaurantetcc;Uid=root;Pwd=";

        private void button1_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigoFornecedor.Text;

            if (txtCodigoFornecedor.Text != "")
            {
                string sql = "SELECT * FROM fornecedor WHERE idFornecedor =" + codigo;
                Conexao = new MySqlConnection(strCon);
                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                try
                {
                    Conexao.Open();
                    MySqlDataReader reader = comando.ExecuteReader();



                    while (reader.Read())
                    {
                        string[] row =
                        {
                            reader.GetString(0),
                            reader.GetString(1)
                        };


                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add(row[0], row[1]);

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtNomeFornecedor.Text + "%'";

                Conexao = new MySqlConnection(strCon);

                string sql = "SELECT * FROM fornecedor WHERE nomeFornecedor LIKE " + q;

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();



                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                    };

                    var linha_listview = new ListViewItem(row);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add(row[0], row[1]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void ListaFornecedor_Load(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(strCon);

                string sql = "SELECT * FROM fornecedor";

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();


                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),

                    };

                    var linha_listview = new ListViewItem(row);



                    dataGridView1.Rows.Add(row[0], row[1]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
