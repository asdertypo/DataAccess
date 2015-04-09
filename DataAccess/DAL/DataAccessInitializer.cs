using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DataAccess.Models;

namespace DataAccess.DAL
{
    public class DataAccessInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccessContext>
    {
        protected override void Seed(DataAccessContext context)
        {
            var institutions = new List<Institution>{
                new Institution{InstitutionName="市局培训科",CreateDate=DateTime.Now},
                new Institution{InstitutionName="阳春培训股",CreateDate=DateTime.Now}
            };
            institutions.ForEach(i => context.Institutions.Add(i));
            context.SaveChanges();

            var students = new List<Student>{
                new Student { Name = "test2", Gender = Gender.男, IdNum = "441781199103230518", School = "阳江职业技术学院", TrainingDate = DateTime.Now, InstitutionId = 1, InputDate = DateTime.Now },
                new Student { Name = "test3", Gender = Gender.男, IdNum = "441781199103110518", School = "阳江职业技术学院", TrainingDate = DateTime.Now, InstitutionId = 1, InputDate = DateTime.Now },
                new Student { Name = "test4", Gender = Gender.女, IdNum = "441781199101230514", School = "阳江职业技术学院", TrainingDate = DateTime.Now, InstitutionId = 1, InputDate = DateTime.Now },
                new Student { Name = "test5", Gender = Gender.男, IdNum = "441781199105130512", School = "阳江职业技术学院", TrainingDate = DateTime.Now, InstitutionId = 2, InputDate = DateTime.Now },
                new Student { Name = "test6", Gender = Gender.女, IdNum = "441781199403230518", School = "阳江职业技术学院", TrainingDate = DateTime.Now, InstitutionId = 1, InputDate = DateTime.Now },
                new Student { Name = "test7", Gender = Gender.女, IdNum = "441781199103230518", School = "阳江职业技术学院", TrainingDate = DateTime.Now, InstitutionId = 2, InputDate = DateTime.Now }
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

        }
    }
}