using System;
using System.Collections.Generic;

namespace Subject_1.Data.EfCore;

public partial class OrderSubtotal
{
    public int? OrderId { get; set; }

    public double? Subtotal { get; set; }
}
