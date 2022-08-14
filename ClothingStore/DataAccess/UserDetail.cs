using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ClothingStore.DataAccess
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            OrderDetails = new HashSet<OrderDetail>();
            UserLogins = new HashSet<UserLogin>();
        }


        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage ="Please enter your firstname")]
        [StringLength(10, MinimumLength = 3)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your lastname")]
        [StringLength(10, MinimumLength = 3)]
        public string LastName { get; set; } = null!;

        public int Type { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="Your email ID is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailId { get; set; } = null!;

        [Required(ErrorMessage ="Please enter your address")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your city")]
        [StringLength(10, MinimumLength = 3)]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your pincode")]
        [RegularExpression(@"^\(?[a-zA-Z][0-9][a-zA-Z]\)?[- ]?([0-9][a-zA-Z][0-9])$", ErrorMessage = "Please enter your pincode in correct format(x0x 0x0)")]
        public string PinCode { get; set; } = null!;

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
