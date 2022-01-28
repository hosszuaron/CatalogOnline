using System.ComponentModel.DataAnnotations;

namespace OnlineCatalog.Models
{
    public class Student
    {
        public int StudentID { get; set; }
   
        [Display(Name = "Nume")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Display(Name = "Numar Matricol")]
        public int NrMatricol { get; set; }

        [Display(Name = "Specializare")]
        public int SpecializationID { get; set; }

        [Display(Name = "Specializare")]
        public Specialization? Specialization { get; set; }

        public ICollection<Grade>? Grades { get; set; }
    }
}
