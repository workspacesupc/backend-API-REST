//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessBookWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TokenEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TokenEmployee()
        {
            this.Employee = new HashSet<Employee>();
        }
    
        public int TokenEmployeeId { get; set; }
        public string AccessToken { get; set; }
        public string TypeToken { get; set; }
        public Nullable<int> ExpireInToken { get; set; }
        public string RefreshToken { get; set; }
        public string ErrorToken { get; set; }
        public Nullable<System.DateTime> Issued { get; set; }
        public Nullable<System.DateTime> Expires { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
