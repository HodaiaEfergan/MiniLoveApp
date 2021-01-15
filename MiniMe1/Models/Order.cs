using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sharedAngular.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNum { get; set; }
        public Users Users { get; set; }

        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public float SumPrice { get; set; }
        //צורת תשלום
        [Required(ErrorMessage = "שדה חובה ")]
        public string PaymentMethods { get; set; }
        public ICollection<ProductsOrder> ProductsOrder { get; set; }
    }
}
