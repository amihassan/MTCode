using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        [Column("gpa")]
        [Display(Name = "gpa")]
        public string gpa { get; set; }
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        [Column("CreditsEarned")]
        [Display(Name = "CreditsEarned")]
        public double CreditsEarned { get; set; }
    }
}