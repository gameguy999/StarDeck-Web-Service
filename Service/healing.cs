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
    
    public partial class healing
    {
        [Key]
        public int card_id { get; set; }
        public int shield_restore { get; set; }
        public int hull_restore { get; set; }
        public int health { get; set; }

        [InverseProperty("card_id")]
        [ForeignKey("card_id")]
        public virtual card card { get; set; }
    }
}
