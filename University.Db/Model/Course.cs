using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace University.Db.Model
{
    public class Course
    {
        public long NumberOfUnits { get; set; }
        [Key]
        public string Name { get; set; }

        //one to one (class- course)
        public long? ClassID { get; set; }
        public UniversityClass UniversityClass { get; set; }

    }
}
