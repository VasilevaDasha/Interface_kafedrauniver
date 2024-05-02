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
    public partial class Form4 : Form
    {
        Base database = new Base();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            database.openConnection();
            CreateColumns();
            RefreshDataGridView(dataGridView);

        }
        private void CreateColumns()
        {
            dataGridView.Columns.Add("ID_Lesson", "ID_Предмета");
            dataGridView.Columns.Add("NameLesson", "Предмет");
            dataGridView.Columns.Add("AcademHour", "Академических часов");
            dataGridView.Columns.Add("Lecture", "Лекций");
            dataGridView.Columns.Add("Practic", "Практик");
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2),
            record.GetInt32(3), record.GetInt32(4));
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

            string queryString = $"select* from Lessons";

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
            SqlCommand comman = new SqlCommand($"INSERT INTO Lessons (IdLesson,NameLesson,AcademHour, Lecture, Practic) Values (@IdLesson, @NameLesson, @AcademHour, @Lecture, @Practic)", database.getConnection());
            comman.Parameters.AddWithValue("IdLesson", textBox1.Text);
            comman.Parameters.AddWithValue("NameLesson", textBox2.Text);
            comman.Parameters.AddWithValue("AcademHour", textBox3.Text);
            comman.Parameters.AddWithValue("Lecture", textBox4.Text);
            comman.Parameters.AddWithValue("Practic", textBox5.Text);
            comman.ExecuteNonQuery();
        }
    }
}

