//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Std_Crs
    {
        public int crs_id { get; set; }
        public int std_id { get; set; }
        public Nullable<int> grade { get; set; }
        public Nullable<int> Total_Deg { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}
