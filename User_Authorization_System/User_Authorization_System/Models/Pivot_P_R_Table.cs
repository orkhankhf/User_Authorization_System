//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace User_Authorization_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pivot_P_R_Table
    {
        public int ppr_id { get; set; }
        public Nullable<int> ppr_permission_id { get; set; }
        public Nullable<int> ppr_role_id { get; set; }
    
        public virtual Permission_Table Permission_Table { get; set; }
        public virtual Role_Table Role_Table { get; set; }
    }
}
