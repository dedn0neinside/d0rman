using MySqlConnector;
namespace практика_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void войти_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dorman;User ID=root;Password=D0rlina060720;";
            string password = textBox2.Text;
            string login = textBox1.Text;
            string username = GetUsernameByPassword(password, login, connectionString);

            if (login == null)
            {
                MessageBox.Show("Неверный пароль.");
            }
            else if (login == "Управляющий")
            {
                this.Hide();
                control f = new control();
                f.ShowDialog();
            }
            else if (login == "Официант")
            {
                this.Hide();
                waiter f = new waiter();
                f.ShowDialog();
            }
            else if (login == "Повар")
            {
                this.Hide();
                cook f = new cook();
                f.ShowDialog();
            }
            else if (login == "Бармен")
            {
                this.Hide();
                bartender f = new bartender();
                f.ShowDialog();
            }
            else if (login == "Администратор")
            {
                this.Hide();
                manager f = new manager();
                f.ShowDialog();
            }

        }
        private string GetUsernameByPassword(string password, string login, string connectionString)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT FROM employee WHERE Passwords = @password AND Loogin = @login";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@login", login);
                        var result = command.ExecuteScalar();
                        return result?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}");
                    return null;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
