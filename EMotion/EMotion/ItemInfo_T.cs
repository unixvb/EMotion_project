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
    
    public partial class ItemInfo_T
    {
        public Nullable<int> ItemID { get; set; }
        public int ID { get; set; }
        public string InfoName { get; set; }
        public string InfoValue { get; set; }
    
        public virtual Item_T Item_T { get; set; }
    }
}
