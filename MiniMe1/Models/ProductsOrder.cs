using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharedAngular.Models
{
    public class ProductsOrder
    {
    public int Id { get; set; }

    public int ProductId { get; set; }

    public Products Products { get; set; }

    public int OrdertId { get; set; }

    public Order Order { get; set; }

    public ICollection<ProductsOrder> ProdctsOrder { get; set; }




    }
}
