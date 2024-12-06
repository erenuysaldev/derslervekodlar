using System.ComponentModel.DataAnnotations;

namespace Project08_EfCore_CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Bu alan zorunludur!")]
        [MinLength(5,ErrorMessage ="En az 5 karakter olmak zorunda!")]
        [MaxLength(10,ErrorMessage ="En az 10 karakter olmak zorunda")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [MinLength(5, ErrorMessage = "En az 5 karakter olmak zorunda!")]
        [MaxLength(10, ErrorMessage = "En az 10 karakter olmak zorunda")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [EmailAddress(ErrorMessage ="Geçersiz email")]
        public required string Email { get; set; }

        [Range(18,150,ErrorMessage ="Yasal yaş sınırının dışındasınız.")]
        [Required(ErrorMessage ="Bu alan zorunludur")]
        public byte? Age { get; set; }

        [Required(ErrorMessage ="Bu alan zorunldudur")]
        //[DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required(ErrorMessage = "Bu alan zorunldudur")]
        //[DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Parolalar Eşleşmiyor")]
        public required string RePassword { get; set; }

        public DateTime ApplyDate { get; set; }
    }
}
