//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace districtProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class District
    {
        public int district_id { get; set; }
        public string district_name_thai { get; set; }
        public string district_name_eng { get; set; }
        public Nullable<int> multiple_district_id { get; set; }
    
        public virtual MultipleDistrict MultipleDistrict { get; set; }
    }
}
