using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordLoginGeneration
{
    class Student
    {
        public string key;
        public string value;

        public Student(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class HashTable
    {
        private int size;
        private Student[] table;
        private int count;

        public HashTable(int size)
        {
            this.size = size;
            table = new Student[size];
            count = 0;
        }

        // Adding a new student to the table.
        // Collision handling by open addresing.
        public void AddNewStudent(string key, string value)
        {
            if ((double)count / size >= 0.75)
            {
                ResizeTable();
            }
            int index = GetIndex(key);
            while (table[index] != null)
            {
                index = (index + 1) % size;
            }
            table[index] = new Student(key, value);
            count++;
        }

        // Create a new table when the previous one is full.
        public void ResizeTable()
        {
            int newSize = size * 2;
            Student[] newTable = new Student[newSize];
            foreach (var student in table)
            {
                if (student != null)
                {
                    int index = GetIndex(student.key);
                    while (newTable[index] != null)
                    {
                        index = (index + 1) % size;
                    }
                    newTable[index] = student;
                }
            }
            size = newSize;
            table = newTable;
        }

        // Removing a student.
        public void RemoveStudent(string key)
        {
            int index = GetIndex(key);
            while (table[index] != null)
            {
                if (table[index].key == key)
                {
                    table[index] = null;
                    count--;
                    return;
                }
                index = (index + 1) % size;
            }
        }

        //Search for a password by key(last name).
        public string SearchPassword(string key)
        {
            int index = GetIndex(key);
            while (table[index] != null)
            {
                if (table[index].key == key)
                {
                    return table[index].value;
                }
                index = (index + 1) % size;
            }
            return "Password wasn't found.";
        }

        // Getting an index by converting each character of the string to the corresponding ASCII number 
        // and dividing by the size of the array.
        private int GetIndex(string key)
        {
            int index = 0;
            for (int i = 0; i < key.Length; i++)
            {
                index += (key[i]);
            }
            return index % size;
        }

        private static Random random = new Random();

        // Username generation
        static string GenerateUsername(int length = 10)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789._";
            char[] username = new char[length];
            for (int i = 0; i < length; i++)
            {
                username[i] = chars[random.Next(chars.Length)];
            }
            return new string(username);
        }

        // Password generation for students.
        static string GeneratePasswordForStudents(int length = 8)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }

        // Password generation for professors.
        static string GeneratePasswordForProfessors(int length = 9)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }

        // To display data correctly in the console.
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                if (table[i] != null)
                {
                    result += $"Index {i}: {table[i].key}; {table[i].value}\n";
                }
            }
            return result;
        }

        /*static void Main(string[] args)
        {
            HashTable hashtable = new HashTable(30);
            string username1 = GenerateUsername();
            string password1 = GeneratePasswordForStudents();
            hashtable.AddNewStudent(username1, password1);
            string username2 = GenerateUsername();
            string password2 = GeneratePasswordForStudents();
            hashtable.AddNewStudent(username2, password2);
            string username3 = GenerateUsername();
            string password3 = GeneratePasswordForStudents();
            hashtable.AddNewStudent(username3, password3);
            string username4 = GenerateUsername();
            string password4 = GeneratePasswordForStudents();
            hashtable.AddNewStudent(username4, password4);
            Console.WriteLine(hashtable.ToString());

            string passwordSearch1 = hashtable.SearchPassword(username3);
            Console.WriteLine(passwordSearch1.ToString());
            string username5 = GenerateUsername();
            string passwordSearch2 = hashtable.SearchPassword(username5);
            Console.WriteLine(passwordSearch2.ToString());

            hashtable.RemoveStudent(username3);
            Console.WriteLine(hashtable.ToString());

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }*/
    }
}