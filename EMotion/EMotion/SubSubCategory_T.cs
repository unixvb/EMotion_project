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
    
    public partial class SubSubCategory_T
    {
        public SubSubCategory_T()
        {
            this.Item_T = new HashSet<Item_T>();
        }
    
        public Nullable<int> SubCategoryID { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
    
        public virtual ICollection<Item_T> Item_T { get; set; }
        public virtual SubCategory_T SubCategory_T { get; set; }
    }
}
