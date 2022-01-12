using System.Collections.Generic;

namespace University.Db.Model
{
    public class Student
    {
        public long NumberOfUnits { get; set; }
        public double AverageScore { get; set; }
        public long StudentID { get; set; }

        // one to many.
        public UniversityClass? UniversityClass { get; set; }
        public long ClassCode { get; set; }

        //many to many(student-enroll)
        public ICollection<Enroll> enrolls { get; set; }
        //

        public void StudentEnroll(Course course ) {
            if (this.AverageScore >= 17)
            {
                if (this.NumberOfUnits + course.NumberOfUnits < 25)
                {
                    using (var context = new UniversityDbContext())
                    {

                        var enroll = new Enroll()
                        {
                            ClassId = (long)course.ClassID,
                            PersonID = this.StudentID,
                            ClassName = course.Name
                        };

                        context.Enrolls.Add(enroll);
                        context.SaveChanges();
                    }
                }
            }
                if (this.AverageScore < 17) 
                {
                    if (this.NumberOfUnits + course.NumberOfUnits < 21)
                    {
                        using (var context = new UniversityDbContext())
                        {

                            var enroll = new Enroll()
                            {
                                ClassId = (long)course.ClassID,
                                PersonID = this.StudentID,
                                ClassName = course.Name
                            };

                            context.Enrolls.Add(enroll);
                            context.SaveChanges();
                        }
                    }
                }
        }


    }
}
