using System;


namespace BrahmaServer.Models {
    public class Notification{
        public int ID {get; set;}
        public string Message {get; set;}
        public DateTime PostedDate {get; set;}
    }

    public class NotificationSeedData{
        static public Notification[] Seed(DBContext context){
            return new Notification[]{
                new Notification
                     {
                         Message = "North End of the Pit Closed",
                         PostedDate = DateTime.Parse("2017-9-1"),
                     },
                     new Notification
                     {
                         Message = "Company wide safety meeting",
                         PostedDate = DateTime.Parse("2017-9-15"),
                     },
                     new Notification
                     {
                         Message = "Shutdowns start on October 14",
                         PostedDate = DateTime.Parse("2017-9-17"),
                     },
            };       
        }
    }
}