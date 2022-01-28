using System.ComponentModel.DataAnnotations;

namespace OnlineCatalog.Models
{
    public class Grade
    {
        public int GradeID { get; set; }

        [Display(Name = "Nota")]
        public decimal GradeValue { get; set; }

        [Display(Name = "Student")]
        public int StudentID { get; set; }

        public Student? Student { get; set; }
    }
}
