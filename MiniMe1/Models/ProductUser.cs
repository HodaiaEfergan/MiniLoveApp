using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharedAngular.Models
{
    public class ProductUser
    {
        public int Id { get; set; }
        public int NewOrderId { get; set; }
        public Users Users { get; set; }
        public int ProductsId { get; set; }
        public Products Pro { get; set; }



    }
}

