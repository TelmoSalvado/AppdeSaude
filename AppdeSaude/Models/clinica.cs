//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppdeSaude.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class clinica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clinica()
        {
            this.medico = new HashSet<medico>();
        }
    
        public int id { get; set; }
        public string Nome { get; set; }
        public int clinica_id { get; set; }
        public int localidade_localidade_id { get; set; }
    
        public virtual localidade localidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medico> medico { get; set; }
    }
}
