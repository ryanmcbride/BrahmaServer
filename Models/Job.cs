using System;


namespace BrahmaServer.Models {
    public class Job{
        public int ID {get; set;}
        public string Name {get; set;}
        public string JobNumber {get; set;}
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public float ShiftLength {get; set;}
        public int ContactID1 {get; set;}
        public int ContactID2 {get; set;}
        public int ContactID3 {get; set;}
    }

    public class JobSeedData{
        static public Job[] Seed(DBContext context){
            return new Job[]{
                new Job
                     {
                         Name = "Moly Piping Upgrades",
                         JobNumber = "1217-0324",
                         StartDate = DateTime.Parse("2017-10-3"),
                         EndDate = DateTime.Parse("2017-10-7"),
                         ShiftLength = 10f,
                         ContactID1 = 1,
                         ContactID2 = 2,
                         ContactID3 = 3,
                     },
                     new Job
                     {
                         Name = "Sampling",
                         JobNumber = "1217-0320",
                         StartDate = DateTime.Parse("2017-9-23"),
                         EndDate = DateTime.Parse("2017-10-17"),
                         ShiftLength = 8f,
                         ContactID1 = 1,
                         ContactID2 = 2,
                         ContactID3 = 3,
                     },
                     new Job
                     {
                         Name = "Tear ",
                         JobNumber = "1217-0307",
                         StartDate = DateTime.Parse("2017-10-3"),
                         EndDate = DateTime.Parse("2017-10-7"),
                         ShiftLength = 10f,
                         ContactID1 = 1,
                         ContactID2 = 2,
                         ContactID3 = 3,
                     },
                     new Job
                     {
                         Name = "Tear Down Portable pumps",
                         JobNumber = "1217-0305",
                         StartDate = DateTime.Parse("2017-9-3"),
                         EndDate = DateTime.Parse("2017-9-30"),
                         ShiftLength = 12f,
                         ContactID1 = 1,
                         ContactID2 = 2,
                         ContactID3 = 3,
                     },

            };
                
        }
    }
}