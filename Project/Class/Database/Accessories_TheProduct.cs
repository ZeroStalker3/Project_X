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
    
    public partial class Accessories_TheProduct
    {
        public string Артикул_фурнитуры { get; set; }
        public string Артикул_изделия { get; set; }
        public string Размещение { get; set; }
        public int Количество { get; set; }
    
        public virtual Accessory Accessory { get; set; }
        public virtual TheProduct TheProduct { get; set; }
    }
}