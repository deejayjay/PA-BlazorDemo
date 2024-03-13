namespace BlazorDemo.Data
{
    public class Student
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public void ResetToDefault()
        { 
            FirstName = string.Empty;
            LastName = string.Empty;
            Age = 0;
        }
    }
}
