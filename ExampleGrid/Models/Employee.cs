namespace ExampleGrid.Models
{
    public class Employee
    {
        public Employee(int id, string name, string address, string city, string state, string zip, string gender, string designation, string role, double salary)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Gender = gender;
            Designation = designation;
            Role = role;
            Salary = salary;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Gender { get; set; }

        public string Designation { get; set; }

        public string Role { get; set; }

        public double Salary { get; set; }
    }
}
