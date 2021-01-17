using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharedAngular.Models
{
    public class ProductsNewOrder
    {
    public int Id { get; set; }

    public int ProductId { get; set; }

    public Products Products { get; set; }

    public int NewOrderId { get; set; }

    public NewOrder NewOrder { get; set; }

    public ICollection<ProductsNewOrder> ProdctsNewOrder { get; set; }




    }
}
