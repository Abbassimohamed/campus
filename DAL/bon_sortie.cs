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
    
    public partial class bon_sortie
    {
        public int id { get; set; }
        public Nullable<int> numero_bs { get; set; }
        public Nullable<System.DateTime> date_ajout { get; set; }
        public string etat { get; set; }
        public Nullable<double> montant_BS { get; set; }
        public string id_clt { get; set; }
        public string client { get; set; }
        public string id_fact { get; set; }
        public string id_commande { get; set; }
        public string nbcmd { get; set; }
        public string mode_livraison { get; set; }
        public string moyen_livraison { get; set; }
        public string lieu_livraison { get; set; }
        public Nullable<double> remise { get; set; }
        public Nullable<double> totalSansRemise { get; set; }
        public string L_num_bl { get; set; }
    }
}
