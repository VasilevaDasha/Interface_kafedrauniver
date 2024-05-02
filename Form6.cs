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
    public partial class Form6 : Form
    {
        Base database = new Base();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            database.openConnection();
            CreateColumns();
            RefreshDataGridView(dataGridView);
        }
        private void CreateColumns()
        {
            dataGridView.Columns.Add("Semester", "Семестр");
            dataGridView.Columns.Add("Kurs", "Курс");
            dataGridView.Columns.Add("ID_Lesson", "ID_Предмета");
            dataGridView.Columns.Add("AcademHour", "Академических часов");
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3));
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

            string queryString = $"select* from PlanKafedra";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw, reader);
            }
            reader.Close();
        }
        // кнопка удаление
        private void deleteRow()
        {
            int index = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows[index].Visible = false;

            if (dataGridView.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand($"INSERT INTO PlanKafedra (Semester,Kurs, IdLesson, AcademHour) Values (@Semester, @Kurs, @IdLesson, @AcademHour)", database.getConnection());
            comman.Parameters.AddWithValue("Semester", textBox1.Text);
            comman.Parameters.AddWithValue("Kurs", textBox2.Text);
            comman.Parameters.AddWithValue("IdLesson", textBox3.Text);
            comman.Parameters.AddWithValue("AcademHour", textBox4.Text);

            comman.ExecuteNonQuery();
        }
    }
}
