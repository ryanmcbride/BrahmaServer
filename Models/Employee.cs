using System;


namespace BrahmaServer.Models {
    public class Employee{
        public int ID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string EmployeeID {get; set;}
        public string Email {get; set;}
        public DateTime Birthday {get; set;}
        public string Gender {get; set;}
    }

    public class EmployeeSeedData{
        static public Employee[] Seed(DBContext context){
            return new Employee[]{
                new Employee
                     {
                         FirstName = "Danny",
                         LastName = "Smith",
                         PhoneNumber = "801-555-1234",
                         EmployeeID = "12345",
                         Email = "dsmith@brahma.com",
                         Birthday = DateTime.Parse("1980-2-3"),
                         Gender = "M"
                     },
                     new Employee
                     {
                         FirstName = "Roger",
                         LastName = "Jones",
                         PhoneNumber = "801-555-5678",
                         EmployeeID = "56789",
                         Email = "rjones@brahma.com",
                         Birthday = DateTime.Parse("1970-5-4"),
                         Gender = "M"
                     },
                     new Employee
                     {
                         FirstName = "Bob",
                         LastName = "Dinkley",
                         PhoneNumber = "801-555-2468",
                         EmployeeID = "24681",
                         Email = "bdinkley@brahma.com",
                         Birthday = DateTime.Parse("1990-12-13"),
                         Gender = "M"
                     },
                     new Employee
                     {
                         FirstName = "Ed",
                         LastName = "Blake",
                         PhoneNumber = "801-555-1357",
                         EmployeeID = "13579",
                         Email = "eblake@brahma.com",
                         Birthday = DateTime.Parse("1978-7-1"),
                         Gender = "M"
                     },

            };
                
        }
    }
}