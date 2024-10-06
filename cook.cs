using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_2._0
{
    public partial class cook : Form
    {
        public cook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string connectionString = "Server=localhost;Database=dorman;User ID=root;Password=D0rlina060720;";
            // SQL-запрос для получения данных
            string query = "SELECT name FROM stop_k";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Открываем соединение
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Выполняем запрос и получаем данные
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Чтение данных
                            while (reader.Read())
                            {
                                // Добавляем каждое имя в ListBox
                                listBox1.Items.Add(reader.GetString("name"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dorman;User ID=root;Password=D0rlina060720;";
            string name = textBox1.Text;
            string query = "INSERT INTO stop_k (Name) VALUES (@name)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Открываем соединение
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Добавляем параметры
                        command.Parameters.AddWithValue("@name", name);


                        // Выполняем команду
                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно вставлены!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
             menu f = new menu();
            f.ShowDialog();
        }
    }
}
