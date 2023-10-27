

public class FileManager
{
    public static void CreateCsvFiles()
    {
        using (StreamWriter sw = new StreamWriter("students.csv"))
        {
            sw.WriteLine("First Name;Last Name;Email;Group;StudentType;ID");
            sw.WriteLine("David;Talk;davidtalk@email.com;GRP210;Contract;0");
            sw.WriteLine("Maria;Tkachenko;mariatkachenko@email.com;GRP210;Budget;1");
            sw.WriteLine("Oleksandr;Romanenko;olexroman@email.com;GRP220;Budget;2");
            sw.WriteLine("Natalia;Moroz;moroz@email.com;GRP220;Contract;3");
            // Add more students
        }

        using (StreamWriter sw = new StreamWriter("schedule.csv"))
        {
            sw.WriteLine("Date;Time;Course;Group;Professor");
            sw.WriteLine("30-10-2023;10:00;Math;GRP210;Professor 1");
            sw.WriteLine("30-10-2023;10:00;English;GRP220;Professor 2");
            sw.WriteLine("30-10-2023;12:00;Physics;GRP210;Professor3");
            sw.WriteLine("31-10-2023;11:00;Math;GRP220;Professor 1");
            sw.WriteLine("31-10-2023;12:00;English;GRP210;Professor 2");
            sw.WriteLine("31-10-2023;12:00;Physics;GRP230;Professor 3");
            // Add more schedules
        }
    }

    public static void CreateJsonFiles()
    {
        string studentsJson =
        "[\n" +
        "  { \"id\": 0, \"login\": \"david123\", \"password\": \"password123\" },\n" +
        "  { \"id\": 1, \"login\": \"maria456\", \"password\": \"securepass\" },\n" +
        "  { \"id\": 2, \"login\": \"olex789\", \"password\": \"password789\" },\n" +
        "  { \"id\": 3, \"login\": \"natali123\", \"password\": \"secure123\" }\n" +
        "]";
        File.WriteAllText("students.json", studentsJson);

        string professorsJson =
        "[\n" +
        "  { \"name\": \"Professor 1\", \"course\": \"Math\", \"login\": \"pro1\", \"password\": \"pass1\" },\n" +
        "  { \"name\": \"Professor 2\", \"course\": \"Physics\", \"login\": \"pro2\", \"password\": \"pass2\" },\n" +
        "  { \"name\": \"Professor 3\", \"course\": \"English\", \"login\": \"pro3\", \"password\": \"pass3\" }\n" +
        "]";
        File.WriteAllText("professors.json", professorsJson);
    }
}
