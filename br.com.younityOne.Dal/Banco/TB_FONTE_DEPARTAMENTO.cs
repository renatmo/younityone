//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace br.com.younityOne.DAL.Banco
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_FONTE_DEPARTAMENTO
    {
        public TB_FONTE_DEPARTAMENTO()
        {
            this.TB_TAREFA_FONTE = new HashSet<TB_TAREFA_FONTE>();
        }
    
        public int ID { get; set; }
        public int ID_FONTE { get; set; }
        public int ID_DEPARTAMENTO { get; set; }
    
        public virtual TB_DEPARTAMENTO_CLIENTE TB_DEPARTAMENTO_CLIENTE { get; set; }
        public virtual TB_FONTE_PAGADORA TB_FONTE_PAGADORA { get; set; }
        public virtual ICollection<TB_TAREFA_FONTE> TB_TAREFA_FONTE { get; set; }
    }
}
