using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace sharedAngular.Models
{
    public class Products
    {
       
        public int Id { get; set; }
        //name
        [Required(ErrorMessage = "שדה חובה ")]
        [StringLength(15, ErrorMessage = "מקסימום 15 תווים")]
        [Display(Name = "שם")]
        public string Name { get; set; }
        //amount-כמות
        [Required(ErrorMessage = "שדה חובה ")]
        [Display(Name = "כמות")]
        public int Amount { get; set; }
        //category:בנים,בנות,וכו
        //בדף ששלחתן לא מופיע קטגוריה,לדעתי חייב
        [Required(ErrorMessage = "שדה חובה ")]
        [Display(Name = "קטגוריה")]
        public string Category { get; set; }
       
        //type:חולצות,חצאיות וכו
        //בדף ששלחתן לא מופיע סוג, לדעתי חייב
        [Required(ErrorMessage = "שדה חובה ")]
        [Display(Name = "סוג")]
        public string Type { get; set; }
        //תיאור המוצר-כולל הרכב בד,הוראות כביסה

        [Required(ErrorMessage = "שדה חובה ")]
        [Display(Name = "תיאור המוצר")]
        public string Description { get; set; }
        //מחיר מקורי לפני הנחה(אם יש)
        [Required(ErrorMessage = "שדה חובה ")]
        [Range(0, 1000 ,ErrorMessage = "אין מחיר כזה")]
        [Display(Name = "מחיר")]
        public float Price { get; set; }
        //מחיר לאחר הנחה
        [Range(0, 1000, ErrorMessage = "אין מחיר כזה")]
        [Display(Name = "מחיר לאחר הנחה")]
        public float NewPrice { get; set; }
        //מידה
        [Required(ErrorMessage = "שדה חובה ")]
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size2 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size3 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size4 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size5 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size6 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size7 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size8 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size9 { get; set; }
        [Range(0, 18, ErrorMessage = "אין מידה כזו")]
        [Display(Name = "מידה")]
        public int Size10 { get; set; }



        //צבעים
        [Required(ErrorMessage = "שדה חובה ")]
        [Display(Name = "צבע")]
        public string Colors { get; set; }
        [Display(Name = "צבע")]
        public string Colors2 { get; set; }
        [Display(Name = "צבע")]
        public string Colors3 { get; set; }
        [Display(Name = "צבע")]
        public string Colors4 { get; set; }




        //תאריך הוספה לאתר
        public DateTime Time { get; set; }
        //מספר מכירות-אוטומטי
        public int NumOfSale { get; set; }
        //האם במבצע
        [Display(Name = "מבצע?")]
        public bool OnSale { get; set; }
        //תמונה
        [Required(ErrorMessage = "שדה חובה ")]
        [Display(Name = "תמונה")]
        public string Pictures { get; set; }
        [Display(Name = "תמונה")]
        public string Pictures2 { get; set; }
        [Display(Name = "תמונה")]
        public string Pictures3 { get; set; }
        [Display(Name = "תמונה")]
        public string Pictures4 { get; set; }
        [Display(Name = "תמונה")]
        public string Pictures5 { get; set; }
        public ICollection<ProductsOrder> ProductsOrder { get; set; }

    }
}
