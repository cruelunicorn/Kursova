class Program
{
    static void Main()
    {
        FileManager.CreateCsvFiles();
        FileManager.CreateJsonFiles();

        //Methods.ReadStudentsFromCsv();
        //Methods.ReadScheduleFromCsv();

        var Data = Methods.ReadStudentsFromJson();
        Console.WriteLine(Data[0].Login);
        Console.WriteLine(Data[0].Password);

        Methods.RemoveStudent("Mardia", "Tkachenko");

        Methods.AddStudent(new Student
        {
            FirstName = "Hanna",
            LastName = "Tent",
            Email = "hannatent@email.com",
            Group = "GRP210",
            StudentType = "Contract"
        },
        new LoginInfo
        {
            Login = "login",
            Password = "password"
        });

        Methods.EditStudent(
        new Student
        {
            ID = 1,
            FirstName = "Maria",
            LastName = "Tkachik",
            Email = "newemail@email.com",
            Group = "GRP230",
            StudentType = "Contract"
        },
        new LoginInfo
        {
            ID = 1,
            Login = "newlogin",
            Password = "newpassword"
        }
        );

        Console.WriteLine("Program was successfully executed!");
    }
}