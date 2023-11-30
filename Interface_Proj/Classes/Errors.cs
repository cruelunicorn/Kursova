using System;
namespace Interface_Proj.Classes
{
    public class InternetConectionException : Exception
    {
        public InternetConectionException() { }
        public InternetConectionException(string message) : base(message) { }
    }
    public class ProfessorPasswordException : Exception
    {
        public ProfessorPasswordException() { }
        public ProfessorPasswordException(string message) : base(message) { }
    }
    public class StudentPasswordException : Exception
    {
        public StudentPasswordException() { }
        public StudentPasswordException(string message) : base(message) { }
    }
    public class WrongLoginException : Exception
    {
        public WrongLoginException () { }
        public WrongLoginException (string message) : base(message) { }
    }
    public class HashPasswordNotFound : Exception
    {
        public HashPasswordNotFound() { }
        public HashPasswordNotFound(string message) : base(message) { }
    }
    public class FailedToDownloadFile : Exception
    {
        public FailedToDownloadFile() { }
        public FailedToDownloadFile(string message) : base(message) { }
    }
    public class StudentsNotUpLoaded : Exception
    {
        public StudentsNotUpLoaded() { }
        public StudentsNotUpLoaded(string message) : base(message) { }
    }
    public class CharacterConversion : Exception
    {
        public CharacterConversion() { }
        public CharacterConversion(string message) : base(message) { }
    }
    public class RemovingException : Exception
    {
        public RemovingException() { }
        public RemovingException(string message) : base(message) { }
    }
}
