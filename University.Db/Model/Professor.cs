using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Db.Model
{
    public class Professor
    {
        [Key]
        public long ProfessorID { get; set; }

        // one to many(professor-class)
        public ICollection<UniversityClass> UniversityClasses { get; set; }
        

    }
}
