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
    
    public partial class Item_T
    {
        public Item_T()
        {
            this.ItemInfo_T = new HashSet<ItemInfo_T>();
            this.Price_T = new HashSet<Price_T>();
            this.Trade_T = new HashSet<Trade_T>();
        }
    
        public Nullable<int> SubSubCategoryID { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public Nullable<int> ItemProducerID { get; set; }
        public string Name { get; set; }
        public string Reference { get; set; }
    
        public virtual SubSubCategory_T SubSubCategory_T { get; set; }
        public virtual ItemProducer_T ItemProducer_T { get; set; }
        public virtual ICollection<ItemInfo_T> ItemInfo_T { get; set; }
        public virtual ICollection<Price_T> Price_T { get; set; }
        public virtual ICollection<Trade_T> Trade_T { get; set; }
    }
}
