using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Proj
{
    public partial class IStudentForm1 : Form
    {
        private readonly string csvFilePathSched = Path.Combine(Directory.GetCurrentDirectory(), "schedule.csv");
        private string nameAndLastName;
        public IStudentForm1(string nameAndLastName)
        {
            InitializeComponent();
            Text = $"Студент - {nameAndLastName}";
            this.nameAndLastName = nameAndLastName;
            listView1.View = View.Details;

            listView1.Clear();

            // Завантаження даних з CSV файлу
            LoadDataFromCSV(csvFilePathSched);
            File.Delete(csvFilePathSched);

            listView1.FullRowSelect = true;
            listView1.MultiSelect = true;

            // Обробник події до listView1
            listView1.MouseDoubleClick += listView1_MouseDoubleClick!;
        }

        private void LoadDataFromCSV(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Прочитати заголовок (першу строку) і розділити її на стовпці
                    string[] headers = reader.ReadLine()!.Split(';');

                    // Додати стовпці до ListView з автоматичним розміром
                    foreach (var header in headers)
                    {
                        listView1.Columns.Add(header, -2);
                    }

                    // Додавання решти рядків
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine()!.Split(';');

                        ListViewItem item = new ListViewItem(fields);
                        listView1.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не знайдено: " + filePath);
            }
        }

        private async void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo test = listView1.HitTest(e.Location);

            if (test.Item != null)
            {
                string link = test.Item.SubItems[^1].Text;

                // Відкрити посилання у браузері
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });

                if (DateTime.Now.ToString("dddd", new CultureInfo("uk-UA")) == test.Item.SubItems[0].Text.ToLower()) { 
                    string subject = test.Item.SubItems[2].Text;
                    MicrosoftStorageHandler handler = new();
                    if (await handler.DownloadFile($"{subject}.json", "AttendanceFolder") != "Success") return;
                    var jsonObj = JObject.Parse(File.ReadAllText($"{subject}.json"));
                    if (jsonObj[nameAndLastName] != null)
                        jsonObj[nameAndLastName] = (int)jsonObj[nameAndLastName]! + 1;
                    else
                        jsonObj[nameAndLastName] = 1;
                    File.WriteAllText($"{subject}.json", jsonObj.ToString());
                    await handler.UploadFile($"{subject}.json", "AttendanceFolder");
                    File.Delete($"{subject}.json");
                }
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
