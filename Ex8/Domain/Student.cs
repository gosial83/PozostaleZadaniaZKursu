using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ex8.Domain
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide PESEL")]
        [StringLength(11)]
        public string PESEL { get; set; }
        
        [Required(ErrorMessage = "Please provide Gender")]
        public Gender Gender { get; set; }

        public bool? IsSuspended { get; set; }

        [DefaultValue(0)]
        public int? NumberOfAbsences { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Please provide Birthday")]
        public DateTime Birthday { get; set; }

        [StringLength(100)]
        public string FathersName { get; set; }

        [StringLength(100)]
        public string MothersName { get; set; }
    }

    public enum Gender
    {
        M,
        F
    }
}
