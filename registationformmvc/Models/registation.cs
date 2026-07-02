using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace registationformmvc.Models
{
    public class registation
    {
        

        [Required (ErrorMessage ="enter fist name")]
        public string fistName { get; set; }
        [Required(ErrorMessage ="enter last name")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "enter email")]
        [EmailAddress]
        public string email { get; set; }
        [Required (ErrorMessage ="enter password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string cpassword { get; set; }






    }
}