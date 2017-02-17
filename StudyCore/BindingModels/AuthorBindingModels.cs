using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudyCore.BindingModels
{
    public class CreateAuthorBindingModel
    {
        [Required]
        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Name { get; set; }
    }
}