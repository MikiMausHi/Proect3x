using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proect3x
{
    class DBLayer
    {

        //подключение
        public static string GetConnectionString()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Properties.Settings.Default.server;
            builder.Database = Properties.Settings.Default.db;
            builder.UserID = Properties.Settings.Default.dbUser;
            builder.Password = Properties.Settings.Default.dbPassword;
            return builder.ConnectionString;
        }

        //метод тестирвоания подключения
        public static void TestConnection()
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                try
                {
                    conn.ConnectionString = GetConnectionString();
                    conn.Open();
                    MessageBox.Show("Соединение установлено");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при установке соединения\n ", ex.Message);
                }
            }
        }



        //метод вывода таблицы/представления врменно
        public static DataTable GetTable(string tableName)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                DataTable table = new DataTable(tableName);
                try
                {
                    conn.ConnectionString = GetConnectionString();
                    conn.Open();

                    string selectCommand = "SELECT * FROM " + tableName;

                    MySqlCommand cmd = new MySqlCommand(selectCommand, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    table.Load(reader);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при установке соединения\n ", ex.Message);
                }

                return table;
            }
        }


        //добавление users
        public static void AddUsers(string loginUser, string passwordUser, string emailUser, string nameUser, string phoneUser)
        {
            using (MySqlConnection conns = new MySqlConnection())
            {
                conns.ConnectionString = GetConnectionString();
                conns.Open();
                MySqlCommand com2 = new MySqlCommand("Select * from users where loginUser='" + loginUser + "'", conns);
                if (com2.ExecuteScalar() == null)
                {
                    string selectCommand = "INSERT INTO users (name, loginUser, passwordUser,email,phone) VALUES('"+ nameUser + "', '"+ loginUser + "', '"+passwordUser+"', '"+emailUser+"', '"+ phoneUser + "')";
                    MySqlCommand cmd = new MySqlCommand(selectCommand, conns);
                    MessageBox.Show("Вы зарегистировались");

                }
                else
                {
                    MessageBox.Show("Такой пользователь уже существует");
                }
                conns.Close();


            }
        }
    }
}

