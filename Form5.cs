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

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form5 : Form
    {
        Base database = new Base();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            database.openConnection();
            CreateColumns();
            RefreshDataGridView(dataGridView);
        }

        private void CreateColumns()
        {
            dataGridView.Columns.Add("IDTeach", "ID_Преподавателя");
            dataGridView.Columns.Add("IDLesson", "ID_Предмета");
            dataGridView.Columns.Add("IDGroup", "ID_Группы");
            dataGridView.Columns.Add("Kurs", "Курс");
            dataGridView.Columns.Add("Semester", "Семестр");
            dataGridView.Columns.Add("AcademHour", "Академических Часов");

        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2),
            record.GetInt32(3), record.GetInt32(4), record.GetInt32(5));
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

            string queryString = $"select* from PlanTeacher";

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
                dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            SqlCommand comman = new SqlCommand($"INSERT INTO PlanTeacher (IdTeach,IdLesson, IdGroup, Kurs, Semester, AcademHour) Values (@IdTeach, @IdLesson, @IdGroup, @Kurs, @Semester, @AcademHour)", database.getConnection());
            comman.Parameters.AddWithValue("IdTeach", textBox1.Text);
            comman.Parameters.AddWithValue("IdLesson", textBox2.Text);
            comman.Parameters.AddWithValue("IdGroup", textBox3.Text);
            comman.Parameters.AddWithValue("Kurs", textBox4.Text);
            comman.Parameters.AddWithValue("Semester", textBox5.Text);
            comman.Parameters.AddWithValue("AcademHour", textBox6.Text);
            comman.ExecuteNonQuery();
        }




        private void update()
        {
            database.openConnection();
            for(int index=0; index < dataGridView.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                    continue;
                // условие при удалении
                if (rowState == RowState.Deleted)
                {
                    var idteach = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from PlanTeacher where IdTeach ={idteach}";   

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modified)
                {
                    var idteach = dataGridView.Rows[index].Cells[0].Value.ToString();
                    var idlesson = dataGridView.Rows[index].Cells[1].Value.ToString();
                    var idgroup = dataGridView.Rows[index].Cells[2].Value.ToString();
                    var kurs = dataGridView.Rows[index].Cells[3].Value.ToString();
                    var semester = dataGridView.Rows[index].Cells[4].Value.ToString();
                    var hour = dataGridView.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update PlanTeacher set IdLesson = '{idlesson}' ,IdGroup = '{idgroup}' ,Kurs = '{kurs}', Semester = '{semester}', AcademHour = '{hour}' where IdTeach = '{idteach}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            database.closeConnection();
        }

        


    }
}
