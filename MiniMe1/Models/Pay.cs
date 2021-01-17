using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace sharedAngular.Models
{
    public class Pay
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //credit card
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "שדה חובה")]
        [StringLength(16, ErrorMessage = "בדיוק 16 תווים", MinimumLength = 16)]
        [DataType(DataType.CreditCard)]
        [Display(Name = "מספר אשראי")]
        public string CreditNum { get; set; }

        //month
        [Required]
        [Range(1, 12, ErrorMessage = "מספר זה אינו חודש")]
        [Display(Name = "תוקף-חודש")]
        public int ExpireMonth { get; set; }
        //year
        [Required]
        [Range(2020, 9999, ErrorMessage = "שנה שגויה")]
        [Display(Name = "תוקף-שנה")]
        public int ExpireYear { get; set; }

        //name
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(30, ErrorMessage = "מקסימום 30 תווים")]
        [Display(Name = "שם בעל הכרטיס")]
        public string OwnName { get; set; }

        //ת"ז
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(15, ErrorMessage = "מקסימום 15 תווים")]
        [Display(Name = "תעודת זהות בעל הכרטיס")]
        public string IdNum { get; set; }
        //3 ספרות
        [Required(ErrorMessage = "שדה חובה")]
        [StringLength(3, ErrorMessage = "יש להקליד 3 תווים")]
        [Display(Name = " ספרות בגב הכרטיס")]
        public string CW { get; set; }
    }
}
