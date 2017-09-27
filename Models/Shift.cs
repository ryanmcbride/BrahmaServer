using System;


namespace BrahmaServer.Models {
    public class Shift{
        public int ID {get; set;}
        public string JobNumber {get; set;}
        public DateTime StartDateTime {get; set;}
        public float ShiftLength {get; set;}
        public DateTime ShiftStartTime {get; set;}
        public DateTime ShiftEndTime {get; set;}
        public string EmployeeId {get; set;}
    }
}