using System.Text.RegularExpressions;

namespace SecondProject
{
    public partial class SecondProject : Form
    {
        private string pattern = @"^[A-Za-zА-Яа-я\-]+$";

        public SecondProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;

            dataGridView1.Rows.Add(["Васильев", "Андрей", "Владимирович", "15 марта 1957"]);
            dataGridView1.Rows.Add(["Сафонов", "Платон", "Андреевич", "16 мая 2001"]);
            dataGridView1.Rows.Add(["Блинов", "Никита", "Сергеевич", "23 декабря 2003"]);
        }

        private void IsValidString(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new MissingFieldException("Поле не заполнено");
            }
            if (!Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                throw new FormatException("Используются недопустимые символы");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] newRow = { textBoxSurname.Text, textBox.Text, textBoxSecondName.Text, dateTimePicker1.Text };
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    IsValidString(newRow[i]);
                }
                catch (Exception ex)
                {
                    labelException.Text = $"Поле {i+1}: {ex.Message}";
                    return;
                }
            }
            dataGridView1.Rows.Add(newRow);
            labelException.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 &&
                dataGridView1.SelectedRows[0].Index !=
                dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
