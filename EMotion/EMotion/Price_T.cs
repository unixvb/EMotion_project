//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMotion
{
    using System;
    using System.Collections.Generic;
    
    public partial class Price_T
    {
        public Price_T()
        {
            this.OrderItem_T = new HashSet<OrderItem_T>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> UnitCost { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
    
        public virtual Item_T Item_T { get; set; }
        public virtual ICollection<OrderItem_T> OrderItem_T { get; set; }
    }
}
