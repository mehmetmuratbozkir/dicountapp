using FiftyVisitor.Api.Model;
using System;
using System.Collections.Generic;

namespace DiscountApp.Api.Models
{
    public class CustomerType: BaseModel
    {
        public string Type { get; set; }
        public decimal DiscountRatio { get; set; }
    }
}
