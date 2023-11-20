using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Proj
{
    public partial class IStudentForm1 : Form
    {
        private readonly string csvFilePathSched = Path.Combine(Directory.GetCurrentDirectory(), "schedule.csv");
        public IStudentForm1()
        {
            InitializeComponent();
            listView1.View = View.Details;

            listView1.Clear();

            // Завантаження даних з CSV файлу
            LoadDataFromCSV(csvFilePathSched);

            listView1.FullRowSelect = true;
            listView1.MultiSelect = true;

            // Обробник події до listView1
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
        }

        private void LoadDataFromCSV(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Прочитати заголовок (першу строку) і розділити її на стовпці
                    string[] headers = reader.ReadLine().Split(';');

                    // Додати стовпці до ListView з автоматичним розміром
                    foreach (var header in headers)
                    {
                        listView1.Columns.Add(header, -2);
                    }

                    // Додавання решти рядків
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split(';');

                        ListViewItem item = new ListViewItem(fields);
                        listView1.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден: " + filePath);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo test = listView1.HitTest(e.Location);

            if (test.Item != null)
            {
                string link = test.Item.SubItems[test.Item.SubItems.Count - 1].Text;

                // Відкрити посилання у браузері
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }
        }

        private void IStudentForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void IStudentForm1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }
    }
}
