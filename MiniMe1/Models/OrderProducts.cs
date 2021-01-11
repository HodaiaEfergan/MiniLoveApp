using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharedAngular.Models
{
    public class OrderProducts
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        public int ProId { get; set; }
        public Products Pro { get; set; }



    }
}
