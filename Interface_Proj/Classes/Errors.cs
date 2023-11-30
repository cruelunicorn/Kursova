using System;
namespace Interface_Proj.Classes
{
    public class InternetConectionException : Exception
    {
        public InternetConectionException() { }
        public InternetConectionException(string message) : base(message) { }
    }
    public class DataHasNotBeenUpdated : Exception
    {
        public DataHasNotBeenUpdated() { }
        public DataHasNotBeenUpdated(string message) : base(message) { }
    }
    public class NameTooLong : Exception
    {
        public NameTooLong() { }
        public NameTooLong(string message) : base(message) { }
    }
    public class PasswordTooLong : Exception
    {
        public PasswordTooLong() { }
        public PasswordTooLong(string message) : base(message) { }
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
    public class Removing : Exception
    {
        public Removing() { }
        public Removing(string message) : base(message) { }
    }
}
