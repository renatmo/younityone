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
    
    public partial class TB_UNIDADE
    {
        public TB_UNIDADE()
        {
            this.TB_CONTATO = new HashSet<TB_CONTATO>();
            this.TB_ENDERECO = new HashSet<TB_ENDERECO>();
            this.TB_TAREFA_FONTE_ACESSO = new HashSet<TB_TAREFA_FONTE_ACESSO>();
        }
    
        public int ID { get; set; }
        public int ID_CLIENTE { get; set; }
        public string NUM_CNPJ { get; set; }
        public string NOM_UNIDADE { get; set; }
        public bool FLG_ATIVO { get; set; }
    
        public virtual TB_CLIENTE TB_CLIENTE { get; set; }
        public virtual ICollection<TB_CONTATO> TB_CONTATO { get; set; }
        public virtual ICollection<TB_ENDERECO> TB_ENDERECO { get; set; }
        public virtual ICollection<TB_TAREFA_FONTE_ACESSO> TB_TAREFA_FONTE_ACESSO { get; set; }
    }
}