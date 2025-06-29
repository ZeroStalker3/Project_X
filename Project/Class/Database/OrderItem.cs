//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.Class.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int id { get; set; }
        public Nullable<int> IdOreder { get; set; }
        public string IdProduct { get; set; }
        public string IdFabric { get; set; }
        public string IdAccessory { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Price { get; set; }
        public int RorarionAngle { get; set; }
        public int Amount { get; set; }
        public int UnitID { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual Fabric Fabric { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
