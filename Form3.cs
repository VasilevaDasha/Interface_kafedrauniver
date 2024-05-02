using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace practica2
{
    public partial class Form3 : Form
    {
        Base database = new Base();
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            database.openConnection();
            CreateColumns();
            RefreshDataGridView(dataGridView);

        }
        private void CreateColumns()
        {
            dataGridView.Columns.Add("ID_Teach", "ID_Преподавателя");
            dataGridView.Columns.Add("LastName", "Фамилия");
            dataGridView.Columns.Add("FirstName", "Имя");
            dataGridView.Columns.Add("Patronymic", "Отчество");
            dataGridView.Columns.Add("Statuse", "Статус");
            dataGridView.Columns.Add("Rate", "Ставка");
            dataGridView.Columns.Add("Loads", "Кол-во часов");
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2),
            record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6));
        }

        private void RefreshDataGridView(DataGridView dgw)
        {

            if (this.dataGridView.DataSource != null)
            {
                this.dataGridView.DataSource = null;
            }
            else
            {
                this.dataGridView.Rows.Clear();
            }

            string queryString = $"select* from Teachers";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand($"INSERT INTO Teachers (IdTeach,LastName, FirstName, Patronymic, Statuse, Rate, Loads) Values (@IdTeach, @LastName, @FirstName, @Patronymic, @Statuse, @Rate, @Loads)", database.getConnection());
            comman.Parameters.AddWithValue("IdTeach", textBox1.Text);
            comman.Parameters.AddWithValue("LastName", textBox2.Text);
            comman.Parameters.AddWithValue("FirstName", textBox3.Text);
            comman.Parameters.AddWithValue("Patronymic", textBox4.Text);
            comman.Parameters.AddWithValue("Statuse", textBox5.Text);
            comman.Parameters.AddWithValue("Rate", textBox6.Text);
            comman.Parameters.AddWithValue("Loads", textBox7.Text);
            comman.ExecuteNonQuery();
        }
    }
}
