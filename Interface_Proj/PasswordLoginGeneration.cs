using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordLoginGeneration
{
    struct Student
    {
        public string key;
        public string value;

        public Student(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    class Generation
    {
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
    }
}