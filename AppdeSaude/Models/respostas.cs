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
    
    public partial class respostas
    {
        public int id { get; set; }
        public string Resposta { get; set; }
        public int perguntas_id { get; set; }
        public int parametrosimc_id { get; set; }
    
        public virtual parametrosimc parametrosimc { get; set; }
        public virtual perguntas perguntas { get; set; }
    }
}
