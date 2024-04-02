namespace SecondProject
{
    partial class SecondProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSurname = new TextBox();
            textBox = new TextBox();
            textBoxSecondName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Add = new Button();
            dataGridView1 = new DataGridView();
            Surname = new DataGridViewTextBoxColumn();
            txtName = new DataGridViewTextBoxColumn();
            SecondName = new DataGridViewTextBoxColumn();
            DateBirth = new DataGridViewTextBoxColumn();
            Delete = new Button();
            labelSurname = new Label();
            labelName = new Label();
            labelSecondName = new Label();
            labelException = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(610, 21);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(200, 23);
            textBoxSurname.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Location = new Point(610, 50);
            textBox.Name = "textBox";
            textBox.Size = new Size(200, 23);
            textBox.TabIndex = 1;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(610, 79);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(200, 23);
            textBoxSecondName.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(610, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2024, 4, 2, 0, 0, 0, 0);
            // 
            // Add
            // 
            Add.Location = new Point(610, 137);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 4;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Surname, txtName, SecondName, DateBirth });
            dataGridView1.Location = new Point(12, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 5;
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            // 
            // txtName
            // 
            txtName.HeaderText = "Имя";
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            // 
            // SecondName
            // 
            SecondName.HeaderText = "Отчество";
            SecondName.Name = "SecondName";
            SecondName.ReadOnly = true;
            // 
            // DateBirth
            // 
            DateBirth.HeaderText = "Дата Рождения";
            DateBirth.Name = "DateBirth";
            DateBirth.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(735, 137);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 6;
            Delete.Text = "Удалить";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(538, 29);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(58, 15);
            labelSurname.TabIndex = 7;
            labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(538, 58);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 15);
            labelName.TabIndex = 8;
            labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            labelSecondName.AutoSize = true;
            labelSecondName.Location = new Point(538, 87);
            labelSecondName.Name = "labelSecondName";
            labelSecondName.Size = new Size(58, 15);
            labelSecondName.TabIndex = 9;
            labelSecondName.Text = "Отчество";
            // 
            // labelException
            // 
            labelException.AutoSize = true;
            labelException.Location = new Point(610, 177);
            labelException.Name = "labelException";
            labelException.Size = new Size(0, 15);
            labelException.TabIndex = 10;
            // 
            // SecondProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 233);
            Controls.Add(labelException);
            Controls.Add(labelSecondName);
            Controls.Add(labelName);
            Controls.Add(labelSurname);
            Controls.Add(Delete);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBox);
            Controls.Add(textBoxSurname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SecondProject";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSurname;
        private TextBox textBox;
        private TextBox textBoxSecondName;
        private DateTimePicker dateTimePicker1;
        private Button Add;
        private DataGridView dataGridView1;
        private Button Delete;
        private Label labelSurname;
        private Label labelName;
        private Label labelSecondName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn txtName;
        private DataGridViewTextBoxColumn SecondName;
        private DataGridViewTextBoxColumn DateBirth;
        private Label labelException;
    }
}
