namespace WebApp.Models
{
    public class PersonModel
    {
        public int EmployeeNumber { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public PersonModel()
        {
        }

        public PersonModel(int employeeNumber, string forename, string surname)
        {
            EmployeeNumber = employeeNumber;
            Forename = forename;
            Surname = surname;
        }
    }
}