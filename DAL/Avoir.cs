//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avoir
    {
        public int id { get; set; }
        public Nullable<int> numeroavoir { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string idclt { get; set; }
        public string client { get; set; }
        public Nullable<double> montant { get; set; }
        public Nullable<double> remise { get; set; }
        public Nullable<double> montanttotal { get; set; }
        public string Comment { get; set; }
    }
}
