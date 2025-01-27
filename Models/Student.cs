using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsim alanı zorunlu")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı zorunlu")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Telefon numarası zorunlu")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Mail zorunlu")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen katılma durumunuzu giriniz")]
        public bool? Confirm { get; set; } //true,false,null
    }
}