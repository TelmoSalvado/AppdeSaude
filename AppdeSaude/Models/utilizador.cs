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
    using System.ComponentModel.DataAnnotations;

    public partial class utilizador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public utilizador()
        {
            this.alimentos = new HashSet<alimentos>();
            this.analises = new HashSet<analises>();
            this.atividadefisica = new HashSet<atividadefisica>();
            this.consulta = new HashSet<consulta>();
            this.medicacao = new HashSet<medicacao>();
            this.registos = new HashSet<registos>();
        }
    
        public int id { get; set; }
        public string Nome { get; set; }
        public int Contacto { get; set; }
        public int Nrutente { get; set; }
        public System.DateTime Datadenascimento { get; set; }
        public string Genero { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public int localidade_localidade_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alimentos> alimentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<analises> analises { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<atividadefisica> atividadefisica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consulta { get; set; }
        public virtual localidade localidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medicacao> medicacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<registos> registos { get; set; }
    }
}
