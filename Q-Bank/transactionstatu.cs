//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Q_Bank
{
    using System;
    using System.Collections.Generic;
    
    public partial class transactionstatu
    {
        public transactionstatu()
        {
            this.transactions = new HashSet<transaction>();
        }
    
        public int transactionStatusId { get; set; }
        public string transactionStatusName { get; set; }
        public string remark { get; set; }
    
        public virtual ICollection<transaction> transactions { get; set; }
    }
}
