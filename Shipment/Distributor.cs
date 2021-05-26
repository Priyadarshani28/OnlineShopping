using System;

using System.Collections.Generic;

namespace Shipment
{
 public class Distributor
 {
    public int ID{get; set;}
    public ICollection<StreetAddress>
  ShippingCenters{get; set;}  
 }

}