using System;
using System.Collections.Generic;

namespace дээм.Models;

public partial class OrdersProduct
{
    public int IdOrdersProducts { get; set; }

    public int IdDelivery { get; set; }

    public int IdProduct { get; set; }

    public int Count { get; set; }

    public virtual Delivery IdDeliveryNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
