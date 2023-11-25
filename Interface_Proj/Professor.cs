using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


// RJ5I93D.K6  KKDZ01BDB


namespace Interface_Proj
{
    public partial class IProfessorForm1 : Form
    {
        private readonly string csvFilePathSched = Path.Combine(Directory.GetCurrentDirectory(), "schedule.csv");
        private readonly string folderPath = "AttendanceFolder";
        public IProfessorForm1()
        {
            InitializeComponent();

            CBSubj(csvFilePathSched);
            //AddWordsFromJson(jsonFilePathSubj);

            ISubjCB.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void CBSubj(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    // Читання CSV-файлу
                    using (var reader = new StreamReader(filePath))
                    {
                        // Пропускаємо перший рядок (заголовок)
                        reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            if (!string.IsNullOrEmpty(line))
                            {
                                // Розбиваємо рядок за допомогою розділювача ";"
                                string[] fields = line.Split(';');

                                // Перевіряємо, чи маємо третє слово
                                if (fields.Length >= 3)
                                {
                                    string thirdWord = fields[2];

                                    // Додаємо третє слово до ComboBox
                                    ISubjCB.Items.Add(thirdWord);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при читанні CSV-файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Отримуємо вибраний предмет з ComboBox
            string selectedSubject = ISubjCB.SelectedItem as string;
            MicrosoftStorageHandler handler = new();
            await handler.DownloadFile($"{selectedSubject}.json", folderPath);

            if (selectedSubject != null)
            {

                // Формуємо шлях до файлу
//                string filePath = Path.Combine(folderPath, $"{selectedSubject}.json");

                // Викликаємо метод для завантаження та виведення вмісту файла
                DisplayFileContent($"{selectedSubject}.json");
            }
        }

        private void DisplayFileContent(string filePath)
        {
            // Перевіряємо, чи файл існує
            if (File.Exists(filePath))
            {
                try
                {
                    // Читаємо вміст файла
                    string fileContent = File.ReadAllText(filePath);

                    // Розбираємо JSON-рядок у об'єкт JObject
                    JObject jsonObj = JObject.Parse(fileContent);

                    // Очищаємо вміст ListView
                    IProfLV.Items.Clear();

                    // Додаємо вміст файла до ListView
                    foreach (var property in jsonObj)
                    {
                        ListViewItem item = new ListViewItem(property.Key);
                        item.SubItems.Add(property.Value.ToString());
                        IProfLV.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при читанні та виведенні файла: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Файл {Path.GetFileName(filePath)} не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IProfessorForm1_Load(object sender, EventArgs e)
        {

        }

        private void IProfessorForm1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void IProfessorForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
