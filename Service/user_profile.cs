//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class user_profile
    {
        [Key]
        public int user_id { get; set; }
        public Nullable<int> wins { get; set; }
        public Nullable<int> loses { get; set; }
        public Nullable<int> money { get; set; }
        public Nullable<int> points { get; set; }

        [InverseProperty("user_id")]
        [ForeignKey("user_id")]
        public virtual user user { get; set; }
    }
}
