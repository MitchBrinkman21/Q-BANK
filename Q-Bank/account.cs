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
    
    public partial class account
    {
        public account()
        {
            this.transactions = new HashSet<transaction>();
        }
    
        public int accountId { get; set; }
        public int userId { get; set; }
        public int accountTypeId { get; set; }
        public double balance { get; set; }
        public string accountNumber { get; set; }
        public string iban { get; set; }
        public string bic { get; set; }
        public byte[] active { get; set; }
    
        public virtual accounttype accounttype { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<transaction> transactions { get; set; }
    }
}