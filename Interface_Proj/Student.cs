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

//gwquhychvf  1j6lpwrh

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
            IStudLV.View = View.Details;

            IStudLV.Clear();

            // Завантаження даних з CSV файлу
            LoadDataFromCSV(csvFilePathSched);
            File.Delete(csvFilePathSched);

            IStudLV.FullRowSelect = true;
            IStudLV.MultiSelect = true;

            // Обробник події до listView1
            IStudLV.MouseDoubleClick += listView1_MouseDoubleClick!;

            IStudLV.OwnerDraw = true;
        }

        private void IStudLV_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var headerBackgroundBrush = new SolidBrush(Color.FromArgb(11, 76, 163)))
            {
                e.Graphics.FillRectangle(headerBackgroundBrush, e.Bounds);
            }

            //Колір тексту
            using (Brush brush = new SolidBrush(Color.LightBlue))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }

            e.DrawDefault = false;
        }

        private void IStudLV_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

            // Колір текста
            using (Brush textBrush = new SolidBrush(Color.Black))
            {
                // Колір фона
                using (Brush backgroundBrush = new SolidBrush(Color.AliceBlue))
                {
                    e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                    // Колір текста
                    e.Item.ForeColor = Color.Black;
                    // Колір фона
                    e.Item.BackColor = Color.AliceBlue;
                }
            }
        }


        private void LoadDataFromCSV(string filePath)
        {
            if (File.Exists(filePath))
            {
                IStudLV.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(IStudLV_DrawColumnHeader);
                IStudLV.DrawItem += new DrawListViewItemEventHandler(IStudLV_DrawItem);

                using (var reader = new StreamReader(filePath))
                {
                    // Зчитування першої строки та ділення на стовбці
                    string[] headers = reader.ReadLine()!.Split(';');

                    // Дадавання стовбчиків ListView з автоматичним розміром
                    foreach (var header in headers)
                    {
                        IStudLV.Columns.Add(header, -2);
                    }

                    // Додавання залишившихся строк
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine()!.Split(';');

                        // Створення ListViewItem та додавання його в IStudLV
                        ListViewItem item = new ListViewItem(fields);
                        IStudLV.Items.Add(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл не найден: " + filePath);
            }
        }


        private async void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo test = IStudLV.HitTest(e.Location);

            if (test.Item != null)
            {
                string link = test.Item.SubItems[^1].Text;

                // Відкрити посилання у браузері
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });

                if (DateTime.Now.ToString("dddd", new CultureInfo("uk-UA")) == test.Item.SubItems[0].Text.ToLower())
                {
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
    }
}
