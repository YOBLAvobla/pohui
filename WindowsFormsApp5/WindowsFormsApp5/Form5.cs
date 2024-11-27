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
    public partial class Form5 : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private string connectionString = @"Data Source=U315-S1\SQLEXPRESS01;Initial Catalog=petrov1122;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM [Каталог товаров]", connectionString); // Set the ConnectionString property
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // This will automatically generate the insert/update/delete commands
                    adapter.InsertCommand = commandBuilder.GetInsertCommand();
                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    adapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (dataTable != null)
            {
                DataRow newRow = dataTable.NewRow();

                try
                {
                    // Example of filling mandatory fields
                    Console.WriteLine("Введите Код_товара (целое число):");
                    string input = Console.ReadLine();
                    newRow["Код_товара"] = Convert.ToInt32(input);

                    // Fill other fields as necessary
                    // newRow["ColumnName2"] = "Value2"; 

                    dataTable.Rows.Add(newRow);
                    MessageBox.Show("Новая строка добавлена. Заполните данные.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка: Введите корректное целое число для Код товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Таблица данных не загружена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<int> primaryKeysToRemove = new List<int>(); //Или другой тип ключа
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        //Предполагается, что первичный ключ находится в столбце с индексом 0
                        primaryKeysToRemove.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                }

                foreach (int primaryKey in primaryKeysToRemove)
                {
                    DataRow rowToRemove = dataTable.AsEnumerable().FirstOrDefault(row => Convert.ToInt32(row["Код_товара"]) == primaryKey);
                    if (rowToRemove != null)
                    {
                        dataTable.Rows.Remove(rowToRemove);
                    }
                }

                SaveData();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (dataTable != null)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        adapter.Update(dataTable); // This will apply all changes to the database

                        MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Refresh the grid after saving
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Таблица данных не загружена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
