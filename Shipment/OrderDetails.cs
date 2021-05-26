﻿using System;

namespace Shipment
{
    public class OrderDetails
    {
        public DetailedOrder Order{get; set;}
        public StreetAddress BillingAddress{get; set;}
        public StreetAddress ShippingAddress{get; set;}
    }
}
