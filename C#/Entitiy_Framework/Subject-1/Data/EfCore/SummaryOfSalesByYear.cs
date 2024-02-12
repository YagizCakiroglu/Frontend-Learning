using System;
using System.Collections.Generic;

namespace Subject_1.Data.EfCore;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int? OrderId { get; set; }

    public double? Subtotal { get; set; }
}
