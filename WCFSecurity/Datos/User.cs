//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFSecurity.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UsersInRoles = new HashSet<UsersInRoles>();
        }
    
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public System.DateTime DateCreate { get; set; }
        public System.DateTime DateUpdate { get; set; }
        public Nullable<int> FailedAttempts { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
