using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace workshop.Models
{
    public class student_register
    {
        [Key]
        public int student_id { get; set; }
        [Required, NotNull]

        public string student_name { get; set; }
        [Required, NotNull]

        public string student_description { get; set; }
       
    }
}
