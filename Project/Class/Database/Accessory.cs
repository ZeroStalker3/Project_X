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
    
    public partial class Accessory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessory()
        {
            this.Warehouse_Accessories = new HashSet<Warehouse_Accessories>();
            this.Accessories_TheProduct = new HashSet<Accessories_TheProduct>();
        }
    
        public string Артикул { get; set; }
        public string Наименование { get; set; }
        public Nullable<double> Ширина { get; set; }
        public Nullable<double> Длина { get; set; }
        public string Тип { get; set; }
        public Nullable<double> Вес { get; set; }
        public decimal Цена { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warehouse_Accessories> Warehouse_Accessories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accessories_TheProduct> Accessories_TheProduct { get; set; }
    }
}