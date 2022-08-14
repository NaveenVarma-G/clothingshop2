using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.DataAccess
{
    public partial class UserLogin
    {
        public int CredentialId { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please enter a username")]
        [MinLength(3, ErrorMessage = "Username length should be more than 3 characters.")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Password should atleast 8 characters long with one Capital letter,small letter, number and a special character")]
        public string Password { get; set; } = null!;

        public virtual UserDetail User { get; set; } = null!;
    }
}
