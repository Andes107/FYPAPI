//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYPAPI.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblInterestedIn
    {
        public short fypId { get; set; }
        public short groupId { get; set; }
        public short priority { get; set; }
        public string etag { get; set; }
    
        public virtual tblFyp tblFyp { get; set; }
        public virtual tblProjectGroup tblProjectGroup { get; set; }
    }
}