using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppSherzan.Models
{
    public class EndBirthdateModel
    {
        [Required(ErrorMessage = "Please enter a birth year.")]
        [Range(1900, 2021, ErrorMessage = "Birth year must be between 1900 and 2021.")]
        public int BirthYear { get; set; } 

        [Required(ErrorMessage = "Please enter your name.")]
        public string FirstName { get; set; }
       
        public int CalculateEndBirthdate()
        {
            return DateTime.Now.Year - BirthYear;

        }
    }
}

