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
    
    public partial class TB_TIPO_ACAO
    {
        public TB_TIPO_ACAO()
        {
            this.TB_ACAO = new HashSet<TB_ACAO>();
        }
    
        public int ID { get; set; }
        public string DES_TIPO { get; set; }
    
        public virtual ICollection<TB_ACAO> TB_ACAO { get; set; }
    }
}
