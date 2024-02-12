using System;
using System.Collections.Generic;

namespace Subject_1.Data.EfCore;

public partial class ProductsByCategory
{
    public string? CategoryName { get; set; }

    public string? ProductName { get; set; }

    public string? QuantityPerUnit { get; set; }

    public int? UnitsInStock { get; set; }

    public string? Discontinued { get; set; }
}
