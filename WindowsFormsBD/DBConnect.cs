using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics.Contracts;
using System.Globalization;
using System;

namespace WindowsFormsBD
{
    internal class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string username;
        private string password;
        private string database;
        private string port;

        public DBConnect()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "192.168.88.132";
            database = "gestaoformandos";
            username = "programador";
            password = "Cookie@901";
            port = "3306";

            string connectionString = "Server = " + server + ";Port = " + port + ";Database = " +
                database + "; Uid = " + username + "; Pwd = " + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public string StatusConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection.State.ToString();
        }
        public int Count()
        {
            int count = -1;
            string query = "select count(*) from formando";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    count = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }

        public bool Insert(string ID, string nome, string morada, string contacto, string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            string query = "insert into formando (id_formando, nome, morada, contacto, iban, sexo, data_nascimento, id_nacionalidade) values ('" +
               ID + "', '" + nome + "', '" + morada + "', '" + contacto + "', '" + iban + "', '" + sexo + "', '" + data_nascimento + "', '" + id_nacionalidade + "');";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool Insert2(string ID, string nome, string nif, string id_area, string dataNascimento, string id_utilizador)
        {
            string query = "insert into formador (id_formador, nome, nif, id_area,dataNascimento, id_utilizador) values" +
                " ('" +ID + "', '" + nome + "', '" + nif + "', '" + id_area + "', '" + dataNascimento + "', '" + id_utilizador +  "');";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool InserirNacionalidade(string iso2, string nacionalidade )
        {
            string query = "insert into nacionalidade (id_nacionalidade, alf2, nacionalidade) values (0, '" +
               iso2 + "', '" + nacionalidade + "');";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public bool InserirArea(string id_area, string area)
        {
            string query = "insert into area (id_area, area) values ('" +
               id_area + "', '" + area + "');";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public bool Delete(string id)
        {
            string query = "delete from formando where id_formando = '" + id + "';";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public bool DeleteFormador(string id)
        {
            string query = "delete from formador where id_formador = '" + id + "';";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public bool DeleteNacionalidade(string nacionalidade)
        {
            string query = "delete from nacionalidade where nacionalidade = '" + nacionalidade + "';";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool DeleteArea(string area)
        {
            string query = "delete from area where area = '" + area + "';";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public void PreencherComboNacionalidade(ref ComboBox combo)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from " + "nacionalidade order by nacionalidade;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[2].ToString() + " - " + dr["alf2"].ToString() + " - " + dr[0].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                CloseConnection();
            }

        }
        public void PreencherComboArea(ref ComboBox combo)
        {
            string query = "select id_area, area from " + "area order by id_area;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        combo.Items.Add(dr[1].ToString() + " - " + dr["id_area"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }

        public void SelecionarNacionalidade(ref ComboBox combo, string id_nacionalidadeSelecionado)
        {
            combo.Items.Clear(); // Limpa os itens existentes na ComboBox antes de adicionar novos

            string query = "SELECT id_nacionalidade, alf2, nacionalidade FROM Nacionalidade ORDER BY nacionalidade;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string item = $"{dr["alf2"].ToString()} {dr["nacionalidade"].ToString()} {dr["id_nacionalidade"].ToString()}";
                        combo.Items.Add(item);

                        // Verifica se o id_nacionalidade atual corresponde ao id_nacionalidadeSelecionado
                        if (dr["id_nacionalidade"].ToString() == id_nacionalidadeSelecionado)
                        {
                            // Define o índice do item correspondente ao id_nacionalidadeSelecionado
                            combo.SelectedIndex = combo.Items.Count - 1;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void SelecionarArea(ref ComboBox combo, string id_areaSelecionado)
        {
            combo.Items.Clear(); // Limpa os itens existentes na ComboBox antes de adicionar novos

            string query = "SELECT id_area, area FROM area ORDER BY id_area;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string item = $"{dr["area"].ToString()} {dr["id_area"].ToString()}";
                        combo.Items.Add(item);

                        // Verifica se o id_area atual corresponde ao id_areadeSelecionado
                        if (dr["id_area"].ToString() == id_areaSelecionado)
                        {
                            // Define o índice do item correspondente ao id_areaSelecionado
                            combo.SelectedIndex = combo.Items.Count - 1;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public int DevolveUltimoID()
        {
            int ultimoID = 0;

            string query = "select max(id_formando) from formando";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    ultimoID++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return ultimoID;
        }
        public bool PesquisaFormando(string ID_pesquisa, ref string nome, ref string morada, ref string contacto,
            ref string iban, ref char sexo, ref string data_nascimento, ref string id_nacionalidade)
        {
            bool flag = false;

            string query = "SELECT nome, morada, contacto, iban, sexo, data_nascimento, id_nacionalidade FROM formando " +
                 "WHERE id_formando = '" + ID_pesquisa + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nome = dataReader[0].ToString();
                        morada = dataReader["morada"].ToString();
                        contacto = dataReader[2].ToString();
                        iban = dataReader[3].ToString();
                        sexo = dataReader["sexo"].ToString()[0];
                        data_nascimento = dataReader[5].ToString();
                        id_nacionalidade = dataReader[6].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool PesquisaFormador(string ID_pesquisa, ref string nome, ref string nif, ref string id_area, 
            ref string dataNascimento, ref string id_utilizador)
        {
            bool flag = false;

            string query = "SELECT nome, nif, id_area, dataNascimento, id_utilizador FROM formador " +
                 "WHERE id_formador = '" + ID_pesquisa + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nome = dataReader[0].ToString();
                        nif = dataReader["nif"].ToString();
                        id_area = dataReader[2].ToString();
                        dataNascimento = dataReader[3].ToString();
                        id_utilizador = dataReader[4].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public int DevolveUltimoIDFormador()
        {
            int ultimoID = 0;

            string query = "select max(id_formador) from formador";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int.TryParse(cmd.ExecuteScalar().ToString(), out ultimoID);
                    ultimoID++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return ultimoID;
        }
        public bool Update(string id, string nome)
        {
            string query = "update formando set nome = '" + nome + "' where id_formando = '" + id + "'";

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool Update(string ID, string nome, string morada, string contacto, string iban, char sexo, string data_nascimento, string id_nacionalidade)
        {
            string query = "UPDATE formando SET nome = '" + nome + "', morada = '" + morada + "', contacto = '" +
    contacto + "', iban = '" + iban + "', sexo = '" + sexo + "', data_nascimento = '" + data_nascimento + "', id_nacionalidade = '" + id_nacionalidade + "'" +
    " WHERE id_formando = " + ID;


            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }
        public bool Update2(string ID, string nome, string nif, string id_area, string dataNascimento, string id_utilizador)
        {
            string query = "UPDATE formador SET nome = '" + nome + "', nif = '" + nif 
                + "', id_area = '" + id_area + "', dataNascimento = '" + dataNascimento + "', id_utilizador = '" + id_utilizador + "'" + 
                " WHERE id_formador = " + ID;

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }

        public void PreencherDataGridViewFormandos(ref DataGridView dgv)
        {
            string query = "select id_formando, nome, iban, contacto, sexo from formando order by nome;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["codID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["Nome"].Value = dr["nome"].ToString();
                        dgv.Rows[idxLinha].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr["contacto"].ToString();
                        dgv.Rows[idxLinha].Cells["Genero"].Value = dr["sexo"].ToString();
                        

                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        public void PreencherDataGridViewFormador(ref DataGridView dgv)
        {
            string query = "select id_formador, nome, nif, dataNascimento, id_area, area, id_utilizador from vformador order by nome;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["id_formador"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["nome"].Value = dr["nome"].ToString();
                        dgv.Rows[idxLinha].Cells["nif"].Value = dr["nif"].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr[3].ToString();
                        dgv.Rows[idxLinha].Cells[4].Value = dr[4].ToString();
                        dgv.Rows[idxLinha].Cells[5].Value = dr[5].ToString();
                        dgv.Rows[idxLinha].Cells[6].Value = dr[6].ToString();
                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }

        public void PreencherDataGridViewNacionalidade(ref DataGridView dgv)
        {
            string query = "select id_nacionalidade, alf2, nacionalidade from Nacionalidade order by nacionalidade;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["id_nacionalidade"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["alf2"].Value = dr["alf2"].ToString();
                        dgv.Rows[idxLinha].Cells["nacionalidade"].Value = dr["nacionalidade"].ToString();

                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        public void PreencherDataGridViewArea(ref DataGridView dgv)
        {
            string query = "select id_area, area from area order by area;";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["id_area"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["area"].Value = dr["area"].ToString();

                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }

        public bool AtualizarNacionalidade(string id_nacionalidade, string alf2, string nacionalidade)
        {
            try
            {
                if (OpenConnection())
                {
                    string query = "UPDATE Nacionalidade SET alf2=@Alf2, nacionalidade=@Nacionalidade WHERE id_nacionalidade=@ID";

                    using (MySqlCommand comando = new MySqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@ID", id_nacionalidade);
                        comando.Parameters.AddWithValue("@Alf2", alf2);
                        comando.Parameters.AddWithValue("@Nacionalidade", nacionalidade);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na atualização do registro: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return false;
        }
        public bool AtualizarArea(string id_area, string idarea, string area)
        {
            try
            {
                if (OpenConnection())
                {
                    string query = "UPDATE area SET id_area=@idarea, area=@area WHERE id_area=@id_area";

                    using (MySqlCommand comando = new MySqlCommand(query, connection))
                    {
                        comando.Parameters.AddWithValue("@id_area", id_area);
                        comando.Parameters.AddWithValue("@idarea", idarea);
                        comando.Parameters.AddWithValue("@area", area);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na atualização do registro: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return false;
        }


        public bool PesquisaNacionalidade(string id_nacionalidade, ref string alf2, ref string nacionalidade)
        {
            bool flag = false;

            string query = "select alf2, nacionalidade from nacionalidade " +
                 "where id_nacionalidade = '" + id_nacionalidade + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        alf2 = dataReader[0].ToString();
                        nacionalidade = dataReader[1].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;

        }
        public bool PesquisaArea(string id_area, ref string idarea, ref string area)
        {
            bool flag = false;

            string query = "select id_area, area from area " +
                 "where id_area = '" + id_area + "'";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        idarea = dataReader[0].ToString();
                        area = dataReader[1].ToString();
                        flag = true;
                    }
                    dataReader.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;

        }

        public void PreencherDataGridViewFormandos(ref DataGridView dgv, char genero, string nome)
        {
            string query = "select id_formando, nome, iban, contacto, sexo from formando ";

            if (genero != 'T')
            {
                query = query + " where sexo =  '" + genero + "'";
            }

            if (nome.Length > 0 && genero != 'T')
            {
                query = query + " and nome like '%" + nome + "%'";
            }

            else if (nome.Length > 0)
            {
                query = query + " where nome like '%" + nome + "%'";
            }

            query = query + " order by nome";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["codID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["Nome"].Value = dr["nome"].ToString();
                        dgv.Rows[idxLinha].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr["contacto"].ToString();
                        dgv.Rows[idxLinha].Cells["Genero"].Value = dr["sexo"].ToString();
                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }


        }
        

        public void PreencherDataGridViewFormandos(ref DataGridView dgv, char genero, string nome, string id_nacionalidade)
        {
            string query = "select id_formando, nome, iban, contacto, sexo, nacionalidade, id_nacionalidade from vFormando ";

            bool flag = false;

            if (genero != 'T')
            {
                query = query + " where sexo =  '" + genero + "'";
                flag = true;
            }

            if (nome.Length > 0 && genero != 'T')
            {
                query = query + " and nome like '%" + nome + "%'";
            }

            else if (nome.Length > 0)
            {
                query = query + " where nome like '%" + nome + "%'";
                flag = true;
            }

            if(id_nacionalidade.Length > 0 && flag == true) 
            {
                query = query + " and id_nacionalidade = '" + id_nacionalidade + "'";
            }

            else if (id_nacionalidade.Length > 0)
            {
                query = query + " where id_nacionalidade = '" + id_nacionalidade + "'"; 
            }

            query = query + " order by nome";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["codID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["Nome"].Value = dr["nome"].ToString();
                        dgv.Rows[idxLinha].Cells[2].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr["contacto"].ToString();
                        dgv.Rows[idxLinha].Cells["Genero"].Value = dr["sexo"].ToString();
                        dgv.Rows[idxLinha].Cells[5].Value = dr["nacionalidade"].ToString();
                        dgv.Rows[idxLinha].Cells[6].Value = dr["id_nacionalidade"].ToString();

                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }


        }
        public void PreencherDataGridViewFormador(ref DataGridView dgv, string nome, string id_area)
        {
            string query = "select id_formador, nome, nif, dataNascimento, id_area, area, id_utilizador from vformador";

            bool flag = false;

            if (!string.IsNullOrEmpty(nome))
            {
                query += " where nome like '%" + nome + "%'";
                flag = true;
            }

            if (!string.IsNullOrEmpty(id_area))
            {
                if (!flag)
                {
                    query += " where id_area = '" + id_area + "'";
                }
                else
                {
                    query += " and id_area = '" + id_area + "'";
                }
            }

            query += " order by nome";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    int idxLinha = 0;
                    while (dr.Read())
                    {
                        dgv.Rows.Add();
                        dgv.Rows[idxLinha].Cells["FormID"].Value = dr[0].ToString();
                        dgv.Rows[idxLinha].Cells["nome"].Value = dr["nome"].ToString();
                        dgv.Rows[idxLinha].Cells["nif"].Value = dr[2].ToString();
                        dgv.Rows[idxLinha].Cells[3].Value = dr["dataNascimento"].ToString();
                        dgv.Rows[idxLinha].Cells["id_area"].Value = dr["id_area"].ToString();
                        dgv.Rows[idxLinha].Cells[5].Value = dr["area"].ToString();
                        dgv.Rows[idxLinha].Cells[6].Value = dr["id_utilizador"].ToString();
                        idxLinha++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }


        }
        public bool ValidateUser(string userName, string passWord, ref string id_user)
        {
            bool flag = false;
            try
            {
                string query = "select userRole from users where binary uname = '" + userName + "' and pwd = " +
                    "sha2('" + passWord + "',512);";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (cmd.ExecuteScalar() != null)
                    {
                        id_user = cmd.ExecuteScalar().ToString();
                        flag = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }

        public bool ValidateUser2(string userName, string passWord, ref string id_user)
        {
            bool flag = false;
            try
            {
                string query = "select id_utilizador from utilizador where binary nome_utilizador = '" + userName + "' and palavra_passe = " +
                    "sha2('" + passWord + "',512) and estado = 'A';";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (cmd.ExecuteScalar() != null)
                    {
                        id_user = cmd.ExecuteScalar().ToString();
                        flag = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
                if (flag)
                {
                    PUSuccessLogin(userName, "S");
                }
                else
                {
                    PUSuccessLogin(userName, "U");
                }
            }
            return flag;
        }
        private void PUSuccessLogin(string userName, string result)
        {
            try
            {
                string query = "call pUSuccessLogin('" + userName + "', '" + result + "');";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            
        }
        public bool ValidateUserStatus(string userName)
        {
            bool flag = false;
            try
            {
                string query = "select id_utilizador from utilizador where nome_utilizador = '" + userName + "' and estado = 'I';";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if(cmd.ExecuteScalar() != null)
                    {
                        flag = true;
                    }
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);   
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
        public bool ValidateUserStatus(string userName, ref int nfalhas)
        {
            bool flag = false;
            try
            {
                string query = "select falhas from utilizador where nome_utilizador = '" + userName + "' and estado = 'I';";

                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (cmd.ExecuteScalar() != null)
                    {
                        nfalhas = int.Parse(cmd.ExecuteScalar().ToString());
                        flag = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return flag;
        }
    }
}