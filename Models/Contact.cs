using System;


namespace BrahmaServer.Models {
    public class Contact{
        public int ID {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Title {get; set;}
        public string PhoneNumber {get; set;}
        public string Email {get; set;}
    }

    public class ContactSeedData{
        static public Contact[] Seed(DBContext context){
            return new Contact[]{
                new Contact
                     {
                         FirstName = "Chance",
                         LastName = "Carter",
                         Title = "Foreman",
                         PhoneNumber = "801-368-1095",
                         Email = "",
                     },
                     new Contact
                     {
                         FirstName = "Nate",
                         LastName = "Fox",
                         Title = "Superintendent Pit",
                         PhoneNumber = "801-556-7783",
                         Email = "",
                     },
                     new Contact
                     {
                         FirstName = "Braxton",
                         LastName = "Christensen",
                         Title = "Superintendent Concentrator",
                         PhoneNumber = "801-362-6811",
                         Email = "",
                     },
                     new Contact
                     {
                         FirstName = "Earl",
                         LastName = "Skougaard",
                         Title = "Construction Manager",
                         PhoneNumber = "801-450-4163",
                         Email = "",
                     },

            };
                
        }
    }
}