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
using System.Configuration;

namespace practica2
{
    public partial class Form2 : Form
    {
        Base database = new Base();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            database.openConnection();
            CreateColumns();
            RefreshDataGridView(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Group", "ID_Группы");
            dataGridView1.Columns.Add("Kurs", "Курс");
            dataGridView1.Columns.Add("Department", "Факультет");
        }
        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {

            dgw.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetString(2));
        }
        private void RefreshDataGridView(DataGridView dgw)
        {

            if (this.dataGridView1.DataSource != null)
            {
                this.dataGridView1.DataSource = null;
            }
            else
            {
                this.dataGridView1.Rows.Clear();
            }

            string queryString = $"select* from Groups";

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
            SqlCommand comman = new SqlCommand($"INSERT INTO Groups (IdGroup, Kurs, Department) Values (@IdGroup, @Kurs, @Department)", database.getConnection());
            comman.Parameters.AddWithValue("IdGroup", textBox_id.Text);
            comman.Parameters.AddWithValue("Kurs", textBox_kurs.Text);
            comman.Parameters.AddWithValue("Department", textBox_department.Text);
            comman.ExecuteNonQuery();
        }
    }
}
