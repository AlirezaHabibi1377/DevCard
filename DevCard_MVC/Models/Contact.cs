using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MaxLength(25, ErrorMessage = "حداکثر طول این کاراکتر، 25 است.")]
        [MinLength(5, ErrorMessage = "حداقل طول این کاراکتر، 5 است.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست.")]
        public string Email { get; set; }
        public string Service { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string Message { get; set; }

        public SelectList Services { get; set; }

    }
}
