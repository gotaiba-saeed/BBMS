//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwOutgoingInfo
    {
        public int Outgoing_Id { get; set; }
        public Nullable<int> Patient_No { get; set; }
        public int Donar_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public System.DateTime Date_of_Birth { get; set; }
        public string Gender { get; set; }
        public string National_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int ColIection_Id { get; set; }
        public string Type_Name { get; set; }
        public System.DateTime Expr1 { get; set; }
        public double Hemo { get; set; }
        public string Patiant_Name { get; set; }
        public string Patient_Relation_Name { get; set; }
        public Nullable<byte> CanDonate { get; set; }
        public string Donate_Type { get; set; }
        public string Email { get; set; }
        public int Blood_Type_No { get; set; }
        public bool Blood_Status_No { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> Expr2 { get; set; }
        public string Expr3 { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}
