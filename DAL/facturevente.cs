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
    
    public partial class facturevente
    {
        public int id { get; set; }
        public Nullable<int> numero_fact { get; set; }
        public Nullable<System.DateTime> date_ajout { get; set; }
        public string id_clt { get; set; }
        public string client { get; set; }
        public Nullable<double> montant_hr { get; set; }
        public Nullable<double> remise { get; set; }
        public Nullable<double> montant { get; set; }
        public Nullable<double> retenusource { get; set; }
        public Nullable<int> id_bl { get; set; }
        public string L_num_bl { get; set; }
        public string RefCmd { get; set; }
        public string etat { get; set; }
        public Nullable<double> reste { get; set; }
        public string quittance { get; set; }
        public Nullable<System.DateTime> datequittance { get; set; }
    }
}