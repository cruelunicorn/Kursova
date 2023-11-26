using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
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
        private readonly string csvFilePathInfo = Path.Combine(Directory.GetCurrentDirectory(), "students.csv");
        private readonly string folderPath = "AttendanceFolder";
        public IProfessorForm1()
        {
            InitializeComponent();

            IProfDGV.ReadOnly = true;
            IProfDGV.AllowUserToAddRows = false;
            IProfDGV.AllowUserToDeleteRows = false;

            ISubjCB.SelectedIndexChanged += ComboBox1_SelectedIndex;
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

        private async void IProfessorForm1_Load(object sender, EventArgs e)
        {
            try
            {
                MicrosoftStorageHandler handl = new MicrosoftStorageHandler();
                await handl.DownloadFile("schedule.csv", "ScheduleFolder");

                // После успешной загрузки файла, вызываем метод CBSubj
                CBSubj(csvFilePathSched);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ComboBox1_SelectedIndex(object sender, EventArgs e)
        {
            // Отримуємо вибраний предмет з ComboBox
            string selectedSubject = ISubjCB.SelectedItem as string;
            MicrosoftStorageHandler handler = new();
            await handler.DownloadFile($"{selectedSubject}.json", folderPath);

            if (selectedSubject != null)
            {
                // Викликаємо метод для завантаження та виведення вмісту файла
                DisplayJson($"{selectedSubject}.json", csvFilePathInfo);
            }
        }

        private void DisplayJson(string filePath, string filePath1)
        {
            if (File.Exists(filePath))
            {
                // Читання JSON файлу та виведення його в DataGridView
                string fileContent = File.ReadAllText(filePath);
                JObject jsonObj = JObject.Parse(fileContent);

                // Очищення вмісту DataGridView перед заповненням
                IProfDGV.Rows.Clear();
                IProfDGV.Columns.Clear();

                // Додавання заголовків до DataGridView
                IProfDGV.Columns.Add("NameLastName", "NameLastName");
                IProfDGV.Columns.Add("Attendance", "Attendance");

                // Додаємо вміст файла JSON до DataGridView
                foreach (var pair in jsonObj)
                {
                    AttendanceInfo attPair = new AttendanceInfo
                    {
                        NameLastName = pair.Key,
                        Attendance = pair.Value.ToString()
                    };

                    // Додаємо дані в DataGridView
                    IProfDGV.Rows.Add(attPair.NameLastName, attPair.Attendance);
                }
                IProfDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                
            }
            else
            {
                MessageBox.Show($"Файл не знайдено: {filePath}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Перевіряємо наявність файлу CSV
            if (File.Exists(filePath1))
            {
                // Зчитуємо дані з файлу CSV та зберігаємо їх у словник для подальшого використання
                Dictionary<string, List<string>> csvData = new Dictionary<string, List<string>>();

                using (var reader = new StreamReader(filePath1))
                {
                    // Читаємо заголовок (першу строку) і розділити її на стовпці
                    string[] headers = reader.ReadLine()!.Split(';');

                    // Додаємо стовпці до DataGridView з автоматичним розміром
                    foreach (var header in headers.Skip(2)) // Пропускаємо перші два поля
                    {
                        IProfDGV.Columns.Add(header, header);
                    }

                    if (IProfDGV.Columns.Count > 0)
                    {
                        // Видалити останній стовпець (останній заголовок)
                        IProfDGV.Columns.RemoveAt(IProfDGV.Columns.Count - 1);
                    }

                    // Додаємо дані з CSV файлу до словника
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine()!.Split(';');

                        // Перевірка, чи є достатньо полів
                        if (fields.Length >= 3)
                        {
                            string nameLastName = $"{fields[0]} {fields[1]}";
                            List<string> data = fields.Skip(2).Take(fields.Length - 3).ToList();
                            csvData[nameLastName] = data;
                        }
                    }
                }

                // Оновлюємо інформацію в DataGridView на основі словника
                foreach (DataGridViewRow row in IProfDGV.Rows)
                {
                    string nameLastName = row.Cells["NameLastName"].Value.ToString();

                    if (csvData.TryGetValue(nameLastName, out List<string> dataFromCsv))
                    {
                        // Додаємо дані з файлу CSV в поточний рядок у DataGridView
                        for (int i = 0; i < dataFromCsv.Count; i++)
                        {
                            row.Cells[i + 2].Value = dataFromCsv[i];
                        }
                    }
                }
                IProfDGV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                int lastColumnIndex = IProfDGV.Columns.Count - 1;
                // AutoSizeMode останнього стовпця на Fill
                IProfDGV.Columns[lastColumnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                MessageBox.Show($"Файл не знайдено: {filePath1}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
