using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication.ViewModels
{
    public class IndexViewModel
    {
        [Required]
        [Display(Name = "Add new user")]
        [StringLength(100)]
        public string NewUser { get; set; }

        [BindNever]
        public IList<string> ExistingUsers { get; set; }
    }
}