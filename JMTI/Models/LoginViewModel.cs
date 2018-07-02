using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JMTI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuário:")]
        public string usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Senha:")]
        public string senha { get; set; }

        [Display(Name ="Lembrar Me")]
        public bool lembrarMe { get; set; }
    }
}