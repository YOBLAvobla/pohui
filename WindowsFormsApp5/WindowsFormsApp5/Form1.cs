using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form1 = new Form2();
            Form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form1 = new Form3();
            Form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=U315-S1\SQLEXPRESS01;Initial Catalog=petrov1122;Integrated Security=True";

            string username = login.Text; // Имя пользователя
            string password = parol.Text; // Пароль
                                          // Другие поля...

            // Проверка на пустые значения
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Вставка данных в базу данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Покупатели (Логин, Пароль) VALUES (@Username, @Password)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password); // Не забудьте хешировать пароль для безопасности

                        int result = command.ExecuteNonQuery();

                        // Проверка результата
                        if (result > 0)
                        {
                            MessageBox.Show("Регистрация прошла успешно!");
                            var Form1 = new Form3();
                            Form1.Show();
                            this.Hide();
                        
                    }
                        else
                        {
                            MessageBox.Show("Ошибка при регистрации. Попробуйте еще раз.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }
        }
    }
}
