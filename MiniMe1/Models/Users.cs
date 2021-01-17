using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sharedAngular.Models
{
    public class Users
    {
        //id
        public int Id { get; set; }
        //name
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(15, ErrorMessage = "מקסימום 15 תווים")]
        [Display(Name = "שם")]

        public string Name { get; set; }
        [StringLength(4, ErrorMessage = "מקסימום 4 תווים")]
        [Display(Name = "תפקיד")]

        public string Manag { get; set; }
        //email
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(50, ErrorMessage = "מקסימום 50 תווים")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "אימייל")]
        public string Mail { get; set; }
        //city
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(100, ErrorMessage = "מקסימום 100 תווים")]
        [Display(Name = "עיר")]
        public string City { get; set; }
        //phone
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(10, ErrorMessage = "מקסימום 10 תווים")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "מס' טלפון")]
        public string Phone { get; set; }
        //password
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(20, ErrorMessage = "סיסמא חייבת להיות בין 5 ל20 תווים", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Display(Name = "סיסמה")]
        public string password { get; set; }
        
        //lists
        public ICollection<Products> Love { get; set; }
        public ICollection<Products> ShoppingCart { get; set; }
        public ICollection<NewOrder> ListOfOrders { get; set; }
       
       
       

    }
}
