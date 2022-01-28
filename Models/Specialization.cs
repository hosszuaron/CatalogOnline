using System.ComponentModel.DataAnnotations;

namespace OnlineCatalog.Models
{
    public class Specialization
    {

        public int SpecializationID { get; set; }

        [Display(Name = "Specializare")]
        public string SpecializationName { get; set; }

        public ICollection<Student>? Students { get; set; }

    }
}
