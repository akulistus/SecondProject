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
            dateTimePicker1.Value = DateTime.Today.AddDays(-1);

            dataGridView1.Rows.Add(["Васильев", "Андрей", "Владимирович", "15 марта 1957"]);
            dataGridView1.Rows.Add(["Сафонов", "Платон", "Андреевич", "16 мая 2001"]);
            dataGridView1.Rows.Add(["Блинов", "Никита", "Сергеевич", "23 декабря 2003"]);
        }

        private void isValidField(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new MissingFieldException("Поле не заполнено");
            }
            if (str.EndsWith('-'))
            {
                throw new FormatException("Поле заполнено неправильно");
            }
        }

        private void isValidChar(object sender, KeyPressEventArgs e)
        {
            string text = ((TextBox)sender).Text;
            if (e.KeyChar == '-' && (text.Length == 0 || e.KeyChar == text[text.Length - 1]))
            {
                e.Handled = true;
            }

            if (e.KeyChar != (char)8 && !Regex.IsMatch(e.KeyChar.ToString(), pattern, RegexOptions.IgnoreCase))
            {
                e.Handled = true;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string[] newRow = { textBoxSurname.Text, textBox.Text, dateTimePicker1.Text };
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    isValidField(newRow[i]);
                }
                catch (Exception ex)
                {
                    labelException.Text = $"Поле {i + 1}: {ex.Message}";
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

        private void textChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 1)
            {
                tb.Text = tb.Text.ToUpper();
                tb.Select(tb.Text.Length, 0);
            }
        }
    }
}
