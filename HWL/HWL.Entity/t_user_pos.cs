//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HWL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_user_pos
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string pos_details { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string geohash_key { get; set; }
        public int country_id { get; set; }
        public int province_id { get; set; }
        public int city_id { get; set; }
        public int district_id { get; set; }
        public System.DateTime create_date { get; set; }
        public System.DateTime update_date { get; set; }
    }
}
