namespace MyLibrary
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public String FullName => $"{FirstName} {LastName}";
    }
 }

