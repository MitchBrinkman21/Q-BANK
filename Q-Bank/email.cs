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
    
    public partial class email
    {
        public int emailId { get; set; }
        public int userId { get; set; }
        public byte[] active { get; set; }
        public string email1 { get; set; }
    
        public virtual user user { get; set; }
    }
}
