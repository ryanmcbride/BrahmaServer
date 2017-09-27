using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BrahmaServer.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DBContext>>()))
            {
                if (!context.Employee.Any()){
                    context.Employee.AddRange(EmployeeSeedData.Seed(context));
                context.SaveChanges();
                }
                if (!context.Job.Any()){
                    context.Job.AddRange(JobSeedData.Seed(context));
                context.SaveChanges();
                }
                if (!context.Contact.Any()){
                    context.Contact.AddRange(ContactSeedData.Seed(context));
                context.SaveChanges();
                }
                if (!context.Notification.Any()){
                    context.Notification.AddRange(NotificationSeedData.Seed(context));
                context.SaveChanges();
                }
                if (!context.Certification.Any()){
                    context.Certification.AddRange(CertificationSeedData.Seed(context));
                context.SaveChanges();
                }

            }
        }
    }
}