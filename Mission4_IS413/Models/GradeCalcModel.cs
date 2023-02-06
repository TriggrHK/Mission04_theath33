using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission4_IS413.Models
{
    public class GradeCalcModel
    {
        [Required(ErrorMessage = "Must have value for Assignments")]
        [Range(0, 100, ErrorMessage = "Assignments grade must be 0-100")]
        public string Assignments { get; set; }

        [Required(ErrorMessage = "Must have value for GroupProjects")]
        [Range(0, 100, ErrorMessage = "Group grade must be 0-100")]
        public string GroupProject { get; set; }

        [Required(ErrorMessage = "Must have value for Quizzes")]
        [Range(0, 100, ErrorMessage = "Quizzes grade must be 0-100")]
        public string Quizzes { get; set; }

        [Required(ErrorMessage = "Must have value for Midterm")]
        [Range(0, 100, ErrorMessage = "Midterm grade must be 0-100")]
        public string Midterm { get; set; }

        [Required(ErrorMessage = "Must have value for Final")]
        [Range(0, 100, ErrorMessage = "Final grade must be 0-100")]
        public string Final { get; set; }

        [Required(ErrorMessage = "Must have value for Intex")]
        [Range(0, 100, ErrorMessage = "Intex grade must be 0-100")]
        public string Intex { get; set; }
    }
}