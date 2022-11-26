using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesCh12.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        // Foreign key
        public int DepartmentID { get; set; }
        // Navigation Property
        public virtual Department Department { get; set; }

        //foreign key
        public int BenefitID { get; set; }
        //Navigation Property
        public virtual Benefits Benefits { get; set; }
    }
}