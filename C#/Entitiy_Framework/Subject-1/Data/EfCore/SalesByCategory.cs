using System;
using System.Collections.Generic;

namespace Subject_1.Data.EfCore;

public partial class SalesByCategory
{
    public int? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? ProductName { get; set; }

    public byte[]? ProductSales { get; set; }
}
