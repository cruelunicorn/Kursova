using System;

namespace Console_Proj
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string patronymic;
        public string educationStatus;
        public string eMail;
        public string login;
        public string password;
        public int group;

        public Student(string firstName, string lastName, string patronymic,
            string educationStatus, string eMail, string login, string password, int group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.patronymic = patronymic;
            this.educationStatus = educationStatus;
            this.eMail = eMail;
            this.login = login;
            this.password = password;
            this.group = group;
        }
    }

    class Node
    {
        public Student data;
        public Node prev;
        public Node next;

        public Node(Student data)
        {
            this.data = data;
            next = null;
            prev = null;
        }
    }

    class DoublyLinkedList
    {
        private Node head;
        private Node tail;

        // Adding students to the end of the list.
        public void AddStudent(Student student)
        {
            Node newNode = new Node(student);
            newNode.prev = tail;
            if (tail != null)
            {
                tail.next = newNode;
            }
            if (head == null)
            {
                head = newNode;
            }
            tail = newNode;
        }

        // Sorting students by group.
        public void SortStudents()
        {
            Node current = head;
            Node index = null;
            if (head == null)
            {
                return;
            }
            while (current != null)
            {
                index = current.next;
                while (index != null)
                {
                    if (current.data.group > index.data.group)
                    {
                        Student tmp = current.data;
                        current.data = index.data;
                        index.data = tmp;
                    }
                    index = index.next;
                }
                current = current.next;
            }
        }

        // Displaying the results in the console.
        public void DisplayStudents()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"{current.data.firstName}, {current.data.lastName}, " +
                    $"{current.data.patronymic}, {current.data.educationStatus}, {current.data.eMail}, " +
                    $"{current.data.login}, {current.data.password}, КНТ-{current.data.group}");
                current = current.next;
            }
        }

        static void Main(string[] args)
        {
            DoublyLinkedList studentList = new DoublyLinkedList();
            studentList.AddStudent(new Student("Iван", "Iваненко", "Iванович", "Контракт", "ivan@example.com", "username1", "password1", 122));
            studentList.AddStudent(new Student("Сергiй", "Сергiєнко", "Сергiйович", "Бюджет", "serhii@example.com", "username2", "password2", 112));
            studentList.AddStudent(new Student("Петро", "Петренко", "Петрович", "Бюджет", "petro@example.com", "username3", "password3", 111));
            Console.WriteLine("List of the Students:");
            studentList.DisplayStudents();

            studentList.SortStudents();
            Console.WriteLine("List of students after sorting by group:");
            studentList.DisplayStudents();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
