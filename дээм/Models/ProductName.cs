using System;
using System.Collections.Generic;

namespace дээм.Models;

public partial class ProductName
{
    public int IdProductName { get; set; }

    public string ProductName1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
