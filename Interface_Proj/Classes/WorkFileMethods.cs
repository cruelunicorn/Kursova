using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Globalization;


public struct Student
{
    public int ID;
    public string FirstName;
    public string LastName;
    public string Email;
    public string Group;
    public string StudentType;
}

public struct Schedule
{
    public string Day;
    public string ID;
    public string Name;
    public string Type;
    public string Link;
}

public struct LoginInfo
{
    public int ID;
    public string Login;
    public string Password;
}

public class LoginInfoProfessors
{
    public string? Login;
    public string? Password;
}

public struct AttendanceInfo
{
    public string NameLastName;
    public string Attendance;
}

public class Methods
{
    
    //ReadStudentsFromCsv
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

    //ReadSchedule
    public static List<Schedule> ReadScheduleFromCsv()
    {
        string csvFileName = "schedule.csv";

        if (!File.Exists(csvFileName))
        {
            using (var writer = new StreamWriter(csvFileName))
            {
                writer.WriteLine("Day Of Week;ID;Subject Name;Type;Subject Link");
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
                        Day = values[0],
                        ID = values[1],
                        Name = values[2],
                        Type = values[3],
                        Link = values[4]
                    });
                }
            }
        }

        return schedule;
    }

    // Add a new Subject.
    public static void AddSubject(Schedule newSubjects)
    {
        List<Schedule> schedule = ReadScheduleFromCsv();
        schedule.Add(newSubjects);

        schedule = schedule.OrderBy(s => new CultureInfo("uk-UA").DateTimeFormat.DayNames.ToList().
        IndexOf(s.Day.ToLower().Replace("'", "\u02bc"))).ThenBy(s => s.ID).ToList();

        using (var writer = new StreamWriter("schedule.csv"))
        {
            writer.WriteLine("Day Of Week;ID;Subject Name;Type;Subject Link");
            foreach (var entry in schedule)
            {
                writer.WriteLine($"{entry.Day};{entry.ID};{entry.Name};{entry.Type};{entry.Link}");
            }
        }
    }

    // Remove the Subject.
    public static void RemoveSubject(string day, string id, string subject, string type)
    {
        List<Schedule> schedule = ReadScheduleFromCsv();

        Schedule subjectToRemove = schedule.Find(entry => entry.Day == day && entry.ID == id
        && entry.Name == subject && entry.Type == type);

        if (!subjectToRemove.Equals(default(Schedule)))
        {
            schedule.Remove(subjectToRemove);
            using (var writer = new StreamWriter("schedule.csv"))
            {
                writer.WriteLine("Day Of Week;ID;Subject Name;Type;Subject Link");
                foreach (var entry in schedule)
                {
                    writer.WriteLine($"{entry.Day};{entry.ID};{entry.Name};{entry.Type};{entry.Link}");
                }
            }
        }
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

    /////////////////RemoveProfessor
    public static void RemoveProfessor(string login)
    {
        List<LoginInfoProfessors> loginInfosProf = ReadProfessorsFromJson();
        loginInfosProf.RemoveAll(loginInfoProfessors => loginInfoProfessors.Login == login);

        string json = JsonConvert.SerializeObject(loginInfosProf, Formatting.Indented);
        File.WriteAllText("professors.json", json);
    }

    public static int FindStudentID(string firstName, string lastName)
    {
        List<Student> students = ReadStudentsFromCsv();
        var student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        if (!student.Equals(default(Schedule)))
        {
            return student.ID;
        }
        return -1;
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
}