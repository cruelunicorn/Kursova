using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

        // Username generation for professors.
        public static string GenerateUsernameForProfessors(int length = 10)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._";
            char[] username = new char[length];
            for (int i = 0; i < length; i++)
            {
                username[i] = chars[random.Next(chars.Length)];
            }
            return new string(username);
        }

        // Username generation for students.
        public static string GenerateUsernameForStudents(int length = 10)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz._";
            char[] username = new char[length];
            for (int i = 0; i < length; i++)
            {
                username[i] = chars[random.Next(chars.Length)];
            }
            return new string(username);
        }

        // Password generation for professors.
        public static string GeneratePasswordForProfessors(int length = 9)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$&";
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }

        // Password generation for students.
        public static string GeneratePasswordForStudents(int length = 8)
        {
            string chars = "abcdefghijklmnopqrstuvwxyz0123456789!#$%&";
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }

        // Salt generation.
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);
            return salt;
        }

        // Hash password.
        public static string HashPassword(string password, string salt)
        {
            string combinedPassword = password + salt;
            byte[] passwordBytes = Encoding.UTF8.GetBytes(combinedPassword);
            using (var sha256 = new SHA256Managed())
            {
                byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);

                return hashedPassword;
            }
        }
    }
}