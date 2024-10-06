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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace практика_2._0
{
    public partial class control : Form
    {
        public control()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dorman;User ID=root;Password=D0rlina060720;";
            string password = textBox1.Text;
            string login = textBox2.Text;
            string name = comboBox1.SelectedItem as string;
            string query = "INSERT INTO employee (Password, Login, Name) VALUES (@password, @ogin, @name)";

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
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            report f = new report();
            f.ShowDialog();
        }
    }
}
