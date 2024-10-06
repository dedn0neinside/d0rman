using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика_2._0
{
    public partial class bartender : Form
    {
        public bartender()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string connectionString = "Server=localhost;Database=dorman;User ID=root;Password=D0rlina060720;";
            // SQL-запрос для получения данных
            string query = "SELECT name FROM stop_b";

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





        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=ple;User ID=root;Password=D0rlina060720;";
            string name = textBox1.Text;
            string query = "INSERT INTO stop_b (Name) VALUES (@name)";

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

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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
    }
}
    
