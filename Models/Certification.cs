using System;


namespace BrahmaServer.Models {
    public class Certification{
        public enum CategoryType{
            CATEGORY_NONE,
            CATEGORY_5000_23,
            CATEGORY_SITE,
            CATEGORY_5000_23_EQUIPMENT,
            RIO_TINTO_KENNECOTT
        }
        public int ID {get; set;}
        public CategoryType Category {get; set;}
        public DateTime ExpirationDate {get; set;}
        public byte[] Image {get; set;}
        public string Description {get; set;}
        public int Employee {get; set;}
    }

    public class CertificationSeedData{
        static public Certification[] Seed(DBContext context){
            return new Certification[]{
                new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Underground certified",
                         Employee = 1
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23_EQUIPMENT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "426B Backhoe",
                         Employee = 1
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.RIO_TINTO_KENNECOTT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Certifacate of fit",
                         Employee = 1
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23_EQUIPMENT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Doosan DX 225 LC",
                         Employee = 1
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Underground certified",
                         Employee = 2
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23_EQUIPMENT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "426B Backhoe",
                         Employee = 2
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.RIO_TINTO_KENNECOTT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Certifacate of fit",
                         Employee = 2
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23_EQUIPMENT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "CAT TL1255",
                         Employee = 2
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Underground certified",
                         Employee = 3
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23_EQUIPMENT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "426B Backhoe",
                         Employee = 3
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.RIO_TINTO_KENNECOTT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "Certifacate of fit",
                         Employee = 3
                     },
                     new Certification
                     {
                         Category = Certification.CategoryType.CATEGORY_5000_23_EQUIPMENT,
                         ExpirationDate = DateTime.Parse("2018-9-1"),
                         Description = "6190 truck wash",
                         Employee = 3
                     },
            };       
        }
    }
}