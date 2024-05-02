namespace practica2
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.planKafedraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kafedraDataSet = new practica2.kafedraDataSet();
            this.planKafedraTableAdapter = new practica2.kafedraDataSetTableAdapters.PlanKafedraTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.kafedraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.planKafedraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // planKafedraBindingSource
            // 
            this.planKafedraBindingSource.DataMember = "PlanKafedra";
            this.planKafedraBindingSource.DataSource = this.kafedraDataSet;
            // 
            // kafedraDataSet
            // 
            this.kafedraDataSet.DataSetName = "kafedraDataSet";
            this.kafedraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planKafedraTableAdapter
            // 
            this.planKafedraTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.DataSource = this.kafedraDataSetBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(53, 164);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1016, 284);
            this.dataGridView.TabIndex = 2;
            // 
            // kafedraDataSetBindingSource
            // 
            this.kafedraDataSetBindingSource.DataSource = this.kafedraDataSet;
            this.kafedraDataSetBindingSource.Position = 0;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(853, 464);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(201, 47);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(753, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 40);
            this.label7.TabIndex = 26;
            this.label7.Text = "Академических \r\n       часов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Семестр";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Курс";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Id Группы";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Id Предмета";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 40);
            this.label12.TabIndex = 21;
            this.label12.Text = "           Id \r\nПреподавателя";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(757, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 26);
            this.textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(609, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 26);
            this.textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(460, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 26);
            this.textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(323, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 26);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 26);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 26);
            this.textBox1.TabIndex = 15;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(941, 95);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(128, 35);
            this.button.TabIndex = 27;
            this.button.Text = "Добавить";
            this.button.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1136, 522);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planKafedraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafedraDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private kafedraDataSet kafedraDataSet;
        private System.Windows.Forms.BindingSource planKafedraBindingSource;
        private kafedraDataSetTableAdapters.PlanKafedraTableAdapter planKafedraTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource kafedraDataSetBindingSource;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button;
    }
}