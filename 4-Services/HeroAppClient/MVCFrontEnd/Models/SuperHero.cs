using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFrontEnd.Models
{
    public class SuperHero
    {
        [Display(AutoGenerateField =false)]
        public int Id { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="The alias of super hero should be atleast 2 characters and not be more than 30 characters",MinimumLength =2)]
        [DataType(DataType.Text)]
        [RegularExpression(@"[a-zA-Z]+")]
        public string Alias { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="The real name should be atleast 2 characters and not be more than 50 characters",MinimumLength =2)]
        [DataType(DataType.Text)]
        public string RealName { get; set; }
        [StringLength(50, ErrorMessage = "The hide out should be atleast 4 characters and not be more than 50 characters", MinimumLength =4)]
        [DataType(DataType.MultilineText)]
         [Required]
        public string HideOut { get; set; }
    }
}
