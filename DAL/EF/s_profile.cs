//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class s_profile
    {
        public int id { get; set; }
        public int s_id { get; set; }
        public string s_name { get; set; }
        public string s_address { get; set; }
        public string s_img { get; set; }
        public string s_email { get; set; }
        public string s_num { get; set; }
        public string country { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string a_address1 { get; set; }
        public string zip { get; set; }
        public string fb_url { get; set; }
    
        public virtual user_details user_details { get; set; }
    }
}
