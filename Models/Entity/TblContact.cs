//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCvProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblContact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string about { get; set; }
        public string message { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    }
}
