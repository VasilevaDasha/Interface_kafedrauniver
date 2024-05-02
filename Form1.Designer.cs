namespace practica2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlanKafedra = new System.Windows.Forms.Button();
            this.PlanTeacher = new System.Windows.Forms.Button();
            this.TableLessons = new System.Windows.Forms.Button();
            this.TableTeachers = new System.Windows.Forms.Button();
            this.TableGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlanKafedra
            // 
            this.PlanKafedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlanKafedra.Location = new System.Drawing.Point(291, 328);
            this.PlanKafedra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlanKafedra.Name = "PlanKafedra";
            this.PlanKafedra.Size = new System.Drawing.Size(219, 47);
            this.PlanKafedra.TabIndex = 10;
            this.PlanKafedra.Text = "План Кафедры";
            this.PlanKafedra.UseVisualStyleBackColor = true;
            this.PlanKafedra.Click += new System.EventHandler(this.PlanTeacher_Click);
            // 
            // PlanTeacher
            // 
            this.PlanTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlanTeacher.Location = new System.Drawing.Point(291, 265);
            this.PlanTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlanTeacher.Name = "PlanTeacher";
            this.PlanTeacher.Size = new System.Drawing.Size(219, 47);
            this.PlanTeacher.TabIndex = 9;
            this.PlanTeacher.Text = "План Преподавателя";
            this.PlanTeacher.UseVisualStyleBackColor = true;
            this.PlanTeacher.Click += new System.EventHandler(this.PlanKafedra_Click);
            // 
            // TableLessons
            // 
            this.TableLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableLessons.Location = new System.Drawing.Point(291, 203);
            this.TableLessons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableLessons.Name = "TableLessons";
            this.TableLessons.Size = new System.Drawing.Size(219, 47);
            this.TableLessons.TabIndex = 8;
            this.TableLessons.Text = "Предметы";
            this.TableLessons.UseVisualStyleBackColor = true;
            this.TableLessons.Click += new System.EventHandler(this.TableLessons_Click);
            // 
            // TableTeachers
            // 
            this.TableTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableTeachers.Location = new System.Drawing.Point(291, 138);
            this.TableTeachers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableTeachers.Name = "TableTeachers";
            this.TableTeachers.Size = new System.Drawing.Size(219, 47);
            this.TableTeachers.TabIndex = 7;
            this.TableTeachers.Text = "Преподаватели";
            this.TableTeachers.UseVisualStyleBackColor = true;
            this.TableTeachers.Click += new System.EventHandler(this.TableTeachers_Click);
            // 
            // TableGroups
            // 
            this.TableGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableGroups.Location = new System.Drawing.Point(291, 75);
            this.TableGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TableGroups.Name = "TableGroups";
            this.TableGroups.Size = new System.Drawing.Size(219, 47);
            this.TableGroups.TabIndex = 6;
            this.TableGroups.Text = "Группы";
            this.TableGroups.UseVisualStyleBackColor = true;
            this.TableGroups.Click += new System.EventHandler(this.TableGroups_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlanKafedra);
            this.Controls.Add(this.PlanTeacher);
            this.Controls.Add(this.TableLessons);
            this.Controls.Add(this.TableTeachers);
            this.Controls.Add(this.TableGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlanKafedra;
        private System.Windows.Forms.Button PlanTeacher;
        private System.Windows.Forms.Button TableLessons;
        private System.Windows.Forms.Button TableTeachers;
        private System.Windows.Forms.Button TableGroups;
    }
}

