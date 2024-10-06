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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace практика_2._0
{
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dorman;User ID=root;Password=D0rlina060720;";
            string money = textBox2.Text;
            string k = textBox1.Text;
            string time = String.Format(dateTimePicker1.Text); ;
            string query = "INSERT INTO bb (time, money, kk) VALUES (@time, @money, @kk)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Открываем соединение
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Добавляем параметры
                        command.Parameters.AddWithValue("@time", time);
                        command.Parameters.AddWithValue("@money", money);
                        command.Parameters.AddWithValue("@kk", k);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking f = new booking();
            f.ShowDialog();
            button1.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            report f = new report();
            f.ShowDialog();
        }
    }
}
