//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Virus
    {
        public int Virus_Id { get; set; }
        public int Collection_No { get; set; }
        public Nullable<bool> VDRL { get; set; }
        public Nullable<bool> HCV { get; set; }
        public Nullable<bool> HBV { get; set; }
        public Nullable<bool> HIV { get; set; }
        public int User_No { get; set; }
    
        public virtual Collected_Blood Collected_Blood { get; set; }
    }
}
