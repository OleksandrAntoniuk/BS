//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BS.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class InputOrder
    {
        public InputOrder()
        {
            this.InputOrderItems = new HashSet<InputOrderItem>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public int Status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<InputOrderItem> InputOrderItems { get; set; }
    }
}