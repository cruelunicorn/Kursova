using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public class Student
{
    public int ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Group { get; set; }
    public string? StudentType { get; set; }
}

public class Schedule
{
    public string? Date { get; set; }
    public string? Time { get; set; }
    public string? Course { get; set; }
}

public class LoginInfo
{
    public int ID { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }
}

public class LoginInfoProfessors
{
    public string? Login { get; set; }
    public string? Password { get; set; }
}


public class Methods
{
    
    //////////////////ReadStudentsFromCsv
    public static List<Student> ReadStudentsFromCsv()
    {
        string csvFileName = "students.csv";

        if (!File.Exists(csvFileName))
        {
            using (var writer = new StreamWriter(csvFileName))
            {
                writer.WriteLine("First Name;Last Name;Email;Group;StudentType;ID");
            }
        }

        List<Student> students = new List<Student>();

        using (var reader = new StreamReader(csvFileName))
        {
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(';');
                    students.Add(new Student
                    {
                        FirstName = values[0],
                        LastName = values[1],
                        Email = values[2],
                        Group = values[3],
                        StudentType = values[4],
                        ID = int.Parse(values[5])
                    });
                }
            }
        }

        return students;
    }

    /////////////////////ReadSchedule
    public static List<Schedule> ReadScheduleFromCsv()
    {
        string csvFileName = "schedule.csv";

        if (!File.Exists(csvFileName))
        {
            using (var writer = new StreamWriter(csvFileName))
            {
                writer.WriteLine("Date;Time;Course;Group;Professor");
            }
        }

        List<Schedule> schedule = new List<Schedule>();

        using (var reader = new StreamReader(csvFileName))
        {
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(';');
                    schedule.Add(new Schedule
                    {
                        Date = values[0],
                        Time = values[1],
                        Course = values[2]
                    });
                }
            }
        }

        return schedule;
    }


    //////////////ReadStudentFromJson
    public static List<LoginInfo> ReadStudentsFromJson()
    {
        string jsonFileName = "students.json";

        if (!File.Exists(jsonFileName))
        {
            File.WriteAllText(jsonFileName, "[]");
        }

        string json = File.ReadAllText(jsonFileName);
        List<LoginInfo>? studentsList = JsonConvert.DeserializeObject<List<LoginInfo>>(json);

        if (studentsList != null)
        {
            return studentsList;
        }
        else
        {
            return new List<LoginInfo>();
        }
    }

    //////////////ReadProfessorsFromJson
    public static List<LoginInfoProfessors> ReadProfessorsFromJson()
    {
        string jsonFileName = "professors.json";

        if (!File.Exists(jsonFileName))
        {
            File.WriteAllText(jsonFileName, "[]");
        }

        string json = File.ReadAllText(jsonFileName);
        List<LoginInfoProfessors>? professorsList = JsonConvert.DeserializeObject<List<LoginInfoProfessors>>(json);

        if (professorsList != null)
        {
            return professorsList;
        }
        else
        {
            return new List<LoginInfoProfessors>();
        }
    }

    
    ///////////////////////////AddProfessor
    public static void AddProfessor(LoginInfoProfessors newProfessorInfo)
    {
        List<LoginInfoProfessors> professors = ReadProfessorsFromJson();
        professors.Add(newProfessorInfo);

        string json = JsonConvert.SerializeObject(professors, Formatting.Indented);
        File.WriteAllText("professors.json", json);
    }

    //ProfessorPasswordExist
    public static bool ProfessorPasswordExist(string Password)
    {
        List<LoginInfoProfessors> professors = ReadProfessorsFromJson();
        var professor = professors.FirstOrDefault(s => s.Password == Password);
        if (professor != null)
        {
            return true;
        }
        return false;
    }

    //ProfessorLoginExist
    public static bool ProfessorLoginExist(string Login)
    {
        List<LoginInfoProfessors> professors = ReadProfessorsFromJson();
        var professor = professors.FirstOrDefault(s => s.Login == Login);
        if (professor != null)
        {
            return true;
        }
        return false;
    }

    public static int FindStudentID(string firstName, string lastName)
    {
        List<Student> students = ReadStudentsFromCsv();
        var student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        if (student != null)
        {
            return student.ID;
        }
        return -1;
    }
    public static bool StudentPasswordExist(string Password)
    {
        List<LoginInfo> students = ReadStudentsFromJson();
        var student = students.FirstOrDefault(s => s.Password == Password);
        if (student != null)
        {
            return true;
        }
        return false;
    }

    public static bool StudentLoginExist(string Login)
    {
        List<LoginInfo> students = ReadStudentsFromJson();
        var student = students.FirstOrDefault(s => s.Login == Login);
        if (student != null)
        {
            return true;
        }
        return false;
    }

    public static void RemoveStudent(string firstName, string lastName)
    {
        int studentID = FindStudentID(firstName, lastName);
        if (studentID == -1)
        {
            return;
        }

        List<Student> students = ReadStudentsFromCsv();
        students.RemoveAll(student => student.ID == studentID);

        using (var writer = new StreamWriter("students.csv"))
        {
            writer.WriteLine("First Name;Last Name;Email;Group;StudentType;ID");
            foreach (var student in students)
            {
                writer.WriteLine($"{student.FirstName};{student.LastName};{student.Email};{student.Group};{student.StudentType};{student.ID}");
            }
        }

        List<LoginInfo> loginInfos = ReadStudentsFromJson();
        loginInfos.RemoveAll(loginInfo => loginInfo.ID == studentID);

        string json = JsonConvert.SerializeObject(loginInfos, Formatting.Indented);
        File.WriteAllText("students.json", json);
    }

    private static int FindSmallestAvailableID(List<Student> students)
    {
        var usedIDs = students.Select(student => student.ID);
        int newID = 0;
        while (usedIDs.Contains(newID))
        {
            newID++;
        }
        return newID;
    }

    public static void AddStudent(Student newStudent, LoginInfo loginInfo)
    {
        List<Student> students = ReadStudentsFromCsv();
        int newStudentID = FindSmallestAvailableID(students);
        newStudent.ID = newStudentID;

        students.Add(newStudent);
        students = students.OrderBy(student => student.Group).ToList();
        using (var writer = new StreamWriter("students.csv"))
        {
            writer.WriteLine("First Name;Last Name;Email;Group;StudentType;ID");
            foreach (var student in students)
            {
                writer.WriteLine($"{student.FirstName};{student.LastName};{student.Email};{student.Group};{student.StudentType};{student.ID}");
            }
        }

        List<LoginInfo> loginInfos = ReadStudentsFromJson();
        loginInfos.Add(new LoginInfo { ID = newStudent.ID, Login = loginInfo.Login, Password = loginInfo.Password });
        string json = JsonConvert.SerializeObject(loginInfos, Formatting.Indented);
        File.WriteAllText("students.json", json);
    }

    public static void EditStudent(Student updatedStudent, LoginInfo updatedLoginInfo)
    {
        List<Student> students = ReadStudentsFromCsv();

        int studentIndex = students.FindIndex(student => student.ID == updatedStudent.ID);
        if (studentIndex < 0)
        {
            return;
        }
        students[studentIndex] = updatedStudent;
        students = students.OrderBy(student => student.Group).ToList();

        using (var writer = new StreamWriter("students.csv"))
        {
            writer.WriteLine("First Name;Last Name;Email;Group;StudentType;ID");
            foreach (var student in students)
            {
                writer.WriteLine($"{student.FirstName};{student.LastName};{student.Email};{student.Group};{student.StudentType};{student.ID}");
            }
        }

        List<LoginInfo> loginInfos = ReadStudentsFromJson();
        int loginInfoIndex = loginInfos.FindIndex(loginInfo => loginInfo.ID == updatedLoginInfo.ID);
        loginInfos[loginInfoIndex] = updatedLoginInfo;
        string json = JsonConvert.SerializeObject(loginInfos, Formatting.Indented);
        File.WriteAllText("students.json", json);
    }

}