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
    
    public partial class t_circle
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int content_type { get; set; }
        public string circle_content { get; set; }
        public System.DateTime publish_time { get; set; }
        public int pos_id { get; set; }
        public double lng { get; set; }
        public double lat { get; set; }
        public string link_url { get; set; }
        public string link_title { get; set; }
        public string link_image { get; set; }
        public int image_count { get; set; }
        public int comment_count { get; set; }
        public int like_count { get; set; }
    }
}